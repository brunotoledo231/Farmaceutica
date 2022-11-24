using Farmaceutica.Dominio;
using Farmaceutica.Http;
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
    public partial class ABMProducto : Form
    {
        private Productos oProducto;
        private bool nuevo;
        public ABMProducto()
        {
            InitializeComponent();
            Habilitar(false);
            oProducto = new Productos();
            nuevo = false;
        }
        private async void ABMProducto_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
            await CargarTiposProductoAsync();
        }
        private async Task CargarProductosAsync()
        {
            string url = "http://localhost:5140/productos";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Productos>>(resultado);
            cboProductoID.DataSource = lista;
            cboProductoID.ValueMember = "IdProducto";
            cboProductoID.DisplayMember = "NombreComercial";
        }
        private async Task CargarTiposProductoAsync()
        {
            string url = "http://localhost:5140/tipos_producto";
            var resultado = await ClienteSingleton.GetInstancia().GetAsincrono(url);
            var lista = JsonConvert.DeserializeObject<List<Tipo_Producto>>(resultado);
            cboTipoProducto.DataSource = lista;
            cboTipoProducto.ValueMember = "IdTipo";
            cboTipoProducto.DisplayMember = "Descripcion";
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
            Limpiar();
            cboProductoID.Visible = false;
            label1.Visible = false;
        }

        private void Habilitar(bool x)
        {
            cboProductoID.Enabled = !x;
            cboTipoProducto.Enabled = x;
            txtCodigoBarras.Enabled = x;
            txtDescripcion.Enabled = x;
            txtNombreComercial.Enabled = x;
            txtPrecio.Enabled = x;
            dtpVencimiento.Enabled = x;
            btnGuardar.Enabled = x;
            btnQuitarProducto.Enabled = !x;
            btnNuevoProducto.Enabled = !x;
            btnEditar.Enabled = !x;
            chBaja.Enabled = false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

                oProducto.IdProducto = Convert.ToInt32(cboProductoID.SelectedValue);
                oProducto.TipoProducto = (Tipo_Producto)cboTipoProducto.SelectedItem;
                oProducto.Descripcion = txtDescripcion.Text;
                oProducto.NombreComercial = txtNombreComercial.Text;
                oProducto.CodBarras = Convert.ToInt32(txtCodigoBarras.Text);
                oProducto.Precio = Convert.ToDouble(txtPrecio.Text);
                oProducto.Vencimiento = dtpVencimiento.Value;
                //oProducto.Baja = chBaja.Checked;

                if (nuevo)
                {
                    oProducto.Baja = false;
                    string contenido = JsonConvert.SerializeObject(oProducto);
                    string url = "http://localhost:5140/productos";
                    var resultado = await ClienteSingleton.GetInstancia().PostAsincrono(url, contenido);

                    if (resultado.Equals("true"))
                    {
                        if (MessageBox.Show("Producto registrado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Limpiar();
                            Habilitar(false);
                            CargarProductosAsync();

                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo registrar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string contenido = JsonConvert.SerializeObject(oProducto);
                    string url = "http://localhost:5140/productos";
                    var resultado = await ClienteSingleton.GetInstancia().PutAsincrono(url, contenido);

                    if (resultado.Equals("true"))
                    {
                        if (MessageBox.Show("Producto modificado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Limpiar();
                            Habilitar(false);
                            CargarProductosAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            cboProductoID.Visible = true;
            label1.Visible = true;
        }

        private bool Validar()
        {
            bool aux = true;

            if (cboTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de producto!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aux = false;
                cboTipoProducto.Focus();
            }
            if (String.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aux = false;
                txtDescripcion.Focus();
            }
            if (String.IsNullOrEmpty(txtCodigoBarras.Text))
            {
                MessageBox.Show("Debe ingresar un codigo de barras!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aux = false;
                txtCodigoBarras.Focus();
            }
            if (String.IsNullOrEmpty(txtNombreComercial.Text))
            {
                MessageBox.Show("Debe ingresar un nombre!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aux = false;
                txtNombreComercial.Focus();
            }
            if (String.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar un precio!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aux = false;
                txtPrecio.Focus();
            }
            if (dtpVencimiento.Value < DateTime.Now)
            {
                MessageBox.Show("No es posible seleccionar una fecha anterior a la actual", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aux = false;
                txtCodigoBarras.Focus();
            }
            return aux;
        }

        private void Limpiar()
        {
            cboTipoProducto.SelectedIndex = 0;
            txtCodigoBarras.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtNombreComercial.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            dtpVencimiento.Value = DateTime.Now;
            chBaja.Checked = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Habilitar(true);
        }
        private void LevantadoDatos()
        {
            Productos prod = (Productos)cboProductoID.SelectedItem;

            txtNombreComercial.Text = prod.NombreComercial;
            cboTipoProducto.Text = prod.TipoProducto.Descripcion.ToString();
            txtCodigoBarras.Text = prod.CodBarras.ToString();
            txtDescripcion.Text = prod.Descripcion;
            txtPrecio.Text = prod.Precio.ToString();
            dtpVencimiento.Value = Convert.ToDateTime(prod.Vencimiento);
            if (prod.Baja)
            {
                chBaja.Checked = true;
            }
            else
            {
                chBaja.Checked = false;
            }

            cboProductoID.Focus();
        }

        private void cboProductoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevantadoDatos();
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            nuevo = false;
            oProducto.Baja = true;
            btnGuardar_Click(sender, e);
        }

        private void btnQuitarProducto_Click_1(object sender, EventArgs e)
        {
            nuevo = false;
            oProducto.Baja = true;
            btnGuardar_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                Habilitar(false);
                cboProductoID.Visible = true;
                label1.Visible = true;
            }
        }
    }
}
