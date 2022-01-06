using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ApplicationLauncher.Logic
{
    //TODO: Rework saving --> SaveManager.dll
    public static class SaveManager
    {
        private static string DefaultSavePath = Environment.CurrentDirectory + "\\Saves\\";

        public static string SavePath { get; set; }

        public static void SaveToFile(Data.SaveItem item)
        {
            #region --- Exceptions ---
            if (string.IsNullOrEmpty(SavePath)) throw new Exceptions.SavePathWasNotSetException(); 
            if (!Directory.Exists(SavePath)) throw new Exceptions.SavePathNotFoundException(SavePath);
            if (SavePath != DefaultSavePath) throw new Exceptions.ChangedSavePathException();
            #endregion

            FileStream fileStream = new FileStream(SavePath + item.itemName + ".sav", FileMode.Create);

            new BinaryFormatter().Serialize(fileStream, item);

            fileStream.Close();
        }

        public static Data.SaveItem[] LoadFromFiles(string pSavePath)
        {
            #region --- Exceptions ---
            if (string.IsNullOrEmpty(pSavePath)) throw new ArgumentNullException("SavePath", "Given SavePath was null or empty");
            if (!Directory.Exists(pSavePath)) throw new Exceptions.SavePathNotFoundException(pSavePath);
            #endregion

            string[] filePaths = Directory.GetFiles(SavePath, "*.sav");
            List<Data.SaveItem> result = new List<Data.SaveItem>();

            foreach (string file in filePaths)
            {
                FileStream fileStream = new FileStream(file, FileMode.Open);
                result.Add(new BinaryFormatter().Deserialize(fileStream) as Data.SaveItem);
                fileStream.Close();
            }

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
