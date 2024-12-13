using api_bbdd.Model;
using Microsoft.EntityFrameworkCore;

namespace api_bbdd.DataContext;

public class DataContextNothwind : DbContext
{
    public DataContextNothwind(DbContextOptions<DataContextNothwind> options) : base(options)
    {

    }

    public DbSet<Employees> Employees { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<Orders> Orders { get; set; }
}
