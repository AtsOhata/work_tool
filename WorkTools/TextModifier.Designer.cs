
namespace WorkTools
{
    partial class TextModifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextModifier));
            this.Execute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegexText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModeSelectComboBox = new System.Windows.Forms.ComboBox();
            this.RegexPattern1 = new System.Windows.Forms.Label();
            this.RegexPattern2 = new System.Windows.Forms.Label();
            this.RegexPattern2_StartPattern = new System.Windows.Forms.TextBox();
            this.RegexPattern2_EndPattern = new System.Windows.Forms.TextBox();
            this.NewLineBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LangCombo = new System.Windows.Forms.ComboBox();
            this.InPathText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutPathText = new System.Windows.Forms.TextBox();
            this.MultilineFlagBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Execute.Location = new System.Drawing.Point(561, 27);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(159, 45);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "Process";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 105);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // RegexText
            // 
            this.RegexText.Location = new System.Drawing.Point(21, 242);
            this.RegexText.Multiline = true;
            this.RegexText.Name = "RegexText";
            this.RegexText.Size = new System.Drawing.Size(624, 21);
            this.RegexText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Regex Expression";
            // 
            // ReplaceText
            // 
            this.ReplaceText.BackColor = System.Drawing.Color.DarkGray;
            this.ReplaceText.Location = new System.Drawing.Point(21, 296);
            this.ReplaceText.Multiline = true;
            this.ReplaceText.Name = "ReplaceText";
            this.ReplaceText.Size = new System.Drawing.Size(624, 21);
            this.ReplaceText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Replace Expression";
            // 
            // ModeSelectComboBox
            // 
            this.ModeSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelectComboBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModeSelectComboBox.FormattingEnabled = true;
            this.ModeSelectComboBox.Items.AddRange(new object[] {
            "Extract",
            "Replace",
            "Delete"});
            this.ModeSelectComboBox.Location = new System.Drawing.Point(561, 105);
            this.ModeSelectComboBox.Name = "ModeSelectComboBox";
            this.ModeSelectComboBox.Size = new System.Drawing.Size(121, 22);
            this.ModeSelectComboBox.TabIndex = 10;
            this.ModeSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeSelectComboBox_SelectedIndexChanged);
            // 
            // RegexPattern1
            // 
            this.RegexPattern1.AutoSize = true;
            this.RegexPattern1.Location = new System.Drawing.Point(21, 332);
            this.RegexPattern1.Name = "RegexPattern1";
            this.RegexPattern1.Size = new System.Drawing.Size(136, 15);
            this.RegexPattern1.TabIndex = 12;
            this.RegexPattern1.Text = "Leftmost-shortest match";
            this.RegexPattern1.Click += new System.EventHandler(this.RegexPattern1_Click);
            // 
            // RegexPattern2
            // 
            this.RegexPattern2.AutoSize = true;
            this.RegexPattern2.Location = new System.Drawing.Point(173, 332);
            this.RegexPattern2.Name = "RegexPattern2";
            this.RegexPattern2.Size = new System.Drawing.Size(144, 15);
            this.RegexPattern2.TabIndex = 13;
            this.RegexPattern2.Text = "Rightmost-shortest match";
            this.RegexPattern2.Click += new System.EventHandler(this.RegexPattern2_Click);
            // 
            // RegexPattern2_StartPattern
            // 
            this.RegexPattern2_StartPattern.Location = new System.Drawing.Point(21, 379);
            this.RegexPattern2_StartPattern.Name = "RegexPattern2_StartPattern";
            this.RegexPattern2_StartPattern.Size = new System.Drawing.Size(119, 23);
            this.RegexPattern2_StartPattern.TabIndex = 14;
            // 
            // RegexPattern2_EndPattern
            // 
            this.RegexPattern2_EndPattern.Location = new System.Drawing.Point(173, 379);
            this.RegexPattern2_EndPattern.Name = "RegexPattern2_EndPattern";
            this.RegexPattern2_EndPattern.Size = new System.Drawing.Size(120, 23);
            this.RegexPattern2_EndPattern.TabIndex = 15;
            // 
            // NewLineBox
            // 
            this.NewLineBox.AutoSize = true;
            this.NewLineBox.Location = new System.Drawing.Point(379, 201);
            this.NewLineBox.Name = "NewLineBox";
            this.NewLineBox.Size = new System.Drawing.Size(158, 19);
            this.NewLineBox.TabIndex = 17;
            this.NewLineBox.Text = "Start a new line per result";
            this.NewLineBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Easy Setting";
            // 
            // LangCombo
            // 
            this.LangCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangCombo.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LangCombo.FormattingEnabled = true;
            this.LangCombo.Items.AddRange(new object[] {
            "",
            "Latin",
            "Cyrillic"});
            this.LangCombo.Location = new System.Drawing.Point(21, 172);
            this.LangCombo.Name = "LangCombo";
            this.LangCombo.Size = new System.Drawing.Size(135, 22);
            this.LangCombo.TabIndex = 20;
            this.LangCombo.SelectedIndexChanged += new System.EventHandler(this.LangCombo_SelectedIndexChanged);
            // 
            // InPathText
            // 
            this.InPathText.Location = new System.Drawing.Point(307, 39);
            this.InPathText.Multiline = true;
            this.InPathText.Name = "InPathText";
            this.InPathText.PlaceholderText = "Resource";
            this.InPathText.Size = new System.Drawing.Size(194, 21);
            this.InPathText.TabIndex = 21;
            this.InPathText.Text = "Resource";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "OUT";
            // 
            // OutPathText
            // 
            this.OutPathText.Location = new System.Drawing.Point(307, 92);
            this.OutPathText.Multiline = true;
            this.OutPathText.Name = "OutPathText";
            this.OutPathText.PlaceholderText = "Result";
            this.OutPathText.Size = new System.Drawing.Size(194, 21);
            this.OutPathText.TabIndex = 24;
            this.OutPathText.Text = "Result";
            // 
            // MultilineFlagBox
            // 
            this.MultilineFlagBox.AutoSize = true;
            this.MultilineFlagBox.Location = new System.Drawing.Point(379, 176);
            this.MultilineFlagBox.Name = "MultilineFlagBox";
            this.MultilineFlagBox.Size = new System.Drawing.Size(235, 19);
            this.MultilineFlagBox.TabIndex = 25;
            this.MultilineFlagBox.Text = "Regex Expression doesn\'t straddle a line";
            this.MultilineFlagBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(21, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Start pattern";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(173, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "End pattern";
            // 
            // TextModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MultilineFlagBox);
            this.Controls.Add(this.OutPathText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InPathText);
            this.Controls.Add(this.LangCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewLineBox);
            this.Controls.Add(this.RegexPattern2_EndPattern);
            this.Controls.Add(this.RegexPattern2_StartPattern);
            this.Controls.Add(this.RegexPattern2);
            this.Controls.Add(this.RegexPattern1);
            this.Controls.Add(this.ModeSelectComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReplaceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegexText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Execute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextModifier";
            this.Text = "Extractor";
            this.Load += new System.EventHandler(this.Extractor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegexText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReplaceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ModeSelectComboBox;
        private System.Windows.Forms.Label RegexPattern1;
        private System.Windows.Forms.Label RegexPattern2;
        private System.Windows.Forms.TextBox RegexPattern2_StartPattern;
        private System.Windows.Forms.TextBox RegexPattern2_EndPattern;
        private System.Windows.Forms.CheckBox NewLineBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LangCombo;
        private System.Windows.Forms.TextBox InPathText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OutPathText;
        private System.Windows.Forms.CheckBox MultilineFlagBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}