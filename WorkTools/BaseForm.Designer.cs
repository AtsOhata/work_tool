
namespace WorkTools
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.OpenTextReplacer = new System.Windows.Forms.Button();
            this.OpenWordFrequencyAnalyzer = new System.Windows.Forms.Button();
            this.OpenCrowler = new System.Windows.Forms.Button();
            this.OpenTextModifier = new System.Windows.Forms.Button();
            this.OpenMultipleChoiceMaker = new System.Windows.Forms.Button();
            this.OpenJoinMultipleFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenTextReplacer
            // 
            this.OpenTextReplacer.Location = new System.Drawing.Point(39, 58);
            this.OpenTextReplacer.Name = "OpenTextReplacer";
            this.OpenTextReplacer.Size = new System.Drawing.Size(191, 40);
            this.OpenTextReplacer.TabIndex = 0;
            this.OpenTextReplacer.Text = "Text Replacer";
            this.OpenTextReplacer.UseVisualStyleBackColor = true;
            this.OpenTextReplacer.Click += new System.EventHandler(this.TextReplacer_Click);
            // 
            // OpenWordFrequencyAnalyzer
            // 
            this.OpenWordFrequencyAnalyzer.Location = new System.Drawing.Point(39, 119);
            this.OpenWordFrequencyAnalyzer.Name = "OpenWordFrequencyAnalyzer";
            this.OpenWordFrequencyAnalyzer.Size = new System.Drawing.Size(191, 40);
            this.OpenWordFrequencyAnalyzer.TabIndex = 2;
            this.OpenWordFrequencyAnalyzer.Text = "Word Frequency Analyzer";
            this.OpenWordFrequencyAnalyzer.UseVisualStyleBackColor = true;
            this.OpenWordFrequencyAnalyzer.Click += new System.EventHandler(this.EnglishWordFreq_Click);
            // 
            // OpenCrowler
            // 
            this.OpenCrowler.Location = new System.Drawing.Point(39, 181);
            this.OpenCrowler.Name = "OpenCrowler";
            this.OpenCrowler.Size = new System.Drawing.Size(191, 40);
            this.OpenCrowler.TabIndex = 3;
            this.OpenCrowler.Text = "Crowler";
            this.OpenCrowler.UseVisualStyleBackColor = true;
            this.OpenCrowler.Click += new System.EventHandler(this.OpenCrowler_Click);
            // 
            // OpenTextModifier
            // 
            this.OpenTextModifier.Location = new System.Drawing.Point(284, 119);
            this.OpenTextModifier.Name = "OpenTextModifier";
            this.OpenTextModifier.Size = new System.Drawing.Size(191, 40);
            this.OpenTextModifier.TabIndex = 4;
            this.OpenTextModifier.Text = "Text Modifier";
            this.OpenTextModifier.UseVisualStyleBackColor = true;
            this.OpenTextModifier.Click += new System.EventHandler(this.Extractor_Click);
            // 
            // OpenMultipleChoiceMaker
            // 
            this.OpenMultipleChoiceMaker.Location = new System.Drawing.Point(284, 58);
            this.OpenMultipleChoiceMaker.Name = "OpenMultipleChoiceMaker";
            this.OpenMultipleChoiceMaker.Size = new System.Drawing.Size(191, 40);
            this.OpenMultipleChoiceMaker.TabIndex = 5;
            this.OpenMultipleChoiceMaker.Text = "Multiple Choice Maker";
            this.OpenMultipleChoiceMaker.UseVisualStyleBackColor = true;
            this.OpenMultipleChoiceMaker.Click += new System.EventHandler(this.WrongChoiceMaker_Click);
            // 
            // OpenJoinMultipleFiles
            // 
            this.OpenJoinMultipleFiles.Location = new System.Drawing.Point(284, 181);
            this.OpenJoinMultipleFiles.Name = "OpenJoinMultipleFiles";
            this.OpenJoinMultipleFiles.Size = new System.Drawing.Size(191, 40);
            this.OpenJoinMultipleFiles.TabIndex = 6;
            this.OpenJoinMultipleFiles.Text = "Join Multiple Files";
            this.OpenJoinMultipleFiles.UseVisualStyleBackColor = true;
            this.OpenJoinMultipleFiles.Click += new System.EventHandler(this.JoinMultipleFiles_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 286);
            this.Controls.Add(this.OpenJoinMultipleFiles);
            this.Controls.Add(this.OpenMultipleChoiceMaker);
            this.Controls.Add(this.OpenTextModifier);
            this.Controls.Add(this.OpenCrowler);
            this.Controls.Add(this.OpenWordFrequencyAnalyzer);
            this.Controls.Add(this.OpenTextReplacer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "Base";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenTextReplacer;
        private System.Windows.Forms.Button OpenWordFrequencyAnalyzer;
        private System.Windows.Forms.Button OpenCrowler;
        private System.Windows.Forms.Button OpenTextModifier;
        private System.Windows.Forms.Button OpenMultipleChoiceMaker;
        private System.Windows.Forms.Button OpenJoinMultipleFiles;
    }
}

