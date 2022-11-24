using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmaceutica.Datos;
using Farmaceutica.Dominio;
using Farmaceutica.PRESENTACION;

namespace Farmaceutica
{
    public partial class FrmLoginGerente : Form
    {
        private string nombre;
        private string pass;
        private Sesiones login;
        private HelperDB cnn;
        public FrmLoginGerente()
        {
            InitializeComponent();
            login = new Sesiones(nombre, pass);
            cnn = new HelperDB();
        }

        public FrmLoginGerente(string nombre, string pass)
        {
            this.nombre = nombre;
            this.pass = pass;
        }
        private void FrmLoginGerente_Load(object sender, EventArgs e)
        {

        }

        private void btnInicioGerente_Click(object sender, EventArgs e)
        {
            if (txtUsuarioGerente.Text == "")
            {
                { MessageBox.Show("Error de Usuario", "error", MessageBoxButtons.OK); }
            }
            if (txtContraGerente.Text == "")
            {
                { MessageBox.Show("Error de Usuario", "error", MessageBoxButtons.OK); }
            }


            var validLogin = HelperDB.ObtenerInstancia().LoginGerente(txtUsuarioGerente.Text, txtContraGerente.Text);
            if (validLogin == true)
            {
                panelGerente.Controls.Clear();
                //SistemaVentas sv = new SistemaVentas();
                PantallaDelGerente pg = new PantallaDelGerente();

                pg.TopLevel = false;
                panelGerente.Controls.Add(pg);
                pg.Show();
                pg.FormClosed += LogoutGerente;
                this.Show();
                LimpiarPassGerente();

            }
            else { MessageBox.Show("Error de usuario o contrasenia"); LimpiarPassGerente(); }
        }
        private void LogoutGerente(object sender, FormClosedEventArgs e)
        {
            txtContraGerente.Clear();
            txtUsuarioGerente.Clear();
            this.Show();
            txtUsuarioGerente.Focus();

        }

        public void LimpiarPassGerente()
        {
            txtUsuarioGerente.Text = "";
            txtContraGerente.Text = "";
        }

        private void txtContraGerente_TextChanged(object sender, EventArgs e)
        {
            txtContraGerente.PasswordChar = '*';
        }

        private void panelGerente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicioGerente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
         }

        private void txtContraGerente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnInicioGerente_Click(sender, e);//llama al evento click del boton
            }
        }
    }
}