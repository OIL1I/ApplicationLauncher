using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SaveHelper
{
    public static class SaveHelper
    {

        /// <summary>
        /// Serializes and saves a given SaveItem to a given Path as: "pPath\\pItem.Name.sav"
        /// </summary>
        /// <param name="pPath">
        /// Path to save to
        /// </param>
        /// <param name="pItem">
        /// SaveItem to save
        /// </param>
        /// <returns>
        /// "true" when saving succeeds, otherwise "false"
        /// </returns>
        public static bool SaveToPath(string pPath, SaveItem pItem)
        {
            try
            {
                object itemName;
                pItem.GetDictionary().TryGetValue("Name", out itemName);
                FileStream fileStream = new FileStream(pPath + itemName.ToString() + ".sav", FileMode.Create);
                new BinaryFormatter().Serialize(fileStream, pItem);
                fileStream.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Serializes and saves a given SaveItem to a given Path as: "pPath\\pFileName.sav"
        /// </summary>
        /// <param name="pPath">Path to save to</param>
        /// <param name="pItem">SaveItem to save</param>
        /// <param name="pFileName">Name the file should have</param>
        /// <returns>"true" when saving succeeds, otherwise "false"</returns>
        public static bool SaveToPath(string pPath, SaveItem pItem, string pFileName)
        {
            try
            {
                FileStream fileStream = new FileStream(pPath + pFileName + ".sav", FileMode.Create);
                new BinaryFormatter().Serialize(fileStream, pItem);
                fileStream.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Serializes and saves a given SaveItem to a given Path as: "pPath\\pFileName.pFileExtension"
        /// </summary>
        /// <param name="pPath">Path to save to</param>
        /// <param name="pItem">SaveItem to save</param>
        /// <param name="pFileName">Name the file should have</param>
        /// <param name="pFileExtension">Extension the file should have (e.g. ".exe")</param>
        /// <returns>"true" when saving succeeds, otherwise "false"</returns>
        public static bool SaveToPath(string pPath, SaveItem pItem, string pFileName, string pFileExtension)
        {
            try
            {
                FileStream fileStream = new FileStream(pPath + pFileName + pFileExtension, FileMode.Create);
                new BinaryFormatter().Serialize(fileStream, pItem);
                fileStream.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Serializes and saves a given SaveItem to a given file
        /// </summary>
        /// <param name="pFilePath">
        /// File to save to
        /// </param>
        /// <param name="pItem">
        /// SaveItem to save
        /// </param>
        /// <returns>
        /// "true" when saving succeeds, otherwise "false"
        /// </returns>
        public static bool SaveToFile(string pFilePath, SaveItem pItem)
        {
            try
            {
                FileStream fileStream = new FileStream(pFilePath, FileMode.Create);
                new BinaryFormatter().Serialize(fileStream, pItem);
                fileStream.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
