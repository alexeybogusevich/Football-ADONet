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
    public partial class ClubsTournamentsForm : Form
    {
        private int id;

        public ClubsTournamentsForm()
        {
            InitializeComponent();
            t_CLUBSTableAdapter1.Fill(footballDataSet1.T_CLUBS);
        }

        public ClubsTournamentsForm(int id)
        {
            InitializeComponent();
            this.id = id;
            dTTournamentsClubsTableAdapter.FillByExactTournament(footballDataSet1.DTTournamentsClubs, id);
        }

        private void ClubsTournamentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.TOURNAMENTS". При необходимости она может быть перемещена или удалена.
            this.tOURNAMENTSTableAdapter.Fill(this.footballDataSet1.TOURNAMENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.CLUBS". При необходимости она может быть перемещена или удалена.
            this.cLUBSTableAdapter.Fill(this.footballDataSet1.CLUBS);
        }

        //buttonAdd_Click
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxClubs.SelectedItem != null)
            {
                int x = (int)comboBoxClubs.SelectedValue;
                int tc_count = (int)dTTournamentsClubsTableAdapter.ScalarQueryCount(id, x); ;
                if(tc_count != 0)
                {
                    MessageBox.Show("Дублювання інформації!");
                    return;
                }
                int tmc_id = (int)dTTournamentsClubsTableAdapter.ScalarQueryMax() + 1;
                dTTournamentsClubsTableAdapter.InsertQuery(id, x, tmc_id);
                dTTournamentsClubsTableAdapter.FillByExactTournament(footballDataSet1.DTTournamentsClubs, id);
            }
           else
            {
                MessageBox.Show("Виберіть клуб!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dTTournamentsClubsTableAdapter.DeleteQuery((int)dataGridViewTclubs.CurrentRow.Cells["tMCIDDataGridViewTextBoxColumn"].Value);
            dTTournamentsClubsTableAdapter.FillByExactTournament(footballDataSet1.DTTournamentsClubs, id);
        }

        private void dataGridViewTclubs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }
    }
}
