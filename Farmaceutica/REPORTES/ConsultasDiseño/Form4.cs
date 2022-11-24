﻿using Farmaceutica.Servicios.Implementacion;
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
    public partial class Form4 : Form
    {
        private IServicio servicio;
        public Form4()
        {
            InitializeComponent();
            servicio = new Servicio();
            CargarTipoProducto();
            CargarSucursales();
        }
        private void CargarTipoProducto()
        {
            cboTipo.DataSource = servicio.ObtenerTipoProducto();
            cboTipo.DisplayMember = "Descripcion";
            cboTipo.ValueMember = "IdTipo";
        }

        private void CargarSucursales()
        {
            cboSucursal.DataSource = servicio.ObtenerSucursales();
            cboSucursal.DisplayMember = "NombreSucursal";
            cboSucursal.ValueMember = "IdSucursal";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.sP_Consulta4TableAdapter.Fill(this.dSConsulta1.SP_Consulta4, Convert.ToInt32(cboTipo.SelectedValue), Convert.ToInt32(cboSucursal.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
