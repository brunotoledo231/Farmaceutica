using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Barrios
    {
        

        public int IdBarrio { get; set; }//este es el id del barrio 
        public string NombreBarrio { get; set; }

        public Localidades IdLocalidadBarrios { get; set; }
       
    }
}
