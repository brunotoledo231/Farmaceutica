using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entity;
using Farmaceutica.Datos;

namespace Datos
{
    public class DaoFactura : IDaoFactura
    {
        private string cadenaConexion = @"Data Source=LAPTOP-E4M69B29\SQLEXPRESS;Initial Catalog=FarmaFinal;Integrated Security=True";


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
                p.IdProducto = (int)fila["IdProd"];
                p.Descripcion = fila["Pdescrip"].ToString();
                p.NombreComercial = fila["Nombre"].ToString();
                p.CodBarras = (int)fila["Cod"];
                p.Precio = Convert.ToDecimal(fila["Pre"].ToString());
                p.Vencimiento = Convert.ToDateTime(fila["Vto"].ToString());
                p.Baja = (bool)fila["Baj"];
                p.TipoProducto.IdTipo = (int)fila["IdTipo"];
                p.TipoProducto.Descripcion = fila["TPdescrip"].ToString();

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
                cl.NombreCompleto = fila["nombre"].ToString() +" "+ fila["apellido"].ToString();
                cl.CuitOSCliente.CuitOS = Convert.ToInt32(fila["cuit_obra_social"].ToString());
                cl.CondicionIvaCliente.IdCondicionIva = Convert.ToInt32(fila["id_condicion_iva"].ToString());
                listaClientes.Add(cl);
            }
            return listaClientes;
        }
        public List<Empleados> ObtenerEmpleados()
        {
            List<Empleados> listaEmpleados = new List<Empleados>();
            string sp = "SP_EMPLEADOS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                Empleados e = new Empleados();
                e.IdEmpleado = Convert.ToInt32(fila["id_empleado"].ToString());
                e.NombreCompleto = fila["nombre"].ToString() + " " + fila["apellido"].ToString();
                e.Observaciones = fila["observacion"].ToString();
                e.sucursal.IdSucursal = Convert.ToInt32(fila["id_sucursal"].ToString());
                listaEmpleados.Add(e);
            }
            return listaEmpleados;
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
            return HelperDB.ObtenerInstancia().InsertarMaestroDetalle(oFactura);
        }

        public bool Loguearse(Sesiones sesion)
        {
            return HelperDB.ObtenerInstancia().Login(sesion.nombre, sesion.pass);
        }

        public List<Facturas> ObtenerFacturas()
        {
            List<Facturas> listaFacturas = new List<Facturas>();
            string sp = "SP_MOSTRAR_FACTURAS";
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow fila in tabla.Rows)
            {
                Facturas f = new Facturas();
                f.IdFactura = Convert.ToInt32(fila["IdFactura"].ToString());
                f.FechaFactura = Convert.ToDateTime(fila["Fecha"].ToString());
                f.IdEmpleadoFactura.NombreCompleto = fila["empleado"].ToString();
                f.IdFormasPagoFactura.DescripcionFP = fila["FormaPago"].ToString();
                f.IdClienteFacturas.NombreCompleto = fila["cliente"].ToString();
                f.IdSucursalFactura.NombreSucursal = fila["SucursaL"].ToString();

                listaFacturas.Add(f);
            }
            return listaFacturas;

        }

        public List<DetalleFactura> ObtenerDetallesProductos(int numerofactura)
        {
            List<DetalleFactura> listaDetallesProductos = new List<DetalleFactura>();
            string sp = "SP_MOSTRAR_DETALLES_PRODUCTOS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@ID_FACTURA", numerofactura));
            DataTable t = HelperDB.ObtenerInstancia().ConsultaSQL1(sp, lst);
            //mapeo 
            foreach (DataRow fila in t.Rows)
            {
                DetalleFactura df = new DetalleFactura();
                df.producto.NombreComercial = fila["producto"].ToString();
                df.producto.Precio = Convert.ToDecimal(fila["precio"].ToString());
                df.Cantidad = Convert.ToInt32(fila["cantidad"].ToString());
                df.DescuentoSucursal = Convert.ToDouble(fila["descuento"].ToString());

                listaDetallesProductos.Add(df);
            }
            return listaDetallesProductos;
        }

        public bool CrearProducto(Productos oProducto)
        {
            return HelperDB.ObtenerInstancia().InsertarProducto(oProducto);
        }

        public bool ModificarProducto(Productos oProducto)
        {
            return HelperDB.ObtenerInstancia().ModificarProducto(oProducto);
        }

    }
}
