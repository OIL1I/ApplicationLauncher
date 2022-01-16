using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SaveHelper
{
    public static class LoadHelper
    {
        /// <summary>
        /// Loads the content of a given savefile to a SaveItem
        /// </summary>
        /// <param name="pFilePath">Path to savefile</param>
        /// <param name="item">SaveItem filecontent get loaded into</param>
        /// <returns>Returns "true" when loading succeeds, otherwise "false"</returns>
        public static bool LoadFromFile(string pFilePath, out SaveItem item)
        {
            item = null;
            try
            {
                FileStream fileStream = new FileStream(pFilePath, FileMode.Open);
                item = (new BinaryFormatter().Deserialize(fileStream)) as SaveItem;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Loads all .sav files into a list of SaveItems
        /// </summary>
        /// <param name="pPath">Path to files</param>
        /// <param name="items">List of SaveItems</param>
        /// <returns>Returns "true" when loading succeeds, otherwise "false"</returns>
        public static bool LoadFromPath(string pPath, out List<SaveItem> items)
        {
            items = new List<SaveItem>();
            try
            {
                string[] files = Directory.GetFiles(pPath, "*.sav");

                foreach (string file in files)
                {
                    FileStream fileStream = new FileStream(file, FileMode.Open);
                    SaveItem saveItem = (new BinaryFormatter().Deserialize(fileStream)) as SaveItem;
                    items.Add(saveItem);
                    fileStream.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Loads files of a given extension into a list of SaveItems
        /// </summary>
        /// <param name="pPath">Path to Files</param>
        /// <param name="items">List of SaveItems</param>
        /// <param name="pFileExtension">Extension that is searched for</param>
        /// <returns>Returns "true" when loading succeeds, otherwise "false"</returns>
        public static bool LoadFromPath(string pPath, out List<SaveItem> items, string pFileExtension)
        {
            items = new List<SaveItem>();
            if (String.IsNullOrEmpty(pFileExtension)) return false;
            try
            {
                string[] files = Directory.GetFiles(pPath, pFileExtension);

                foreach (string file in files)
                {
                    FileStream fileStream = new FileStream(file, FileMode.Open);
                    SaveItem saveItem = (new BinaryFormatter().Deserialize(fileStream)) as SaveItem;
                    items.Add(saveItem);
                    fileStream.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
