using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bamerra
{
    public partial class LogAdminPage : Form
    {
        public LogAdminPage()
        {
            InitializeComponent();
        }

        private void SignInAdminButton_Click(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Valik\Documents\BamerraData.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection sql_connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter("Select count(*) from Admins Where AdminName='" + AdminNameTextBox.Text + "' and Password='" + PasswordTextBox.Text + "'", sql_connection);
                DataTable data_table = new DataTable();
                sql_data_adapter.Fill(data_table);
                if (data_table.Rows[0][0].ToString() == "1")
                {
                    AdminRightsMainPage admpage = new AdminRightsMainPage();
                    admpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check your name and password!");
                }
            }
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
