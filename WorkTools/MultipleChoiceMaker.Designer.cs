
namespace WorkTools
{
    partial class MultipleChoiceMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WrongChoiceVocabulary = new System.Windows.Forms.TextBox();
            this.CorrectChoices = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Make = new System.Windows.Forms.Button();
            this.AmountOfChoices = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WarningMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WrongChoiceVocabulary
            // 
            this.WrongChoiceVocabulary.Location = new System.Drawing.Point(27, 43);
            this.WrongChoiceVocabulary.Multiline = true;
            this.WrongChoiceVocabulary.Name = "WrongChoiceVocabulary";
            this.WrongChoiceVocabulary.Size = new System.Drawing.Size(250, 346);
            this.WrongChoiceVocabulary.TabIndex = 0;
            this.WrongChoiceVocabulary.Text = "Helbst\r\nWort\r\nVater\r\nZahl\r\nZeit\r\nStadt\r\nNacht\r\nRegen\r\nSchnee";
            // 
            // CorrectChoices
            // 
            this.CorrectChoices.Location = new System.Drawing.Point(316, 43);
            this.CorrectChoices.Multiline = true;
            this.CorrectChoices.Name = "CorrectChoices";
            this.CorrectChoices.Size = new System.Drawing.Size(150, 346);
            this.CorrectChoices.TabIndex = 1;
            this.CorrectChoices.Text = "Frühling\r\nWoche";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(516, 43);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(250, 346);
            this.ResultBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wrong choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correct choice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // Make
            // 
            this.Make.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Make.Location = new System.Drawing.Point(583, 426);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(109, 43);
            this.Make.TabIndex = 6;
            this.Make.Text = "Make";
            this.Make.UseVisualStyleBackColor = true;
            this.Make.Click += new System.EventHandler(this.Make_Click);
            // 
            // AmountOfChoices
            // 
            this.AmountOfChoices.Location = new System.Drawing.Point(316, 446);
            this.AmountOfChoices.Name = "AmountOfChoices";
            this.AmountOfChoices.Size = new System.Drawing.Size(142, 23);
            this.AmountOfChoices.TabIndex = 7;
            this.AmountOfChoices.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount of choices";
            // 
            // WarningMessage
            // 
            this.WarningMessage.AutoSize = true;
            this.WarningMessage.ForeColor = System.Drawing.Color.Red;
            this.WarningMessage.Location = new System.Drawing.Point(463, 402);
            this.WarningMessage.Name = "WarningMessage";
            this.WarningMessage.Size = new System.Drawing.Size(108, 15);
            this.WarningMessage.TabIndex = 9;
            this.WarningMessage.Text = "Show warning here";
            this.WarningMessage.Visible = false;
            // 
            // MultipleChoiceMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.WarningMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountOfChoices);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.CorrectChoices);
            this.Controls.Add(this.WrongChoiceVocabulary);
            this.Name = "MultipleChoiceMaker";
            this.Text = "WrongChoiceMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WrongChoiceVocabulary;
        private System.Windows.Forms.TextBox CorrectChoices;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Make;
        private System.Windows.Forms.TextBox AmountOfChoices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WarningMessage;
    }
}