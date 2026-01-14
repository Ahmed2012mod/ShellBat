namespace ShellBat.Windows.Effects;

public static class AcrylicBrush
{
    private static readonly D3DCOLORVALUE _exclusionColor = D3DCOLORVALUE.FromArgb(26, 255, 255, 255);
    private const float _saturation = 1.25f;
    private const float _blurRadius = 30f;
    private const float _noiseOpacity = 0.02f;

    // indicates whether the running OS is Windows 10 19H1 (v1903) or higher.
    private static bool Is19H1OrHigher => WindowsVersionUtilities.IsApiContractAvailable(8);

    private static CompositeStepEffect CombineNoiseWithTintEffectLegacy(IGraphicsEffectSource blurredSource, IGraphicsEffectSource tintColorEffect)
    {
        var saturationEffect = new SaturationEffect
        {
            Saturation = _saturation,
            Source = blurredSource
        };

        var exclusionColorEffect = new FloodEffect
        {
            Color = _exclusionColor
        };

        var blendEffectInner = new BlendEffect
        {
            Mode = D2D1_BLEND_MODE.D2D1_BLEND_MODE_EXCLUSION,
            Foreground = exclusionColorEffect,
            Background = saturationEffect
        };

        var compositeEffect = new CompositeStepEffect
        {
            Mode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
            Destination = blendEffectInner,
            Source = tintColorEffect
        };

        return compositeEffect;
    }

    private static BlendEffect CombineNoiseWithTintEffectLuminosity(
        IGraphicsEffectSource blurredSource,
        IGraphicsEffectSource tintColorEffect,
        D3DCOLORVALUE initialLuminosityColor,
        List<string> animatedProperties
        )
    {
        animatedProperties.Add("LuminosityColor.Color");

        var luminosityColorEffect = new FloodEffect
        {
            Name = "LuminosityColor",
            Color = initialLuminosityColor
        };

        var luminosityBlendEffect = new BlendEffect
        {
            Mode = D2D1_BLEND_MODE.D2D1_BLEND_MODE_COLOR,
            Background = blurredSource,
            Foreground = luminosityColorEffect
        };

        var colorBlendEffect = new BlendEffect
        {
            Mode = D2D1_BLEND_MODE.D2D1_BLEND_MODE_LUMINOSITY,
            Background = luminosityBlendEffect,
            Foreground = tintColorEffect
        };

        return colorBlendEffect;
    }

    private static float GetTintOpacityModifier(D3DCOLORVALUE tintColor)
    {
        if (!Is19H1OrHigher)
            return 1f;

        const float midPoint = 0.50f;
        const float whiteMaxOpacity = 0.45f;
        const float midPointMaxOpacity = 0.90f;
        const float blackMaxOpacity = 0.85f;

        var hsv = Hsv.From(tintColor);
        var opacityModifier = midPointMaxOpacity;

        if (hsv.Value != midPoint)
        {
            float lowestMaxOpacity = midPointMaxOpacity;
            float maxDeviation = midPoint;

            if (hsv.Value > midPoint)
            {
                lowestMaxOpacity = whiteMaxOpacity;
                maxDeviation = 1f - maxDeviation;
            }
            else if (hsv.Value < midPoint)
            {
                lowestMaxOpacity = blackMaxOpacity;
            }

            var maxOpacitySuppression = midPointMaxOpacity - lowestMaxOpacity;
            var deviation = Math.Abs(hsv.Value - midPoint);
            var normalizedDeviation = deviation / maxDeviation;

            if (hsv.Saturation > 0f)
            {
                maxOpacitySuppression *= Math.Max(1f - hsv.Saturation * 2f, 0f);
            }

            var opacitySuppression = maxOpacitySuppression * normalizedDeviation;
            opacityModifier = midPointMaxOpacity - opacitySuppression;
        }

        return opacityModifier;
    }

