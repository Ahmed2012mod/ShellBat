namespace ShellBat.Utilities;

// see http://stackoverflow.com/questions/429692/properly-notifying-all-listeners-of-a-system-wide-named-manual-reset-event-and-t/
public static class NotifyEvent
{
    public static EventWaitHandle CreateEvent(string namePrefix)
    {
        ArgumentNullException.ThrowIfNull(namePrefix);
        var maximumListeners = Settings.Current.MaximumInstances;
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maximumListeners);

        for (var i = 0; i < maximumListeners; i++)
        {
            var evt = new EventWaitHandle(false, EventResetMode.AutoReset, namePrefix + i, out var createdNew);
            if (createdNew)
                return evt;

            evt.Dispose();
        }

        throw new ShellBatException($"0008: Can't listen to other {Program.AppId} instances. Increase MaximumInstances, currently set to {maximumListeners}.");
    }

    public static void RaiseEvent(string? namePrefix)
    {
        if (namePrefix == null)
            return;

        var maximumListeners = Settings.Current.MaximumInstances;
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maximumListeners);

        for (var i = 0; i < maximumListeners; i++)
        {
            if (EventWaitHandle.TryOpenExisting(namePrefix + i, out var evt))
            {
                evt.Set();
                evt.Dispose();
            }
        }
    }
}
