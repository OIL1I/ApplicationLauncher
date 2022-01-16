using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SaveHelper;

namespace ApplicationLauncher.Logic
{
    public static class SaveManager
    {
        private static string DefaultSavePath = Environment.CurrentDirectory + "\\Saves\\";

        public static string SavePath { get; set; }

        public static void SaveToFile(SaveItem item)
        {
            #region --- Exceptions ---
            if (string.IsNullOrEmpty(SavePath)) throw new Exceptions.SavePathWasNotSetException(); 
            if (!Directory.Exists(SavePath)) throw new Exceptions.SavePathNotFoundException(SavePath);
            if (SavePath != DefaultSavePath) throw new Exceptions.ChangedSavePathException();
            #endregion

            SaveHelper.SaveHelper.SaveToPath(SavePath, item);
        }

        public static SaveItem[] LoadFromFiles(string pSavePath)
        {
            #region --- Exceptions ---
            if (string.IsNullOrEmpty(pSavePath)) throw new ArgumentNullException("SavePath", "Given SavePath was null or empty");
            if (!Directory.Exists(pSavePath)) throw new Exceptions.SavePathNotFoundException(pSavePath);
            #endregion
            List<SaveItem> result = new List<SaveItem>();

            if (!LoadHelper.LoadFromPath(pSavePath, out result)) throw new Exception("Error loading from path: " + SavePath);

            return result.ToArray();
        }

        public static void SetPathsToDefault()
        {
            SavePath = DefaultSavePath;
        }

        public static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
