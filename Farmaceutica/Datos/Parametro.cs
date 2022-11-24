using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Datos
{
    internal class Parametro
    {
        public string NombreParametro { get; set; }
        public object valorParametro { get; set; }
        public Parametro(string nombreParametro, object valorParametro)
        {
            NombreParametro = nombreParametro;
            this.valorParametro = valorParametro;
        }
    }
}
