using api_bbdd.Model;

namespace api_bbdd.repository
{
    public interface INorthwindRepository
    {
        Task<List<Employees>> ObtenerTodosLosEmpleados();
        Task<int> ObtenerCantidadDeEmpleados();
        Task<Employees> ObtenerEmpleadoPorId(int id);
        Task<Employees> ObtenerEmpleadoPorNombre(string name);
        Task<Employees> ObtenerEmpleadoPorTitulo(string titulo);
        Task<Employees> ObtenerEmpleadoPorPais(string pais);
        Task<List<Employees>> ObtenerTodosLosEmpleadosPorPais(string pais);
        Task<Employees> ObtenerElEmpleadoMasGrande(); 
    }
}
