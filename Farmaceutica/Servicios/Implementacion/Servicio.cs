using Farmaceutica.Datos;
using Farmaceutica.Datos.Implementacion;
using Farmaceutica.Datos.Interfaz;
using Farmaceutica.Dominio;
using Farmaceutica.Servicios.interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IDaoFactura dao;
        public Servicio()
        {
            dao = new DaoFactura();
        }
        public int ObtenerProximoNumeroFactura()
        {
            return dao.ObtenerProximoNumeroFactura();   
        }

        public List<Productos> ObtenerProductos()
        {
            return dao.ObtenerProductos();
        }

        public List<Tipo_Producto> ObtenerTipoProducto()
        {
            return dao.ObtenerTipoProducto();
        }

        public List<FormasPago> ObtenerFormaPago()
        {
            return dao.ObtenerFormaPago();
        }

        public List<Sucursales> ObtenerSucursales()
        {
            return dao.ObtenerSucursales();
        }

        public List<Trimestre> ObtenerTrimestre()
        {
            return dao.ObtenerTrimestre();
        }

        public List<Mes> ObtenerMes()
        {
            return dao.ObtenerMes();
        }

        public List<Clientes> ObtenerClientes()
        {
            return dao.ObtenerClientes();
        }

        public bool CrearFacturas(Facturas oFactura)
        {
            return dao.CrearFacturas(oFactura);
        }

        public List<Facturas> ObtenerFacturas()//AGREGAR ESTO
        {
            return dao.ObtenerFacturas();
        }

        public List<DetalleFactura> ObtenerDetallesProductos(int numero)//AGREGAR ESTO
        {
            return dao.ObtenerDetallesProductos(numero);
        }
    }


}
