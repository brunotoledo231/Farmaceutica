using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class Productos
    {
       

        
        public int IdProducto { get; set; }
        //public int Vta_receta { get; set; }
        public string Descripcion { get; set; }
        public string NombreComercial { get; set; }
        public int CodBarras { get; set; }
        public double Precio { get; set; }

        public DateTime Vencimiento { get; set; }

        public Tipo_Producto TipoProducto { get; set; }

        public bool Baja { get; set; }
        public Productos()
        {
            TipoProducto = new Tipo_Producto();
        }
        public Productos(string descrip, string nombre, int cod, double precio, DateTime vto, Tipo_Producto tp, bool baja)
        {
            this.TipoProducto = tp;
            this.Descripcion = descrip;
            this.Precio = precio;
            this.Vencimiento = vto;
            this.CodBarras = cod;
            this.NombreComercial = nombre;
            this.Baja = baja;
        }




    }

}
