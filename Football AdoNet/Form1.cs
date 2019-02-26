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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pLAYERSTableAdapter.Fill(footballDataSet.PLAYERS);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
