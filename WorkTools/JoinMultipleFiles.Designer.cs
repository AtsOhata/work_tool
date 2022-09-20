
namespace WorkTools
{
    partial class JoinMultipleFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinMultipleFiles));
            this.Execute = new System.Windows.Forms.Button();
            this.OutPathText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InPathText = new System.Windows.Forms.TextBox();
            this.IncludeFileNameFlag = new System.Windows.Forms.CheckBox();
            this.TextBetweenFiles = new System.Windows.Forms.TextBox();
            this.FileExtensions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultFileNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Execute.Location = new System.Drawing.Point(411, 56);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(137, 45);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Process";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // OutPathText
            // 
            this.OutPathText.Location = new System.Drawing.Point(16, 80);
            this.OutPathText.Multiline = true;
            this.OutPathText.Name = "OutPathText";
            this.OutPathText.PlaceholderText = "結果";
            this.OutPathText.Size = new System.Drawing.Size(148, 21);
            this.OutPathText.TabIndex = 28;
            this.OutPathText.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "OUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "IN";
            // 
            // InPathText
            // 
            this.InPathText.Location = new System.Drawing.Point(16, 29);
            this.InPathText.Multiline = true;
            this.InPathText.Name = "InPathText";
            this.InPathText.PlaceholderText = "材料";
            this.InPathText.Size = new System.Drawing.Size(148, 21);
            this.InPathText.TabIndex = 25;
            this.InPathText.Text = "Resource";
            // 
            // IncludeFileNameFlag
            // 
            this.IncludeFileNameFlag.AutoSize = true;
            this.IncludeFileNameFlag.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncludeFileNameFlag.Location = new System.Drawing.Point(218, 29);
            this.IncludeFileNameFlag.Name = "IncludeFileNameFlag";
            this.IncludeFileNameFlag.Size = new System.Drawing.Size(152, 18);
            this.IncludeFileNameFlag.TabIndex = 29;
            this.IncludeFileNameFlag.Text = "Put file name in text";
            this.IncludeFileNameFlag.UseVisualStyleBackColor = true;
            // 
            // TextBetweenFiles
            // 
            this.TextBetweenFiles.Location = new System.Drawing.Point(16, 182);
            this.TextBetweenFiles.Multiline = true;
            this.TextBetweenFiles.Name = "TextBetweenFiles";
            this.TextBetweenFiles.Size = new System.Drawing.Size(445, 116);
            this.TextBetweenFiles.TabIndex = 30;
            // 
            // FileExtensions
            // 
            this.FileExtensions.Location = new System.Drawing.Point(16, 129);
            this.FileExtensions.Multiline = true;
            this.FileExtensions.Name = "FileExtensions";
            this.FileExtensions.Size = new System.Drawing.Size(445, 21);
            this.FileExtensions.TabIndex = 31;
            this.FileExtensions.Text = "txt|csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Between-file text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "Target extensions";
            // 
            // ResultFileNameBox
            // 
            this.ResultFileNameBox.Location = new System.Drawing.Point(218, 80);
            this.ResultFileNameBox.Multiline = true;
            this.ResultFileNameBox.Name = "ResultFileNameBox";
            this.ResultFileNameBox.PlaceholderText = "結果";
            this.ResultFileNameBox.Size = new System.Drawing.Size(148, 21);
            this.ResultFileNameBox.TabIndex = 35;
            this.ResultFileNameBox.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(218, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "Result File Name";
            // 
            // JoinMultipleFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 310);
            this.Controls.Add(this.ResultFileNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileExtensions);
            this.Controls.Add(this.TextBetweenFiles);
            this.Controls.Add(this.IncludeFileNameFlag);
            this.Controls.Add(this.OutPathText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InPathText);
            this.Controls.Add(this.Execute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JoinMultipleFiles";
            this.Text = "JoinMultipleFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.TextBox OutPathText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InPathText;
        private System.Windows.Forms.CheckBox IncludeFileNameFlag;
        private System.Windows.Forms.TextBox TextBetweenFiles;
        private System.Windows.Forms.TextBox FileExtensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultFileNameBox;
        private System.Windows.Forms.Label label3;
    }
}