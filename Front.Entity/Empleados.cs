using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleados:Personas
    {
        public int IdEmpleado { get; set; }
        

        public string Observaciones { get; set; }

        public Sucursales sucursal { get; set; }

        public Empleados():base()
        {
            sucursal = new Sucursales();
        }
    }
}
