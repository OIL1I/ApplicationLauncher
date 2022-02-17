using System;

namespace ApplicationLauncher.Controls
{
    public class ItemFlowLayoutPanelEventArgs : EventArgs
    {
        public LauncherItem LauncherItem { get; set; }

        public ItemFlowLayoutPanelEventArgs(LauncherItem pLauncherItem)
        {
            LauncherItem = pLauncherItem;
        }
    }
}
