
using System.ComponentModel.DataAnnotations;
using api_bbdd.DataContext;
using api_bbdd.Model;
using api_bbdd.QueryResponse;
using Microsoft.AspNetCore.Mvc;
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

    public async Task<List<EmpleadoPorTituloResponse>> ObtenerCantidadEmpleadosPorTitulo()
    {
        var result = await( from emp in _dataContext.Employees
                     group emp by emp.Title into g 
                     select new EmpleadoPorTituloResponse
                     {
                         Titulo = g.Key, 
                         CantidadEmpleados = g.Count()

                     }).ToListAsync();
        return result;
    }

    public async Task<List<ProductosPorCategoriaResponse>> ObtenerProductosConCategoria()
    {
        var result = await (from prod in _dataContext.Products
                            join cat in _dataContext.Categories on prod.CategoryID equals cat.CategoryID
                            select new ProductosPorCategoriaResponse
                            {
                                Producto = prod.ProductName,
                                Categoria = cat.CategoryName

                            }).ToListAsync();
        return result;
    }

    public async Task<List<Products>> ObtenerProductosQueContienen(string palabra)
    {
        var result = await _dataContext.Products.Where(p => p.ProductName.Contains(palabra)).ToListAsync();
        return result;
    }
    public async Task<bool> EliminarOrdenPorId(int OrderID)
    {
        Orders? orden = await _dataContext.Orders.Where(r => r.OrderID == OrderID).FirstOrDefaultAsync();
        OrderDetails? ordenDetail = await _dataContext.OrderDetails.Where(r=> r.OrderID == orden.OrderID).FirstOrDefaultAsync();

        _dataContext.OrderDetails.Remove(ordenDetail);
        _dataContext.Orders.Remove(orden);

        var result = _dataContext.SaveChanges();
        return true;
    }

    public async Task<bool> ModificarNombreEmpleado(int idEmpleado, string Nombre)
    {
        bool actualizado = false ;
        Employees result = await _dataContext.Employees.Where(e => e.EmployeeID == idEmpleado).FirstOrDefaultAsync();

        if (result != null)
        {
           result.FirstName = Nombre;
            var resulta =  _dataContext.SaveChanges();
            actualizado = true;
        }

        return actualizado ;
    }

    public async Task<bool> InsertarEmpleado()
    {
        Employees employee = new Employees();
        employee.Title = "Developer";
        employee.LastName = "Melgarejo";
        employee.FirstName = "Julia";
        employee.Country = "Argentina";
        employee.City = "Rosario";
        employee.BirthDate = DateTime.Now;
        employee.HireDate = DateTime.Now;
        var newEmployees = await _dataContext.AddAsync(employee);
        var result = _dataContext.SaveChanges();

        return (result > 0);


    }

}

