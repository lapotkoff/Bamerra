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
    public partial class UserRightsMainPage : Form
    {
        private string connection_string = Properties.Settings.Default.BamerraConnectionString;


        public UserRightsMainPage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void UserRightsMainPage_Load(object sender, EventArgs e)
        {
            this.informationTableAdapter.Fill(this.bamerraDataSet.Information);
            this.informationTableAdapter.Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DBManager.ConfigureinformationAdapter(this.informationTableAdapter.Adapter);
            this.informationTableAdapter.Adapter.FillSchema(this.bamerraDataSet.Information, SchemaType.Mapped);
            this.bamerraDataSet.Information.Columns[0].AutoIncrementSeed = 1;
            this.bamerraDataSet.Information.Columns[0].AutoIncrementStep = 1;
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Ви дійсно хочете вийти?", "Bamerra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void UserRightsMainPage_FormClosing(object sender, FormClosingEventArgs e)
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
