using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmaceutica.REPORTES;
using Farmaceutica.REPORTES.ConsultasDiseño;

namespace Farmaceutica.PRESENTACION
{
    public partial class PantallaDelGerente : Form
    {
        public PantallaDelGerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 c1 = new Form1();
            c1.ShowDialog();

        }

        private void PantallaDelGerente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 c2 = new Form2();
            c2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 c3 = new Form3();
            c3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 c4 = new Form4();
            c4.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 c5 = new Form5();
            c5.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 c6 = new Form6();
            c6.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 c7 = new Form7();
            c7.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 c8 = new Form8();
            c8.ShowDialog();

        }
    }
}
