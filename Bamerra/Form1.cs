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
            CenterToScreen();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            LogAdminPage log_admin_page = new LogAdminPage();
            this.Hide();
            log_admin_page.ShowDialog();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            LogUserPage log_userpage = new LogUserPage();
            this.Hide();
            log_userpage.ShowDialog();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
