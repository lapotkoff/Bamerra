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

   
        public AdminRightsMainPage()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("uk");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("uk");

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
            this.informationTableAdapter.Adapter.RowUpdated += adapter_RowUpdated;
            RowsColor();
            CenterToScreen();
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
                   // DBManager.DeleteInformation(deleterow);
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
                Environment.Exit(0);
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

        private void recoverPasswordsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                DBManager.changeflag("AdminPasswords", "AdmPasswordID", i, "TRUE");
                DBManager.changeflag("UserPasswords", "UsrPasswordID", i, "TRUE");
            }
            MessageBox.Show("Паролі успішно відновлено!");
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

        private void AdminRightsMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви дійсно хочете вийти?", "Bamerra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
