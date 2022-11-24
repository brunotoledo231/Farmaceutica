using Entity;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmaceutica.PRESENTACION
{
    public partial class frmPDF : Form
    {
        public frmPDF()
        {
            InitializeComponent();
            
        }
        private async void frmPDF_Load(object sender, EventArgs e)
        {
            CargarProductos();
            Deshabilitar(true);
        }

        private void Deshabilitar(bool v)
        {
            txtFactura.Enabled = !v;
            txtEmpleado.Enabled = !v;
            dtpFecha.Enabled = !v;
            txtFormaPago.Enabled = !v;
            txtCliente.Enabled = !v;
            dgvPDF.Enabled = !v;
            txtSucursal.Enabled = !v;
            txtTotalConDescuento.Enabled = !v;
            txtDescuento.Enabled = !v;
        }
        private async void CargarProductos()
        {
            int numero = Convert.ToInt32(txtFactura.Text);

            string url = "http://localhost:5140/detalles?detalle=" + numero;
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Dominio.DetalleFactura>>(resultado);

            //List<Facturas> lst = servicio.ObtenerFacturas();
            dgvPDF.Rows.Clear();

            foreach (Dominio.DetalleFactura df in lista)
            {
                dgvPDF.Rows.Add
                    (new object[] {
                    df.producto.NombreComercial,df.producto.Precio,df.Cantidad,df.DescuentoSucursal }
                    );
            }
            txtDescuento.Text = DescuentosTotal().ToString();
            txtTotalConDescuento.Text = TotalConDescuento().ToString();

        }

        private double DescuentosTotal()
        {
            double descuento = 0;
            foreach (DataGridViewRow row in dgvPDF.Rows)
            {
                if (row.Cells["ColPrecio"].Value != null && row.Cells["ColCantidad"].Value != null && row.Cells["ColDescuento"].Value != null)
                    descuento += (double)row.Cells["ColPrecio"].Value * (int)row.Cells["ColCantidad"].Value * (double)row.Cells["ColDescuento"].Value / 100;
            }

            return descuento;
        }

        private double TotalConDescuento()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvPDF.Rows)
            {
                if (row.Cells["ColPrecio"].Value != null && row.Cells["ColCantidad"].Value != null && row.Cells["ColDescuento"].Value != null)
                    total += (double)row.Cells["ColPrecio"].Value * (int)row.Cells["ColCantidad"].Value - (double)row.Cells["ColPrecio"].Value * (int)row.Cells["ColCantidad"].Value * (double)row.Cells["ColDescuento"].Value / 100;
            }
            return total;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtTotalConDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPDF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
