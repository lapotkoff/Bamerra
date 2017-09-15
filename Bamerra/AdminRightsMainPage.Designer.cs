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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRightsMainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bamerraDataSet = new Bamerra.BamerraDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServicesTreeView = new System.Windows.Forms.TreeView();
            this.DistrictTreeView = new System.Windows.Forms.TreeView();
            this.exitButton = new System.Windows.Forms.Button();
            this.lastDataButton = new System.Windows.Forms.Button();
            this.firstDataButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.customerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.informationTableAdapter = new Bamerra.BamerraDataSetTableAdapters.InformationTableAdapter();
            this.tableAdapterManager = new Bamerra.BamerraDataSetTableAdapters.TableAdapterManager();
            this.printButton = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.changeRowButton = new System.Windows.Forms.Button();
            this.rowIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnershipProgramDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.changeRowButton);
            this.panel1.Controls.Add(this.deleteRowButton);
            this.panel1.Controls.Add(this.printButton);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.advancedDataGridView);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddRowButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.lastDataButton);
            this.panel1.Controls.Add(this.firstDataButton);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.nextButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTotal.Name = "lblTotal";
            // 
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToOrderColumns = true;
            this.advancedDataGridView.AutoGenerateColumns = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.partnershipProgramDataGridViewCheckBoxColumn});
            this.advancedDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.advancedDataGridView.DataSource = this.informationBindingSource;
            this.advancedDataGridView.DateWithTime = false;
            resources.ApplyResources(this.advancedDataGridView, "advancedDataGridView");
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.TimeFilter = false;
            this.advancedDataGridView.SortStringChanged += new System.EventHandler(this.advancedDataGridView_SortStringChanged);
            this.advancedDataGridView.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_FilterStringChanged);
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRowButton
            // 
            resources.ApplyResources(this.AddRowButton, "AddRowButton");
            this.AddRowButton.BackColor = System.Drawing.Color.Honeydew;
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.UseVisualStyleBackColor = false;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.ServicesTreeView);
            this.groupBox2.Controls.Add(this.DistrictTreeView);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ServicesTreeView
            // 
            this.ServicesTreeView.CheckBoxes = true;
            resources.ApplyResources(this.ServicesTreeView, "ServicesTreeView");
            this.ServicesTreeView.Name = "ServicesTreeView";
            this.ServicesTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.AfterCheckServicesTreeView);
            // 
            // DistrictTreeView
            // 
            this.DistrictTreeView.CheckBoxes = true;
            resources.ApplyResources(this.DistrictTreeView, "DistrictTreeView");
            this.DistrictTreeView.Name = "DistrictTreeView";
            this.DistrictTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.AfterCheckDistrictTreeView);
            this.DistrictTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DistrictTreeView_AfterSelect);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.Honeydew;
            this.exitButton.Name = "exitButton";
            this.toolTip1.SetToolTip(this.exitButton, resources.GetString("exitButton.ToolTip"));
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lastDataButton
            // 
            resources.ApplyResources(this.lastDataButton, "lastDataButton");
            this.lastDataButton.BackColor = System.Drawing.Color.Honeydew;
            this.lastDataButton.Name = "lastDataButton";
            this.toolTip1.SetToolTip(this.lastDataButton, resources.GetString("lastDataButton.ToolTip"));
            this.lastDataButton.UseVisualStyleBackColor = false;
            this.lastDataButton.Click += new System.EventHandler(this.lastDataButton_Click);
            // 
            // firstDataButton
            // 
            resources.ApplyResources(this.firstDataButton, "firstDataButton");
            this.firstDataButton.BackColor = System.Drawing.Color.Honeydew;
            this.firstDataButton.Name = "firstDataButton";
            this.toolTip1.SetToolTip(this.firstDataButton, resources.GetString("firstDataButton.ToolTip"));
            this.firstDataButton.UseVisualStyleBackColor = false;
            this.firstDataButton.Click += new System.EventHandler(this.firstDataButton_Click);
            // 
            // previousButton
            // 
            resources.ApplyResources(this.previousButton, "previousButton");
            this.previousButton.BackColor = System.Drawing.Color.Honeydew;
            this.previousButton.Name = "previousButton";
            this.toolTip1.SetToolTip(this.previousButton, resources.GetString("previousButton.ToolTip"));
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            resources.ApplyResources(this.nextButton, "nextButton");
            this.nextButton.BackColor = System.Drawing.Color.Honeydew;
            this.nextButton.Name = "nextButton";
            this.toolTip1.SetToolTip(this.nextButton, resources.GetString("nextButton.ToolTip"));
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // customerNoDataGridViewTextBoxColumn
            // 
            this.customerNoDataGridViewTextBoxColumn.DataPropertyName = "CustomerNo";
            resources.ApplyResources(this.customerNoDataGridViewTextBoxColumn, "customerNoDataGridViewTextBoxColumn");
            this.customerNoDataGridViewTextBoxColumn.Name = "customerNoDataGridViewTextBoxColumn";
            this.customerNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            resources.ApplyResources(this.fNameDataGridViewTextBoxColumn, "fNameDataGridViewTextBoxColumn");
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            resources.ApplyResources(this.lNameDataGridViewTextBoxColumn, "lNameDataGridViewTextBoxColumn");
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "MName";
            resources.ApplyResources(this.mNameDataGridViewTextBoxColumn, "mNameDataGridViewTextBoxColumn");
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            resources.ApplyResources(this.address1DataGridViewTextBoxColumn, "address1DataGridViewTextBoxColumn");
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            this.address1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            resources.ApplyResources(this.address2DataGridViewTextBoxColumn, "address2DataGridViewTextBoxColumn");
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            resources.ApplyResources(this.cityDataGridViewTextBoxColumn, "cityDataGridViewTextBoxColumn");
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            resources.ApplyResources(this.phoneDataGridViewTextBoxColumn, "phoneDataGridViewTextBoxColumn");
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dateInSystemDataGridViewTextBoxColumn
            // 
            this.dateInSystemDataGridViewTextBoxColumn.DataPropertyName = "DateInSystem";
            resources.ApplyResources(this.dateInSystemDataGridViewTextBoxColumn, "dateInSystemDataGridViewTextBoxColumn");
            this.dateInSystemDataGridViewTextBoxColumn.Name = "dateInSystemDataGridViewTextBoxColumn";
            this.dateInSystemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminPasswordsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InformationTableAdapter = this.informationTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bamerra.BamerraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserPasswordsTableAdapter = null;
            // 
            // printButton
            // 
            resources.ApplyResources(this.printButton, "printButton");
            this.printButton.BackColor = System.Drawing.Color.Honeydew;
            this.printButton.Name = "printButton";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // deleteRowButton
            // 
            resources.ApplyResources(this.deleteRowButton, "deleteRowButton");
            this.deleteRowButton.BackColor = System.Drawing.Color.Honeydew;
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.UseVisualStyleBackColor = false;
            // 
            // changeRowButton
            // 
            resources.ApplyResources(this.changeRowButton, "changeRowButton");
            this.changeRowButton.BackColor = System.Drawing.Color.Honeydew;
            this.changeRowButton.Name = "changeRowButton";
            this.changeRowButton.UseVisualStyleBackColor = false;
            // 
            // rowIDDataGridViewTextBoxColumn
            // 
            this.rowIDDataGridViewTextBoxColumn.DataPropertyName = "RowID";
            resources.ApplyResources(this.rowIDDataGridViewTextBoxColumn, "rowIDDataGridViewTextBoxColumn");
            this.rowIDDataGridViewTextBoxColumn.Name = "rowIDDataGridViewTextBoxColumn";
            this.rowIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rowIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Services";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "District";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ContactFace";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LPR";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CompletedProjects";
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Rate";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // partnershipProgramDataGridViewCheckBoxColumn
            // 
            this.partnershipProgramDataGridViewCheckBoxColumn.DataPropertyName = "PartnershipProgram";
            resources.ApplyResources(this.partnershipProgramDataGridViewCheckBoxColumn, "partnershipProgramDataGridViewCheckBoxColumn");
            this.partnershipProgramDataGridViewCheckBoxColumn.Name = "partnershipProgramDataGridViewCheckBoxColumn";
            this.partnershipProgramDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // AdminRightsMainPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.panel1);
            this.Name = "AdminRightsMainPage";
            this.Load += new System.EventHandler(this.AdminRightsMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bamerraDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button lastDataButton;
        private System.Windows.Forms.Button firstDataButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView ServicesTreeView;
        private System.Windows.Forms.TreeView DistrictTreeView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button button1;
        private ADGV.AdvancedDataGridView advancedDataGridView;
        private System.Windows.Forms.Label lblTotal;
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
        private BamerraDataSet bamerraDataSet;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private BamerraDataSetTableAdapters.InformationTableAdapter informationTableAdapter;
        private BamerraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button changeRowButton;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn partnershipProgramDataGridViewCheckBoxColumn;
    }
}