    private static D3DCOLORVALUE GetEffectiveTintColor(D3DCOLORVALUE tintColor, float tintOpacity, float? tintLuminosityOpacity)
    {
        if (tintLuminosityOpacity.HasValue)
        {
            tintColor.a *= tintOpacity;
        }
        else
        {
            var tintOpacityModifier = GetTintOpacityModifier(tintColor);
            tintColor.a *= tintOpacity * tintOpacityModifier;
        }

        return tintColor;
    }

    private static D3DCOLORVALUE GetEffectiveLuminosityColor(D3DCOLORVALUE tintColor, float tintOpacity, float? tintLuminosityOpacity)
    {
        tintColor.a *= tintOpacity;
        return GetLuminosityColor(tintColor, tintLuminosityOpacity);
    }

    private static D3DCOLORVALUE GetLuminosityColor(D3DCOLORVALUE tintColor, float? tintLuminosityOpacity)
    {
        if (tintLuminosityOpacity.HasValue)
            return tintColor.ChangeAlpha(tintLuminosityOpacity.Value.Clamp(0f, 1f));

        const float minHsvV = 0.125f;
        const float maxHsvV = 0.965f;

        var hsvTintColor = Hsv.From(tintColor);

        var clampedHsvV = hsvTintColor.Value.Clamp(minHsvV, maxHsvV);
        var hsvLuminosityColor = new Hsv(hsvTintColor.Hue, hsvTintColor.Saturation, clampedHsvV);

        const float minLuminosityOpacity = 0.15f;
        const float maxLuminosityOpacity = 1.03f;

        var luminosityOpacityRangeMax = maxLuminosityOpacity - minLuminosityOpacity;
        var mappedTintOpacity = tintColor.a * luminosityOpacityRangeMax + minLuminosityOpacity;

        var color = hsvLuminosityColor.ToD3DCOLORVALUE(Math.Min(mappedTintOpacity, 1f));
        return color;
    }

    private static CompositionSurfaceBrush CreateNoiseBrush(CompositionGraphicsDevice device)
    {
        const string name = "NoiseAsset_256X256.png";
        using var im = ResourcesUtilities.GetWicBitmapSource(n => n.EndsWith(name)) ?? throw new InvalidOperationException();

        var noiseDrawingSurface = device.CreateDrawingSurface(im.GetWinSize(), DirectXPixelFormat.B8G8R8A8UIntNormalized, DirectXAlphaMode.Premultiplied);
        using var interop = noiseDrawingSurface.AsComObject<ICompositionDrawingSurfaceInterop>();
        using var dc = interop.BeginDraw();
        dc.Clear(D3DCOLORVALUE.Transparent);
        using (var bmp = dc.CreateBitmapFromWicBitmap(im))
        {
            dc.DrawBitmap(bmp);
        }

        interop.EndDraw();
        var brush = device.Compositor.CreateSurfaceBrush(noiseDrawingSurface);
        brush.Stretch = CompositionStretch.None;
        brush.HorizontalAlignmentRatio = 0;
        brush.VerticalAlignmentRatio = 0;
        return brush;
    }

    public static CompositionEffectBrush Create(
        CompositionGraphicsDevice device,
        D3DCOLORVALUE tintColor,
        float tintOpacity,
        float? tintLuminosityOpacity = null,
        bool useLegacyEffect = false,
        bool useWindowsAcrylic = true)
    {
        ArgumentNullException.ThrowIfNull(device);

        var effectiveTintColor = GetEffectiveTintColor(tintColor, tintOpacity, tintLuminosityOpacity);
        var luminosityColor = GetEffectiveLuminosityColor(tintColor, tintOpacity, tintLuminosityOpacity);

        var acrylicBrush = CreateAcrylicBrushWorker(device.Compositor, effectiveTintColor, luminosityColor, useLegacyEffect, useWindowsAcrylic);

        acrylicBrush.SetSourceParameter("Noise", CreateNoiseBrush(device));
        acrylicBrush.Properties.InsertColor("TintColor.Color", effectiveTintColor.ToColor());

        if (!useLegacyEffect && Is19H1OrHigher)
        {
            acrylicBrush.Properties.InsertColor("LuminosityColor.Color", luminosityColor.ToColor());
        }

        return acrylicBrush;
    }

