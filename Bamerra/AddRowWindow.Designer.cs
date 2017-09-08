namespace Bamerra
{
    partial class AddRowWindow
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label rateLabel;
            System.Windows.Forms.Label completedProjectsLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label lPRLabel;
            System.Windows.Forms.Label contactFaceLabel;
            System.Windows.Forms.Label addressLabel;
            this.rateCombobox = new System.Windows.Forms.ComboBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.completedProjectsTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.lPRTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactFaceTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.servicesToAddTreeView = new System.Windows.Forms.TreeView();
            this.districtsToAddTreeView = new System.Windows.Forms.TreeView();
            this.AddRowToDatabaseButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            completedProjectsLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            lPRLabel = new System.Windows.Forms.Label();
            contactFaceLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(42, 13);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "Назва:";
            // 
            // rateCombobox
            // 
            this.rateCombobox.FormattingEnabled = true;
            this.rateCombobox.Location = new System.Drawing.Point(110, 311);
            this.rateCombobox.Name = "rateCombobox";
            this.rateCombobox.Size = new System.Drawing.Size(60, 21);
            this.rateCombobox.TabIndex = 51;
            this.rateCombobox.SelectedIndexChanged += new System.EventHandler(this.rateCombobox_SelectedIndexChanged);
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(176, 312);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(34, 20);
            this.rateTextBox.TabIndex = 50;
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(3, 315);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(51, 13);
            rateLabel.TabIndex = 49;
            rateLabel.Text = "Рейтинг:";
            // 
            // completedProjectsTextBox
            // 
            this.completedProjectsTextBox.Location = new System.Drawing.Point(110, 244);
            this.completedProjectsTextBox.Multiline = true;
            this.completedProjectsTextBox.Name = "completedProjectsTextBox";
            this.completedProjectsTextBox.Size = new System.Drawing.Size(100, 60);
            this.completedProjectsTextBox.TabIndex = 48;
            // 
            // completedProjectsLabel
            // 
            completedProjectsLabel.AutoSize = true;
            completedProjectsLabel.Location = new System.Drawing.Point(3, 247);
            completedProjectsLabel.Name = "completedProjectsLabel";
            completedProjectsLabel.Size = new System.Drawing.Size(99, 13);
            completedProjectsLabel.TabIndex = 47;
            completedProjectsLabel.Text = "Виконані проекти:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(110, 135);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 103);
            this.descriptionTextBox.TabIndex = 46;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 138);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(36, 13);
            descriptionLabel.TabIndex = 45;
            descriptionLabel.Text = "Опис:";
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.Location = new System.Drawing.Point(110, 109);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_mailTextBox.TabIndex = 44;
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(3, 112);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(38, 13);
            e_mailLabel.TabIndex = 43;
            e_mailLabel.Text = "E-mail:";
            // 
            // lPRTextBox
            // 
            this.lPRTextBox.Location = new System.Drawing.Point(110, 83);
            this.lPRTextBox.Name = "lPRTextBox";
            this.lPRTextBox.Size = new System.Drawing.Size(100, 20);
            this.lPRTextBox.TabIndex = 42;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(110, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 32;
            // 
            // lPRLabel
            // 
            lPRLabel.AutoSize = true;
            lPRLabel.Location = new System.Drawing.Point(3, 86);
            lPRLabel.Name = "lPRLabel";
            lPRLabel.Size = new System.Drawing.Size(33, 13);
            lPRLabel.TabIndex = 41;
            lPRLabel.Text = "ЛПР:";
            // 
            // contactFaceTextBox
            // 
            this.contactFaceTextBox.Location = new System.Drawing.Point(110, 57);
            this.contactFaceTextBox.Name = "contactFaceTextBox";
            this.contactFaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactFaceTextBox.TabIndex = 40;
            // 
            // contactFaceLabel
            // 
            contactFaceLabel.AutoSize = true;
            contactFaceLabel.Location = new System.Drawing.Point(3, 60);
            contactFaceLabel.Name = "contactFaceLabel";
            contactFaceLabel.Size = new System.Drawing.Size(106, 13);
            contactFaceLabel.TabIndex = 39;
            contactFaceLabel.Text = "Контактне обличчя:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(3, 34);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 35;
            addressLabel.Text = "Адреса:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(110, 31);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.rateCombobox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.rateTextBox);
            this.panel1.Controls.Add(rateLabel);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.completedProjectsTextBox);
            this.panel1.Controls.Add(contactFaceLabel);
            this.panel1.Controls.Add(completedProjectsLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.contactFaceTextBox);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.e_mailTextBox);
            this.panel1.Controls.Add(lPRLabel);
            this.panel1.Controls.Add(e_mailLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.lPRTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 349);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.districtsToAddTreeView);
            this.panel2.Controls.Add(this.servicesToAddTreeView);
            this.panel2.Location = new System.Drawing.Point(246, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 349);
            this.panel2.TabIndex = 53;
            // 
            // servicesToAddTreeView
            // 
            this.servicesToAddTreeView.CheckBoxes = true;
            this.servicesToAddTreeView.Location = new System.Drawing.Point(13, 8);
            this.servicesToAddTreeView.Name = "servicesToAddTreeView";
            this.servicesToAddTreeView.Size = new System.Drawing.Size(156, 198);
            this.servicesToAddTreeView.TabIndex = 0;
            // 
            // districtsToAddTreeView
            // 
            this.districtsToAddTreeView.CheckBoxes = true;
            this.districtsToAddTreeView.Location = new System.Drawing.Point(13, 218);
            this.districtsToAddTreeView.Name = "districtsToAddTreeView";
            this.districtsToAddTreeView.Size = new System.Drawing.Size(156, 97);
            this.districtsToAddTreeView.TabIndex = 1;
            // 
            // AddRowToDatabaseButton
            // 
            this.AddRowToDatabaseButton.Location = new System.Drawing.Point(155, 375);
            this.AddRowToDatabaseButton.Name = "AddRowToDatabaseButton";
            this.AddRowToDatabaseButton.Size = new System.Drawing.Size(124, 35);
            this.AddRowToDatabaseButton.TabIndex = 54;
            this.AddRowToDatabaseButton.Text = "Додати до списку";
            this.AddRowToDatabaseButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(20, 375);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(119, 35);
            this.returnButton.TabIndex = 55;
            this.returnButton.Text = "Повернутись до списку";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(298, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 35);
            this.exitButton.TabIndex = 56;
            this.exitButton.Text = "Вийти";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // AddRowWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 437);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.AddRowToDatabaseButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddRowWindow";
            this.Text = "AddRowWindow";
            this.Load += new System.EventHandler(this.AddRowWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox rateCombobox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox completedProjectsTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox lPRTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactFaceTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView districtsToAddTreeView;
        private System.Windows.Forms.TreeView servicesToAddTreeView;
        private System.Windows.Forms.Button AddRowToDatabaseButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exitButton;
    }
}