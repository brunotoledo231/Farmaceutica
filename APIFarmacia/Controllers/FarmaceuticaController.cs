using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Datos.fachada;
using Entity;
using Datos;

namespace APIFarmacia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmaceuticaController : ControllerBase
    {
        private IDatos datosAPI;

        public FarmaceuticaController()
        {
            datosAPI = new DatosImp();
        }

        [HttpGet("/sucursales")]
        public IActionResult GetSucursales()
        {
            List<Sucursales> lst = null;
            try
            {
                lst = datosAPI.ObtenerSucursales();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/clientes")]
        public IActionResult GetClientes()
        {
            List<Clientes> lst = null;
            try
            {
                lst = datosAPI.ObtenerClientes();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/productos")]
        public IActionResult GetProductos()
        {
            List<Productos> lst = null;
            try
            {
                lst = datosAPI.ObtenerProductos();
                return Ok(lst);

            }
            catch (Exception ex)
                
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/formaspago")]
        public IActionResult GetFormasPAgo()
        {
            List<FormasPago> lst = null;
            try
            {
                lst = datosAPI.ObtenerFormaPago();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpPost("/factura")]
        public IActionResult PostFactura(Facturas oFactura)
        {
            try
            {
                if (oFactura == null)
                {
                    return BadRequest("Revise los datos de la factura");
                }

                return Ok(datosAPI.CrearFacturas(oFactura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpPost("/login")]
        public IActionResult PostLogin(Sesiones sesion)
        {
            try
            {
                if (sesion == null)
                {
                    return BadRequest("No hay Login");
                }

                return Ok(datosAPI.Loguearse(sesion));

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/facturas")]
        public IActionResult GetFacturas()
        {
            List<Facturas> lstf = null;
            try
            {
                lstf = datosAPI.ObtenerFacturas();
                return Ok(lstf);

            }
            catch (Exception ex)

            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/empleados")]
        public IActionResult GetEmpleados()
        {
            List<Empleados> lst = null;
            try
            {
                lst = datosAPI.ObtenerEmpleados();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/factura")]
        public IActionResult GetFactura()
        {
            Facturas oFacturas = new Facturas();
            int NroFactura;
            try
            {
                NroFactura = datosAPI.ObtenerProximoNumeroFactura();
                return Ok(NroFactura);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }
        [HttpPost("/productos")]
        public IActionResult PostProducto(Productos oProducto)
        {
            try
            {
                if (oProducto == null)
                {
                    return BadRequest("Revise los datos de los productos");
                }

                return Ok(datosAPI.CrearProducto(oProducto));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpPut("/productos")]
        public IActionResult PutProducto(Productos oProducto)
        {
            try
            {
                if (oProducto == null)
                {
                    return BadRequest("Revise los datos de los productos");
                }

                return Ok(datosAPI.ModificarProducto(oProducto));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/tipos_producto")]
        public IActionResult GetTiposProducto()
        {
            List<Tipo_Producto> lst = null;
            try
            {
                lst = datosAPI.ObtenerTipoProducto();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }
        }

        [HttpGet("/detalles")]
        public IActionResult GetDetalles(int detalle)
        {
            List<DetalleFactura> lst = null;
            try
            {
                lst = datosAPI.ObtenerDetallesProductos(detalle);
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error. Comuniquese con el administrador");
            }

        }
    }
}
