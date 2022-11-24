using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class Empleados:Personas
    {
        public int IdEmpleado { get; set; }
      

        public string Observaciones { get; set; }

        public Empleados():base()
        {
            
        }
    }
}
