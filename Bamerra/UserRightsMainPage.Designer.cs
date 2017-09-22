namespace Bamerra
{
    partial class UserRightsMainPage
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
            this.components = new System.ComponentModel.Container();
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.rowIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactFaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedProjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnershipProgramDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bamerraDataSet = new Bamerra.BamerraDataSet();
            this.informationTableAdapter = new Bamerra.BamerraDataSetTableAdapters.InformationTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lastDataButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.firstDataButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToAddRows = false;
            this.advancedDataGridView.AllowUserToDeleteRows = false;
            this.advancedDataGridView.AutoGenerateColumns = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.servicesDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.contactFaceDataGridViewTextBoxColumn,
            this.lPRDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.completedProjectsDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.partnershipProgramDataGridViewCheckBoxColumn});
            this.advancedDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.advancedDataGridView.DataSource = this.informationBindingSource;
            this.advancedDataGridView.DateWithTime = false;
            this.advancedDataGridView.Location = new System.Drawing.Point(12, 69);
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.ReadOnly = true;
            this.advancedDataGridView.Size = new System.Drawing.Size(931, 325);
            this.advancedDataGridView.TabIndex = 39;
            this.advancedDataGridView.TimeFilter = false;
            // 
            // rowIDDataGridViewTextBoxColumn
            // 
            this.rowIDDataGridViewTextBoxColumn.DataPropertyName = "RowID";
            this.rowIDDataGridViewTextBoxColumn.HeaderText = "№";
            this.rowIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rowIDDataGridViewTextBoxColumn.Name = "rowIDDataGridViewTextBoxColumn";
            this.rowIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rowIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rowIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // servicesDataGridViewTextBoxColumn
            // 
            this.servicesDataGridViewTextBoxColumn.DataPropertyName = "Services";
            this.servicesDataGridViewTextBoxColumn.HeaderText = "Послуги";
            this.servicesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.servicesDataGridViewTextBoxColumn.Name = "servicesDataGridViewTextBoxColumn";
            this.servicesDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.servicesDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "Район";
            this.districtDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            this.districtDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // contactFaceDataGridViewTextBoxColumn
            // 
            this.contactFaceDataGridViewTextBoxColumn.DataPropertyName = "ContactFace";
            this.contactFaceDataGridViewTextBoxColumn.HeaderText = "Контактне обличчя";
            this.contactFaceDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.contactFaceDataGridViewTextBoxColumn.Name = "contactFaceDataGridViewTextBoxColumn";
            this.contactFaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactFaceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lPRDataGridViewTextBoxColumn
            // 
            this.lPRDataGridViewTextBoxColumn.DataPropertyName = "LPR";
            this.lPRDataGridViewTextBoxColumn.HeaderText = "ЛПР";
            this.lPRDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.lPRDataGridViewTextBoxColumn.Name = "lPRDataGridViewTextBoxColumn";
            this.lPRDataGridViewTextBoxColumn.ReadOnly = true;
            this.lPRDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Опис";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // completedProjectsDataGridViewTextBoxColumn
            // 
            this.completedProjectsDataGridViewTextBoxColumn.DataPropertyName = "CompletedProjects";
            this.completedProjectsDataGridViewTextBoxColumn.HeaderText = "Виконані проекти";
            this.completedProjectsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.completedProjectsDataGridViewTextBoxColumn.Name = "completedProjectsDataGridViewTextBoxColumn";
            this.completedProjectsDataGridViewTextBoxColumn.ReadOnly = true;
            this.completedProjectsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.completedProjectsDataGridViewTextBoxColumn.Width = 200;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // partnershipProgramDataGridViewCheckBoxColumn
            // 
            this.partnershipProgramDataGridViewCheckBoxColumn.DataPropertyName = "PartnershipProgram";
            this.partnershipProgramDataGridViewCheckBoxColumn.HeaderText = "Партнерська програма";
            this.partnershipProgramDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.partnershipProgramDataGridViewCheckBoxColumn.Name = "partnershipProgramDataGridViewCheckBoxColumn";
            this.partnershipProgramDataGridViewCheckBoxColumn.ReadOnly = true;
            this.partnershipProgramDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.bamerraDataSet;
            // 
            // bamerraDataSet
            // 
            this.bamerraDataSet.DataSetName = "BamerraDataSet";
            this.bamerraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lastDataButton);
            this.panel3.Controls.Add(this.nextButton);
            this.panel3.Controls.Add(this.firstDataButton);
            this.panel3.Controls.Add(this.previousButton);
            this.panel3.Location = new System.Drawing.Point(12, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 66);
            this.panel3.TabIndex = 46;
            // 
            // lastDataButton
            // 
            this.lastDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lastDataButton.BackColor = System.Drawing.Color.Honeydew;
            this.lastDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lastDataButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lastDataButton.Location = new System.Drawing.Point(387, 8);
            this.lastDataButton.Name = "lastDataButton";
            this.lastDataButton.Size = new System.Drawing.Size(118, 40);
            this.lastDataButton.TabIndex = 28;
            this.lastDataButton.Text = "Остання";
            this.lastDataButton.UseVisualStyleBackColor = false;
            this.lastDataButton.Click += new System.EventHandler(this.lastDataButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.Honeydew;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.nextButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nextButton.Location = new System.Drawing.Point(15, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(118, 40);
            this.nextButton.TabIndex = 25;
            this.nextButton.Text = "Наступна";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // firstDataButton
            // 
            this.firstDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.firstDataButton.BackColor = System.Drawing.Color.Honeydew;
            this.firstDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.firstDataButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.firstDataButton.Location = new System.Drawing.Point(263, 8);
            this.firstDataButton.Name = "firstDataButton";
            this.firstDataButton.Size = new System.Drawing.Size(118, 40);
            this.firstDataButton.TabIndex = 27;
            this.firstDataButton.Text = "Перша";
            this.firstDataButton.UseVisualStyleBackColor = false;
            this.firstDataButton.Click += new System.EventHandler(this.firstDataButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.BackColor = System.Drawing.Color.Honeydew;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.previousButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.previousButton.Location = new System.Drawing.Point(139, 8);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(118, 40);
            this.previousButton.TabIndex = 26;
            this.previousButton.Text = "Попередня";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Honeydew;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(825, 419);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 40);
            this.exitButton.TabIndex = 47;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 35);
            this.label1.TabIndex = 48;
            this.label1.Text = "Користувач";
            // 
            // UserRightsMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(955, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.advancedDataGridView);
            this.Name = "UserRightsMainPage";
            this.Text = "Bamerra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserRightsMainPage_FormClosing);
            this.Load += new System.EventHandler(this.UserRightsMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView;
        private BamerraDataSet bamerraDataSet;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private BamerraDataSetTableAdapters.InformationTableAdapter informationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactFaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedProjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn partnershipProgramDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastDataButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button firstDataButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}