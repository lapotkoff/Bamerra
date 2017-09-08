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

namespace Bamerra
{
    public partial class AdminRightsMainPage : Form
    {

        private string connection_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Valik\Documents\Visual Studio 2013\Projects\2 курс\Bamerra\Bamerra\Bamerra\BamerraData.mdf"";Integrated Security=True;Connect Timeout=30";
        private string command_string = "Select * FROM Info";
        private string RowFilter = "";


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

        public AdminRightsMainPage()
        {
            InitializeComponent();
        }

        private void AdminRightsMainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bamerraDataDataSet2.Info' table. You can move, or remove it, as needed.
            this.infoTableAdapter2.Fill(this.bamerraDataDataSet2.Info);
            this.customersTableAdapter.Fill(this.shopDBDataSet.Customers);
            lblTotal.Text = string.Format("Total rows: {0}", customersBindingSource.Count);
            // TODO: This line of code loads data into the 'bamerraDataDataSet1.Info' table. You can move, or remove it, as needed.
            //this.infoTableAdapter1.Fill(this.bamerraDataDataSet1.Info);
            // TODO: This line of code loads data into the 'shopDBDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.shopDBDataSet.Customers);
            // TODO: This line of code loads data into the 'bamerraDataDataSet.Info' table. You can move, or remove it, as needed.
            //this.infoTableAdapter1.Fill(this.bamerraDataDataSet1.Info);
            //this.customersTableAdapter.Fill(this.shopDBDataSet.Customers);
            //встановлюємо з'єднання, витягуємо всю інфу з таблиці Info і відображаємо
            //колонки в datagridview так як нам треба



            //using (SqlConnection sql_connection = new SqlConnection(connection_string))
            //{
            //    DataSet data_set = new DataSet();

            //    SqlDataAdapter sql_data_adapter = new SqlDataAdapter("Select * FROM Info", sql_connection);

            //    sql_data_adapter.MissingMappingAction = MissingMappingAction.Passthrough;

            //    //заставляємо адаптер даних створювати обмеження для таблиці
            //    sql_data_adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            //    DataTableMapping informationMapping = sql_data_adapter.TableMappings.Add("Table","Info");
            //    var infoColumnMappings = new DataColumnMapping[]
            //    {
            //        new DataColumnMapping("Name", "Ім'я"),          
            //        new DataColumnMapping("Services", "Послуги"),   
            //        new DataColumnMapping("Address","Адреса"),      
            //        new DataColumnMapping("District","Район"),      
            //        new DataColumnMapping("ContactFace","Контактне обличчя"),
            //        new DataColumnMapping("LPR","ЛПР"),
            //        new DataColumnMapping("E-mail","E-mail"),
            //        new DataColumnMapping("Description","Опис"),
            //        new DataColumnMapping("CompletedProjects","Виконані проекти"),
            //        new DataColumnMapping("Rate","Рейтинг")
            //    };
            //    informationMapping.ColumnMappings.AddRange(infoColumnMappings);

            //    sql_data_adapter.Fill(data_set);


            //    advancedDataGridView.DataSource = data_set.Tables[0];
            //    dataGridView1.DataSource = data_set.Tables[0];
              
            //}


            LoadServicesTreeView();
            LoadDistrictTreeView();

            //this.advancedDataGridView.RowHeadersVisible = false;       ?????

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Ви дійсно хочете вийти?", "Bamerra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void firstDataButton_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveFirst();
        }

        private void lastDataButton_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveLast();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void infoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            AddRowWindow addrw = new AddRowWindow();
            addrw.Show();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            FindAllCheckedNodes(DistrictTreeView.TopNode, " District ");
            DataTable filteredtable = new DataTable();
            filteredtable.TableName = "FilteredInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(command_string, connection_string);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(filteredtable);
            DataView filteredView = new DataView(filteredtable, RowFilter, "District", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = filteredView;
            RowFilter = "";
        }

        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            this.infoBindingSource.Filter = this.advancedDataGridView.FilterString;
        }

        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            this.infoBindingSource.Sort = this.advancedDataGridView.SortString;
        }

        private void infoBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotal.Text = string.Format("Total rows: {0}", this.infoBindingSource.Count);
        }
    }
}
