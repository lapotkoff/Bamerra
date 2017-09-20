using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bamerra.Commands;

namespace Bamerra
{

    public partial class AddRowWindow : Form
    {

        private DataTable table;

        public AddRowWindow(DataTable table)
        {
            this.table = table;
            InitializeComponent();
        }

        #region Loading tools

        private void LoadServicesToAddTreeView()
        {
            servicesToAddTreeView.Nodes.Add("Послуги");
            
            servicesToAddTreeView.Nodes[0].Nodes.Add("Дизайн");
            
            servicesToAddTreeView.Nodes[0].Nodes[0].Nodes.Add("Бренд");
            servicesToAddTreeView.Nodes[0].Nodes[0].Nodes.Add("Поліграфія");
            servicesToAddTreeView.Nodes[0].Nodes[0].Nodes.Add("Зовнішня реклама");
            servicesToAddTreeView.Nodes[0].Nodes[0].Nodes.Add("Художні роботи");
            servicesToAddTreeView.Nodes[0].Nodes[0].Nodes.Add("Інше");
            
            servicesToAddTreeView.Nodes[0].Nodes.Add("Зовнішня реклама");
            
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Самоклеюча плівка");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Плотерна/фрезерна різка");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Банери");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Банерна сітка");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Вивіски");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Стели");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Лайтбокси");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Біллборди");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Фотошпалери");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Матеріали для реклами");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Монтаж");
            servicesToAddTreeView.Nodes[0].Nodes[1].Nodes.Add("Інше");
           
            servicesToAddTreeView.Nodes[0].Nodes.Add("Друкована реклама");
            
            servicesToAddTreeView.Nodes[0].Nodes[2].Nodes.Add("Цифровий друк");
            servicesToAddTreeView.Nodes[0].Nodes[2].Nodes.Add("Офсетний друк");
            servicesToAddTreeView.Nodes[0].Nodes[2].Nodes.Add("Візитки, флаєри, буклети");
            servicesToAddTreeView.Nodes[0].Nodes[2].Nodes.Add("РОС-матеріали");
            servicesToAddTreeView.Nodes[0].Nodes[2].Nodes.Add("Цінники, етикетки");
            servicesToAddTreeView.Nodes[0].Nodes[2].Nodes.Add("Інше");
           
            servicesToAddTreeView.Nodes[0].Nodes.Add("Фото");
            
            servicesToAddTreeView.Nodes[0].Nodes.Add("Відео");
            
            servicesToAddTreeView.Nodes[0].Nodes.Add("Інтернет реклама");
           
            servicesToAddTreeView.Nodes[0].Nodes[5].Nodes.Add("Розробка сайтів");
            servicesToAddTreeView.Nodes[0].Nodes[5].Nodes.Add("Розробка landing-page");
            servicesToAddTreeView.Nodes[0].Nodes[5].Nodes.Add("Просування в соцмережах");
            servicesToAddTreeView.Nodes[0].Nodes[5].Nodes.Add("Інше");
            
            servicesToAddTreeView.Nodes[0].Nodes.Add("Радіо");
            servicesToAddTreeView.Nodes[0].Nodes.Add("Телебачення");
            servicesToAddTreeView.Nodes[0].Nodes.Add("Копірайт");
        }

        private void LoadDistrictsToAddTreeView()
        {
            districtsToAddTreeView.Nodes.Add("Район");
            districtsToAddTreeView.Nodes[0].Nodes.Add("Залізничний");
            districtsToAddTreeView.Nodes[0].Nodes.Add("Франківський");
            districtsToAddTreeView.Nodes[0].Nodes.Add("Галицький");
            districtsToAddTreeView.Nodes[0].Nodes.Add("Шевченківський");
            districtsToAddTreeView.Nodes[0].Nodes.Add("Личаківський");
            districtsToAddTreeView.Nodes[0].Nodes.Add("Сихівський");
        }

        private void LoadRateComboBox()
        {
            rateCombobox.Items.Add("");
            rateCombobox.Items.Add("5");
            rateCombobox.Items.Add("4");
            rateCombobox.Items.Add("3");
            rateCombobox.Items.Add("2");
            rateCombobox.Items.Add("1");
        }

        #endregion

        private void AddRowWindow_Load(object sender, EventArgs e)
        {
            LoadServicesToAddTreeView();
            LoadDistrictsToAddTreeView();
            LoadRateComboBox();
            CenterToScreen();
        }

        private void rateCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rateCombobox.Text == "5")
            {
                rateTextBox.Text = "";
                rateTextBox.Text = "5";
            }
            if (rateCombobox.Text == "4")
            {
                rateTextBox.Text = "";
                rateTextBox.Text = "4";
            }
            if (rateCombobox.Text == "3")
            {
                rateTextBox.Text = "";
                rateTextBox.Text = "3";
            }
            if (rateCombobox.Text == "2")
            {
                rateTextBox.Text = "";
                rateTextBox.Text = "2";
            }
            if (rateCombobox.Text == "1")
            {
                rateTextBox.Text = "";
                rateTextBox.Text = "1";
            }
            if (rateCombobox.Text == "")
            {
                rateTextBox.Text = "";
                rateTextBox.Text = "No";
            }
        }

        #region Button events

        private void okButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = table.NewRow();
            newRow["Name"] = nameTextBox.Text.Count() == 0 ? null : nameTextBox.Text;
            newRow["Address"] = addressTextBox.Text.Count() == 0 ? null : addressTextBox.Text;
            newRow["ContactFace"] = contactFaceTextBox.Text.Count() == 0 ? null : contactFaceTextBox.Text;
            newRow["LPR"] = lPRTextBox.Text.Count() == 0 ? null : lPRTextBox.Text;
            newRow["Email"] = e_mailTextBox.Text.Count() == 0 ? null : e_mailTextBox.Text;
            newRow["Description"] = descriptionTextBox.Text.Count() == 0 ? null : descriptionTextBox.Text;
            newRow["Email"] = e_mailTextBox.Text.Count() == 0 ? null : e_mailTextBox.Text;
            newRow["CompletedProjects"] = completedProjectsTextBox.Text.Count() == 0 ? null : completedProjectsTextBox.Text;
            newRow["Rate"] = rateTextBox.Text.Count() == 0 ? null : rateTextBox.Text;
            if(partnershipCheckBox.Checked == true)
            {
                newRow["PartnershipProgram"] = true;
            }
            else
            {
                newRow["PartnershipProgram"] = false;
            }
            newRow["District"] = TreeViewCells.district_cell;
            newRow["Services"] = TreeViewCells.services_cell;

            try
            {
                table.Rows.Add(newRow);

                DialogResult = System.Windows.Forms.DialogResult.OK;

                DBManager.InsertInformation(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TreeViewCells.services_cell = "";
                TreeViewCells.district_cell = "";
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region TreeView

        private void AfterCheckServicesTreeView(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked,ref TreeViewCells.services_cell);
                }
                if(e.Node.Nodes.Count == 0 && e.Node.Checked == true)
                {
                    TreeViewCells.services_cell += e.Node.Text + ", ";
                }
            }
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked,ref string choosen_words)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked, ref choosen_words);
                }
                if (node.Nodes.Count == 0 && node.Checked == true)
                {
                    choosen_words += node.Text + ", ";
                }
            }
        }

        //private void FindAllCheckedNodes(TreeNode treeNode, string columnFilter)
        //{
        //    if (treeNode.Checked == true)
        //    {
        //        string to_add = columnFilter + "LIKE '" + treeNode.Text + "%' OR";
        //        RowFilter += to_add;
        //    }
        //    foreach (TreeNode node in treeNode.Nodes)
        //    {
        //        if (node.Checked == true)
        //        {
        //            string to_add = columnFilter + "LIKE '" + node.Text + "%' OR";
        //            RowFilter += to_add;
        //        }
        //        if (node.Nodes.Count > 0)
        //        {
        //            // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
        //            this.FindAllCheckedNodes(node, columnFilter);
        //        }
        //    }
        //    if (RowFilter.Length > 0)
        //    {
        //        RowFilter = RowFilter.Remove(RowFilter.LastIndexOf("OR"), 2);
        //    }
        //}


        private void AfterCheckDistrictTreeView(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked, ref TreeViewCells.district_cell);
                }
                if (e.Node.Nodes.Count == 0 && e.Node.Checked == true)
                {
                    TreeViewCells.district_cell += e.Node.Text + ", ";
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
    }

    public static class TreeViewCells
    {
        public static string services_cell = "";
        public static string district_cell = "";
    }

}
