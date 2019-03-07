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
    public partial class SearchPlayersForm : Form
    {
        public SearchPlayersForm()
        {

            InitializeComponent();
        }

        private void buttonSearchPlayers_Click(object sender, EventArgs e)
        {
            string findCountry = (PStextBoxCountry.Text != "") ? "%" + PStextBoxCountry.Text + "%" : "";
            string findClub = (PStextBoxClub.Text != "") ? "%" + PStextBoxClub.Text + "%" : "";
            int findAge = (PStextBoxAge.Text != "") ? Convert.ToInt32(PStextBoxAge.Text) : 0;

            if (PStextBoxAge.Text == "" && PStextBoxClub.Text == "" && PStextBoxCountry.Text == "")
            {
                MessageBox.Show("Виберіть критерії пошуку!");
                return;
            }
            else
            {
                if(PStextBoxAge.Text != "" && PStextBoxClub.Text != "" && PStextBoxCountry.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByAgeANDCountryANDClub(footballDataSet1.DTSearchPlayers, findClub, findAge, findCountry);
                }
                else if (PStextBoxAge.Text != "" && PStextBoxClub.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByAgeANDClub(footballDataSet1.DTSearchPlayers, findClub, findAge);
                }
                else if (PStextBoxClub.Text != "" && PStextBoxCountry.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByCountryANDClub(footballDataSet1.DTSearchPlayers, findClub, findCountry);
                }
                else if (PStextBoxAge.Text != "" && PStextBoxCountry.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByAgeANDCountry(footballDataSet1.DTSearchPlayers, findCountry, findAge);
                }
                else if (PStextBoxAge.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByAge(footballDataSet1.DTSearchPlayers, findAge);
                }
                else if (PStextBoxClub.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByClub(footballDataSet1.DTSearchPlayers, findClub);
                }
                else if (PStextBoxCountry.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByCountry(footballDataSet1.DTSearchPlayers, findCountry);
                }
            }

        }
    }
}
