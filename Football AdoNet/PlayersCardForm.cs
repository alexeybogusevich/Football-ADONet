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
    public partial class PlayersCardForm : Form
    {
        private int id;

        public PlayersCardForm()
        {
            InitializeComponent();
        }

        public PlayersCardForm(int id)
        {
            InitializeComponent();
            this.id = id;
            fIFA_RATINGSTableAdapter.FillByPlayerID(footballDataSet.FIFA_RATINGS, id);
            playersTableAdapter1.Fill(footballDataSet.PLAYERS);
            clubsTableAdapter1.Fill(footballDataSet.CLUBS);
            countriesTableAdapter1.Fill(footballDataSet.COUNTRIES);
            GetPlayer();
        }

        private void GetPlayer()
        {
            var playerInfo = footballDataSet.PLAYERS.Where(x => x.P_ID == id).FirstOrDefault();
            var playerRating = footballDataSet.FIFA_RATINGS.Where(x => x.FR_PlayerID == id).FirstOrDefault();
            
            if (playerInfo == null)
            {
                MessageBox.Show($"Гравець з id = {id} відсутній в базі даних!", "Помилка");
                this.Close();
            }

            if(playerRating == null)
            {
                fIFA_RATINGSTableAdapter.InsertQuery(id, 0, 0, 0, 0, 0, 0);
                fIFA_RATINGSTableAdapter.Fill(footballDataSet.FIFA_RATINGS);
                playerRating = footballDataSet.FIFA_RATINGS.Where(x => x.FR_PlayerID == id).FirstOrDefault();
            }

            var playerCountry = (footballDataSet.COUNTRIES.Where(x => x.CNTRY_ID == playerInfo.P_CountryID).FirstOrDefault());

            if (playerCountry == null)
            {
                MessageBox.Show($"Країна з id = {playerInfo.P_CountryID} відсутня в базі даних!", "Помилка");
                this.Close();
            }

            var playerClub = (footballDataSet.CLUBS.Where(x => x.C_ID == playerInfo.P_ClubID)).FirstOrDefault();

            if (playerClub == null)
            {
                MessageBox.Show($"Клуб з id = {playerInfo.P_ClubID} відсутній в базі даних!", "Помилка");
                this.Close();
            }

            comboBoxDEF.Text = playerRating.FR_Defense.ToString();
            comboBoxDRI.Text = playerRating.FR_Dribbling.ToString();
            comboBoxPAC.Text = playerRating.FR_Pace.ToString();
            comboBoxPHY.Text = playerRating.FR_Physical.ToString();
            comboBoxSHO.Text = playerRating.FR_Shooting.ToString();
            comboBoxPAS.Text = playerRating.FR_Passing.ToString();

            //лейбли
            labelName.Text = playerInfo.P_Name;
            labelSummary.Text = GetSummary();
            labelCountry.Text = playerCountry.CNTRY_Name;
            labelClub.Text = playerClub.C_Name;

        }

        private string GetSummary()
        {
            return ((Convert.ToInt32(comboBoxDEF.Text) + Convert.ToInt32(comboBoxDRI.Text)
                + Convert.ToInt32(comboBoxPAC.Text) + Convert.ToInt32(comboBoxPAS.Text)
                + Convert.ToInt32(comboBoxPHY.Text) + Convert.ToInt32(comboBoxSHO.Text)) / 6).ToString();
        }

        private void PlayersCardForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet.FIFA_RATINGS". При необходимости она может быть перемещена или удалена.
            //this.fIFA_RATINGSTableAdapter.Fill(this.footballDataSet.FIFA_RATINGS);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            fIFA_RATINGSTableAdapter.UpdateQuery(Convert.ToInt32(comboBoxPAC.Text), Convert.ToInt32(comboBoxSHO.Text),
                Convert.ToInt32(comboBoxPAS.Text), Convert.ToInt32(comboBoxDRI.Text),
                Convert.ToInt32(comboBoxDEF.Text), Convert.ToInt32(comboBoxPHY.Text), id);
            labelSummary.Text = GetSummary();
        }
    }
}
