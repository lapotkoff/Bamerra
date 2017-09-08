namespace Bamerra
{
    partial class AdminRightsMainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.infoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bamerraDataDataSet2 = new Bamerra.BamerraDataDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServicesTreeView = new System.Windows.Forms.TreeView();
            this.DistrictTreeView = new System.Windows.Forms.TreeView();
            this.exitButton = new System.Windows.Forms.Button();
            this.lastDataButton = new System.Windows.Forms.Button();
            this.firstDataButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.infoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bamerraDataDataSet1 = new Bamerra.BamerraDataDataSet1();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bamerraDataDataSet = new Bamerra.BamerraDataDataSet();
            this.infoTableAdapter = new Bamerra.BamerraDataDataSetTableAdapters.InfoTableAdapter();
            this.tableAdapterManager = new Bamerra.BamerraDataDataSetTableAdapters.TableAdapterManager();
            this.shopDBDataSet = new Bamerra.ShopDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Bamerra.ShopDBDataSetTableAdapters.CustomersTableAdapter();
            this.infoTableAdapter1 = new Bamerra.BamerraDataDataSet1TableAdapters.InfoTableAdapter();
            this.infoTableAdapter2 = new Bamerra.BamerraDataDataSet2TableAdapters.InfoTableAdapter();
            this.customerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.advancedDataGridView);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddRowButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.lastDataButton);
            this.panel1.Controls.Add(this.firstDataButton);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Location = new System.Drawing.Point(11, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 579);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1127, 369);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 13);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "Total rows: 0";
            // 
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToOrderColumns = true;
            this.advancedDataGridView.AutoGenerateColumns = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNoDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateInSystemDataGridViewTextBoxColumn});
            this.advancedDataGridView.DataSource = this.customersBindingSource;
            this.advancedDataGridView.DateWithTime = false;
            this.advancedDataGridView.Location = new System.Drawing.Point(209, 3);
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.Size = new System.Drawing.Size(931, 350);
            this.advancedDataGridView.TabIndex = 38;
            this.advancedDataGridView.TimeFilter = false;
            this.advancedDataGridView.SortStringChanged += new System.EventHandler(this.advancedDataGridView_SortStringChanged);
            this.advancedDataGridView.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_FilterStringChanged);
            // 
            // infoBindingSource2
            // 
            this.infoBindingSource2.DataMember = "Info";
            this.infoBindingSource2.DataSource = this.bamerraDataDataSet2;
            // 
            // bamerraDataDataSet2
            // 
            this.bamerraDataDataSet2.DataSetName = "BamerraDataDataSet2";
            this.bamerraDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(64, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRowButton.Location = new System.Drawing.Point(208, 360);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(140, 40);
            this.AddRowButton.TabIndex = 36;
            this.AddRowButton.Text = "Додати ";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.servicesDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.contactFaceDataGridViewTextBoxColumn,
            this.lPRDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.completedProjectsDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(273, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 115);
            this.dataGridView1.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.ServicesTreeView);
            this.groupBox2.Controls.Add(this.DistrictTreeView);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 412);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фільтри";
            // 
            // ServicesTreeView
            // 
            this.ServicesTreeView.CheckBoxes = true;
            this.ServicesTreeView.Location = new System.Drawing.Point(16, 19);
            this.ServicesTreeView.Name = "ServicesTreeView";
            this.ServicesTreeView.Size = new System.Drawing.Size(142, 228);
            this.ServicesTreeView.TabIndex = 32;
            this.ServicesTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.AfterCheckServicesTreeView);
            // 
            // DistrictTreeView
            // 
            this.DistrictTreeView.CheckBoxes = true;
            this.DistrictTreeView.Location = new System.Drawing.Point(16, 253);
            this.DistrictTreeView.Name = "DistrictTreeView";
            this.DistrictTreeView.Size = new System.Drawing.Size(142, 143);
            this.DistrictTreeView.TabIndex = 33;
            this.DistrictTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.AfterCheckDistrictTreeView);
            this.DistrictTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DistrictTreeView_AfterSelect);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(959, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 40);
            this.exitButton.TabIndex = 29;
            this.exitButton.Text = "Вихід";
            this.toolTip1.SetToolTip(this.exitButton, "Exit");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lastDataButton
            // 
            this.lastDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lastDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDataButton.Location = new System.Drawing.Point(823, 360);
            this.lastDataButton.Name = "lastDataButton";
            this.lastDataButton.Size = new System.Drawing.Size(130, 40);
            this.lastDataButton.TabIndex = 28;
            this.lastDataButton.Text = "Остання";
            this.toolTip1.SetToolTip(this.lastDataButton, "Last Data");
            this.lastDataButton.UseVisualStyleBackColor = true;
            this.lastDataButton.Click += new System.EventHandler(this.lastDataButton_Click);
            // 
            // firstDataButton
            // 
            this.firstDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.firstDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDataButton.Location = new System.Drawing.Point(677, 360);
            this.firstDataButton.Name = "firstDataButton";
            this.firstDataButton.Size = new System.Drawing.Size(140, 40);
            this.firstDataButton.TabIndex = 27;
            this.firstDataButton.Text = "Перша";
            this.toolTip1.SetToolTip(this.firstDataButton, "First Data");
            this.firstDataButton.UseVisualStyleBackColor = true;
            this.firstDataButton.Click += new System.EventHandler(this.firstDataButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(500, 360);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(171, 40);
            this.previousButton.TabIndex = 26;
            this.previousButton.Text = "Попередня";
            this.toolTip1.SetToolTip(this.previousButton, "Previous");
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(354, 360);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(140, 40);
            this.nextButton.TabIndex = 25;
            this.nextButton.Text = "Наступна";
            this.toolTip1.SetToolTip(this.nextButton, "Next");
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // infoBindingSource1
            // 
            this.infoBindingSource1.DataMember = "Info";
            this.infoBindingSource1.DataSource = this.bamerraDataDataSet1;
            // 
            // bamerraDataDataSet1
            // 
            this.bamerraDataDataSet1.DataSetName = "BamerraDataDataSet1";
            this.bamerraDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.bamerraDataDataSet;
            this.infoBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.infoBindingSource_ListChanged);
            // 
            // bamerraDataDataSet
            // 
            this.bamerraDataDataSet.DataSetName = "BamerraDataDataSet";
            this.bamerraDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InfoTableAdapter = this.infoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bamerra.BamerraDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shopDBDataSet
            // 
            this.shopDBDataSet.DataSetName = "ShopDBDataSet";
            this.shopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.shopDBDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // infoTableAdapter1
            // 
            this.infoTableAdapter1.ClearBeforeFill = true;
            // 
            // infoTableAdapter2
            // 
            this.infoTableAdapter2.ClearBeforeFill = true;
            // 
            // customerNoDataGridViewTextBoxColumn
            // 
            this.customerNoDataGridViewTextBoxColumn.DataPropertyName = "CustomerNo";
            this.customerNoDataGridViewTextBoxColumn.HeaderText = "CustomerNo";
            this.customerNoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.customerNoDataGridViewTextBoxColumn.Name = "customerNoDataGridViewTextBoxColumn";
            this.customerNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "MName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "MName";
            this.mNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            this.address1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dateInSystemDataGridViewTextBoxColumn
            // 
            this.dateInSystemDataGridViewTextBoxColumn.DataPropertyName = "DateInSystem";
            this.dateInSystemDataGridViewTextBoxColumn.HeaderText = "DateInSystem";
            this.dateInSystemDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dateInSystemDataGridViewTextBoxColumn.Name = "dateInSystemDataGridViewTextBoxColumn";
            this.dateInSystemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // servicesDataGridViewTextBoxColumn
            // 
            this.servicesDataGridViewTextBoxColumn.DataPropertyName = "Services";
            this.servicesDataGridViewTextBoxColumn.HeaderText = "Services";
            this.servicesDataGridViewTextBoxColumn.Name = "servicesDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            // 
            // contactFaceDataGridViewTextBoxColumn
            // 
            this.contactFaceDataGridViewTextBoxColumn.DataPropertyName = "ContactFace";
            this.contactFaceDataGridViewTextBoxColumn.HeaderText = "ContactFace";
            this.contactFaceDataGridViewTextBoxColumn.Name = "contactFaceDataGridViewTextBoxColumn";
            // 
            // lPRDataGridViewTextBoxColumn
            // 
            this.lPRDataGridViewTextBoxColumn.DataPropertyName = "LPR";
            this.lPRDataGridViewTextBoxColumn.HeaderText = "LPR";
            this.lPRDataGridViewTextBoxColumn.Name = "lPRDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // completedProjectsDataGridViewTextBoxColumn
            // 
            this.completedProjectsDataGridViewTextBoxColumn.DataPropertyName = "CompletedProjects";
            this.completedProjectsDataGridViewTextBoxColumn.HeaderText = "CompletedProjects";
            this.completedProjectsDataGridViewTextBoxColumn.Name = "completedProjectsDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // AdminRightsMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1292, 616);
            this.Controls.Add(this.panel1);
            this.Name = "AdminRightsMainPage";
            this.Text = "Bamerra";
            this.Load += new System.EventHandler(this.AdminRightsMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BamerraDataDataSet bamerraDataDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private BamerraDataDataSetTableAdapters.InfoTableAdapter infoTableAdapter;
        private BamerraDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button lastDataButton;
        private System.Windows.Forms.Button firstDataButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView ServicesTreeView;
        private System.Windows.Forms.TreeView DistrictTreeView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button button1;
        private ADGV.AdvancedDataGridView advancedDataGridView;
        private System.Windows.Forms.Label lblTotal;
        private ShopDBDataSet shopDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ShopDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private BamerraDataDataSet1 bamerraDataDataSet1;
        private System.Windows.Forms.BindingSource infoBindingSource1;
        private BamerraDataDataSet1TableAdapters.InfoTableAdapter infoTableAdapter1;
        private BamerraDataDataSet2 bamerraDataDataSet2;
        private System.Windows.Forms.BindingSource infoBindingSource2;
        private BamerraDataDataSet2TableAdapters.InfoTableAdapter infoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInSystemDataGridViewTextBoxColumn;
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
    }
}