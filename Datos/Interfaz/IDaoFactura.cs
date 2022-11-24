using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Datos
{
    public interface IDaoFactura
    {
        List<Productos> ObtenerProductos();
        List<Tipo_Producto> ObtenerTipoProducto();
        List<FormasPago> ObtenerFormaPago();
        List<Sucursales> ObtenerSucursales();
        int ObtenerProximoNumeroFactura();
        List<Trimestre> ObtenerTrimestre();
        List<Mes> ObtenerMes();
        bool CrearFacturas(Facturas oFactura);
        List<Clientes> ObtenerClientes();
        bool Loguearse(Sesiones sesion);
        List<Facturas> ObtenerFacturas();
        public List<DetalleFactura> ObtenerDetallesProductos(int numero);
        bool CrearProducto(Productos oProducto);
        bool ModificarProducto(Productos oProducto);

        List<Empleados> ObtenerEmpleados();

        //List<Login> Loguearse(string user, string pass);


    }
}
