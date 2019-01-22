using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidasDujeImageList
{
    public partial class Form1 : Form
    {
        public int brojac = 1;
        public Form1()
        {
            InitializeComponent();
            pBox.Image = imgList.Images[0];
        }

        private void pBox_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(brojac % 2 == 0)
            {
                pBox.Image = imgList.Images[0];
            }
            else
            {
                pBox.Image = imgList.Images[1];
            }
            brojac++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_Programu prog = new O_Programu();
            prog.Show();
        }
    }
}
