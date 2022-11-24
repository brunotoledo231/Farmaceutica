using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class Facturas
    {
        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public Empleados IdEmpleadoFactura { get; set; }
        public FormasPago IdFormasPagoFactura { get; set; }
        public Clientes IdClienteFacturas { get; set; }
        public Sucursales IdSucursalFactura { get; set; }
        public ObrasSociales CuitOSFactura { get; set; }
        public string Observaciones { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
        
        public Facturas()
        {
            IdEmpleadoFactura = new Empleados();
            IdFormasPagoFactura = new FormasPago();
            IdClienteFacturas = new Clientes();
            IdSucursalFactura = new Sucursales();
            CuitOSFactura=new ObrasSociales();
            Detalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

       
    }
}
