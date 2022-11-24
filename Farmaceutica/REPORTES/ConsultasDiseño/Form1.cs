using Farmaceutica.Datos;
using Farmaceutica.Datos.Implementacion;
using Farmaceutica.Servicios.Implementacion;
using Farmaceutica.Servicios.interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmaceutica.REPORTES.ConsultasDiseño
{
    
    public partial class Form1 : Form
    {
        
        private IServicio servicio;
        public Form1()
        {
            InitializeComponent();
            servicio = new Servicio();
            CargarSucursales();




        }

        private void CargarSucursales()
        {
            cboSucursal.DataSource = servicio.ObtenerSucursales();
            cboSucursal.DisplayMember = "NombreSucursal";
            cboSucursal.ValueMember = "IdSucursal";
            ///OJO!!! ES EL NOMBRE DE LA VARIABLE QUE SE IGUALA CON LO DE LA BASE!!!!
            ///el display y el value se asigna el nombre de la property del mapeo
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.pa_mas_vendidos_x_sucursalTableAdapter.Fill(this.dSConsulta1.pa_mas_vendidos_x_sucursal, dtpFechaInicio.Value, dtpFechaFin.Value, Convert.ToInt32(cboSucursal.SelectedValue));

            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void dtpFechaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnConsultar_Click(sender, e);//llama al evento click del boton
            }
        }

        private void cboSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnConsultar_Click(sender, e);//llama al evento click del boton
            }
        }

        private void dtpFechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnConsultar_Click(sender, e);//llama al evento click del boton
            }
        }
    }
}
