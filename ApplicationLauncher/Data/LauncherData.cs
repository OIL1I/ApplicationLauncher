﻿using System;
using ApplicationLauncher.Controls;

namespace ApplicationLauncher.Data
{
    public static class LauncherData
    {
        private static LauncherItem[] Items = new LauncherItem[0];

        public static int ItemCount { get => Items.Length; }

        public static LauncherItem GetItem(int index)
        {
            if (index > Items.Length) return null;

            return Items[index];
        }

        public static bool AddItem(LauncherItem newItem)
        {
            try
            {
                LauncherItem[] t = new LauncherItem[Items.Length];

                for (int i = 0; i < Items.Length; i++)
                {
                    t[i] = Items[i];
                }

                Items = new LauncherItem[t.Length + 1];

                for (int i = 0; i < t.Length; i++)
                {
                    Items[i] = t[i];
                }

                Items[t.Length] = newItem;

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
                LauncherItem[] t = new LauncherItem[Items.Length];

                for (int i = 0; i < Items.Length; i++)
                {
                    t[i] = Items[i];
                }

                Items = new LauncherItem[t.Length - 1];

                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i].Equals(ItemToRemove))
                    {
                        t[i] = null;
                        break;
                    }
                }

                var j = 0;

                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] == null)
                    {
                        j++;
                    }
                    Items[i] = t[j];
                    j++;
                }

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
                LauncherItem[] t = new LauncherItem[Items.Length];

                for (int i = 0; i < Items.Length; i++)
                {
                    t[i] = Items[i];
                }

                Items = new LauncherItem[t.Length - 1];

                t[index] = null;

                var j = 0;

                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] == null)
                    {
                        j++;
                    }
                    Items[i] = t[j];
                    j++;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