    private static CompositionEffectBrush CreateAcrylicBrushWorker(
        Compositor compositor,
        D3DCOLORVALUE initialTintColor,
        D3DCOLORVALUE initialLuminosityColor,
        bool useLegacyEffect = false,
        bool useWindowsAcrylic = true
        )
    {
        var effectFactory = CreateAcrylicBrushCompositionEffectFactory(compositor, initialTintColor, initialLuminosityColor, useLegacyEffect, useWindowsAcrylic);
        var acrylicBrush = effectFactory.CreateBrush();

        if (useWindowsAcrylic)
        {
            // Note: requires Window.EnableBlurBehind(); otherwise the brush may render black.
            var hostBackdropBrush = compositor.CreateHostBackdropBrush();
            acrylicBrush.SetSourceParameter("Backdrop", hostBackdropBrush);
        }
        else
        {
            var backdropBrush = compositor.CreateBackdropBrush();
            acrylicBrush.SetSourceParameter("Backdrop", backdropBrush);
        }
        return acrylicBrush;
    }

    private static CompositionEffectFactory CreateAcrylicBrushCompositionEffectFactory(
                Compositor compositor,
                D3DCOLORVALUE initialTintColor,
                D3DCOLORVALUE initialLuminosityColor,
                bool useLegacyEffect = false,
                bool useWindowsAcrylic = true
                )
    {
        var tintColorEffect = new FloodEffect
        {
            Name = "TintColor",
            Color = initialTintColor
        };

        var animatedProperties = new List<string>
        {
            "TintColor.Color"
        };

        var backdropEffectSourceParameter = new CompositionEffectSourceParameter("Backdrop");

        IGraphicsEffectSource blurredSource;
        if (useWindowsAcrylic)
        {
            blurredSource = backdropEffectSourceParameter.As<IGraphicsEffectSource>();
        }
        else
        {
            var gaussianBlurEffect = new GaussianBlurEffect
            {
                Name = "Blur",
                BorderMode = D2D1_BORDER_MODE.D2D1_BORDER_MODE_HARD,
                StandardDeviation = _blurRadius,
                Source = backdropEffectSourceParameter.As<IGraphicsEffectSource>()
            };
            blurredSource = gaussianBlurEffect;
        }

        if (!Is19H1OrHigher)
        {
            useLegacyEffect = true;
        }

        IGraphicsEffectSource tintOutput = useLegacyEffect ?
            CombineNoiseWithTintEffectLegacy(blurredSource, tintColorEffect) :
            CombineNoiseWithTintEffectLuminosity(blurredSource, tintColorEffect, initialLuminosityColor, animatedProperties);

        // Ensure noise covers all surface by wrapping edges.
        var noiseBorderEffect = new BorderEffect
        {
            EdgeModeX = D2D1_BORDER_EDGE_MODE.D2D1_BORDER_EDGE_MODE_WRAP,
            EdgeModeY = D2D1_BORDER_EDGE_MODE.D2D1_BORDER_EDGE_MODE_WRAP,
            Source = new CompositionEffectSourceParameter("Noise").As<IGraphicsEffectSource>()
        };

        var noiseOpacityEffect = new OpacityEffect
        {
            Name = "NoiseOpacity",
            Opacity = _noiseOpacity,
            Source = noiseBorderEffect
        };

        var blendEffectOuter = new CompositeStepEffect
        {
            Mode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
            Destination = tintOutput,
            Source = noiseOpacityEffect
        };

        return compositor.CreateEffectFactory(blendEffectOuter, animatedProperties);
    }
}
