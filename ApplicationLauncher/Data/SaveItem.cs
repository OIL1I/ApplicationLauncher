using System;

namespace ApplicationLauncher.Data
{
    [Serializable]
    public class SaveItem
    {
        public bool isFavorite { get; set; }
        public string itemName { get; set; }
        public string itemPath { get; set; }
        public string args { get; set; }
        public System.Drawing.Image symbol { get; set; }
        public System.Drawing.Image defaultSymbol { get; set; }

        public SaveItem(Controls.LauncherItem pItem)
        {
            isFavorite = pItem.IsFavorite;
            itemName = pItem.ItemName;
            itemPath = pItem.PathToExe;
            args = pItem.Args;
            symbol = pItem.Symbol;
            defaultSymbol = pItem.DefaultItemSymbol;
        }
    }
}
