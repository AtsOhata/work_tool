using System;
using System.Windows.Forms;


namespace WorkTools
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            Utility.Initialize();
        }

        /// <summary>Open TextReplacer window </summary>
        void TextReplacer_Click(object sender, EventArgs e)
        {
            TextReplacer.Instance.Show();
        }

        /// <summary>Open EnglishWordFreq window</summary>
        void EnglishWordFreq_Click(object sender, EventArgs e)
        {
            WordFrequencyAnalyzer.Instance.Show();
        }

        /// <summary>Open Crowler window</summary>
        void OpenCrowler_Click(object sender, EventArgs e)
        {
            Crowler.Instance.Show();
        }

        /// <summary>Open TextModifier window</summary>
        void Extractor_Click(object sender, EventArgs e)
        {
            TextModifier.Instance.Show();
        }

        /// <summary>Open WrongChoiceMaker window</summary>
        void WrongChoiceMaker_Click(object sender, EventArgs e)
        {
            MultipleChoiceMaker.Instance.Show();
        }

        /// <summary>Open JoinMultipleFiles window</summary>
        void JoinMultipleFiles_Click(object sender, EventArgs e)
        {
            JoinMultipleFiles.Instance.Show();
        }
    }
}
