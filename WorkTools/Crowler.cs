using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace WorkTools
{
    public partial class Crowler : Form
    {
        static Crowler _instance;
        public static Crowler Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Crowler();
                }
                return _instance;
            }
        }
        
        // Crowling occurs every some seconds to avoid bothering sites
        /// <summary>The variation of waiting time</summary>
        readonly int waitTimeFrom = 5000;
        readonly int waitTimeTo = 7000;

        string FolderPath;

        public Crowler()
        {
            InitializeComponent();
        }

        void Crowler_Load(object sender, EventArgs e) 
        { 
            FolderPath = Utility.AppPath + @"Put files here\Crowler\";
        }

        /// <summary> Execute </summary>
        void Execute_Click(object sender, EventArgs e)
        {
            // Make button "Processing" and unable to push while processing
            Execute.Text = "Processing";
            Execute.Enabled = false;

            // Get urls from files
            List<string> files = FileUtility.ReadFilesInFolder(FolderPath + "URL", "csv|txt");
            List<string> URLs = new();
            files.ForEach(x =>
            {
                URLs.AddRange(FileUtility.ReadFileAsList(x));
            });

            // Get html from the url and extract and save the data
            URLs.ForEach(url =>
            {
                string text = GetHtml(url);
                if (string.IsNullOrEmpty(text)) return;
                var pathAndMessage = FileUtility.MakeNewFilePath(FolderPath + @"Result\" + url.Split('/').Last() + ".txt");
                using (StreamWriter sw = new(pathAndMessage.Item1, true))
                {
                    sw.Write(text);
                }
                LogBox.Text += "Got data from: " + url;
                if (!string.IsNullOrEmpty(pathAndMessage.Item2)) LogBox.Text += pathAndMessage.Item2;
                // Wait for some seconds to avoid bother sites
                Thread.Sleep(new Random().Next(waitTimeFrom, waitTimeTo));
                return;
            }
            );
            Execute.Enabled = true;
        }

        /// <summary>Get html file</summary>
        /// <param name="url">URL</param>
        static string GetHtml(string url)
        {
            try
            {
                using WebClient wc = new();
                using Stream st = wc.OpenRead(url);
                using StreamReader sr = new(st);
                return sr.ReadToEnd();
            }
            catch (WebException)
            {
                return "";
            }
        }

    }
}
