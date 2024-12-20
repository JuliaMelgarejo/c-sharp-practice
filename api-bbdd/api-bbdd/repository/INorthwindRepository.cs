﻿using System.ComponentModel.DataAnnotations;
using api_bbdd.Model;
using api_bbdd.QueryResponse;
using Microsoft.AspNetCore.Mvc;

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
        Task<List<EmpleadoPorTituloResponse>> ObtenerCantidadEmpleadosPorTitulo();
        Task<List<ProductosPorCategoriaResponse>> ObtenerProductosConCategoria();
        Task<List<Products>> ObtenerProductosQueContienen(string palabra);
        Task<bool> EliminarOrdenPorId(int id);
        Task<bool> ModificarNombreEmpleado(int idEmpleado, string Nombre);
        Task<bool> InsertarEmpleado();
    }
}
