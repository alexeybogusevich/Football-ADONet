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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFormFootball_Click(object sender, EventArgs e)
        {
            FormFootball formFootball = new FormFootball();
            this.Visible = false;
            formFootball.FormClosed += FormFootball_Closed;
            formFootball.ShowDialog(this);
            formFootball.Dispose();
        }

        private void FormFootball_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AB 2019.\n" +
                "Версія 1.0.1.\n" +
                "Програмна реалізація предметної області <Футбольний світ>. \n\n" +
                "Використані технології: ADO.Net, .Net Framework, Windows Forms.\n" +
                "Користувач має змогу напряму працювати з базою даних предметної області <Футбольний світ>:\n" +
                "\t додавати, видаляти, вносити зміни, виконувати пошук за ключовими словами. \n\n" +
                "Основні об'єкти предметної області: футбольні гравці, клуби та змагання.", "Довідка");
        }

        private void buttonNeural_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В розробці...", "Додатково");
        }
    }
}
