using System;

namespace ApplicationLauncher.Controls
{
    public class LauncherItemFlowLayoutPanelEventArgs : EventArgs
    {
        public LauncherItem LauncherItem { get; set; }

        public LauncherItemFlowLayoutPanelEventArgs(LauncherItem pLauncherItem)
        {
            LauncherItem = pLauncherItem;
        }
    }
}
