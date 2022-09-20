using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace WorkTools
{
    public partial class TextReplacer : Form
    {
        static TextReplacer _instance;
        public static TextReplacer Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new TextReplacer();
                }
                return _instance;
            }
        }

        static public string CurrentDirectory;


        public TextReplacer()
        {
            InitializeComponent();
        }

        /// <summary> 「Make txt」button</summary>
        void ReplaceSame_Click(object sender, EventArgs e)
        {
            WarningMessage.Visible = false;

            string templateText = templateTextBox1.Text.Trim();
            if(templateText.Length < 1)
            {
                Warn("Template is missing");
                return;
            }

            List<string> replacedText = replacedTextBox1.Lines.Select(x => x.Trim()).ToList();
            // Omit lines with only whitespaces
            replacedText.RemoveAll(x => x == "");
            // null check
            if (replacedText.Count < 1)
            {
                Warn("Replaced text is missing");
                return;
            }

            List<string> result = new();

            // Tame the replaced text
            // Put a mark to show where to replace in line 1
            List<string> marks = replacedText[0].Split(',').ToList();
            replacedText.RemoveAt(0);  // Remove line 1
            // Get texts from line 2 split by ","
            List<List<string>> someList = replacedText.Select(x => x.Split(',').ToList()).ToList();
            // If there were not enough "," then warn and end
            bool finishFlag = false;
            someList.ForEach(x =>
            {
                if (x.Count < marks.Count)
                {
                    Warn("There are not enough data 「" + string.Join(",", x) + "」");
                    finishFlag = true;
                }
            });
            if (finishFlag) return;

            // Replaced text
            replacedText.ForEach(x =>
            {
                string newText = templateText;
                List<string> replacedWords = x.Split(',').ToList();
                // Replaced text
                for (int i = 0; i < marks.Count; i++)
                {
                    newText = newText.Replace(marks[i], replacedWords[i]);
                }
                result.Add(newText);
            });

            var opendlg = new OpenFileDialog();
            // Save
            SaveFileDialog sfd = new();
            sfd.FileName = opendlg.FileName.Split('.')[0] + ".txt";
            sfd.InitialDirectory = CurrentDirectory;
            sfd.Filter = "txt file(*.txt)|*.txt";
            sfd.Title = "Specify the new file name";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(sfd.FileName);
                result.ForEach(x => sw.WriteLine(x));
            }

            void Warn(string str)
            {
                WarningMessage.Text = str;
                WarningMessage.Visible = true;
            }
        }

        void ReplaceInOrder_Click(object sender, EventArgs e)
        {
            WarningMessage.Visible = false;

            List<string> text = templateTextBox2.Lines.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            if (text.Count < 1)
            {
                Warn("Template is missing");
                return;
            }

            List<string> text2 = replacedTextBox2.Lines.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            // Omit whitespaces
            text2.RemoveAll(x => x == "");
            if (text2.Count < 1)
            {
                Warn("Replaced text is missing");
                return;
            }

            List<string> result = new();

            // Tame the replaced text
            // Put a mark to show where to replace in line 1
            string mark = text2[0];
            text2.RemoveAt(0);

            int index = 0;

            text.ForEach(x =>
            {
                if (text2.Count <= index)
                {
                    result.Add(x);
                }
                else
                {
                    string str = x;
                    x = Utility.ReplaceFirst(x, mark, text2[index]);
                    while (str != x)
                    {
                        index++;
                        if (text2.Count <= index) break;
                        str = x;
                        x = Utility.ReplaceFirst(x, mark, text2[index]);
                    }
                    result.Add(x);
                }
            });

            var opendlg = new OpenFileDialog();
            // Save
            SaveFileDialog sfd = new()
            {
                FileName = opendlg.FileName.Split('.')[0] + ".txt",
                InitialDirectory = CurrentDirectory,
                Filter = "txt file(*.txt)|*.txt",
                Title = "Specify the new file name"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new(sfd.FileName);
                result.ForEach(x => sw.WriteLine(x));
            }

            void Warn(string str)
            {
                WarningMessage.Text = str;
                WarningMessage.Visible = true;
            }
        }
    }
}
