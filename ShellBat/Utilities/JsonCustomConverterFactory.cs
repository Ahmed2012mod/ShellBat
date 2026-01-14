namespace ShellBat.Utilities;

// these structs cause recursive serialization issues, so we need custom converters
public class JsonCustomConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert == typeof(RECT) || typeToConvert == typeof(POINT) || typeToConvert == typeof(WINDOWPLACEMENT);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(RECT))
            return new JsonCustomRECTConverter();

        if (typeToConvert == typeof(D2D_RECT_F))
            return new JsonCustomD2D_RECT_FConverter();

        if (typeToConvert == typeof(POINT))
            return new JsonCustomPOINTConverter();

        if (typeToConvert == typeof(WINDOWPLACEMENT))
            return new JsonCustomWINDOWPLACEMENTConverter();

        throw new ShellBatException($"0007: Internal error.");
    }

    private sealed class JsonCustomWINDOWPLACEMENTConverter : JsonConverter<WINDOWPLACEMENT>
    {
        public override WINDOWPLACEMENT Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException($"Expected start of object for {nameof(WINDOWPLACEMENT)}.");

            var placement = new WINDOWPLACEMENT();
            while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case nameof(WINDOWPLACEMENT.length):
                            placement.length = reader.GetUInt32();
                            break;

                        case nameof(WINDOWPLACEMENT.flags):
                            placement.flags = (WINDOWPLACEMENT_FLAGS)reader.GetUInt32();
                            break;

                        case nameof(WINDOWPLACEMENT.showCmd):
                            placement.showCmd = reader.GetUInt32();
                            break;

                        case nameof(WINDOWPLACEMENT.ptMinPosition):
                            placement.ptMinPosition = JsonSerializer.Deserialize(ref reader, JsonSourceStructGenerationContext.Default.POINT);
                            break;

                        case nameof(WINDOWPLACEMENT.ptMaxPosition):
                            placement.ptMaxPosition = JsonSerializer.Deserialize(ref reader, JsonSourceStructGenerationContext.Default.POINT);
                            break;

                        case nameof(WINDOWPLACEMENT.rcNormalPosition):
                            placement.rcNormalPosition = JsonSerializer.Deserialize(ref reader, JsonSourceStructGenerationContext.Default.RECT);
                            break;
                    }
                }
            }
            return placement;
        }
        public override void Write(Utf8JsonWriter writer, WINDOWPLACEMENT value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber(nameof(WINDOWPLACEMENT.length), value.length);
            writer.WriteNumber(nameof(WINDOWPLACEMENT.flags), (uint)value.flags);
            writer.WriteNumber(nameof(WINDOWPLACEMENT.showCmd), value.showCmd);
            writer.WritePropertyName(nameof(WINDOWPLACEMENT.ptMinPosition));
            JsonSerializer.Serialize(writer, value.ptMinPosition, JsonSourceStructGenerationContext.Default.POINT);
            writer.WritePropertyName(nameof(WINDOWPLACEMENT.ptMaxPosition));
            JsonSerializer.Serialize(writer, value.ptMaxPosition, JsonSourceStructGenerationContext.Default.POINT);
            writer.WritePropertyName(nameof(WINDOWPLACEMENT.rcNormalPosition));
            JsonSerializer.Serialize(writer, value.rcNormalPosition, JsonSourceStructGenerationContext.Default.RECT);
            writer.WriteEndObject();
        }
    }

    private sealed class JsonCustomPOINTConverter : JsonConverter<POINT>
    {
        public override POINT Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException($"Expected start of object for {nameof(POINT)}.");

            var point = new POINT();
            while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case nameof(POINT.x):
                            point.x = reader.GetInt32();
                            break;

                        case nameof(POINT.y):
                            point.y = reader.GetInt32();
                            break;
                    }
                }
            }
            return point;
        }

        public override void Write(Utf8JsonWriter writer, POINT value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber(nameof(POINT.x), value.x);
            writer.WriteNumber(nameof(POINT.y), value.y);
            writer.WriteEndObject();
        }
    }

    private sealed class JsonCustomRECTConverter : JsonConverter<RECT>
    {
        public override RECT Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException($"Expected start of object for {nameof(RECT)}.");

            var rect = new RECT();
            while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case nameof(RECT.left):
                            rect.left = reader.GetInt32();
                            break;

                        case nameof(RECT.top):
                            rect.top = reader.GetInt32();
                            break;

                        case nameof(RECT.right):
                            rect.right = reader.GetInt32();
                            break;

                        case nameof(RECT.bottom):
                            rect.bottom = reader.GetInt32();
                            break;
                    }
                }
            }
            return rect;
        }

        public override void Write(Utf8JsonWriter writer, RECT value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber(nameof(RECT.left), value.left);
            writer.WriteNumber(nameof(RECT.top), value.top);
            writer.WriteNumber(nameof(RECT.right), value.right);
            writer.WriteNumber(nameof(RECT.bottom), value.bottom);
            writer.WriteEndObject();
        }
    }

    private sealed class JsonCustomD2D_RECT_FConverter : JsonConverter<D2D_RECT_F>
    {
        public override D2D_RECT_F Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException($"Expected start of object for {nameof(D2D_RECT_F)}.");

            var rect = new D2D_RECT_F();
            while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case nameof(D2D_RECT_F.left):
                            rect.left = reader.GetSingle();
                            break;

                        case nameof(D2D_RECT_F.top):
                            rect.top = reader.GetSingle();
                            break;

                        case nameof(D2D_RECT_F.right):
                            rect.right = reader.GetSingle();
                            break;

                        case nameof(D2D_RECT_F.bottom):
                            rect.bottom = reader.GetSingle();
                            break;
                    }
                }
            }
            return rect;
        }

        public override void Write(Utf8JsonWriter writer, D2D_RECT_F value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber(nameof(D2D_RECT_F.left), value.left);
            writer.WriteNumber(nameof(D2D_RECT_F.top), value.top);
            writer.WriteNumber(nameof(D2D_RECT_F.right), value.right);
            writer.WriteNumber(nameof(D2D_RECT_F.bottom), value.bottom);
            writer.WriteEndObject();
        }
    }
}
