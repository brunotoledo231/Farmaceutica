using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmaceutica.REPORTES.ConsultasDiseño
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSConsulta1.Consulta6' Puede moverla o quitarla según sea necesario.
            this.consulta6TableAdapter.Fill(this.dSConsulta1.Consulta6);

            this.reportViewer1.RefreshReport();
        }
    }
}
