using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class Medicos
    {
        public int Matricula { get; set; }
        public Personas IdPersonaMedico { get; set; }
        public Especialidades IdEspecialidadMedico { get; set; }

        public Medicos()
        {
            IdPersonaMedico=new Personas();
            IdEspecialidadMedico=new Especialidades();
        }
    }
}
