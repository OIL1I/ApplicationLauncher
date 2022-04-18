using System;
using ApplicationLauncher.Controls;
using System.Collections.Generic;

namespace ApplicationLauncher.Data
{
    public static class LauncherData
    {
        private static List<LauncherItem> Items = new List<LauncherItem>();
        private static List<FolderItem> Folder = new List<FolderItem>();

        public static int ItemCount { get => Items.Count; }
        public static int FolderCount { get => Folder.Count; }

        public static LauncherItem GetItem(int index)
        {
            if (index > Items.Count) return null;
            return Items[index];
        }

        public static FolderItem GetFolder(int index)
        {
            if (index > Folder.Count) return null;
            return Folder[index];
        }

        public static bool AddItem(LauncherItem newItem)
        {
            try
            {
                Items.Add(newItem);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool AddFolder(FolderItem newFolder)
        {
            try
            {
                Folder.Add(newFolder);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool RemoveItem(LauncherItem ItemToRemove)
        {
            try
            {
                Items.Remove(ItemToRemove);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public static bool RemoveFolder(FolderItem FolderToRemove)
        {
            try
            {
                Folder.Remove(FolderToRemove);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool RemoveItemAt(int index)
        {
            try
            {
                Items.RemoveAt(index);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public static bool RemoveFolderAt(int index)
        {
            try
            {
                Folder.RemoveAt(index);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
