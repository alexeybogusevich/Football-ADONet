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
    public partial class AddCityForm : Form
    {
        public AddCityForm()
        {
            InitializeComponent();
            citiesTableAdapter1.Fill(footballDataSet1.CITIES);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            citiesTableAdapter1.Update(footballDataSet1.CITIES);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewAddCity.CurrentRow.Cells["cTIDDataGridViewTextBoxColumn"].Value;
                int c_count = (int)queriesTableAdapter1.ScalarQueryCitiesINClubs(id);

                if (c_count == 0)
                {
                    cITIESBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("У вашому місті знаходиться один або більше клубів!\n" + "Видалення неможливе.");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації!");
            }
        }

        private void AddCityForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.COUNTRIES". При необходимости она может быть перемещена или удалена.
            this.cOUNTRIESTableAdapter.Fill(this.footballDataSet1.COUNTRIES);

        }

        private void dataGridViewAddCity_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Порушення правил заповнення таблиці!\nРядок, що не відповідає вимогам форматування, буде видалено!");
        }
    }
}
