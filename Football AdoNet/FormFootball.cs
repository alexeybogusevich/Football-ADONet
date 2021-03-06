﻿using System;
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
            this.dataGridViewPlayers.Sort(this.dataGridViewPlayers.Columns["pNameDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
            this.dataGridViewClubs.Sort(this.dataGridViewClubs.Columns["cNameDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
            this.dataGridViewTournaments.Sort(this.dataGridViewTournaments.Columns["tNameDataGridViewTextBoxColumn"], ListSortDirection.Ascending);

        }

        private void buttonSavePlayers_Click(object sender, EventArgs e)
        {
            pLAYERSTableAdapter.Update(footballDataSet.PLAYERS);
        }

        private void buttonDeletePlayers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Буде також видалено рейтингову картку гравця!"); 
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
                int ct_count = (int)queriesTableAdapter1.ScalarQueryCLUBSinT_CLUBS(id);

                if (c_count == 0 && ct_count == 0)
                {
                    cLUBSBindingSource.RemoveCurrent();
                }
                else if(ct_count != 0 && c_count == 0)
                {
                    queriesTableAdapter1.DeleteQueryT_Clubs(id);
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
            addForm.ShowDialog(this);
            addForm.Dispose();
        }

        private void addCountryForm_Closed(object sender, FormClosedEventArgs e)
        {
            cOUNTRIESTableAdapter.Fill(footballDataSet.COUNTRIES);
        }

        private void buttonAddClubs_Click(object sender, EventArgs e)
        {
            AddCityForm addForm = new AddCityForm();
            addForm.FormClosed += addCitiesForm_Closed;
            addForm.ShowDialog(this);
            addForm.Dispose();
        }

        private void addCitiesForm_Closed(object sender, FormClosedEventArgs e)
        {
            cITIESTableAdapter.Fill(footballDataSet.CITIES);
        }

        private void buttonAddHeadcoaches_Click(object sender, EventArgs e)
        {
            AddHeadcoachForm addForm = new AddHeadcoachForm();
            addForm.FormClosed += addHeadcoachesForm_Closed;
            addForm.ShowDialog(this);
            addForm.Dispose();
        }

        private void addHeadcoachesForm_Closed(object sender, FormClosedEventArgs e)
        {
            hEADCOACHESTableAdapter.Fill(footballDataSet.HEADCOACHES);
        }

        private void buttonAddPresident_Click(object sender, EventArgs e)
        {
            AddPresidentForm addForm = new AddPresidentForm();
            addForm.FormClosed += addPresidentsForm_Closed;
            addForm.ShowDialog(this);
            addForm.Dispose();
        }

        private void addPresidentsForm_Closed(object sender, FormClosedEventArgs e)
        {
            pRESIDENTSTableAdapter.Fill(footballDataSet.PRESIDENTS);
        }

        private void dataGridViewPlayers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Порушення правил заповнення таблиці!\nРядок, що не відповідає вимогам форматування, буде видалено!", "Помилка");
        }

        private void dataGridViewClubs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Порушення правил заповнення таблиці!\nРядок, що не відповідає вимогам форматування, буде видалено!", "Помилка");
        }

        private void dataGridViewTournaments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Порушення правил заповнення таблиці!\nРядок, що не відповідає вимогам форматування, буде видалено!", "Помилка");
        }

        private void dataGridViewTournaments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridViewTournaments.CurrentRow.Cells["tIDDataGridViewTextBoxColumn"].Value;
                ClubsTournamentsForm tclubsForm = new ClubsTournamentsForm(id);
                tclubsForm.ShowDialog(this);
                tclubsForm.Dispose();
            }
            catch(Exception)
            {
                MessageBox.Show("Помилка переходу до таблиці з командами-учасниками!", "Помилка");
            }
        }

        private void buttonAddLeague_Click(object sender, EventArgs e)
        {
            AddLeagueForm addForm = new AddLeagueForm();
            addForm.FormClosed += addLeagueForm_Closed;
            addForm.ShowDialog(this);
            addForm.Dispose();
        }

        private void addLeagueForm_Closed(object sender, FormClosedEventArgs e)
        {
            lEAGUESTableAdapter.Fill(footballDataSet.LEAGUES);
        }

        private void dataGridViewPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridViewPlayers.CurrentRow.Cells["pIDDataGridViewTextBoxColumn"].Value;
            PlayersCardForm cardForm = new PlayersCardForm(id);
            cardForm.ShowDialog(this);
            cardForm.Dispose();
        }

        private void FormFootball_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Зберегти зміни?", "Програма", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                pLAYERSTableAdapter.Update(footballDataSet.PLAYERS);
                cLUBSTableAdapter.Update(footballDataSet.CLUBS);
                tOURNAMENTSTableAdapter.Update(footballDataSet.TOURNAMENTS);
                this.Dispose();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        private void dataGridViewPlayers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPlayers.CurrentCell.ColumnIndex == 3)
            {
                int number = (int)dataGridViewPlayers.CurrentRow.Cells["pNumberDataGridViewTextBoxColumn"].Value;
                if(number <= 0 || number > 100)
                {
                    MessageBox.Show("Номер гравця має бути в діапазоні від 1 до 100!", "Помилка");
                    dataGridViewPlayers.CurrentRow.Cells["pNumberDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                }
            }
        }

        private void dataGridViewClubs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClubs.CurrentCell.ColumnIndex == 5)
            {
                int founded = (int)dataGridViewClubs.CurrentRow.Cells["cDateOfFoundationDataGridViewTextBoxColumn"].Value;
                if (founded <= 1870 || founded > 2019)
                {
                    MessageBox.Show("Рік заснування неможливий!", "Помилка");
                    dataGridViewClubs.CurrentRow.Cells["cDateOfFoundationDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                }
            }
        }
    }
}
