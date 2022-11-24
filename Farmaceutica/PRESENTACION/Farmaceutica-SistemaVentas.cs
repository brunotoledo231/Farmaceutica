using Farmaceutica.Datos.Implementacion;
using Farmaceutica.Dominio;
using Farmaceutica.Http;
using Farmaceutica.Servicios;
using Farmaceutica.Servicios.Implementacion;
using Farmaceutica.Servicios.interfaz;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmaceutica
{
    public partial class SistemaVentas : Form
    {
        
        private Facturas nueva;
        public SistemaVentas()
        {
            InitializeComponent();
            nueva = new Facturas();
        
        }
       
        
        private async void CargarClientesAsync()
        {
            string url = "http://localhost:5140/clientes";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Clientes>>(resultado);
            cboCliente.DataSource = lista;
            cboCliente.DisplayMember = "NombreCompleto";        
            cboCliente.ValueMember = "IdCliente";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

       

        private async void CargarFormasPagoAsync()
        {
            string url = "http://localhost:5140/formaspago";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<FormasPago>>(resultado);
            cboFormaPago.DataSource = lista;
            cboFormaPago.DisplayMember = "DescripcionFP";
            cboFormaPago.ValueMember = "IdFormaPago";
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void NumeroFacturaAsync()
        {
            string url = "http://localhost:5140/factura";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var contenido = JsonConvert.DeserializeObject(resultado);
            txtComprobante.Text = contenido.ToString();
        }
        private void Form2_LoadAsync(object sender, EventArgs e)
        {
            NumeroFacturaAsync();
            CargarProductosAsync();
            CargarFormasPagoAsync();
            CargarClientesAsync();
            cboCliente.SelectedIndex = -1;
        }

        private async void CargarProductosAsync()
        {
            string url = "http://localhost:5140/productos";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            List<Productos> lista = JsonConvert.DeserializeObject<List<Productos>>(resultado);
            List<Productos> listaP = new List<Productos>();
            foreach (Productos p in lista)
            {
                if (p.Baja == false)
                {
                    listaP.Add(p);
                }
            }
            cboProducto.DataSource = listaP;
            cboProducto.ValueMember = "IdProducto";
            cboProducto.DisplayMember = "NombreComercial";
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        public void Limpiar()
        {
            txtComprobante.Text = "";
            cboFormaPago.SelectedIndex = 0;
            cboProducto.SelectedIndex = 0;
            cboSucursal.SelectedIndex = 0;
            cboCliente.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dgvDetalles.Rows.Clear();
            txtDescuento.Text = "";
            nueva.Detalles.Clear();
            txtDescuentoTotal.Text = "";
            txtTotalPagar.Text = "";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            if (cboProducto.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un PRODUCTO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (nudCantidad.Text == "" || !int.TryParse(nudCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColProducto"].Value == null)
                {
                    break;
                }

                if (row.Cells["ColProducto"].Value.ToString().Equals(cboProducto.Text))
                {
                    MessageBox.Show("PRODUCTO: " + cboProducto.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }

            Productos p = (Productos)cboProducto.SelectedItem;
            int cant = Convert.ToInt32(nudCantidad.Value);
            double dto = 0;
            if (txtDescuento.Text == String.Empty)
            {
                dto = 0;
            }
            else
            {
                dto = Convert.ToDouble(txtDescuento.Text);
            }


            DetalleFactura det = new DetalleFactura(p, cant, dto);
            nueva.AgregarDetalle(det);
            dgvDetalles.Rows.Add(new object[] { p.IdProducto,p.NombreComercial,p.Precio, dto,p.TipoProducto.IdTipo,p.Descripcion,cant });
            txtDescuentoTotal.Text = DescuentosTotal().ToString();
            txtTotalPagar.Text = TotalConDescuento().ToString();


        }

        private double DescuentosTotal()
        {
            double descuento = 0;
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColPrecio"].Value != null && row.Cells["ColCantidad"].Value != null && row.Cells["ColDescuento"].Value != null)
                    descuento += (double)row.Cells["ColPrecio"].Value * (int)row.Cells["ColCantidad"].Value * (double)row.Cells["ColDescuento"].Value / 100;
            }

            return descuento;
        }

        private double TotalConDescuento()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColPrecio"].Value != null && row.Cells["ColCantidad"].Value != null && row.Cells["ColDescuento"].Value != null)
                    total += (double)row.Cells["ColPrecio"].Value * (int)row.Cells["ColCantidad"].Value - (double)row.Cells["ColPrecio"].Value * (int)row.Cells["ColCantidad"].Value * (double)row.Cells["ColDescuento"].Value / 100;
            }
            return total;
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDetalles.CurrentCell.ColumnIndex == 7)
            {
                nueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //click button:
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                //nueva.quitarDetalle();
                //CalcularTotal();

            }

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dtpFecha.Value.Day != DateTime.Now.Day)
            {
                MessageBox.Show("No es posible seleccionar una fecha anterior a hoy", "Error", MessageBoxButtons.OK);
                return;
            }
            if (cboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar forma de pago", "Error", MessageBoxButtons.OK);

            }

            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sucursal", "Error", MessageBoxButtons.OK);

            }

            //nueva.IdFactura = Convert.ToInt32(txtComprobante.Text);//otro problemilla
            nueva.IdClienteFacturas.IdCliente = Convert.ToInt32(cboCliente.SelectedValue);
            nueva.FechaFactura = dtpFecha.Value;
            nueva.IdFormasPagoFactura.IdFormaPago= Convert.ToInt32(cboFormaPago.SelectedValue);
            nueva.IdSucursalFactura.IdSucursal= Convert.ToInt32(txtIdSucursal.Text);
            nueva.IdEmpleadoFactura.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);

            string contenido = JsonConvert.SerializeObject(nueva);
            string url = "http://localhost:5140/factura";
            var resultado = await ClienteSingleton.GetInstancia().PostAsincrono(url, contenido);

            if (resultado.Equals("true"))
            {
                if(MessageBox.Show("Factura registrada", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    this.Limpiar();
                    this.NumeroFacturaAsync();
                }
                

            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescuentoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuentoTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
