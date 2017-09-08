using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bamerra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            LogAdminPage log_admin_page = new LogAdminPage();
            log_admin_page.Show();
            this.Hide();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            UserRightsMainPage usermainpage = new UserRightsMainPage();
            usermainpage.Show();
            this.Hide();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
