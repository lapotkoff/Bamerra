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
using Bamerra.Commands;

namespace Bamerra
{
    public partial class LogAdminPage : Form
    {
        private byte counter = 3;
        private byte failedpasswords = 0;
        private string connection_string = Properties.Settings.Default.BamerraConnectionString;
        // string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Valik\Desktop\Bamerra\Bamerra\Bamerra.mdf;Integrated Security=True;Connect Timeout=30";


        public LogAdminPage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void SignInAdminButton_Click(object sender, EventArgs e)
        {
            string command = "Select count(*) from AdminPasswords Where AdmPasswordValue='" + PasswordTextBox.Text + "' AND Flag='TRUE'";
            using (SqlConnection sql_connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter(command, sql_connection);
                DataTable data_table = new DataTable();
                sql_data_adapter.Fill(data_table);
                if (data_table.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    AdminRightsMainPage admpage = new AdminRightsMainPage();
                    admpage.ShowDialog();
                }
                else
                {
                    counter--;
                    MessageBox.Show("Please check your name and password!");
                    warningLabel.Text = string.Format("У вас залишилось {0} спроб, будьте уважніші", counter);

                    if(counter == 0 && failedpasswords == 0)
                    {
                        failedpasswords++;
                        warningLabel.Text = string.Format("Ви втратили можливість вводити PIN1!");

                        DBManager.changeflag("AdminPasswords", "AdmPasswordID", 1, "FALSE");

                        pinPukLabel.Text = string.Format("PIN2:");
                        counter = 3;
                    }
                    else if(counter == 0 && failedpasswords == 1)
                    {
                        failedpasswords++;
                        warningLabel.Text = string.Format("Ви втратили можливість вводити PIN2!");
                        DBManager.changeflag("AdminPasswords", "AdmPasswordID", 2, "FALSE");
                        pinPukLabel.Text = string.Format("PUK1:");
                        counter = 3;
                    }
                    else if(counter == 0 && failedpasswords == 2)
                    {
                        failedpasswords++;
                        warningLabel.Text = string.Format("Ви втратили можливість вводити PUK1!");
                        DBManager.changeflag("AdminPasswords", "AdmPasswordID", 3, "FALSE");
                        pinPukLabel.Text = string.Format("PUK2:");
                        counter = 3;
                    }
                    else if(counter == 0 && failedpasswords == 3)
                    {
                        warningLabel.Text = string.Format("На жаль, ваші дії сприймаються програмою як зловмисницькі, саме тому ми змушені заборонити вам доступ до ресурсів.");
                        DBManager.changeflag("AdminPasswords", "AdmPasswordID", 4, "FALSE");
                        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        System.Threading.Thread.Sleep(7000);
                        Application.Exit();
                    }
                }
            }
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Ви дійсно хочете вийти?", "Bamerra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void LogAdminPage_FormClosing(object sender, FormClosingEventArgs e)
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
