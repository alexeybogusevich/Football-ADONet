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
    public partial class FormFootball : Form
    {
        public FormFootball()
        {
            InitializeComponent();
            pLAYERSTableAdapter.Fill(footballDataSet.PLAYERS);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.T_TYPES". При необходимости она может быть перемещена или удалена.
            this.t_TYPESTableAdapter.Fill(this.footballDataSet.T_TYPES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.ASSOCIATIONS". При необходимости она может быть перемещена или удалена.
            this.aSSOCIATIONSTableAdapter.Fill(this.footballDataSet.ASSOCIATIONS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.TOURNAMENTS". При необходимости она может быть перемещена или удалена.
            this.tOURNAMENTSTableAdapter.Fill(this.footballDataSet.TOURNAMENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.PRESIDENTS". При необходимости она может быть перемещена или удалена.
            this.pRESIDENTSTableAdapter.Fill(this.footballDataSet.PRESIDENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.LEAGUES". При необходимости она может быть перемещена или удалена.
            this.lEAGUESTableAdapter.Fill(this.footballDataSet.LEAGUES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.HEADCOACHES". При необходимости она может быть перемещена или удалена.
            this.hEADCOACHESTableAdapter.Fill(this.footballDataSet.HEADCOACHES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.CITIES". При необходимости она может быть перемещена или удалена.
            this.cITIESTableAdapter.Fill(this.footballDataSet.CITIES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.POSITIONS". При необходимости она может быть перемещена или удалена.
            this.pOSITIONSTableAdapter.Fill(this.footballDataSet.POSITIONS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.CLUBS". При необходимости она может быть перемещена или удалена.
            this.cLUBSTableAdapter.Fill(this.footballDataSet.CLUBS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.COUNTRIES". При необходимости она может быть перемещена или удалена.
            this.cOUNTRIESTableAdapter.Fill(this.footballDataSet.COUNTRIES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.PLAYERS". При необходимости она может быть перемещена или удалена.
            this.pLAYERSTableAdapter.Fill(this.footballDataSet.PLAYERS);

        }

        private void buttonSavePlayers_Click(object sender, EventArgs e)
        {
            pLAYERSTableAdapter.Update(footballDataSet.PLAYERS);
        }

        private void buttonDeletePlayers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Буде також видалено рейтингову картку гравця!"); ////////////////
            int id = (int)dataGridViewPlayers.CurrentRow.Cells["pIDDataGridViewTextBoxColumn"].Value;
            queriesTableAdapter1.DeleteQueryFIFA_RATINGofThePLAYER(id);
            pLAYERSBindingSource.RemoveCurrent();
        }

        private void buttonSaveClubs_Click(object sender, EventArgs e)
        {
            cLUBSTableAdapter.Update(footballDataSet.CLUBS);
        }

        private void buttonDeleteClubs_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClubs.CurrentRow.Cells["cIDDataGridViewTextBoxColumn"].Value;
                int c_count = (int)queriesTableAdapter1.ScalarQueryClubsInPlayers(id);

                if (c_count == 0)
                {
                    cLUBSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("У вашому клубі є гравці!\n" + "Видалення неможливе.");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tOURNAMENTSTableAdapter.Update(footballDataSet.TOURNAMENTS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewTournaments.CurrentRow.Cells["tIDDataGridViewTextBoxColumn"].Value;
                int t_count = (int)queriesTableAdapter1.ScalarQueryTournamentsInT_CLUBS(id);

                if (t_count == 0)
                {
                    tOURNAMENTSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("У змаганні беруть участь одна або більше команд!\n" + "Видалення неможливе.");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації!");
            }
        }

        private void buttonSearchPlayers_Click(object sender, EventArgs e)
        {
            SearchPlayersForm searchForm = new SearchPlayersForm();
            searchForm.Show();
        }

        private void buttonSearchClubs_Click(object sender, EventArgs e)
        {
            SearchClubsForm searchForm = new SearchClubsForm();
            searchForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTournamentsForm searchForm = new SearchTournamentsForm();
            searchForm.Show();
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            AddCountryForm addForm = new AddCountryForm();
            addForm.FormClosed += addCountryForm_Closed; 
            addForm.Show();
        }

        private void addCountryForm_Closed(object sender, FormClosedEventArgs e)
        {
            cOUNTRIESTableAdapter.Fill(footballDataSet1.COUNTRIES);
            cOUNTRIESTableAdapter.Update(footballDataSet1.COUNTRIES);
        }

        private void buttonAddClubs_Click(object sender, EventArgs e)
        {
            AddCityForm addForm = new AddCityForm();
            addForm.Show();
        }

        private void buttonAddHeadcoaches_Click(object sender, EventArgs e)
        {
            AddHeadcoachForm addForm = new AddHeadcoachForm();
            addForm.Show();
        }

        private void buttonAddPresident_Click(object sender, EventArgs e)
        {
            AddPresidentForm addForm = new AddPresidentForm();
            addForm.Show();
        }
    }
}
