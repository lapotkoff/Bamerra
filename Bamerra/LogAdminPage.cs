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
        private byte counter = 3;
        private byte failedpasswords = 0;

        public LogAdminPage()
        {
            InitializeComponent();
        }

        private void SignInAdminButton_Click(object sender, EventArgs e)
        {
            //string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Valik\Desktop\Bamerra\Bamerra\Bamerra.mdf;Integrated Security=True;Connect Timeout=30";
            string connection_string = Properties.Settings.Default.BamerraConnectionString;
            string command = "Select count(*) from AdminPasswords Where AdmPasswordValue='" + PasswordTextBox.Text + "'";
            using (SqlConnection sql_connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter(command, sql_connection);
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
                    counter--;
                    MessageBox.Show("Please check your name and password!");
                    warningLabel.Text = string.Format("У вас залишилось {0} спроб, будьте уважніші", counter);

                    //подумати над цим!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    if(counter == 0 && failedpasswords == 0)
                    {
                        failedpasswords++;
                        warningLabel.Text = string.Format("Ви втратили можливість вводити PIN1!");
                        //чи треба видаляти з бази pin1?
                        pinPukLabel.Text = string.Format("PIN2:");
                        counter = 3;
                    }
                    else if(counter == 0 && failedpasswords == 1)
                    {
                        failedpasswords++;
                        warningLabel.Text = string.Format("Ви втратили можливість вводити PIN2!");
                        //чи треба видаляти з бази pin1?
                        pinPukLabel.Text = string.Format("PUK1:");
                        counter = 3;
                    }
                    else if(counter == 0 && failedpasswords == 2)
                    {
                        failedpasswords++;
                        warningLabel.Text = string.Format("Ви втратили можливість вводити PUK1!");
                        //чи треба видаляти з бази pin1?
                        pinPukLabel.Text = string.Format("PUK2:");
                        counter = 3;
                    }
                    else if(counter == 0 && failedpasswords == 3)
                    {
                        warningLabel.Text = string.Format("На жаль, ваші дії сприймаються програмою як зловмисницькі, саме тому ми змушені заборонити вам доступ до ресурсів.");
                        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        System.Threading.Thread.Sleep(7000);
                        Application.Exit();
                    }
                }
            }
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
