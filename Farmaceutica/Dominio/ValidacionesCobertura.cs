using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class ValidacionesCobertura
    {
        public int IdValidacion { get; set; }
        public int NroAfiliado { get; set; }
        
        public Recetas IdRecetaValidacion { get; set; }
        public ObrasSociales CuitOSValidacion { get; set; }

        public DateTime FechaValidacion { get; set; }

        public ValidacionesCobertura()
        {
            IdRecetaValidacion=new Recetas();
            CuitOSValidacion=new ObrasSociales();
        }

    }
}
