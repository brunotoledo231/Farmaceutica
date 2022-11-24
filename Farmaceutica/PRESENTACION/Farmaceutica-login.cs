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
using Farmaceutica.Datos.Implementacion;
using Farmaceutica.Datos.Interfaz;
using Farmaceutica.Dominio;
using Farmaceutica.Http;
using Newtonsoft.Json;

namespace Farmaceutica
{
    public partial class Login : Form
    {
        //private string nombre;
        //private string pass;
        private Sesiones login;

        public Login()
        {
            InitializeComponent();

            //login = new Sesiones(nombre, pass);
        }

        //public Login(string nombre, string pass)
        //{
        //    this.nombre = nombre;
        //    this.pass = pass;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarSucursalesAsync();
            CargarEmpleadosAsync();

        }
        private async void CargarSucursalesAsync()
        {
            string url = "http://localhost:5140/sucursales";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Sucursales>>(resultado);
            cboSucursalLogin.DataSource = lista;
            cboSucursalLogin.DisplayMember = "NombreSucursal";
            cboSucursalLogin.ValueMember = "IdSucursal";
        }


        private async void CargarEmpleadosAsync()
        {
            string url = "http://localhost:5140/empleados";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Empleados>>(resultado);
            cboUsuario.DataSource = lista;
            cboUsuario.DisplayMember = "NombreCompleto";
            cboUsuario.ValueMember = "IdEmpleado";
        }



        private async void btnInicioEmpleado_Click(object sender, EventArgs e)
        {

            //if (txtContra.Text == "")
            //{
            //    { MessageBox.Show("Error de Usuario", "error", MessageBoxButtons.OK); }
            //}

            login = new Sesiones(Convert.ToString(cboUsuario.Text), txtContra.Text);
            string contenido = JsonConvert.SerializeObject(login);
            string url = "http://localhost:5140/login";
            var resultado = await ClienteSingleton.GetInstancia().PostAsincrono(url, contenido);
            var validLogin = JsonConvert.DeserializeObject<bool>(resultado);
            if (validLogin == true)
            {
                if (ValidarLogin())
                {
                    panelLogin.Controls.Clear();
                    SistemaVentas ventanVentas = new SistemaVentas();
                    ventanVentas.txtS.Text = lblS.Text;
                    ventanVentas.txtU.Text = lblU.Text;
                    ventanVentas.txtIdEmpleado.Text = lblIndexEmpleado.Text;
                    ventanVentas.txtIdSucursal.Text = lblIndexSucursal.Text;

                    ventanVentas.TopLevel = false;
                    panelLogin.Controls.Add(ventanVentas);

                    ventanVentas.Show();
                    ventanVentas.FormClosed += Logout;



                    //panelLogin.Controls.Clear();

                    //ventanVentas.TopLevel = false;//que no sea la ventana sv como principal
                    //panelLogin.Controls.Add(ventanVentas);
                    //ventanVentas.Show();
                    //ventanVentas.FormClosed += Logout;
                    this.Show();
                    LimpiarPass();
                }
            }

            else { MessageBox.Show("Error de usuario o contrasenia"); LimpiarPass(); }



        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContra.Clear();
            txtUsuario.Clear();
            this.Show();
            txtUsuario.Focus();

        }


        public bool ValidarLogin()
        {
            bool ok = false;

            if (cboSucursalLogin.Text == "Sucursal Vacalardo" && cboUsuario.Text == "Lautaro Sosa")
            { ok = true; }
            else
            {
                if (cboSucursalLogin.Text == "Sucursal Sunchales" && cboUsuario.Text == "Lucrecia Alvarez")
                { ok = true; }
                else
                {
                    if (cboSucursalLogin.Text == "Sucursal Granja Grande" && cboUsuario.Text == "Pedro Robles")
                    { ok = true; }
                    else
                    {
                        if (cboSucursalLogin.Text == "Sucursal Gral. Paz" && cboUsuario.Text == "Lorenzo Acosta")
                        { ok = true; }
                        else
                        {
                            if (cboSucursalLogin.Text == "Sucursal Granja Grande" && cboUsuario.Text == "Florencia Perez")
                            { ok = true; }
                            else
                            {
                                if (cboSucursalLogin.Text == "Sucursal Sunchales" && cboUsuario.Text == "Paola Alvarez")
                                { ok = true; }
                                else
                                {
                                    if (cboSucursalLogin.Text == "Sucursal Granja Grande" && cboUsuario.Text == "Franco Gambeti")
                                    { ok = true; }
                                    else
                                    {
                                        if (cboSucursalLogin.Text == "Sucursal Gral. Paz" && cboUsuario.Text == "Estefania Pizarro")
                                        { ok = true; }
                                        else
                                        {
                                            if (cboSucursalLogin.Text == "Sucursal Oncativo" && cboUsuario.Text == "Antonio Ferrero")
                                            { ok = true; }
                                            else
                                            {
                                                if (cboSucursalLogin.Text == "Sucursal Oncativo" && cboUsuario.Text == "Gissel Graciani")
                                                { ok = true; }
                                                else
                                                {
                                                    if (cboSucursalLogin.Text == "Sucursal Paisanita" && cboUsuario.Text == "Gustavo DiTrotta")
                                                    { ok = true; }
                                                    else if (cboSucursalLogin.Text == "Sucursal Paisanita" && cboUsuario.Text == "Roman Olave")
                                                    { ok = true; }
                                                    else
                                                    {
                                                        MessageBox.Show("Usted no trabaja en esa sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        ok = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }





            return ok;
        }

        public void LimpiarPass()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            txtContra.PasswordChar = '*';
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void lblCodGerente_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnInicioEmpleado_Click(sender, e);//llama al evento click del boton
            }
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string u = cboUsuario.Text;
            lblU.Text = u;
        }


        internal void cboSucursalLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void lblS_Click(object sender, EventArgs e)
        {
            string s = cboSucursalLogin.Text;
            lblS.Text = s;
        }

        private void lblU_Click(object sender, EventArgs e)
        {
            string u = cboUsuario.Text;
            lblU.Text = u;
        
        }

        private void lblS_Click_1(object sender, EventArgs e)
        {

        }

        private void cboSucursalLogin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Sucursales osucursales = (Sucursales)cboSucursalLogin.SelectedItem;
            string u = cboSucursalLogin.Text;
            lblS.Text = u;
            lblIndexSucursal.Text = osucursales.IdSucursal.ToString();
           
        }

        private void cboUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Empleados oempleado = (Empleados)cboUsuario.SelectedItem;

            string s = cboUsuario.Text;
            lblU.Text = s;
            lblIndexEmpleado.Text = oempleado.IdEmpleado.ToString();
        }
    }
}
