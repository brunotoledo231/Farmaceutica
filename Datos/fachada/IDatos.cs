using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.fachada
{
    public interface IDatos
    {
        List<Productos> ObtenerProductos();
        List<Tipo_Producto> ObtenerTipoProducto();
        List<FormasPago> ObtenerFormaPago();
        List<Sucursales> ObtenerSucursales();
        

        int ObtenerProximoNumeroFactura();

        List<Trimestre> ObtenerTrimestre();
        List<Mes> ObtenerMes();
        List<Clientes> ObtenerClientes();
        bool CrearFacturas(Facturas oFactura);
        bool Loguearse(Sesiones sesion);

        List<Facturas> ObtenerFacturas();
        List<Empleados> ObtenerEmpleados();
        public List<DetalleFactura> ObtenerDetallesProductos(int numero);
        bool CrearProducto(Productos oProducto);
        bool ModificarProducto(Productos oProducto);

    }
}
