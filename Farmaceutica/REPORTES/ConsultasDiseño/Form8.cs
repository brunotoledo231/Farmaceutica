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
    public partial class Form8 : Form
    {
        public IServicio servicio;
        public Form8()
        {
            InitializeComponent();
            servicio = new Servicio();
            CargarComboMes();

        }

        private void CargarComboMes()
        {
            cboMes.DataSource = servicio.ObtenerMes();
            cboMes.ValueMember = "IdMes";
            cboMes.DisplayMember = "NombreMes";
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cboMes.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.consulta8TableAdapter.Fill(this.dSConsulta1.Consulta8, Convert.ToInt32(cboMes.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void cboMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                button1_Click(sender, e);//llama al evento click del boton
            }
        }
    }
}
