using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidasDujePictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
                pBox.Visible = true;
        }

        private void pBox_Click(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_Programu prog = new O_Programu();
            prog.Show();
        }
    }
}
