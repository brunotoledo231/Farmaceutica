using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos

{
    public class Sesiones
    {
        public string nombre { get; set; }
        public string pass { get; set; }

        public Sesiones(string nombre, string pass)
        {
            this.nombre = nombre;
            this.pass = pass;
        }
    }
}
