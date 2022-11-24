using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DescuentosOS_Vigentes
    {
        public int IdDescuento { get; set; }
        public decimal Descuento { get; set; }

        public Productos IdProdDescuento { get; set; }
        public ObrasSociales CuitOSDescuento { get; set; }
        public Sucursales IdSucursalDescuento { get; set; }
        public DateTime Fecha_Descuento { get; set; }

        public DescuentosOS_Vigentes()
        {
            IdProdDescuento = new Productos();
            CuitOSDescuento=new ObrasSociales();
            IdSucursalDescuento=new Sucursales();

        }
    }


}
