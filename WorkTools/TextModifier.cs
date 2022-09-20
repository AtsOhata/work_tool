using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WorkTools
{
    public partial class TextModifier : Form
    {
        static TextModifier _instance;
        public static TextModifier Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new TextModifier();
                }
                return _instance;
            }
        }

        readonly string FolderPath = Utility.AppPath + @"Put files here\TextModifier\";

        public TextModifier()
        {
            InitializeComponent();
        }

        void Extractor_Load(object sender, EventArgs e)
        {
            ModeSelectComboBox.SelectedIndex = 0;
            NewLineBox.Checked = true;
        }

        // Extract/Replace/Delete all files in the target folder
        /// <summary>「Process」Button</summary>
        void Execute_Click(object sender, EventArgs e)
        {
            Execute.Text = "Processing";
            Execute.Enabled = false;

            if (string.IsNullOrEmpty(InPathText.Text))
                InPathText.Text = "Resource";
            string inPath = FolderPath + InPathText.Text;
            if (string.IsNullOrEmpty(OutPathText.Text))
                OutPathText.Text = "Result";
            string outPath = FolderPath + OutPathText.Text;

            if (!Directory.Exists(inPath))
            {
                MessageBox.Show("Resource folder is missing", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Execute.Text = "Process";
                Execute.Enabled = true;
                return;
            }

            List<string> files = FileUtility.ReadFilesInFolder(inPath, "csv|txt");

            // Separate into chunks not to bother PC memory
            var chunks = files.Select((v, i) => new { v, i })
                .GroupBy(x => x.i / 100)
                .Select(g => g.Select(x => x.v));

            foreach (var chunk in chunks)
            {
                foreach (var file in chunk)
                {
                    string text = string.Join("\r\n", FileUtility.ReadFileAsList(file));
                    string result = "";

                    switch (ModeSelectComboBox.Text)
                    {
                        case "Extract":
                            result = text.RegexExtract(RegexText.Text, NewLineBox.Checked, !MultilineFlagBox.Checked);
                            result += "\n";
                            break;
                        case "Replace":
                            result = text.RegexReplace(RegexText.Text, ReplaceText.Text, !MultilineFlagBox.Checked);
                            result += "\n";
                            break;
                        case "Delete":
                            result = text.RegexReplace(RegexText.Text, "", !MultilineFlagBox.Checked);
                            result += "\n";
                            break;
                        default:
                            break;
                    }

                    // Save
                    var a = FileUtility.MakeNewFilePath(outPath + "/" + Path.GetFileName(file));
                    using StreamWriter sw = new(a.Item1, true);
                    sw.Write(result);
                }
            }

            Execute.Text = "Process";
            Execute.Enabled = true;
        }

        /// <summary>Add leftmost-shortest match into regex expression box</summary>
        void RegexPattern1_Click(object sender, EventArgs e)
        {
            string start = RegexPattern2_StartPattern.Text, end = RegexPattern2_EndPattern.Text;

            if (string.IsNullOrEmpty(start) && string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Put start and end patterns", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegexText.Text = start + ".*?" + end;
        }

        /// <summary>Add rightmost-shortest match into regex expression box</summary>
        void RegexPattern2_Click(object sender, EventArgs e)
        {
            string start = RegexPattern2_StartPattern.Text, end = RegexPattern2_EndPattern.Text;

            if (string.IsNullOrEmpty(start) && string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Put start and end patterns", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegexText.Text = start + "(?:(?!" + start + "|" + end + ").)*" + end;
        }

        void ModeSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModeSelectComboBox.Text == "Extract")
            {
                NewLineBox.Enabled = true;
                ReplaceText.Enabled = false;
                ReplaceText.BackColor = System.Drawing.Color.Gray;
            }
            else if (ModeSelectComboBox.Text == "Replace")
            {
                NewLineBox.Enabled = false;
                ReplaceText.Enabled = true;
                ReplaceText.BackColor = System.Drawing.Color.White;
            }
            else if (ModeSelectComboBox.Text == "Delete")
            {
                NewLineBox.Enabled = false;
                ReplaceText.Enabled = false;
                ReplaceText.BackColor = System.Drawing.Color.Gray;
            }
        }

        void LangCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LangCombo.Text)
            {
                case "Latin":
                    RegexText.Text = "[a-zA-Z]+";
                    break;
                case "Cyrillic":
                    RegexText.Text = "[а-яА-Я]+";
                    break;
                default:
                    break;
            }
        }
    }
}
