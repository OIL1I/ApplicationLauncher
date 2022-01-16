using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SaveHelper;

namespace ApplicationLauncher.Logic
{
    public static class SaveManager
    {
        //TODO: Set SavePath on first launch

        private static string DefaultSavePath = Environment.CurrentDirectory + "\\Saves\\";

        public static string CurrentSavePath { get; set; }
        public static string PreviousSavePath { get; set; }

        public static void SaveToFile(SaveItem item)
        {
            #region --- Exceptions ---
            if (string.IsNullOrEmpty(CurrentSavePath)) throw new Exceptions.SavePathWasNotSetException(); 
            if (!Directory.Exists(CurrentSavePath)) throw new Exceptions.SavePathNotFoundException(CurrentSavePath);
            if (CurrentSavePath != DefaultSavePath) throw new Exceptions.ChangedSavePathException();
            #endregion

            SaveHelper.SaveHelper.SaveToPath(CurrentSavePath, item);
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
        }

        public static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
