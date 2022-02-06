using System;
using System.IO;

namespace ShortcutHelper
{
    public static class ShortcutDeleter
    {
        private const string DEFAULT_SHORTCUT_EXTENSION = ".lnk";
        public static Exceptions.ExceptionHelper Exceptions = new Exceptions.ExceptionHelper();

        public static void DeleteDesktopShortcut(string pFilename)
        {
            DeleteShortcut(pFilename, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void DeleteDesktopShortcut(string pFilename, string pExtension)
        {
            DeleteShortcut(pFilename, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), pExtension);
        }
        public static void DeleteStartupShortcut(string pFilename)
        {
            DeleteStartupShortcut(pFilename, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void DeleteStartupShortcut(string pFilename, string pExtension)
        {
            DeleteShortcut(pFilename, Environment.GetFolderPath(Environment.SpecialFolder.Startup), pExtension);
        }
        public static void DeleteShortcut(string pFilename, string pShortcutpath)
        {
            DeleteShortcut(pFilename, pShortcutpath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void DeleteShortcut(string pFilename,string pShortcutpath, string pExtension)
        {
            if (!Directory.Exists(pShortcutpath))
                throw new Exceptions.NotExistingLinkDirectoryException("Given directory: " + pShortcutpath + " was not found!");
            if (String.IsNullOrEmpty(pExtension) || String.IsNullOrWhiteSpace(pExtension) || pExtension[0] != '.')
                throw new Exceptions.InvalidShortcutExtensionException($"Given extension: " + pExtension + " was invalid !");

            string linkname = Path.ChangeExtension(pFilename, pExtension);

            string[] files = Directory.GetFiles(pShortcutpath, linkname);

            if (files.Length == 0) throw new Exceptions.NotExistingShortcutException("There was no matching shortcut to given file: " + pFilename + "in directory: " + pShortcutpath);

            foreach (string file in files) File.Delete(file);
        }
        public static bool TryDeleteShortcut(string pFilename, string pShortcutpath)
        {
            return TryDeleteShortcut(pFilename, pShortcutpath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static bool TryDeleteShortcut(string pFilename, string pShortcutpath, string pExtension)
        {
            try
            {
                DeleteShortcut(pFilename, pShortcutpath, pExtension);
                return true;
            }
            catch (Exception ex)
            {
                Exceptions.OnEception(ex);
                return false;
            }
        }
        public static bool TryDeleteDesktopShortcut(string pFilename)
        {
            return TryDeleteShortcut(pFilename, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), DEFAULT_SHORTCUT_EXTENSION);
        } 
        public static bool TryDeleteDesktopShortcut(string pFilename, string pExtension)
        {
            return TryDeleteShortcut(pFilename, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), pExtension);
        }
        public static bool TryDeleteStartupShortcut(string pFilename)
        {
            return TryDeleteShortcut(pFilename, Environment.GetFolderPath(Environment.SpecialFolder.Startup), DEFAULT_SHORTCUT_EXTENSION);
        } 
        public static bool TryDeleteStartupShortcut(string pFilename, string pExtension)
        {
            return TryDeleteShortcut(pFilename, Environment.GetFolderPath(Environment.SpecialFolder.Startup), pExtension);
        }
    }
}
