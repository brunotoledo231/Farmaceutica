using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ObrasSociales
    {
        public int CuitOS { get; set; }
        public string NombreOS { get; set; }
        public string DireccionOS { get; set; }

        public int AlturaOS { get; set; }

        public Barrios IdBarrioOS { get; set; }

        public ObrasSociales()
        {
            IdBarrioOS = new Barrios();
        }
    }
}
