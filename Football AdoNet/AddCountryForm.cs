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
    public partial class AddCountryForm : Form
    {
        public AddCountryForm()
        {
            InitializeComponent();
            countriesTableAdapter1.Fill(footballDataSet1.COUNTRIES);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            countriesTableAdapter1.Update(footballDataSet1.COUNTRIES);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCountries.CurrentRow.Cells["cNTRYIDDataGridViewTextBoxColumn"].Value;
                int ct_count = (int)queriesTableAdapter1.ScalarQueryCountriesINCities(id);
                int l_count = (int)queriesTableAdapter1.ScalarQueryCountriesINLeagues(id);
                int p_count = (int)queriesTableAdapter1.ScalarQueryCountriesINPlayers(id);

                if (ct_count == 0 && l_count == 0 && p_count == 0)
                {
                    cOUNTRIESBindingSource.RemoveCurrent();
                }
                else if (ct_count != 0 || l_count != 0)
                {
                    MessageBox.Show("У вашій країні знаходиться один або більше клубів!\n" + "Видалення неможливе.");
                }
                else
                {
                    MessageBox.Show("У вашій країні народився один або більше гравців!\n" + "Видалення неможливе.");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації!");
            }
        }
    }
}
