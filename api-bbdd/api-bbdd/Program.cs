using api_bbdd.DataContext;
using api_bbdd.ejemploConDI;
using api_bbdd.repository;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddTransient<UsuarioServiceConDI>();
        builder.Services.AddTransient< IEmailServiceConDY, EmailServiceConDY>();
        builder.Services.AddDbContext<DataContextNothwind>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("Northwind")));
        builder.Services.AddTransient<INorthwindRepository, NorthwindRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}