using System;
using System.Collections.Generic;
using System.IO;
using SaveHelper;

namespace ApplicationLauncher.Logic
{
    public static class SaveManager
    {
        public static string DefaultSavePath { get; set; }
        public static string CurrentSavePath { get; set; }
        public static string PreviousSavePath { get; set; }

        public static void SaveToFile(SaveItem item)
        {
            #region --- Exceptions ---
            if (string.IsNullOrEmpty(CurrentSavePath)) throw new Exceptions.SavePathWasNotSetException(); 
            if (!Directory.Exists(CurrentSavePath)) throw new Exceptions.SavePathNotFoundException(CurrentSavePath);
            if (CurrentSavePath != PreviousSavePath) throw new Exceptions.ChangedSavePathException();
            #endregion

            object _appPath;
            item.GetDictionary().TryGetValue("ItemPath", out _appPath);
            SaveHelper.SaveHelper.SaveToPath(CurrentSavePath, item, Path.GetFileNameWithoutExtension(_appPath.ToString()));
        }

        public static SaveItem[] LoadFromFiles(string pSavePath)
        {
            #region --- Exceptions ---
            if (string.IsNullOrEmpty(pSavePath)) throw new ArgumentNullException("SavePath", "Given SavePath was null or empty");
            if (!Directory.Exists(pSavePath)) throw new Exceptions.SavePathNotFoundException(pSavePath);
            #endregion
            List<SaveItem> result = new List<SaveItem>();

            if (!LoadHelper.LoadFromPath(pSavePath, out result)) throw new Exception("Error loading from path: " + CurrentSavePath);

            return result.ToArray();
        }

        public static void SetPathsToDefault()
        {
            CurrentSavePath = DefaultSavePath;
            PreviousSavePath = DefaultSavePath;
        }

        public static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static void RemoveSaveFile(string itemName)
        {
            File.Delete(PreviousSavePath + itemName + ".sav");
        }

        public static void RemoveCurrentSaveFiles()
        {
            foreach (string file in Directory.GetFiles(PreviousSavePath, "*.sav"))
            {
                File.Delete(file);
            }
        }
    }
}
