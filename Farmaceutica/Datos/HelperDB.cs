using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmaceutica.Datos
{
    internal class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection conexion;
        public HelperDB()
        {
            conexion = new SqlConnection(Properties.Resources.cadenaConexion);
        }
        public static HelperDB ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public DataTable ConsultaSQL(string nombreSP)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            //if (valores != null)
            //{
            //    foreach (Parametro p in valores)
            //    {
            //        cmd.Parameters.AddWithValue(p.NombreParametro, p.valorParametro);
            //    }
            //}
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        //AGREGAR ESTO
        public DataTable ConsultaSQL1(string spNombre, List<Parametro> valores)//AGREGAR ESTO
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            SqlCommand cmd = new SqlCommand(spNombre, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (valores != null)
            {
                foreach (Parametro oParametro in valores)
                {
                    cmd.Parameters.AddWithValue(oParametro.NombreParametro, oParametro.valorParametro);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            return tabla;
        }




        public int ConsultarEscalarSalida(string nombreSP, string paramSalida)
        {
            int aux;
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(nombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pSalida = new SqlParameter();
                pSalida.ParameterName = paramSalida;
                pSalida.DbType = DbType.Int32;
                pSalida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pSalida);
                cmd.ExecuteNonQuery();
                conexion.Close();
                aux = (int)pSalida.Value;               
            }
            catch(Exception ex)
            {
                aux = 1;
            }
            return aux;
            
        }

        public DataTable ConsultarLogin(string nombreSP, List<Parametro> param)
        {
            DataTable dt = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (param != null)
            {
                foreach (Parametro par in param)
                {
                    cmd.Parameters.AddWithValue(par.NombreParametro, par.valorParametro);

                }
            }
            dt.Load(cmd.ExecuteReader());
            conexion.Close();
            return dt;

        }

        public bool Login(string user, string pass)
        {
            using (var cnn = new SqlConnection(Properties.Resources.cadenaConexion))
            {
                cnn.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "SP_LOGINS";
                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    { return true; }

                    else
                    { return false; }
                }

            }

        }

        public SqlConnection ConectaralaBase()
        {
            return this.conexion;
        }

        public bool LoginGerente(string user, string pass)
        {
            using (var cnn = new SqlConnection(Properties.Resources.cadenaConexion))
            {
                cnn.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "SP_LoginGerente";
                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    { return true; }

                    else
                    { return false; }
                }

            }








        }
    }
}
