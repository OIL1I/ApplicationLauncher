using System;
using IWshRuntimeLibrary;
using System.IO;

namespace ShortcutHelper
{
    public static class ShortcutCreater
    {
        private const string DEFAULT_SHORTCUT_EXTENSION = ".lnk";
        public static Exceptions.ExceptionHelper Exceptions = new Exceptions.ExceptionHelper();
        public static void CreateDesktopShortcut(string pFilepath)
        {
            CreateDesktopShortcut(pFilepath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void CreateDesktopShortcut(string pFilepath, string pExtension)
        {
            CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), pFilepath, pExtension);
        }
        public static void CreateDesktopShortcutWithArguments(string pFilepath, string pArguments)
        {
            CreateDesktopShortcutWithArguments(pFilepath, pArguments, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void CreateDesktopShortcutWithArguments(string pFilepath,string pArguments, string pExtension)
        {
            CreateShortcutWithArguments(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), pFilepath, pArguments, pExtension);
        }
        public static void CreateStartupShortcut(string pFilepath)
        {
            CreateStartupShortcut(pFilepath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void CreateStartupShortcut(string pFilepath, string pExtension)
        {
            CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), pFilepath, pExtension);
        }
        public static void CreateStartupShortcutWithArguments(string pFilepath, string pArguments)
        {
            CreateStartupShortcutWithArguments(pFilepath, pArguments, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void CreateStartupShortcutWithArguments(string pFilepath, string pArguments, string pExtension)
        {
            CreateShortcutWithArguments(Environment.GetFolderPath(Environment.SpecialFolder.Startup), pFilepath, pArguments, pExtension);
        }
        public static void CreateShortcut(string pLinkpath, string pFilepath)
        {
            CreateShortcut(pLinkpath, pFilepath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void CreateShortcut(string pLinkpath, string pFilepath, string pExtension)
        {
            if (!Directory.Exists(pLinkpath))
                throw new Exceptions.NotExistingLinkDirectoryException("Path: " + pLinkpath + "was not found !");
            if (String.IsNullOrEmpty(pExtension) || String.IsNullOrWhiteSpace(pExtension) || pExtension[0] != '.')
                throw new Exceptions.InvalidShortcutExtensionException($"Given extension: " + pExtension + " was invalid !");

            string linkName = Path.ChangeExtension(Path.GetFileName(pFilepath), pExtension);

            WshShell shell = new WshShell();
            IWshShortcut shortcut = shell.CreateShortcut(pLinkpath + Path.DirectorySeparatorChar + linkName);
            shortcut.Description = System.Diagnostics.FileVersionInfo.GetVersionInfo(pFilepath).FileDescription;
            shortcut.WorkingDirectory = pFilepath.Substring(0, pFilepath.Length - Path.GetFileName(pFilepath).Length);
            shortcut.TargetPath = pFilepath;

            shortcut.Save();
        }
        public static void CreateShortcutWithArguments(string pLinkpath, string pFilepath, string pArguments)
        {
            CreateShortcutWithArguments(pLinkpath, pFilepath, pArguments, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static void CreateShortcutWithArguments(string pLinkpath, string pFilepath, string pArguments, string pExtension)
        {
            if (!Directory.Exists(pLinkpath))
                throw new Exceptions.NotExistingLinkDirectoryException("Path: " + pLinkpath + "was not found !");
            if (String.IsNullOrEmpty(pExtension) || String.IsNullOrWhiteSpace(pExtension) || pExtension[0] != '.')
                throw new Exceptions.InvalidShortcutExtensionException($"Given extension: " + pExtension + " was invalid !");

            string linkName = Path.ChangeExtension(Path.GetFileName(pFilepath), pExtension);

            WshShell shell = new WshShell();
            IWshShortcut shortcut = shell.CreateShortcut(pLinkpath + Path.DirectorySeparatorChar + linkName);
            shortcut.Description = System.Diagnostics.FileVersionInfo.GetVersionInfo(pFilepath).FileDescription;
            shortcut.WorkingDirectory = pFilepath.Substring(0, pFilepath.Length - Path.GetFileName(pFilepath).Length);
            shortcut.TargetPath = pFilepath;
            shortcut.Arguments = pArguments;

            shortcut.Save();
        }
        public static bool TryCreateDesktopShortcut(string pFilepath)
        {
            return TryCreateDesktopShortcut(pFilepath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static bool TryCreateDesktopShortcut(string pFilepath, string pExtension)
        {
            try
            {
                CreateDesktopShortcut(pFilepath, pExtension);
                return true;
            }
            catch (Exception ex)
            {
                Exceptions.OnEception(ex);
                return false;
            }
        }
        public static bool TryCreateDesktopShortcutWithArguments(string pFilepath, string pArguments)
        {
            return TryCreateDesktopShortcutWithArguments(pFilepath, pArguments, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static bool TryCreateDesktopShortcutWithArguments(string pFilepath, string pArguments, string pExtension)
        {
            try
            {
                CreateDesktopShortcutWithArguments(pFilepath, pArguments, pExtension);
                return true;
            }
            catch (Exception ex)
            {
                Exceptions.OnEception(ex);
                return false;
            }
        }
        public static bool TryCreateStartupShortcut(string pFilepath)
        {
            return TryCreateStartupShortcut(pFilepath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static bool TryCreateStartupShortcut(string pFilepath, string pExtension)
        {
            try
            {
                CreateStartupShortcut(pFilepath, pExtension);
                return true;
            }
            catch (Exception ex)
            {
                Exceptions.OnEception(ex);
                return false;
            }
        }
        public static bool TryCreateStartupShortcutWithArguments(string pFilepath, string pArguments)
        {
            return TryCreateStartupShortcutWithArguments(pFilepath, pArguments, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static bool TryCreateStartupShortcutWithArguments(string pFilepath, string pArguments, string pExtension)
        {
            try
            {
                CreateStartupShortcutWithArguments(pFilepath, pArguments, pExtension);
                return true;
            }
            catch (Exception ex)
            {
                Exceptions.OnEception(ex);
                return false;
            }
        }
        public static bool TryCreateShortcut(string pLinkpath, string pFilepath)
        {
            return TryCreateShortcut(pLinkpath, pFilepath, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static bool TryCreateShortcut(string pLinkpath, string pFilepath, string pExtension)
        {
            try
            {
                CreateShortcut(pLinkpath, pFilepath, pExtension);
                return true;
            }
            catch (Exception ex)
            {
                Exceptions.OnEception(ex);
                return false;
            }
        }
        public static bool TryCreateShortcutWithArguments(string pLinkpath, string pFilepath, string pArguments)
        {
            return TryCreateShortcutWithArguments(pLinkpath, pFilepath, pArguments, DEFAULT_SHORTCUT_EXTENSION);
        }
        public static bool TryCreateShortcutWithArguments(string pLinkpath, string pFilepath, string pArguments, string pExtension)
        {
            try
            {
                CreateShortcutWithArguments(pLinkpath, pFilepath, pArguments, pExtension);
                return true;
            }
            catch (Exception ex)
            {
                Exceptions.OnEception(ex);
                return false;
            }
        }
    }
}