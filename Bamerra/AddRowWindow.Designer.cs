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
            this.partnershipCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.districtsToAddTreeView = new System.Windows.Forms.TreeView();
            this.servicesToAddTreeView = new System.Windows.Forms.TreeView();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
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
            nameLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            nameLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.Honeydew;
            nameLabel.Location = new System.Drawing.Point(3, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(42, 16);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "Назва:";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rateLabel.ForeColor = System.Drawing.Color.Honeydew;
            rateLabel.Location = new System.Drawing.Point(3, 315);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(57, 16);
            rateLabel.TabIndex = 49;
            rateLabel.Text = "Рейтинг:";
            // 
            // completedProjectsLabel
            // 
            completedProjectsLabel.AutoSize = true;
            completedProjectsLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            completedProjectsLabel.ForeColor = System.Drawing.Color.Honeydew;
            completedProjectsLabel.Location = new System.Drawing.Point(3, 247);
            completedProjectsLabel.Name = "completedProjectsLabel";
            completedProjectsLabel.Size = new System.Drawing.Size(108, 16);
            completedProjectsLabel.TabIndex = 47;
            completedProjectsLabel.Text = "Виконані проекти:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.Honeydew;
            descriptionLabel.Location = new System.Drawing.Point(3, 138);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(38, 16);
            descriptionLabel.TabIndex = 45;
            descriptionLabel.Text = "Опис:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.ForeColor = System.Drawing.Color.Honeydew;
            e_mailLabel.Location = new System.Drawing.Point(3, 112);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(48, 16);
            e_mailLabel.TabIndex = 43;
            e_mailLabel.Text = "E-mail:";
            // 
            // lPRLabel
            // 
            lPRLabel.AutoSize = true;
            lPRLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lPRLabel.ForeColor = System.Drawing.Color.Honeydew;
            lPRLabel.Location = new System.Drawing.Point(3, 86);
            lPRLabel.Name = "lPRLabel";
            lPRLabel.Size = new System.Drawing.Size(33, 16);
            lPRLabel.TabIndex = 41;
            lPRLabel.Text = "ЛПР:";
            // 
            // contactFaceLabel
            // 
            contactFaceLabel.AutoSize = true;
            contactFaceLabel.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactFaceLabel.ForeColor = System.Drawing.Color.Honeydew;
            contactFaceLabel.Location = new System.Drawing.Point(3, 60);
            contactFaceLabel.Name = "contactFaceLabel";
            contactFaceLabel.Size = new System.Drawing.Size(106, 15);
            contactFaceLabel.TabIndex = 39;
            contactFaceLabel.Text = "Контактне обличчя:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.ForeColor = System.Drawing.Color.Honeydew;
            addressLabel.Location = new System.Drawing.Point(3, 34);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(49, 16);
            addressLabel.TabIndex = 35;
            addressLabel.Text = "Адреса:";
            // 
            // rateCombobox
            // 
            this.rateCombobox.BackColor = System.Drawing.Color.MintCream;
            this.rateCombobox.FormattingEnabled = true;
            this.rateCombobox.Location = new System.Drawing.Point(110, 311);
            this.rateCombobox.Name = "rateCombobox";
            this.rateCombobox.Size = new System.Drawing.Size(60, 21);
            this.rateCombobox.TabIndex = 51;
            this.rateCombobox.SelectedIndexChanged += new System.EventHandler(this.rateCombobox_SelectedIndexChanged);
            // 
            // rateTextBox
            // 
            this.rateTextBox.BackColor = System.Drawing.Color.MintCream;
            this.rateTextBox.Location = new System.Drawing.Point(176, 312);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(34, 20);
            this.rateTextBox.TabIndex = 50;
            // 
            // completedProjectsTextBox
            // 
            this.completedProjectsTextBox.BackColor = System.Drawing.Color.MintCream;
            this.completedProjectsTextBox.Location = new System.Drawing.Point(110, 244);
            this.completedProjectsTextBox.Multiline = true;
            this.completedProjectsTextBox.Name = "completedProjectsTextBox";
            this.completedProjectsTextBox.Size = new System.Drawing.Size(100, 60);
            this.completedProjectsTextBox.TabIndex = 48;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.MintCream;
            this.descriptionTextBox.Location = new System.Drawing.Point(110, 135);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 103);
            this.descriptionTextBox.TabIndex = 46;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.BackColor = System.Drawing.Color.MintCream;
            this.e_mailTextBox.Location = new System.Drawing.Point(110, 109);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_mailTextBox.TabIndex = 44;
            // 
            // lPRTextBox
            // 
            this.lPRTextBox.BackColor = System.Drawing.Color.MintCream;
            this.lPRTextBox.Location = new System.Drawing.Point(110, 83);
            this.lPRTextBox.Name = "lPRTextBox";
            this.lPRTextBox.Size = new System.Drawing.Size(100, 20);
            this.lPRTextBox.TabIndex = 42;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.MintCream;
            this.nameTextBox.Location = new System.Drawing.Point(110, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 32;
            // 
            // contactFaceTextBox
            // 
            this.contactFaceTextBox.BackColor = System.Drawing.Color.MintCream;
            this.contactFaceTextBox.Location = new System.Drawing.Point(110, 57);
            this.contactFaceTextBox.Name = "contactFaceTextBox";
            this.contactFaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactFaceTextBox.TabIndex = 40;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.MintCream;
            this.addressTextBox.Location = new System.Drawing.Point(110, 31);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.partnershipCheckBox);
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
            this.panel1.Size = new System.Drawing.Size(228, 375);
            this.panel1.TabIndex = 52;
            // 
            // partnershipCheckBox
            // 
            this.partnershipCheckBox.AutoSize = true;
            this.partnershipCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnershipCheckBox.ForeColor = System.Drawing.Color.Honeydew;
            this.partnershipCheckBox.Location = new System.Drawing.Point(34, 351);
            this.partnershipCheckBox.Name = "partnershipCheckBox";
            this.partnershipCheckBox.Size = new System.Drawing.Size(150, 20);
            this.partnershipCheckBox.TabIndex = 52;
            this.partnershipCheckBox.Text = "Партнерська програма";
            this.partnershipCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.districtsToAddTreeView);
            this.panel2.Controls.Add(this.servicesToAddTreeView);
            this.panel2.Location = new System.Drawing.Point(246, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 375);
            this.panel2.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(10, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Райони:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Послуги:";
            // 
            // districtsToAddTreeView
            // 
            this.districtsToAddTreeView.BackColor = System.Drawing.Color.MintCream;
            this.districtsToAddTreeView.CheckBoxes = true;
            this.districtsToAddTreeView.Location = new System.Drawing.Point(13, 247);
            this.districtsToAddTreeView.Name = "districtsToAddTreeView";
            this.districtsToAddTreeView.Size = new System.Drawing.Size(156, 112);
            this.districtsToAddTreeView.TabIndex = 1;
            this.districtsToAddTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.AfterCheckDistrictTreeView);
            // 
            // servicesToAddTreeView
            // 
            this.servicesToAddTreeView.BackColor = System.Drawing.Color.MintCream;
            this.servicesToAddTreeView.CheckBoxes = true;
            this.servicesToAddTreeView.Location = new System.Drawing.Point(13, 27);
            this.servicesToAddTreeView.Name = "servicesToAddTreeView";
            this.servicesToAddTreeView.Size = new System.Drawing.Size(156, 198);
            this.servicesToAddTreeView.TabIndex = 0;
            this.servicesToAddTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.AfterCheckServicesTreeView);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.MintCream;
            this.okButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(76, 398);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 27);
            this.okButton.TabIndex = 54;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MintCream;
            this.cancelButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(292, 398);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 27);
            this.cancelButton.TabIndex = 55;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddRowWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(445, 437);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddRowWindow";
            this.Text = "Bamerra";
            this.Load += new System.EventHandler(this.AddRowWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox partnershipCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}