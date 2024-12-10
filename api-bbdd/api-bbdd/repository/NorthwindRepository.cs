
using api_bbdd.DataContext;
using api_bbdd.Model;
using Microsoft.EntityFrameworkCore;

namespace api_bbdd.repository;
public class NorthwindRepository : INorthwindRepository
    {
    private readonly DataContextNothwind _dataContext;

    public NorthwindRepository(DataContextNothwind dataContext)
    {
        _dataContext = dataContext;  
    }

    public async Task<List<Employees>> ObtenerTodosLosEmpleados()
    {
        var result = await _dataContext.Employees.ToListAsync();
        return result;
    }

    public async Task<int> ObtenerCantidadDeEmpleados()
    {
        var result = await _dataContext.Employees.CountAsync();
        return result;
    }

    public async Task<Employees> ObtenerEmpleadoPorId(int id)
    {
        var result = await _dataContext.Employees.Where(e => e.EmployeeID == id).FirstOrDefaultAsync();
        return result;
    }

    public async Task<Employees> ObtenerEmpleadoPorNombre(string name)
    {
        var result = await _dataContext.Employees.FirstOrDefaultAsync(e => e.FirstName== name);
        return result;
    }

    public async Task<Employees> ObtenerEmpleadoPorTitulo(string titulo)
    {
        var result = from emp in _dataContext.Employees where emp.Title == titulo select emp;
        return await result.FirstOrDefaultAsync();
    }

    public async Task<Employees> ObtenerEmpleadoPorPais(string pais)
    {
        var result = from emp in _dataContext.Employees
                     where emp.Country == pais
                     select new Employees
                     {
                         Title = emp.Title,
                         FirstName = emp.FirstName
                     };
        return await result.FirstOrDefaultAsync();
    }

    public async Task<List<Employees>> ObtenerTodosLosEmpleadosPorPais(string pais)
    {
        var result = from emp in _dataContext.Employees
                     where emp.Country == pais
                     orderby emp.FirstName
                     select new Employees
                     {
                         Title = emp.Title,
                         FirstName = emp.FirstName
                     };
        return await result.ToListAsync();
    }

    public async Task<Employees> ObtenerElEmpleadoMasGrande()
    {
        var result = from emp in _dataContext.Employees                  
                     orderby emp.BirthDate
                     select new Employees
                     {
                         Title = emp.Title,
                         FirstName = emp.FirstName,
                         LastName = emp.LastName

                     };
        return await result.FirstOrDefaultAsync();
    }

}

