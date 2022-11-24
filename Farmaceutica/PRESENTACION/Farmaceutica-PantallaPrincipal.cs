using Farmaceutica.PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Farmaceutica
{
    public partial class PantallaPrincipal : Form
    {
        Login login;

        public PantallaPrincipal()
        {
            InitializeComponent();
           
        }

        

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            login = new Login();
            login.TopLevel = false;
            panel2.Controls.Add(login);
            login.Show();


        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
              
            }
        }

        private void cOMPRASTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FrmLoginGerente loginG = new FrmLoginGerente();
            loginG.TopLevel = false;
            panel2.Controls.Add(loginG);
            loginG.Show();
            
            
        }
        
        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.TopLevel = false;
            panel2.Controls.Add(acercaDe);
            acercaDe.Show();
            acercaDe.Focus();
        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarFacturas frmFacturas = new frmConsultarFacturas();
            //frmFacturas.TopLevel = false;
            //panel2.Controls.Add((frmConsultarFacturas)frmFacturas);
            frmFacturas.ShowDialog();
            frmFacturas.Focus();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            ABMProducto prod = new ABMProducto();
            //prod.TopLevel = false;
            //panel2.Controls.Add(prod);
            prod.ShowDialog();
            prod.Focus();
        }

        private void sOPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Se cerrara sesion", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes)
            login.Close();
      
        }
    }
}
