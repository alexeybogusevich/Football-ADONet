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
            string findPosition = (PStextBoxPosition.Text != "") ? "%" + PStextBoxPosition.Text + "%" : "";

            if (PStextBoxPosition.Text == "" && PStextBoxClub.Text == "" && PStextBoxCountry.Text == "")
            {
                MessageBox.Show("Оберіть критерії пошуку!");
                return;
            }
            else
            {
                if(PStextBoxPosition.Text != "" && PStextBoxClub.Text != "" && PStextBoxCountry.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByPositionANDCountryANDClub(footballDataSet1.DTSearchPlayers, findPosition, findCountry, findClub);
                }
                else if (PStextBoxPosition.Text != "" && PStextBoxClub.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByPositionANDClub(footballDataSet1.DTSearchPlayers, findPosition, findClub);
                }
                else if (PStextBoxClub.Text != "" && PStextBoxCountry.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByCountryANDClub(footballDataSet1.DTSearchPlayers, findClub, findCountry);
                }
                else if (PStextBoxPosition.Text != "" && PStextBoxCountry.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByPositionANDCountry(footballDataSet1.DTSearchPlayers, findCountry, findPosition);
                }
                else if (PStextBoxPosition.Text != "")
                {
                    dtSearchPlayersTableAdapter1.FillByPosition(footballDataSet1.DTSearchPlayers, findPosition);
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
