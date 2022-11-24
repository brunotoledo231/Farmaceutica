using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.fachada
{
    public class DatosImp : IDatos
    {
        private IDaoFactura dao;
        public DatosImp()
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

        public bool Loguearse(Sesiones sesion)
        {
            return dao.Loguearse(sesion);
        }
        public List<Facturas> ObtenerFacturas()//AGREGAR ESTO
        {
            return dao.ObtenerFacturas();
        }

        public List<DetalleFactura> ObtenerDetallesProductos(int numero)//AGREGAR ESTO
        {
            return dao.ObtenerDetallesProductos(numero);
        }

        public bool CrearProducto(Productos oProducto)
        {
            return dao.CrearProducto(oProducto);
        }

        public bool ModificarProducto(Productos oProducto)
        {
            return dao.ModificarProducto(oProducto);
        }
        public List<Empleados> ObtenerEmpleados()
        {
            return dao.ObtenerEmpleados();
        }
    }
}
