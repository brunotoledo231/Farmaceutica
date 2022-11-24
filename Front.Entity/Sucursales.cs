using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sucursales
    {
        Barrios b;
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public int Altura { get; set; }
        public Barrios IdBarrioSucursal { get; set; }

        public Sucursales()
        {
            IdBarrioSucursal=new Barrios();
        }
    }
}
