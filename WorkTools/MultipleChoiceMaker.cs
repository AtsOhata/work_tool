using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkTools
{
    public partial class MultipleChoiceMaker : Form
    {
        static MultipleChoiceMaker _instance;
        public static MultipleChoiceMaker Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new MultipleChoiceMaker();
                }
                return _instance;
            }
        }
        public MultipleChoiceMaker()
        {
            InitializeComponent();
        }

        void Make_Click(object sender, EventArgs e)
        {
            WarningMessage.Visible = false;

            // Get amount of choices
            if (!int.TryParse(AmountOfChoices.Text, out int ChoiceAmount))
            {
                Warn("Amount of choices is not an integer");
                return;
            }

            if (ChoiceAmount < 2)
            {
                Warn("Amount of choices is too small");
                return;
            }

            // Get wrong choices
            List<string> wrongChoiceWords = WrongChoiceVocabulary.Lines.Select(x => x.Trim()).ToList();
            // Omit whitespace lines
            wrongChoiceWords.RemoveAll(x => x == "");
            if (wrongChoiceWords.Count < 1)
            {
                Warn("Wrong choices are missing");
                return;
            }
            // Return if there are not enough wrong choices
            if (wrongChoiceWords.Count < ChoiceAmount - 1)
            {
                Warn("Wrong choices should be more than amount of choices");
                return;
            }

            // Get correct choice
            List<string> correctChoices = CorrectChoices.Lines.Select(x => x.Trim()).ToList();
            // Omit whitespace lines
            correctChoices.RemoveAll(x => x == "");
            if (correctChoices.Count < 1)
            {
                Warn("Correct choice is missing");
                return;
            }

            Random r = new();

            List<string> results = new();

            // Join random wrong choices to each correct choice
            correctChoices.ForEach(x =>
            {
                StringBuilder builder = new(x);
                for (int i = 0; i < ChoiceAmount - 1; i++)
                {
                    // Avoid overlap of correct choice and wrong choices
                    string str;
                    int count = 0;
                    do
                    {
                        str = wrongChoiceWords[r.Next(0, wrongChoiceWords.Count)];
                        count++;
                        // Return if there are too many repetition
                        if (count > 100)
                        {
                            Warn("Correct choice and wrong choices are overlapping");
                            return;
                        }
                    } while (builder.ToString().Split(',').Contains(str));
                    builder.Append("," + str);
                }
                results.Add(builder.ToString());
            });

            ResultBox.Text = string.Join(Environment.NewLine, results);

            
            void Warn(string str)
            {
                WarningMessage.Text = str;
                WarningMessage.Visible = true;
            }
        }
    }
}
