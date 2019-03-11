using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_AdoNet
{
    public partial class AddLeagueForm : Form
    {
        public AddLeagueForm()
        {
            InitializeComponent();
            leaguesTableAdapter1.Fill(footballDataSet1.LEAGUES);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            leaguesTableAdapter1.Update(footballDataSet1.LEAGUES);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            lEAGUESBindingSource.RemoveCurrent();
        }
    }
}
