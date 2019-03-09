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
    public partial class AddHeadcoachForm : Form
    {
        public AddHeadcoachForm()
        {
            InitializeComponent();
            headcoachesTableAdapter1.Fill(footballDataSet1.HEADCOACHES);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            headcoachesTableAdapter1.Update(footballDataSet1.HEADCOACHES);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewHeadcoaches.CurrentRow.Cells["hCIDDataGridViewTextBoxColumn"].Value;
                int c_count = (int)queriesTableAdapter1.ScalarQueryHeadcoachesINClubs(id);

                if (c_count == 0)
                {
                    hEADCOACHESBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Ця людина є головним тренером клубу!\n" + "Видалення неможливе.");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації!");
            }
        }
    }
}
