using Farmaceutica.Dominio;
using Farmaceutica.Http;
using Farmaceutica.Servicios.Implementacion;
using Farmaceutica.Servicios.interfaz;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmaceutica.Datos.Implementacion;
using Front.Entity;
using Farmaceutica.Dominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Farmaceutica.PRESENTACION
{
    public partial class frmConsultarFacturas : Form
    {
        
        private List<Facturas> listafac;
        private Facturas factura;
        
        public frmConsultarFacturas()
        {
            InitializeComponent();
            listafac=new List<Facturas>();
            factura = new Facturas();
 

        }
        private void frmConsultarFacturas_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            dgvFacturas.Rows.Clear();

            string url = "http://localhost:5140/facturas";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Facturas>>(resultado);


            foreach (Facturas f in lista)
            {
                dgvFacturas.Rows.Add
                    (new object[] {
                    f.IdFactura,f.FechaFactura,f.IdEmpleadoFactura.NombreCompleto,
                    f.IdFormasPagoFactura.DescripcionFP,f.IdClienteFacturas.NombreCompleto,
                    f.IdSucursalFactura.NombreSucursal }
                    );
            }

        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.CurrentCell.ColumnIndex == 6)
            {
                frmPDF pdf = new frmPDF();                
                DataGridViewRow llenar = dgvFacturas.Rows[e.RowIndex];
                pdf.txtFactura.Text = llenar.Cells["ColIdFactura"].Value.ToString();
                pdf.dtpFecha.Text = llenar.Cells["ColFecha"].Value.ToString();
                pdf.txtSucursal.Text = llenar.Cells["ColSucursal"].Value.ToString();
                pdf.txtEmpleado.Text = llenar.Cells["ColEmpleado"].Value.ToString();
                pdf.txtCliente.Text = llenar.Cells["ColCliente"].Value.ToString();
                pdf.txtFormaPago.Text = llenar.Cells["ColFormaPago"].Value.ToString();
                
                pdf.ShowDialog();
                
            }
        }

        private async void btnConsultar_Click_1(object sender, EventArgs e)
        {
            dgvFacturas.Rows.Clear();

            string url = "http://localhost:5140/facturas";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Facturas>>(resultado);


            foreach (Facturas f in lista)
            {
                dgvFacturas.Rows.Add
                    (new object[] {
                    f.IdFactura,f.FechaFactura,f.IdEmpleadoFactura.NombreCompleto,
                    f.IdFormasPagoFactura.DescripcionFP,f.IdClienteFacturas.NombreCompleto,
                    f.IdSucursalFactura.NombreSucursal }
                    );
            }

        }
    }
}
