using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidasDujeRichTextBoxDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
             rtb1.LoadFile(@"C:\Users\ASUSvivoBook\Desktop\Tempproba.rtf");
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           rtb1.SaveFile(@"C:\Users\ASUSvivoBook\Desktop\Tempproba.rtf");
            MessageBox.Show("Text Spremljen.");
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {

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
