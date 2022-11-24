using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Localidades
    {
        public int IdLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public Provincias IdProvinciaLocalidad { get; set; }

        public Localidades()
        {
            IdProvinciaLocalidad = new Provincias();
        }
    }
}
