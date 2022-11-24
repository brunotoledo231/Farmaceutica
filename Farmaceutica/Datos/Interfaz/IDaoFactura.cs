using Farmaceutica.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Datos.Interfaz
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
        List<Facturas> ObtenerFacturas();//AGREGAR ESTO

        List<DetalleFactura> ObtenerDetallesProductos(int numero);//AGREGAR ESTO

        //List<Login> Loguearse(string user, string pass);


    }
}
