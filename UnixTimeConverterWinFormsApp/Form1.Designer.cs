
namespace UnixTimeConverterWinFormsApp
{
    partial class Form1
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
            System.Windows.Forms.Label label2;
            this.clipboardTimeTextBox = new System.Windows.Forms.TextBox();
            this.unixTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.nowButton = new System.Windows.Forms.Button();
            this.baseTimeTextBox = new System.Windows.Forms.TextBox();
            this.copiedTimeTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clipboardTimeTextBox
            // 
            this.clipboardTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardTimeTextBox.Location = new System.Drawing.Point(131, 12);
            this.clipboardTimeTextBox.Name = "clipboardTimeTextBox";
            this.clipboardTimeTextBox.ReadOnly = true;
            this.clipboardTimeTextBox.Size = new System.Drawing.Size(302, 32);
            this.clipboardTimeTextBox.TabIndex = 0;
            // 
            // unixTimeTextBox
            // 
            this.unixTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unixTimeTextBox.Location = new System.Drawing.Point(131, 114);
            this.unixTimeTextBox.Name = "unixTimeTextBox";
            this.unixTimeTextBox.ReadOnly = true;
            this.unixTimeTextBox.Size = new System.Drawing.Size(297, 32);
            this.unixTimeTextBox.TabIndex = 2;
            this.unixTimeTextBox.TextChanged += new System.EventHandler(this.unixTimeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clipboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(15, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 26);
            label2.TabIndex = 3;
            label2.Text = "Unix Time";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // copyButton
            // 
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(17, 177);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "&Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // nowButton
            // 
            this.nowButton.Location = new System.Drawing.Point(17, 66);
            this.nowButton.Name = "nowButton";
            this.nowButton.Size = new System.Drawing.Size(75, 23);
            this.nowButton.TabIndex = 5;
            this.nowButton.Text = "&Now";
            this.nowButton.UseVisualStyleBackColor = true;
            this.nowButton.Click += new System.EventHandler(this.nowButton_Click);
            // 
            // baseTimeTextBox
            // 
            this.baseTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseTimeTextBox.Location = new System.Drawing.Point(131, 59);
            this.baseTimeTextBox.Name = "baseTimeTextBox";
            this.baseTimeTextBox.Size = new System.Drawing.Size(302, 32);
            this.baseTimeTextBox.TabIndex = 7;
            this.baseTimeTextBox.TextChanged += new System.EventHandler(this.baseTimeTextBox_TextChanged);
            // 
            // copiedTimeTextBox
            // 
            this.copiedTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiedTimeTextBox.Location = new System.Drawing.Point(131, 170);
            this.copiedTimeTextBox.Name = "copiedTimeTextBox";
            this.copiedTimeTextBox.ReadOnly = true;
            this.copiedTimeTextBox.Size = new System.Drawing.Size(297, 32);
            this.copiedTimeTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(862, 440);
            this.Controls.Add(this.copiedTimeTextBox);
            this.Controls.Add(this.baseTimeTextBox);
            this.Controls.Add(this.nowButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(label2);
            this.Controls.Add(this.unixTimeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clipboardTimeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clipboardTimeTextBox;
        private System.Windows.Forms.TextBox unixTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button nowButton;
        private System.Windows.Forms.TextBox baseTimeTextBox;
        private System.Windows.Forms.TextBox copiedTimeTextBox;
    }
}

