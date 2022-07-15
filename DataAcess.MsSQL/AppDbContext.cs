using Infrastructure.Interfaces.DataAcess;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAcess.MsSQL
{
    public class AppDbContext : DbContext, IDbContext, IReadDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees => throw new NotImplementedException();
        public DbSet<Department> Departments => throw new NotImplementedException();

        IQueryable<Employee> IReadDbContext.Employees => throw new NotImplementedException();
        IQueryable<Department> IReadDbContext.Departments => throw new NotImplementedException();
    }
}