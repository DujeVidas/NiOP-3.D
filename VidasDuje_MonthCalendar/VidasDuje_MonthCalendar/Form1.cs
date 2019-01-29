using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidasDuje_MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mC1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = mC1.SelectionEnd - mC1.SelectionStart;

            if (ts.Days < 1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
                return;
            }

            MessageBox.Show("Rezervirali ste usluge u trajanju od " + ts.Days.ToString() + " dana.", "Rezervacija");
            MessageBox.Show("Vasa rezervacija počinje " + mC1.SelectionStart.ToShortDateString() + " a završava se " + mC1.SelectionEnd.ToShortDateString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_Programu prg = new O_Programu();
            prg.Show();
        }
    }
}
