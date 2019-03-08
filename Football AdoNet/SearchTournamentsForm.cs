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
    public partial class SearchTournamentsForm : Form
    {
        public SearchTournamentsForm()
        {
            InitializeComponent();
        }

        private void buttonSearchTournaments_Click(object sender, EventArgs e)
        {
            string findClub = (TStextBoxClub.Text != "") ? "%" + TStextBoxClub.Text + "%" : "";
            string findAssociation = (TStextBoxAssociation.Text != "") ? "%" + TStextBoxAssociation.Text + "%" : "";
            string findType = (TStextBoxType.Text != "") ? "%" + TStextBoxType.Text + "%" : "";

            if (TStextBoxAssociation.Text == "" && TStextBoxClub.Text == "" && TStextBoxType.Text == "")
            {
                MessageBox.Show("Оберіть критерії пошуку!");
                return;
            }
            else
            {
                if(TStextBoxType.Text != "" && TStextBoxClub.Text != "" && TStextBoxAssociation.Text != "")
                {
                    dtSearchTournamentsTableAdapter1.FillByAssociationANDTeamANDType(footballDataSet1.DTSearchTournaments, findAssociation, findType, findClub);
                }
                else if(TStextBoxAssociation.Text != "" && TStextBoxClub.Text != "")
                {
                    dtSearchTournamentsTableAdapter1.FillByAssociationANDTeam(footballDataSet1.DTSearchTournaments, findAssociation, findClub);
                }
                else if(TStextBoxAssociation.Text != "" && TStextBoxType.Text != "")
                {
                    dtSearchTournamentsTableAdapter1.FillByAssociationANDType(footballDataSet1.DTSearchTournaments, findAssociation, findType);
                }
                else if(TStextBoxType.Text != "" && TStextBoxClub.Text != "")
                {
                    dtSearchTournamentsTableAdapter1.FillByTeamANDType(footballDataSet1.DTSearchTournaments, findType, findClub);
                }
                else if(TStextBoxAssociation.Text != "")
                {
                    dtSearchTournamentsTableAdapter1.FillByAssociation(footballDataSet1.DTSearchTournaments, findAssociation);
                }
                else if(TStextBoxClub.Text != "")
                {
                    dtSearchTournamentsTableAdapter1.FillByTeam(footballDataSet1.DTSearchTournaments, findClub);
                }
                else if(TStextBoxType.Text != "")
                {
                    dtSearchTournamentsTableAdapter1.FillByType(footballDataSet1.DTSearchTournaments, findType);
                }
            }
        }
    }
}
