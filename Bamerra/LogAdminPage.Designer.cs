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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignInAdminButton = new System.Windows.Forms.Button();
            this.PrevPageButton = new System.Windows.Forms.Button();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // AdminNameTextBox
            // 
            this.AdminNameTextBox.Location = new System.Drawing.Point(40, 42);
            this.AdminNameTextBox.Name = "AdminNameTextBox";
            this.AdminNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.AdminNameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(40, 107);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(181, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // SignInAdminButton
            // 
            this.SignInAdminButton.Location = new System.Drawing.Point(96, 146);
            this.SignInAdminButton.Name = "SignInAdminButton";
            this.SignInAdminButton.Size = new System.Drawing.Size(65, 41);
            this.SignInAdminButton.TabIndex = 4;
            this.SignInAdminButton.Text = "Sign in";
            this.SignInAdminButton.UseVisualStyleBackColor = true;
            this.SignInAdminButton.Click += new System.EventHandler(this.SignInAdminButton_Click);
            // 
            // PrevPageButton
            // 
            this.PrevPageButton.Location = new System.Drawing.Point(28, 146);
            this.PrevPageButton.Name = "PrevPageButton";
            this.PrevPageButton.Size = new System.Drawing.Size(62, 41);
            this.PrevPageButton.TabIndex = 5;
            this.PrevPageButton.Text = "Previous Page";
            this.PrevPageButton.UseVisualStyleBackColor = true;
            this.PrevPageButton.Click += new System.EventHandler(this.PrevPageButton_Click);
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Location = new System.Drawing.Point(167, 146);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(64, 41);
            this.ExitAppButton.TabIndex = 6;
            this.ExitAppButton.Text = "Exit";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // LogAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(259, 229);
            this.Controls.Add(this.ExitAppButton);
            this.Controls.Add(this.PrevPageButton);
            this.Controls.Add(this.SignInAdminButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AdminNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogAdminPage";
            this.Text = "Bamerra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SignInAdminButton;
        private System.Windows.Forms.Button PrevPageButton;
        private System.Windows.Forms.Button ExitAppButton;
    }
}