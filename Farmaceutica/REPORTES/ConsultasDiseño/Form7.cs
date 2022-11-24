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
    public partial class Form7 : Form
    {
        private IServicio servicio;
        public Form7()
        {
            InitializeComponent();
            servicio = new Servicio();
            CargarTrimestre();


        }

        private void CargarTrimestre()
        {
            cboTrimestre.DataSource = servicio.ObtenerTrimestre();
            cboTrimestre.ValueMember = "IdTrimestre";
            cboTrimestre.DisplayMember = "NombreTrimestre";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSConsulta1.Consulta7' Puede moverla o quitarla según sea necesario.
            //this.consulta7TableAdapter.Fill(this.dSConsulta1.Consulta7, );
            cboTrimestre.SelectedIndex = -1;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.consulta7TableAdapter.Fill(this.dSConsulta1.Consulta7, Convert.ToInt32(cboTrimestre.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void cboTrimestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                button1_Click(sender, e);//llama al evento click del boton
            }
        }
    }
}
