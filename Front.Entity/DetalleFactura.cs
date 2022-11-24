using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        //public int IdDetalle { get; set; }
        //public Facturas IdFacturaDF { get; set; }
        public Productos producto { get; set; }
        public int Cantidad { get; set; }
        //public decimal Precio_Venta { get; set; } --no va porque el precio q tomamos en detalles es el precio
        //public ValidacionesCobertura IdValidacionDF { get; set; }
        //public DescuentosOS_Vigentes IdDescuentoOS { get; set; }
        public double DescuentoSucursal { get; set; }
        public DetalleFactura()
        {
            //IdFacturaDF = new Facturas();
            producto = new Productos();
            this.Cantidad = 0;
            this.DescuentoSucursal = 0;
            //IdValidacionDF = new ValidacionesCobertura();
            //IdDescuentoOS = new DescuentosOS_Vigentes();
        }

        public DetalleFactura(Productos p, int cant, double descuento)
        {
            producto = p;
            Cantidad = cant;
            DescuentoSucursal= descuento;
        }
    }
}
