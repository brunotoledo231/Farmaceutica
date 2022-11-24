using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class Recetas
    {
        public int IdReceta { get; set; }
        public string DescripcionReceta { get; set; }
        public Medicos MatriculaMedicos { get; set; }

        public Recetas()
        {
            MatriculaMedicos=new Medicos();
        }
    }
}
