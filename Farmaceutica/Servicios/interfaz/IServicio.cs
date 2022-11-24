using Farmaceutica.Datos;
using Farmaceutica.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios.interfaz
{
    public interface IServicio
    {
        List<Productos> ObtenerProductos();
        List<Tipo_Producto> ObtenerTipoProducto();
        List<FormasPago> ObtenerFormaPago();
        List<Sucursales> ObtenerSucursales();

        int ObtenerProximoNumeroFactura();

        List<Trimestre> ObtenerTrimestre();
        List<Mes> ObtenerMes();
        List<Clientes> ObtenerClientes();
        List<Facturas> ObtenerFacturas();//AGREGAR ESTO

        List<DetalleFactura> ObtenerDetallesProductos(int numero);//AGREGAR ESTO 
        bool CrearFacturas(Facturas oFactura);

    }
}
