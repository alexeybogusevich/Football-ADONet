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
    public partial class SearchClubsForm : Form
    {
        public SearchClubsForm()
        {
            InitializeComponent();
        }

        private void buttonSearchClubs_Click(object sender, EventArgs e)
        {
            string findCountry = (CStextBoxCountry.Text != "") ? "%" + CStextBoxCountry.Text + "%" : "";
            string findTournament = (CStextBoxTournament.Text != "") ? "%" + CStextBoxTournament.Text + "%" : "";
            int findDate = (CStextBoxDate.Text != "") ? Convert.ToInt32(CStextBoxDate.Text) : 0;

            if (CStextBoxDate.Text == "" && CStextBoxTournament.Text == "" && CStextBoxCountry.Text == "")
            {
                MessageBox.Show("Оберіть критерії пошуку!");
                return;
            }
            else
            {
                if(CStextBoxCountry.Text != "" && CStextBoxDate.Text != "" && CStextBoxTournament.Text != "")
                {
                    dtSearchClubsTableAdapter1.FillByCountryANDDateANDTournament(footballDataSet1.DTSearchClubs, findCountry, findDate, findTournament);
                }
                else if(CStextBoxCountry.Text != "" && CStextBoxDate.Text != "")
                {
                    dtSearchClubsTableAdapter1.FillByCountryANDDate(footballDataSet1.DTSearchClubs, findCountry, findDate);
                }
                else if(CStextBoxCountry.Text != "" && CStextBoxTournament.Text != "")
                {
                    dtSearchClubsTableAdapter1.FillByCountryANDTournament(footballDataSet1.DTSearchClubs, findCountry, findTournament);
                }
                else if(CStextBoxTournament.Text != "" && CStextBoxDate.Text != "")
                {
                    dtSearchClubsTableAdapter1.FillByDateANDTournament(footballDataSet1.DTSearchClubs, findDate, findTournament);
                }
                else if(CStextBoxCountry.Text != "")
                {
                    dtSearchClubsTableAdapter1.FillByCountry(footballDataSet1.DTSearchClubs, findCountry);
                }
                else if(CStextBoxDate.Text != "")
                {
                    dtSearchClubsTableAdapter1.FillByDate(footballDataSet1.DTSearchClubs, findDate);
                }
                else if(CStextBoxTournament.Text != "")
                {
                    dtSearchClubsTableAdapter1.FillByTournament(footballDataSet1.DTSearchClubs, findTournament);
                }
            }
        }
    }
}
