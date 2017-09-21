namespace Bamerra
{
    partial class LogAdminPage
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
            this.pinPukLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignInAdminButton = new System.Windows.Forms.Button();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pinPukLabel
            // 
            this.pinPukLabel.AutoSize = true;
            this.pinPukLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pinPukLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinPukLabel.ForeColor = System.Drawing.Color.MintCream;
            this.pinPukLabel.Location = new System.Drawing.Point(31, 49);
            this.pinPukLabel.Name = "pinPukLabel";
            this.pinPukLabel.Size = new System.Drawing.Size(42, 18);
            this.pinPukLabel.TabIndex = 1;
            this.pinPukLabel.Text = "PIN1:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(34, 77);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(214, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // SignInAdminButton
            // 
            this.SignInAdminButton.BackColor = System.Drawing.Color.MintCream;
            this.SignInAdminButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInAdminButton.Location = new System.Drawing.Point(34, 116);
            this.SignInAdminButton.Name = "SignInAdminButton";
            this.SignInAdminButton.Size = new System.Drawing.Size(88, 41);
            this.SignInAdminButton.TabIndex = 4;
            this.SignInAdminButton.Text = "Sign in";
            this.SignInAdminButton.UseVisualStyleBackColor = false;
            this.SignInAdminButton.Click += new System.EventHandler(this.SignInAdminButton_Click);
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.BackColor = System.Drawing.Color.MintCream;
            this.ExitAppButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitAppButton.Location = new System.Drawing.Point(160, 116);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(88, 41);
            this.ExitAppButton.TabIndex = 6;
            this.ExitAppButton.Text = "Exit";
            this.ExitAppButton.UseVisualStyleBackColor = false;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.adminLabel);
            this.panel1.Controls.Add(this.warningLabel);
            this.panel1.Controls.Add(this.pinPukLabel);
            this.panel1.Controls.Add(this.ExitAppButton);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.SignInAdminButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 195);
            this.panel1.TabIndex = 7;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.adminLabel.Location = new System.Drawing.Point(74, 13);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(144, 27);
            this.adminLabel.TabIndex = 8;
            this.adminLabel.Text = "Administrator";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(17, 178);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 7;
            // 
            // LogAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(315, 219);
            this.Controls.Add(this.panel1);
            this.Name = "LogAdminPage";
            this.Text = "Bamerra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label pinPukLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SignInAdminButton;
        private System.Windows.Forms.Button ExitAppButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label adminLabel;
    }
}