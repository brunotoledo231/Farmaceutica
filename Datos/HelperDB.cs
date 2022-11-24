using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using Front.Entity;
using System.Net;
using Newtonsoft.Json;
using Farmaceutica.Datos;

namespace Datos
{
    
    public class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection conexion;
        private string cadenaConexion = @"Data Source=LAPTOP-E4M69B29\SQLEXPRESS;Initial Catalog=FarmaFinal;Integrated Security=True";

        public HelperDB()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        
        public static HelperDB ObtenerInstancia()
        {
            //if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public DataTable ConsultaSQL(string nombreSP)//List<Parametro> param
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
        public DataTable ConsultaSQL1(string spNombre, List<Parametro> values)//AGREGAR ESTO
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            SqlCommand cmd = new SqlCommand(spNombre, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
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

        public DataTable ConsultarLogin(string nombreSP)//List<Parametro> param
        {
            DataTable dt = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            //if (param != null)
            //{
            //    foreach (Parametro par in param)
            //    {
            //        cmd.Parameters.AddWithValue(par.NombreParametro, par.valorParametro);

            //    }
            //}
            dt.Load(cmd.ExecuteReader());
            conexion.Close();
            return dt;

        }

        public bool Login(string user, string pass)
        {
            using (var cnn = new SqlConnection(cadenaConexion))
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
            using (var cnn = new SqlConnection(cadenaConexion))
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

        public bool InsertarMaestroDetalle(Facturas oFactura)
        {
            bool ok = true;

            //SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlTransaction t = null;
            SqlCommand cmdMaestro = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                cmdMaestro = new SqlCommand("SP_INSERTAR_MAESTRO", conexion, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@fecha_factura", oFactura.FechaFactura);
                cmdMaestro.Parameters.AddWithValue("@id_empleado", oFactura.IdEmpleadoFactura.IdEmpleado);
                cmdMaestro.Parameters.AddWithValue("@id_forma_pago", oFactura.IdFormasPagoFactura.IdFormaPago);
                cmdMaestro.Parameters.AddWithValue("@id_sucursal", oFactura.IdSucursalFactura.IdSucursal);
                cmdMaestro.Parameters.AddWithValue("@id_cliente", oFactura.IdClienteFacturas.IdCliente);
                //cmdMaestro.Parameters.AddWithValue("@cuit_obra_social", oFactura.CuitOSFactura.CuitOS);
                // cmdMaestro.Parameters.AddWithValue("@observaciones", oFactura.Observaciones);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id_factura";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(pOut);
                cmdMaestro.ExecuteNonQuery();

                int idFactura = (int)pOut.Value;

                SqlCommand cmdDetalle;
                //int detalleNro = 1;
                foreach (DetalleFactura item in oFactura.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_factura", idFactura);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", item.producto.IdProducto);//referencia no establecida como instancia de un objeto
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio_venta", item.producto.Precio);
                    cmdDetalle.Parameters.AddWithValue("@descuento_sucursal", item.DescuentoSucursal);
                    cmdDetalle.ExecuteNonQuery();
                    //detalleNro++;
                }
                t.Commit();
            }
            catch (SqlException e)
            {
                if (t != null)
                {
                    t.Rollback();
                    ok = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {

                    conexion.Close();
                }
            }
            return ok;
        }

        

        public bool InsertarProducto(Productos oProducto)
        {
            bool ok = true;

            SqlCommand cmd = null;

            try
            {
                conexion.Open();
                cmd = new SqlCommand("sp_insertar_producto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_producto", oProducto.TipoProducto.IdTipo);
                cmd.Parameters.AddWithValue("@descripcion", oProducto.Descripcion);
                cmd.Parameters.AddWithValue("@nombre_comercial", oProducto.NombreComercial);
                cmd.Parameters.AddWithValue("@codigo_barras", oProducto.CodBarras);
                cmd.Parameters.AddWithValue("@precio", oProducto.Precio);
                cmd.Parameters.AddWithValue("@vto", oProducto.Vencimiento);
                cmd.Parameters.AddWithValue("@baja", oProducto.Baja);

                int resultado = cmd.ExecuteNonQuery();

                ok = resultado == 1;
            }
            catch (SqlException e)
            {
                ok = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {

                    conexion.Close();
                }
            }
            return ok;
        }

        public bool ModificarProducto(Productos oProducto)
        {
            bool ok = true;

            SqlCommand cmd = null;

            try
            {
                conexion.Open();
                cmd = new SqlCommand("sp_modificar_producto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_producto", oProducto.TipoProducto.IdTipo);
                cmd.Parameters.AddWithValue("@descripcion", oProducto.Descripcion);
                cmd.Parameters.AddWithValue("@nombre_comercial", oProducto.NombreComercial);
                cmd.Parameters.AddWithValue("@codigo_barras", oProducto.CodBarras);
                cmd.Parameters.AddWithValue("@precio", oProducto.Precio);
                cmd.Parameters.AddWithValue("@vto", oProducto.Vencimiento);
                cmd.Parameters.AddWithValue("@id_producto", oProducto.IdProducto);
                cmd.Parameters.AddWithValue("@baja", oProducto.Baja);

                int resultado = cmd.ExecuteNonQuery();

                ok = resultado == 1;
            }
            catch (SqlException e)
            {
                ok = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {

                    conexion.Close();
                }
            }
            return ok;
        }
    }
}
