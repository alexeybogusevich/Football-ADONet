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
    public partial class AddPresidentForm : Form
    {
        public AddPresidentForm()
        {
            InitializeComponent();
            presidentsTableAdapter1.Fill(footballDataSet1.PRESIDENTS);
        }

        private void AddPresidentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.HEADCOACHES". При необходимости она может быть перемещена или удалена.
            this.hEADCOACHESTableAdapter.Fill(this.footballDataSet1.HEADCOACHES);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presidentsTableAdapter1.Update(footballDataSet1.PRESIDENTS);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewPresidents.CurrentRow.Cells["prIDDataGridViewTextBoxColumn"].Value;
                int c_count = (int)queriesTableAdapter1.ScalarQueryPresidentsINClubs(id);

                if (c_count == 0)
                {
                    pRESIDENTSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Ця людина є президентом клубу!\n" + "Видалення неможливе.");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації!");
            }
        }
    }
}
