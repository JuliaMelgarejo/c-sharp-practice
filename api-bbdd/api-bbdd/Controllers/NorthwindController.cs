using System.ComponentModel.DataAnnotations;
using api_bbdd.Model;
using api_bbdd.QueryResponse;
using api_bbdd.repository;
using Microsoft.AspNetCore.Mvc;
namespace api_bbdd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private readonly INorthwindRepository _repository;

        public NorthwindController(INorthwindRepository repository)
        {
            _repository = repository;
        }
        [Route("api/ObtenerTodosLosEmpleados")]
        [HttpGet]
        public async Task<List<Employees>> ObtenerTodosLosEmpleados()
        {
            return await _repository.ObtenerTodosLosEmpleados();
        }
        [Route("api/ObtenerCantidadDeEmpleados")]
        [HttpGet]
        public async Task<int> ObtenerCantidadDeEmpleados()
        {
            return await _repository.ObtenerCantidadDeEmpleados();
        }
        [Route("api/ObtenerEmpleadoPorId")]
        [HttpGet]
        public async Task<Employees> ObtenerEmpleadoPorId([FromQuery] int id)
        {
            return await _repository.ObtenerEmpleadoPorId(id);
        }

        [Route("api/ObtenerEmpleadoPorNombre")]
        [HttpGet]
        public async Task<Employees> ObtenerEmpleadoPorNombre([FromQuery] string name)
        {
            return await _repository.ObtenerEmpleadoPorNombre(name);
        }

        [Route("api/ObtenerEmpleadoPorTitulo")]
        [HttpGet]
        public async Task<Employees> ObtenerEmpleadoPorTitulo([FromQuery] string titulo)
        {
            return await _repository.ObtenerEmpleadoPorTitulo(titulo);
        }

        [Route("api/ObtenerEmpleadoPorPais")]
        [HttpGet]
        public async Task<Employees> ObtenerEmpleadoPorPais([FromQuery] string pais)
        {
            return await _repository.ObtenerEmpleadoPorPais(pais);
        }

        [Route("api/ObtenerTodosLosEmpleadosPorPais")]
        [HttpGet]
        public async Task<List<Employees>> ObtenerTodosLosEmpleadosPorPais([FromQuery] string pais)
        {
            return await _repository.ObtenerTodosLosEmpleadosPorPais(pais);
        }

        [Route("api/ObtenerElEmpleadoMasGrande")]
        [HttpGet]
        public async Task<Employees> ObtenerElEmpleadoMasGrande()
        {
            return await _repository.ObtenerElEmpleadoMasGrande();
        }

        [Route("api/ObtenerCantidadEmpleadosPorTitulo")]
        [HttpGet]
        public async Task<List<EmpleadoPorTituloResponse>> ObtenerCantidadEmpleadosPorTitulo()
        {
            return await _repository.ObtenerCantidadEmpleadosPorTitulo();
        }

        [Route("api/ObtenerProductosConCategoria")]
        [HttpGet]
        public async Task<List<ProductosPorCategoriaResponse>> ObtenerProductosConCategoria()
        {
            return await _repository.ObtenerProductosConCategoria();
        }

        [Route("api/ObtenerProductosQueContienen")]
        [HttpGet]
        public async Task<List<Products>> ObtenerProductosQueContienen(string palabra)
        {
            return await _repository.ObtenerProductosQueContienen(palabra);
        }

        [HttpDelete]
        [Route("api/EliminarOrdenPorId")]
        public async Task<bool> EliminarOrdenPorId([Required, FromQuery] int OrderID)
        {
            return await _repository.EliminarOrdenPorId(OrderID);
        }

        [HttpPut]
        [Route("api/ModificarNombreEmpleado")]
        public async Task<bool> ModificarNombreEmpleado([Required, FromQuery]int idEmpleado, [Required, FromQuery] string Nombre)
        {
            return await _repository.ModificarNombreEmpleado(idEmpleado, Nombre);
        }

        [HttpPut]
        [Route("api/InsertarEmpleado")]
        public async Task<bool> InsertarEmpleado()
        {
            return await _repository.InsertarEmpleado();
        }

    }
}

