
namespace WorkTools
{
    partial class TextReplacer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextReplacer));
            this.ReplaceSame = new System.Windows.Forms.Button();
            this.templateTextBox1 = new System.Windows.Forms.TextBox();
            this.replacedTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WarningMessage = new System.Windows.Forms.Label();
            this.ReplaceInOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.replacedTextBox2 = new System.Windows.Forms.TextBox();
            this.templateTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReplaceSame
            // 
            this.ReplaceSame.Location = new System.Drawing.Point(42, 40);
            this.ReplaceSame.Name = "ReplaceSame";
            this.ReplaceSame.Size = new System.Drawing.Size(190, 23);
            this.ReplaceSame.TabIndex = 0;
            this.ReplaceSame.Text = "Make txt";
            this.ReplaceSame.UseVisualStyleBackColor = true;
            this.ReplaceSame.Click += new System.EventHandler(this.ReplaceSame_Click);
            // 
            // templateTextBox1
            // 
            this.templateTextBox1.Location = new System.Drawing.Point(42, 84);
            this.templateTextBox1.MaxLength = 0;
            this.templateTextBox1.Multiline = true;
            this.templateTextBox1.Name = "templateTextBox1";
            this.templateTextBox1.Size = new System.Drawing.Size(255, 99);
            this.templateTextBox1.TabIndex = 1;
            this.templateTextBox1.Text = "Today\'s menu is ☆\r\nTomorrow\'s menu is ★";
            // 
            // replacedTextBox1
            // 
            this.replacedTextBox1.Location = new System.Drawing.Point(331, 84);
            this.replacedTextBox1.MaxLength = 0;
            this.replacedTextBox1.Multiline = true;
            this.replacedTextBox1.Name = "replacedTextBox1";
            this.replacedTextBox1.Size = new System.Drawing.Size(260, 99);
            this.replacedTextBox1.TabIndex = 2;
            this.replacedTextBox1.Text = "☆, ★\r\nfish, meat\r\nchicken, egg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Replaced text";
            // 
            // WarningMessage
            // 
            this.WarningMessage.AutoSize = true;
            this.WarningMessage.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WarningMessage.ForeColor = System.Drawing.Color.Red;
            this.WarningMessage.Location = new System.Drawing.Point(331, 45);
            this.WarningMessage.Name = "WarningMessage";
            this.WarningMessage.Size = new System.Drawing.Size(120, 14);
            this.WarningMessage.TabIndex = 5;
            this.WarningMessage.Text = "Seems didn\'t work";
            this.WarningMessage.Visible = false;
            // 
            // ReplaceInOrder
            // 
            this.ReplaceInOrder.Location = new System.Drawing.Point(42, 217);
            this.ReplaceInOrder.Name = "ReplaceInOrder";
            this.ReplaceInOrder.Size = new System.Drawing.Size(190, 23);
            this.ReplaceInOrder.TabIndex = 8;
            this.ReplaceInOrder.Text = "Make replaced txt";
            this.ReplaceInOrder.UseVisualStyleBackColor = true;
            this.ReplaceInOrder.Click += new System.EventHandler(this.ReplaceInOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Replaced text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Template";
            // 
            // replacedTextBox2
            // 
            this.replacedTextBox2.Location = new System.Drawing.Point(331, 261);
            this.replacedTextBox2.MaxLength = 0;
            this.replacedTextBox2.Multiline = true;
            this.replacedTextBox2.Name = "replacedTextBox2";
            this.replacedTextBox2.Size = new System.Drawing.Size(260, 99);
            this.replacedTextBox2.TabIndex = 10;
            this.replacedTextBox2.Text = "☆\r\nbeans\r\ncheese";
            // 
            // templateTextBox2
            // 
            this.templateTextBox2.Location = new System.Drawing.Point(42, 261);
            this.templateTextBox2.MaxLength = 0;
            this.templateTextBox2.Multiline = true;
            this.templateTextBox2.Name = "templateTextBox2";
            this.templateTextBox2.Size = new System.Drawing.Size(255, 99);
            this.templateTextBox2.TabIndex = 9;
            this.templateTextBox2.Text = "Today\'s menu is ☆\r\nTomorrow\'s menu is ☆";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Specify where to replace at line 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Specify where to replace at line 1";
            // 
            // TextReplacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 402);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.replacedTextBox2);
            this.Controls.Add(this.templateTextBox2);
            this.Controls.Add(this.ReplaceInOrder);
            this.Controls.Add(this.WarningMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replacedTextBox1);
            this.Controls.Add(this.templateTextBox1);
            this.Controls.Add(this.ReplaceSame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextReplacer";
            this.Text = "TextReplacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReplaceSame;
        private System.Windows.Forms.TextBox templateTextBox1;
        private System.Windows.Forms.TextBox replacedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WarningMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTextBox1;
        private System.Windows.Forms.Button ReplaceInOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox replacedTextBox2;
        private System.Windows.Forms.TextBox templateTextBox2;
        private System.Windows.Forms.Label label6;
    }
}