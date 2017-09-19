using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Common;
using DGVPrinterHelper;
using Bamerra.Commands;
using Microsoft.Office.Interop.Excel;

namespace Bamerra
{
    public partial class AdminRightsMainPage : Form
    {

        //private string connection_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Valik\Documents\Visual Studio 2013\Projects\2 курс\Bamerra\Bamerra\Bamerra\BamerraData.mdf"";Integrated Security=True;Connect Timeout=30";
        private string connection_string = Properties.Settings.Default.BamerraConnectionString;
        private string command_string = "Select * FROM Information";
        private string RowFilter = "";

        #region Loading tools
        private void LoadServicesTreeView()
        {
            ServicesTreeView.BeginUpdate();

            ServicesTreeView.Nodes.Add("Послуги");

            ServicesTreeView.Nodes[0].Nodes.Add("Дизайн");

            ServicesTreeView.Nodes[0].Nodes[0].Nodes.Add("Бренд");
            ServicesTreeView.Nodes[0].Nodes[0].Nodes.Add("Поліграфія");
            ServicesTreeView.Nodes[0].Nodes[0].Nodes.Add("Зовнішня реклама");
            ServicesTreeView.Nodes[0].Nodes[0].Nodes.Add("Художні роботи");
            ServicesTreeView.Nodes[0].Nodes[0].Nodes.Add("Інше");

            ServicesTreeView.Nodes[0].Nodes.Add("Зовнішня реклама");

            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Самоклеюча плівка");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Плотерна/фрезерна різка");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Банери");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Банерна сітка");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Вивіски");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Стели");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Лайтбокси");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Біллборди");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Фотошпалери");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Матеріали для реклами");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Монтаж");
            ServicesTreeView.Nodes[0].Nodes[1].Nodes.Add("Інше");

            ServicesTreeView.Nodes[0].Nodes.Add("Друкована реклама");

            ServicesTreeView.Nodes[0].Nodes[2].Nodes.Add("Цифровий друк");
            ServicesTreeView.Nodes[0].Nodes[2].Nodes.Add("Офсетний друк");
            ServicesTreeView.Nodes[0].Nodes[2].Nodes.Add("Візитки, флаєри, буклети");
            ServicesTreeView.Nodes[0].Nodes[2].Nodes.Add("РОС-матеріали");
            ServicesTreeView.Nodes[0].Nodes[2].Nodes.Add("Цінники, етикетки");
            ServicesTreeView.Nodes[0].Nodes[2].Nodes.Add("Інше");


            ServicesTreeView.Nodes[0].Nodes.Add("Фото");

            ServicesTreeView.Nodes[0].Nodes.Add("Відео");

            ServicesTreeView.Nodes[0].Nodes.Add("Інтернет реклама");

            ServicesTreeView.Nodes[0].Nodes[5].Nodes.Add("Розробка сайтів");
            ServicesTreeView.Nodes[0].Nodes[5].Nodes.Add("Розробка landing-page");
            ServicesTreeView.Nodes[0].Nodes[5].Nodes.Add("Просування в соцмережах");
            ServicesTreeView.Nodes[0].Nodes[5].Nodes.Add("Інше");

            ServicesTreeView.Nodes[0].Nodes.Add("Радіо");
            ServicesTreeView.Nodes[0].Nodes.Add("Телебачення");
            ServicesTreeView.Nodes[0].Nodes.Add("Копірайт");

            ServicesTreeView.EndUpdate();
        }

        private void LoadDistrictTreeView()
        {
            DistrictTreeView.Nodes.Add("Район");
            DistrictTreeView.Nodes[0].Nodes.Add("Залізничний");
            DistrictTreeView.Nodes[0].Nodes.Add("Франківський");
            DistrictTreeView.Nodes[0].Nodes.Add("Галицький");
            DistrictTreeView.Nodes[0].Nodes.Add("Шевченківський");
            DistrictTreeView.Nodes[0].Nodes.Add("Личаківський");
            DistrictTreeView.Nodes[0].Nodes.Add("Сихівський");
        }
        #endregion

        public AdminRightsMainPage()
        {
            InitializeComponent();
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            this.informationTableAdapter.Fill(this.bamerraDataSet.Information);
            this.informationTableAdapter.Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DBManager.ConfigureinformationAdapter(this.informationTableAdapter.Adapter);
            this.informationTableAdapter.Adapter.FillSchema(this.bamerraDataSet.Information, SchemaType.Mapped);
            this.bamerraDataSet.Information.Columns[0].AutoIncrementSeed = 1;
            this.bamerraDataSet.Information.Columns[0].AutoIncrementStep = 1;
            lblTotal.Text = string.Format("Загальна кількість рядків: {0}", informationBindingSource.Count);
            LoadServicesTreeView();
            LoadDistrictTreeView();
            this.informationTableAdapter.Adapter.RowUpdated += adapter_RowUpdated;
            RowsColor();
            //        //this.advancedDataGridView.RowHeadersVisible = false;       ?????
            //        //advancedDataGridView.ReadOnly = true;
        }

        void adapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                var insertedRow = e.Row;

                try
                {
                    insertedRow.Table.Columns[0].ReadOnly = false;

                    insertedRow[0] = e.Command.Parameters["NewRowID"].Value;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    insertedRow.Table.Columns[0].ReadOnly = true;
                }
            }
        }

        #region Button Events

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddRowWindow(this.bamerraDataSet.Information).ShowDialog();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (advancedDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = advancedDataGridView.SelectedRows[0].Index;

                DataRow deleterow = bamerraDataSet.Information.NewRow();
                deleterow["RowID"] = int.Parse(advancedDataGridView[0, selectedIndex].Value.ToString());
                // string sql = "DELETE FROM Table1 WHERE RowID = @RowID";
                try
                {
                    advancedDataGridView.Rows.RemoveAt(selectedIndex);
                    DBManager.DeleteInformation(deleterow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    RowsColor();
                    lblTotal.Text = string.Format("Загальна кількість рядків: {0}", informationBindingSource.Count);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Ви дійсно хочете вийти?", "Bamerra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            informationBindingSource.MoveNext();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            informationBindingSource.MovePrevious();
        }

        private void firstDataButton_Click(object sender, EventArgs e)
        {
            informationBindingSource.MoveFirst();
        }

        private void lastDataButton_Click(object sender, EventArgs e)
        {
            informationBindingSource.MoveLast();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //треба подумати як впихнути в одну сторінку всю таблицю по ширині!!!
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Звіт";
            printer.SubTitle = string.Format("Дата: {0}", DateTime.Now.Date);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Bamerra";
            printer.FooterSpacing = 15;
            //зберігає колір і трохи розширює
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(advancedDataGridView);
        }

        private void savechangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.informationBindingSource.EndEdit();
                this.informationTableAdapter.Update(this.bamerraDataSet.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RowsColor();
                lblTotal.Text = string.Format("Загальна кількість рядків: {0}", informationBindingSource.Count);
            }
            //this.bamerraDataSet.Information.Clear();

            //this.informationTableAdapter.Adapter.Fill(this.bamerraDataSet.Information);
            //RowsColor();
        }

        private void createExcelFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    Microsoft.Office.Interop.Excel.Application excelfile = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = excelfile.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)excelfile.ActiveSheet;
                    excelfile.Visible = false;

                    for (int i = 1; i <= bamerraDataSet.Information.Columns.Count; i++)
                    {
                        ws.Cells[1, i] = advancedDataGridView.Columns[i - 1].HeaderText.ToString();
                    }
                    for (int i = 1; i <= informationBindingSource.Count; i++)
                    {
                        for (int j = 0; j < bamerraDataSet.Information.Columns.Count; j++)
                        {
                            if (advancedDataGridView[j, i-1].Value != null)
                            {
                                ws.Cells[i + 1, j + 1] = advancedDataGridView[j, i - 1].Value.ToString();
                            }
                        }
                    }
                    ws.SaveAs(filename, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    excelfile.Quit();
                }
            }
        }

        #endregion

        #region All about TreeView
        private void DistrictTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void AfterCheckServicesTreeView(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void FindAllCheckedNodes(TreeNode treeNode, string columnFilter)
        {
            if(treeNode.Checked == true)
            {
                string to_add = columnFilter + "LIKE '" + treeNode.Text + "%' OR";
                RowFilter += to_add;
            }
            foreach (TreeNode node in treeNode.Nodes)
            {
                if(node.Checked == true)
                {
                    string to_add = columnFilter + "LIKE '" + node.Text + "%' OR";
                    RowFilter += to_add;
                }
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.FindAllCheckedNodes(node, columnFilter);
                }
            }
            if (RowFilter.Length > 0)
            {
                RowFilter = RowFilter.Remove(RowFilter.LastIndexOf("OR"), 2);
            }
        }

        private void AfterCheckDistrictTreeView(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }

            //DataTable filteredtable = new DataTable();
            //filteredtable.TableName = "FilteredInfo";
            //SqlDataAdapter adapter = new SqlDataAdapter(command_string, connection_string);
            //adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //adapter.Fill(filteredtable);
            //DataView filteredView = new DataView(filteredtable, RowFilter, "District", DataViewRowState.CurrentRows);
            //dataGridView1.DataSource = filteredView;

        }
        #endregion

        #region Test button
        private void button1_Click(object sender, EventArgs e)
        {
           // FindAllCheckedNodes(DistrictTreeView.TopNode, " District ");
           // DataTable filteredtable = new DataTable();
           // filteredtable.TableName = "FilteredInfo";
           // SqlDataAdapter adapter = new SqlDataAdapter(command_string, connection_string);
           // adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
           // adapter.Fill(filteredtable);
           // DataView filteredView = new DataView(filteredtable, RowFilter, "District", DataViewRowState.CurrentRows);
           // //dataGridView1.DataSource = filteredView;
           // RowFilter = "";
        }
        #endregion

        #region Advanced DGridView events
        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            informationBindingSource.Filter = this.advancedDataGridView.FilterString;
            RowsColor();
        }

        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            informationBindingSource.Sort = this.advancedDataGridView.SortString;
        }

        private void infoBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotal.Text = string.Format("Загальна кількість рядків: {0}", this.informationBindingSource.Count);
        }
        #endregion

        public void RowsColor()
        {
            for(int i=0; i<informationBindingSource.Count; i++)
            {
                if(i%2 == 1)
                {
                    advancedDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
                string partnership = advancedDataGridView.Rows[i].Cells[11].Value.ToString();
                if(partnership == "True")
                {
                    advancedDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
                }


            }
        }

    }
}
