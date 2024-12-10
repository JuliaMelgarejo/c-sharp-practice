using api_bbdd.Model;
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
        public async Task<Employees> ObtenerEmpleadoPorId([FromQuery]int id)
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
    }
}
