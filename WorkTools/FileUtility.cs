using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace WorkTools
{
    class FileUtility
    {
        /// <summary>Read text from the file and return as List&lt;string&gt;</summary>
        /// <param name="FilePath">File path</param>
        /// <returns>Text of the file</returns>
        static public List<string> ReadFileAsList(string FilePath)
        {
            List<string> result = new();
            using (StreamReader sr = new(FilePath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    result.Add(line);
                }
            }
            return result;
        }

        /// <summary>Read text from the file and return as string</summary>
        /// <param name="FilePath">File path</param>
        /// <returns>Text of the file</returns>
        static public string ReadFile(string FilePath)
        {
            using StreamReader sr = new(FilePath);
            return sr.ReadToEnd();
        }

        /// <summary>Make a csv file<br></br>
        /// If there's already a file, puts a number in the end</summary>
        /// <param name="Data">Data to write in csv</param>
        /// <param name="FilePath">File path without ".csv"</param>
        /// <returns>The file path finally used</returns>
        static public string MakeCSV(List<string> Data, string FilePath)
        {
            // Check if there's a file with the same name
            // If exists, then put number in the end
            if(File.Exists(FilePath + ".csv"))
            {
                FilePath += "_001";
                int a = 2;
                while (File.Exists(FilePath + ".csv"))
                {
                    FilePath = FilePath.Substring(0, FilePath.Length - 1) + a;
                    a++;
                }
            }
            FilePath += ".csv";

            // Save
            using (StreamWriter sw = new StreamWriter(FilePath, false, new UTF8Encoding(true)))
            {
                Data.ForEach(x => sw.WriteLine(String.Join(',', x)));
            }

            return FilePath;
        }

        /// <summary>Get files of certain extension under the designated folder</summary>
        /// <param name="FolderPath">Folder path</param>
        /// <param name="Extensions">Extension<br></br>Designate like  "csv" or "csv|txt"</param>
        static public List<string> ReadFilesInFolder(string FolderPath, string Extensions = null)
        {
            List<string> files = Directory.GetFiles(FolderPath, "*", SearchOption.AllDirectories).ToList();

            for (int i = 0; i < files.Count; i++)
            {
                if (!Regex.IsMatch(Path.GetExtension(files[i]), Extensions)) files.RemoveAt(i);
            }
            return files;
        }

        /// <summary>
        /// Check if a path doesn't duplicate existing files,<br></br>
        /// if it duplicates, put a number in the end<br></br>
        /// If Folder doesn't exist, create new one
        /// </summary>
        /// <param name="path">Path you want to check</param>
        /// <returns>Path that doesn't duplicate</returns>
        static public (string, string) MakeNewFilePath(string path)
        {
            string message = "";
            string folderPath = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);

            // Replace characters that can't be used for file name to with _
            foreach (char c in Path.GetInvalidFileNameChars()) fileName = fileName.Replace(c, '_');
            path = Path.GetDirectoryName(path) + @"\" + fileName;

            // Create a folder if it doesn't exist
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // When it duplicates, it generates new path
            if (File.Exists(path))
            {
                message = "Path was changed.";
                string extension = Path.GetExtension(path);

                // If the path surpasses 256 characters, it causes an error, so need to shorten it
                // The length of extension will be considered as well
                if(path.Length > 251)
                {
                    if (path.Substring(251).Contains("/"))
                    {
                        message = "The path already exists and the path is too long and file name is too short, so the file will be under the upper folder.";
                    }
                    path = path.Substring(0, 251 - extension.Length) + extension;
                }

                // File existance check without extension and with number
                int i = 1;
                path = path.Remove(path.Length - extension.Length) + i.ToString().PadLeft(4, '0');
                while (File.Exists(path + extension))
                {
                    i++;
                    path = path.Remove(path.Length - 4) + i.ToString().PadLeft(4, '0');
                }
                path += extension;
            }
            return (path, message);
        }

    }
}
