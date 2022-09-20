using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Diagnostics;

namespace WorkTools
{

    public partial class WordFrequencyAnalyzer : Form
    {
        static WordFrequencyAnalyzer _instance;
        public static WordFrequencyAnalyzer Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new WordFrequencyAnalyzer();
                }
                return _instance;
            }
        }
        static public string CurrentDirectory;
        string ResourceFolderPath;

        readonly string LemmaDicName = "Lemma Dictionary.txt";
        readonly string FuncWordDicName = "Functional word dictionary.txt";
        readonly string RegiWordDicName = "Registered word dictionary.txt";
        string ResultFolderPath;
        List<List<string>> LemmaDic = new();  // Lemma List[0]=Stem　[1]～=Conjugation
        List<string> FuncWordDic = new();  // Functional word List[0]=Functiona lword
        List<string> RegiWordDic = new();  // Registered word List[0]=Registered word

        List<string> LemmaFailure = new();
        string FolderPath;

        public WordFrequencyAnalyzer()
        {
            InitializeComponent();
        }

        void EnglishWordFreq_Load(object sender, EventArgs e)
        {
            // Read saved info
            string language = Properties.Settings.Default.SavedLanguage;
            comboBox1.SelectedItem = string.IsNullOrWhiteSpace(language) ? "English" : language;
            checkBox1.Checked = Properties.Settings.Default.Check1;
            checkBox2.Checked = Properties.Settings.Default.Check2;
            checkBox3.Checked = Properties.Settings.Default.Check3;
            analyzeLocalHtml.Checked = Properties.Settings.Default.Check4;
            FolderPath = Utility.AppPath + @"Put files here\WordFrequencyAnalyzer\";

            ResourceFolderPath = Utility.AppPath + @"Resources\\Dictionaries";
        }

        /// <summary> txt analysis button </summary>
        void button1_Click(object sender, EventArgs e)
        {
            string chosenLanguage = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "English";
            PrepareDics(chosenLanguage);

            OpenFileDialog opendlg = new();
            opendlg.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            opendlg.InitialDirectory = CurrentDirectory;
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                // Save the directory
                FileInfo fi = new(opendlg.FileName);
                CurrentDirectory = fi.DirectoryName;

                // Read the file
                SortedDictionary<string, int> LemmaCount = new();
                Stream stm = opendlg.OpenFile();
                if (stm != null)
                {
                    using StreamReader reader = new(stm);
                    string text = reader.ReadToEnd(); // Get whole text
                    text = BuildText(text, chosenLanguage);  // Build text
                    if (checkBox2.Checked) text = OmitFuncWord(text);  // Omit functional words
                    List<string> list = text.Split(' ').ToList<string>();
                    if (checkBox1.Checked) list = LemmaCheck(list);  // Lemmatize
                    if (checkBox3.Checked) list = OmitRegiWord(list);  // Omit registered words
                    list.ForEach(l => { if (LemmaCount.ContainsKey(l)) LemmaCount[l]++; else LemmaCount.Add(l, 1); }); // Count lemmas
                }

                // Write in a file
                SaveFileDialog sfd = new();
                sfd.FileName = Path.GetFileName(opendlg.FileName).Split('.')[0] + "_result.txt";  // File name
                sfd.InitialDirectory = CurrentDirectory;
                sfd.Filter = "Text file(*.txt)|*.txt";
                sfd.Title = "Enter the new file name";

                // Show dialog
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using StreamWriter sw = new(sfd.FileName);
                    foreach (KeyValuePair<string, int> item in LemmaCount) sw.WriteLine(item.Key + "\t=\t" + item.Value);
                }
            }
        }

        /// <summary> html analysis button </summary>
        void button2_Click(object sender, EventArgs e)
        {
            if (!analyzeLocalHtml.Checked && string.IsNullOrWhiteSpace(textBox1.Text))
                return;
            string title = "";  // It becomes the folder name
            string originalText = "";  // Save the extracted text as original text
            string text = "";  // Analised text
            string chosenLanguage = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "English";
            PrepareDics(chosenLanguage);
            // Get text
            if (!analyzeLocalHtml.Checked)
            {
                string url = textBox1.Text;
                using WebClient wc = new();
                using Stream st = wc.OpenRead(url);
                using StreamReader sr = new(st);
                text = sr.ReadToEnd();
            }
            else
            {
                OpenFileDialog opendlg = new();
                opendlg.Filter = "html file (*.html)|*.html|All files (*.*)|*.*";
                opendlg.InitialDirectory = CurrentDirectory;
                if (opendlg.ShowDialog() != DialogResult.OK) return;
                // Save the folder
                FileInfo fi = new(opendlg.FileName);
                CurrentDirectory = fi.DirectoryName;

                // Read the file
                Stream stm = opendlg.OpenFile();
                if (stm != null)
                {
                    using StreamReader reader = new(stm);
                    text = reader.ReadToEnd();
                }
            }
            // Measure the time
            Stopwatch spw = new();
            spw.Start();

            // Analysis
            SortedDictionary<string, int> LemmaCount = new(); // Word - Word count
            title = ExtractTitle(text);
            text = ExtractTextFromHtml(text);
            text = BuildText(text, chosenLanguage);
            originalText = text;
            if (checkBox2.Checked) text = OmitFuncWord(text);
            List<string> list = text.Split(' ').ToList();
            if (checkBox1.Checked) list = LemmaCheck(list);
            if (checkBox3.Checked) list = OmitRegiWord(list);
            list.ForEach(l => { if (LemmaCount.ContainsKey(l)) LemmaCount[l]++; else { LemmaCount.Add(l, 1); } });

            // Make folder
            string path = FolderPath + "\\" + "result_" + title;
            int i = 0;
            if (Directory.Exists(path)) path += ++i;
            while (Directory.Exists(path)) path = path.Substring(0, path.Length - (i / 10 + 1)) + ++i;
            Directory.CreateDirectory(path);
            // Make file
            using (StreamWriter sw = new(path + "\\" + "Main Body.txt"))
            {
                sw.Write(originalText);
            }
            using (StreamWriter sw = new(path + "\\" + "Result.txt"))
            {
                foreach (KeyValuePair<string, int> item in LemmaCount) sw.WriteLine(item.Key + "\t=\t" + item.Value);
            }
            using (StreamWriter sw = new(path + "\\" + "Nonlemmatized.txt"))
            {
                LemmaFailure.ForEach(x => sw.WriteLine(x));
            }

            Console.WriteLine("Elapsed time:" + spw.ElapsedMilliseconds);

        }

        /// <summary> Get text from url </summary>
        public string UrlText(string url)
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
                Console.WriteLine(url + "　was not found");
                return "";
            }
        }

        /// <summary> Prepare dictionaries like lemma dictionary </summary>
        void PrepareDics(string language)
        {
            string di = Directory.GetCurrentDirectory();  // Get the path of .exe file of this project
            ResultFolderPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(di).FullName).FullName).FullName + "\\" + "result";
            
            // Prepare lemma dictionary
            LemmaDic = LoadLemmaList(language);
            List<List<string>> LoadLemmaList(string folder)
            {
                List<List<string>> result = new();
                string path = ResourceFolderPath + "\\" + folder + "\\" + LemmaDicName;
                if (!File.Exists(path)) { MessageBox.Show(path + " doesn't exist"); return null; }
                using (StreamReader stm = new(path))
                {
                    while (stm.Peek() != -1)
                    {
                        string str = stm.ReadLine();
                        List<string> list = str.Split('\t').ToList<string>();  // Split by \t
                        list = list.Where(s => s != "->").ToList();  // Remove "->"
                        result.Add(list);
                    }
                }
                return result;
            }
            // Prepare functional word dictionary
            FuncWordDic = LoadFuncWordList(language);
            List<string> LoadFuncWordList(string folder)
            {
                List<string> result = new();
                string path = ResourceFolderPath + "\\" + folder + "\\" + FuncWordDicName;
                if (!File.Exists(path)) { MessageBox.Show(folder + " folder doesn't have " + FuncWordDicName); return null; }
                using (StreamReader stm = new(path))
                {
                    while (stm.Peek() != -1)
                    {
                        string str = stm.ReadLine();
                        result.Add(str);
                    }
                }
                return result;
            }
            // Prepare registered word dictionary
            RegiWordDic = LoadRegiWordList(language);
            List<string> LoadRegiWordList(string folder)
            {
                List<string> result = new();
                string path = ResourceFolderPath + "\\" + folder + "\\" + RegiWordDicName;
                if (!File.Exists(path)) { MessageBox.Show(folder + " folder doesn't have " + RegiWordDicName); return null; }
                using (StreamReader stm = new(path))
                {
                    while (stm.Peek() != -1)
                    {
                        string str = stm.ReadLine();
                        result.Add(str);
                    }
                }
                return result;
            }

        }


        /// <summary> Build the text for analysis </summary>
        string BuildText(string text, string language)
        {
            text = text.ToLower();  // Make capitals to lowercase
            if(language == "English")
            { 
                text = text.RegexReplace("[^a-z]", " ");  // Make non-alphabet to " " (Doesn't delete for hyphens and parentheses)
            }
            if (language == "Russian")
            {
                text = text.RegexReplace("\u0301", "");  // Delete stress
                text = text.RegexReplace("[^а-я]", " ");  // Make non-alphabet to " " (Doesn't delete for hyphens and parentheses)
            }
            text = text.RegexReplace(" {2,}", " ");
            text = text.Trim();
            return text;
        }

        /// <summary> <para>Extract title from html</para> <para>If nothing found, then "No Title"</para> </summary>
        string ExtractTitle(string text)
        {
            string pattern = "<title>.*?</title>";
            Match match = Regex.Match(text, pattern);
            if (!match.Success) return "No Title";
            string title = match.Value;
            title = title.Replace("<title>", "").Replace("</title>", "");
            return title;
        }
        /// <summary> Build text from html </summary>
        string ExtractTextFromHtml(string text)
        {
            // Extract <p>～</p>
            text = text.RegexExtract("<p(>| .*?>).*?</p>");

            // Extract XXX from <a ～ >XXX</a>
            string[] tags = new string[]
            { 
                "a", "abbr", "acronym", "address", "applet",
                "area", "b", "base", "basefont", "bdo", "bgsound", "big", "blink", "blockquote", 
                "body", "br", "button", "caption", "center", "cite", "code", "col", "colgroup",
                "comment", "dd", "del", "dfn", "dir", "div", "dl", "dt", "em", "embed", "fieldset",
                "font", "form", "frame", "frameset", "h[1-6]", "head", "hr", "html", "i", "iframe", "iframeset",
                "img", "input", "ins", "isindex", "kbd", "label", "legend", "li", "link", "listing",
                "map", "marquee", "menu", "meta", "nobr", "noembed", "noframes", "noscript", "object",
                "ol", "optgroup", "option", "p", "param", "plaintext", "pre", "q", "rb", "rp", "rt",
                "ruby", "s", "samp", "select", "small", "span", "strike", "strong",
                "sub", "sup", "table", "tbody", "td", "textarea", "tfoot", "th", "thead", "title",
                "tr", "tt", "u", "ul", "var", "wbr", "xmp" 
            };

            text = text.RegexReplace("<!DOCTYPE.*?>", "")  // Delete DOCTYPE
                .RegexReplace("<!--.*?-->", "");  // Delete comments
            // Delete each tag
            Array.ForEach(tags, x => 
            {
                text = text.RegexReplace("<" + x + "(>| .*?>)", "");
                text = text.RegexReplace("</" + x + ">", "");
            });

            // Delete html words in the main body
            string[] discardWords =
            {
                "&nbsp;",
                "[edit]",
                "WikiMiniAtlas"
            };
            Array.ForEach(discardWords, x =>
            {
                text = text.Replace(x, "");
            });

            return text;
        }


        /// <summary> Omit functional words </summary>
        string OmitFuncWord(string text)
        {
            FuncWordDic.ForEach(x => { while (text.Contains(" " + x + " ")) text = text.Replace(" " + x + " ", " "); });
            return text;
        }


        /// <summary> Lemmatize </summary>
        List<string> LemmaCheck(List<string> list)
        {
            List<string> result = new();
            List<List<string>> memoList = new();
            foreach(string word in list)
            {
                if (LemmaFailure.Contains(word)) { result.Add(word); continue; }
                List<string> strList = memoList.Find(lemma => lemma.Contains(word));
                if (strList != null) { result.Add(strList[0]); continue; }
                strList = LemmaDic.Find(lemma => lemma.Contains(word));
                if (strList != null) { memoList.Add(strList); result.Add(strList[0]); continue; }
                LemmaFailure.Add(word);
                result.Add(word);
            }
            LemmaFailure.Sort();
            return result;
        }

        /// <summary> Omit registered words </summary>
        List<string> OmitRegiWord(List<string> text)
        {
            RegiWordDic.ForEach(x => { while (text.Contains(x)) { text.Remove(x); if(LemmaFailure.Contains(x)) LemmaFailure.Remove(x); } });
            return text;
        }

        void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = analyzeLocalHtml.Checked;
        }

        void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save values for next use
            Properties.Settings.Default.SavedLanguage = (string) comboBox1.SelectedItem;
            Properties.Settings.Default.Check1 = checkBox1.Checked;
            Properties.Settings.Default.Check2 = checkBox2.Checked;
            Properties.Settings.Default.Check3 = checkBox3.Checked;
            Properties.Settings.Default.Check4 = analyzeLocalHtml.Checked;
            Properties.Settings.Default.Save();
        }

    }

    /// <summary>  </summary>
    public static class RegexExtension
    {
        public static string RegexReplace(this string input, string pattern, string replacement, bool singleLineFlag = true)
        {
            replacement = Regex.Unescape(replacement);
            if (singleLineFlag)
                return Regex.Replace(input, pattern, replacement, RegexOptions.Singleline);
            else
                return Regex.Replace(input, pattern, replacement, RegexOptions.Multiline);
        }

        /// <param name="singleLineFlag">Flag to utilize regex expression across lines</param>
        public static string RegexExtract(this string input, string pattern, bool newLineFlag = false, bool singleLineFlag = true)
        {
            MatchCollection mc;
            if (singleLineFlag)
                mc = Regex.Matches(input, @pattern, RegexOptions.Singleline);
            else
                mc = Regex.Matches(input, @pattern, RegexOptions.Multiline);
            StringBuilder sb = new();
            foreach(Match m in mc)
            {
                sb.Append(m.Value);
                if (newLineFlag) sb.Append("\r\n");
            }
            return sb.ToString();
        }
        public static List<string> RegexExtractExclude1(this string input, string pattern1, string pattern2)
        {

            input = input.RegexExtract(pattern1 + ".*?" + pattern2)
                .RegexReplace(pattern1, ",")
                .RegexReplace(pattern2, "");
            if (input.Length < 1) return new List<string> { "" };
            input = input.Substring(1, input.Length - 1);
            return input.Split(',').ToList();
        }
        public static string RegexExtractExclude2(this string input, string pattern1, string pattern2)
        {
            input = input.RegexExtract(pattern1 + ".*?" + pattern2);
            if (input.Length < 1) return "";
            input = input.Remove(0, pattern1.Length)
                .RegexReplace(pattern2, "");
            return input;

        }
    }




}
