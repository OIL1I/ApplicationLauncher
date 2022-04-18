using System;

namespace ApplicationLauncher.Controls
{
    public class ItemFlowLayoutPanelEventArgs : EventArgs
    {
        public Logic.IItem Item { get; set; }

        public ItemFlowLayoutPanelEventArgs(Logic.IItem pItem)
        {
            Item = pItem;
        }
    }
}
