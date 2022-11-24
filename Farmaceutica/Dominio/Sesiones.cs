using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmaceutica.Datos;

namespace Farmaceutica.Dominio

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

        HelperDB userDao = new HelperDB();
        public bool Loginuser(string user, string pass)
        {
            return HelperDB.ObtenerInstancia().Login(user, pass);

        }
    }
}
