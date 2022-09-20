using System;

namespace WorkTools
{
    class Utility
    {
        /// <summary>Path of application(used for reading and writing files)</summary>
        static public string AppPath;

        static public void Initialize()
        {
            AppPath = AppDomain.CurrentDomain.BaseDirectory;
        }


        /// <summary>
        /// Replace only the first match of text
        /// </summary>
        public static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
