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
            t_CLUBSTableAdapter1.Fill(footballDataSet1.T_CLUBS);
        }

        private void ClubsTournamentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.TOURNAMENTS". При необходимости она может быть перемещена или удалена.
            this.tOURNAMENTSTableAdapter.Fill(this.footballDataSet1.TOURNAMENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.CLUBS". При необходимости она может быть перемещена или удалена.
            this.cLUBSTableAdapter.Fill(this.footballDataSet1.CLUBS);
            for(int i = 0; i< dataGridViewTclubs.Rows.Count - 1; ++i)
            {
                if ((int)dataGridViewTclubs.Rows[i].Cells["tMCTournamentIDDataGridViewTextBoxColumn"].Value != id)
                {
                    CurrencyManager cManager = dataGridViewTclubs.BindingContext[dataGridViewTclubs.DataSource, dataGridViewTclubs.DataMember] as CurrencyManager;
                    cManager.SuspendBinding();
                    dataGridViewTclubs.Rows[i].Visible = false;
                    cManager.ResumeBinding();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            t_CLUBSTableAdapter1.Update(footballDataSet1.T_CLUBS);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            tCLUBSBindingSource.RemoveCurrent();
        }
    }
}
