using Farmaceutica.Datos.Interfaz;
using Farmaceutica.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Farmaceutica.Datos.Implementacion
{
    public class DaoFactura : IDaoFactura
    {


        //public List<Login> Loguearse(string user, string pass)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Login> Loguearse(string user, string pass)
        //{
        //    List<Login> lista = new List<Login>();
        //    string Sp = "SP_LOGINS";
        //    DataTable tabla = HelperDB.ObtenerInstancia().ConsultarLogin(Sp);


        //    foreach (DataRow dr in tabla.Rows)
        //    {
        //        string nombre = dr["usuario"].ToString();
        //        string contra = dr["pass"].ToString();

        //        Login l = new Login(nombre, contra);
        //        lista.Add(l);
        //    }

        //    return lista;
        //}
        public int ObtenerProximoNumeroFactura()
        {
            string sp = "SP_PROXIMO_NUMERO_FACTURA";
            return HelperDB.ObtenerInstancia().ConsultarEscalarSalida(sp, "@prox");
        }

        public List<Productos> ObtenerProductos()
        {
            List<Productos> listaProductos = new List<Productos>();
            string sp = "SP_MOSTRAR_PRODUCTOS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                Productos p = new Productos();
                p.IdProducto = (int)fila["id_producto"];
                p.Descripcion = fila["descripcion"].ToString();
                p.NombreComercial = fila["nombre_comercial"].ToString();
                p.CodBarras = (int)fila["cod_barras"];
                p.Precio = Convert.ToDouble(fila["precio"].ToString());
                p.Vencimiento = Convert.ToDateTime(fila["vencimiento"].ToString());
                p.TipoProducto.IdTipo = (int)fila["id_tipo_producto"];


                listaProductos.Add(p);
            }
            return listaProductos;
        }



        public List<Tipo_Producto> ObtenerTipoProducto()
        {
            List<Tipo_Producto> listaTipoProducto = new List<Tipo_Producto>();
            string sp = "SP_MOSTRAR_TIPOS_PRODUCTOS";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in t.Rows)
            {
                Tipo_Producto tp = new Tipo_Producto();
                tp.IdTipo = Convert.ToInt32(fila["id_tipo_producto"].ToString());
                tp.Descripcion = fila["descripcion"].ToString();

                listaTipoProducto.Add(tp);
            }
            return listaTipoProducto;
        }

        public List<FormasPago> ObtenerFormaPago()
        {
            List<FormasPago> listaFormasPago = new List<FormasPago>();
            string sp = "SP_FORMA_PAGO";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                FormasPago fp = new FormasPago();
                fp.IdFormaPago = Convert.ToInt32(fila["id_forma_pago"].ToString());
                fp.DescripcionFP = fila["descripcion"].ToString();

                listaFormasPago.Add(fp);
            }
            return listaFormasPago;
        }
        public List<Clientes> ObtenerClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();
            string sp = "SP_CLIENTES";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                Clientes cl = new Clientes();
                cl.IdCliente = Convert.ToInt32(fila["id_cliente"].ToString());
                cl.NombreCompleto = fila["nombre"].ToString() + " " + fila["apellido"].ToString();
                cl.CuitOSCliente.CuitOS = Convert.ToInt32(fila["cuit_obra_social"].ToString());
                cl.CondicionIvaCliente.IdCondicionIva = Convert.ToInt32(fila["id_condicion_iva"].ToString());
                listaClientes.Add(cl);
            }
            return listaClientes;
        }

        public List<Sucursales> ObtenerSucursales()
        {
            List<Sucursales> listaSucursales = new List<Sucursales>();
            string sp = "SP_MOSTRAR_SUCURSALES";
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            //mapeo 
            foreach (DataRow fila in t.Rows)
            {
                Sucursales s = new Sucursales();
                s.IdSucursal = Convert.ToInt32(fila["Id_Sucursal"].ToString());
                s.NombreSucursal = fila["nom_sucursaL"].ToString();
                s.Direccion = fila["direccion"].ToString();
                s.Altura = Convert.ToInt32(fila["altura"].ToString());
                Barrios bar = new Barrios();
                s.IdBarrioSucursal.IdBarrio = Convert.ToInt32(fila["id_barrio"].ToString());
                listaSucursales.Add(s);
            }
            return listaSucursales;
        }

        public List<Trimestre> ObtenerTrimestre()///HAY QUE CONTROLAR Y VER QUE HACER PARA QUE CARGUE EL COMBO
        {
            //DataTable t = new DataTable();
            //string sp = "Consulta7";
            //string paramSalida = "@trim";
            //return t= HelperDB.ObtenerInstancia().ConsultaSQL(sp, pOut);
            List<Trimestre> listatrimestre = new List<Trimestre>();
            string sp = "SP_MOSTRAR_TRIMESTRE";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                Trimestre t = new Trimestre();
                t.IdTrimestre = Convert.ToInt32(fila["id_trimestre"].ToString());
                t.NombreTrimestre = fila["trismestre"].ToString();

                listatrimestre.Add(t);
            }
            return listatrimestre;
        }

        public List<Mes> ObtenerMes()
        {
            List<Mes> listaMeses = new List<Mes>();
            string sp = "SP_MOSTRAR_MESES";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                Mes mes = new Mes();
                mes.IdMes = Convert.ToInt32(fila["id_mes"].ToString());
                mes.NombreMes = fila["mes"].ToString();

                listaMeses.Add(mes);
            }
            return listaMeses;
        }

        public bool CrearFacturas(Facturas oFactura)
        {
            bool ok = true;

            SqlConnection cnn = new SqlConnection(Properties.Resources.cadenaConexion);
            SqlTransaction t = null;
            SqlCommand cmdMaestro = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmdMaestro = new SqlCommand("SP_INSERTAR_MAESTRO", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@fecha_factura", oFactura.FechaFactura);
                //cmdMaestro.Parameters.AddWithValue("@id_empleado", oFactura.IdEmpleadoFactura.IdEmpleado);
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
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
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
            catch (Exception e)
            {
                if (t != null)
                {
                    t.Rollback();
                    ok = false;
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {

                    cnn.Close();
                }
            }
            return ok;
        }

        public List<Facturas> ObtenerFacturas()//AGREGAR ESTO
        {
            List<Facturas> listaFacturas = new List<Facturas>();
            string sp = "SP_MOSTRAR_FACTURAS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                Facturas f = new Facturas();
                f.IdFactura = Convert.ToInt32(fila["id_factura"].ToString());
                f.FechaFactura = Convert.ToDateTime(fila["fecha_factura"].ToString());
                f.IdEmpleadoFactura.NombreCompleto = fila["nombre_empleado"].ToString() + " " + fila["apellido_empleado"].ToString();
                f.IdFormasPagoFactura.DescripcionFP = fila["descripcion"].ToString();
                f.IdClienteFacturas.NombreCompleto = fila["nombre_cliente"].ToString() + " " + fila["apellido_cliente"].ToString();
                f.IdSucursalFactura.NombreSucursal = fila["nom_sucursaL"].ToString();

                listaFacturas.Add(f);
            }
            return listaFacturas;

        }
        public List<DetalleFactura> ObtenerDetallesProductos(int numerofactura)//AGREGAR ESTO
        {
            List<DetalleFactura> listaDetallesProductos = new List<DetalleFactura>();
            string sp = "SP_MOSTRAR_DETALLES_PRODUCTOS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@ID_FACTURA", numerofactura));

            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL1(sp,lst);
            //mapeo 
            foreach (DataRow fila in t.Rows)
            {
                DetalleFactura df = new DetalleFactura();
                df.producto.NombreComercial = fila["nombre_comercial"].ToString();
                df.producto.Precio = Convert.ToDouble(fila["precio"].ToString());
                df.Cantidad = Convert.ToInt32(fila["cantidad"].ToString());
                df.DescuentoSucursal = Convert.ToDouble(fila["descuento_sucursal"].ToString());

                listaDetallesProductos.Add(df);
            }
            return listaDetallesProductos;
        }
    }
}
