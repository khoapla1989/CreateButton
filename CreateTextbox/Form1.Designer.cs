﻿namespace CreateTextbox
{
    partial class Form1
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
            this.txbValue = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.btnValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(64, 47);
            this.txbValue.Multiline = true;
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(241, 104);
            this.txbValue.TabIndex = 0;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(64, 184);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(59, 25);
            this.lbValue.TabIndex = 2;
            this.lbValue.Text = "label1";
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(343, 67);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(112, 34);
            this.btnValue.TabIndex = 1;
            this.btnValue.Text = "button1";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnValue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.txbValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.btnValue_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Button btnValue;
    }
}
