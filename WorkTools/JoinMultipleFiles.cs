using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkTools
{
    public partial class JoinMultipleFiles : Form
    {
        static JoinMultipleFiles _instance;
        public static JoinMultipleFiles Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new JoinMultipleFiles();
                }
                return _instance;
            }
        }
        readonly string FolderPath = Utility.AppPath + @"Put files here\JoinMultipleFiles\";

        public JoinMultipleFiles()
        {
            InitializeComponent();
        }

        void Execute_Click(object sender, EventArgs e)
        {
            // Make button "Processing" and unable to push while processing
            Execute.Text = "Processing";
            Execute.Enabled = false;

            // Validation
            if (string.IsNullOrEmpty(InPathText.Text))
                InPathText.Text = "Resource";
            string inPath = FolderPath + InPathText.Text;
            if (string.IsNullOrEmpty(OutPathText.Text))
                OutPathText.Text = "Result";
            string outPath = FolderPath + OutPathText.Text;
            if (string.IsNullOrEmpty(ResultFileNameBox.Text))
                ResultFileNameBox.Text = "Result";

            // Error handling when there's resource folder is missing
            if (!Directory.Exists(inPath))
            {
                MessageBox.Show("Resource folder is missing", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableExecute();
                return;
            }

            // Error Handling when target extensions are not set
            if (string.IsNullOrWhiteSpace(FileExtensions.Text))
            {
                MessageBox.Show("Set target extensions", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableExecute();
                return;
            }

            // Get file paths
            List<string> files = FileUtility.ReadFilesInFolder(inPath, FileExtensions.Text);

            // Separate into chunks not to bother PC memory
            var chunks = files.Select((v, i) => new { v, i })
                .GroupBy(x => x.i / 100)
                .Select(g => g.Select(x => x.v));

            StringBuilder text = new();

            foreach (var chunk in chunks)
            {
                foreach (var file in chunk)
                {
                    if (IncludeFileNameFlag.Checked)
                    {
                        text.Append(Path.GetFileName(file) + "\r\n");
                    }

                    // Extract the main body
                    text.Append(FileUtility.ReadFile(file) + "\r\n");

                    // Put between-file text
                    text.Append(TextBetweenFiles.Text + "\r\n");
                }
            }
            // Delete the last between-file text
            int len = TextBetweenFiles.Text.Length + "\r\n".Length;
            text.Remove(text.Length - len, len);

            // Save
            var a = FileUtility.MakeNewFilePath(outPath + "/" + ResultFileNameBox.Text + ".txt");
            using StreamWriter sw = new(a.Item1, true);
            sw.Write(text);

            EnableExecute();

            void EnableExecute()
            {
                Execute.Text = "Process";
                Execute.Enabled = true;
            }
        }
    }
}
