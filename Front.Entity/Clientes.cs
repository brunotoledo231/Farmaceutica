using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Clientes : Personas
    {
        public int IdCliente { get; set; }

        public ObrasSociales CuitOSCliente { get; set; }

        public CondicionIva CondicionIvaCliente { get; set; }

        public Clientes() : base()
        {
            CuitOSCliente = new ObrasSociales();
            CondicionIvaCliente = new CondicionIva();
        }
    }
}
