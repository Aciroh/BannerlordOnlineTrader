using System;

namespace Bannerlord_Online_Trader
{
    public class ConfigurationParameters
    {
        private String launcherPath;
        public event EventHandler launcherPathChanged;

        public string LauncherPath
        {
            get => launcherPath;
            set
            {
                launcherPath = value;
                LauncherPathChangedFunction(value, EventArgs.Empty);
            }
        }

        private void LauncherPathChangedFunction(string newValue, EventArgs eventArgs)
        {
            launcherPathChanged?.Invoke(newValue, eventArgs);
        }
    }
}