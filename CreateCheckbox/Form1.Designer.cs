namespace CreateCheckbox
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
            this.ckbGender = new System.Windows.Forms.CheckBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbGender
            // 
            this.ckbGender.AutoSize = true;
            this.ckbGender.Location = new System.Drawing.Point(83, 178);
            this.ckbGender.Name = "ckbGender";
            this.ckbGender.Size = new System.Drawing.Size(76, 29);
            this.ckbGender.TabIndex = 1;
            this.ckbGender.Text = "Nam";
            this.ckbGender.UseVisualStyleBackColor = true;
            this.ckbGender.CheckedChanged += new System.EventHandler(this.ckbGender_CheckedChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(83, 84);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 31);
            this.txtName.TabIndex = 0;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(83, 228);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(112, 34);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ckbGender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClick;
    }
}
