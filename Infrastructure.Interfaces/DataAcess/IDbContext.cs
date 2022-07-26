using Microsoft.EntityFrameworkCore;
using Models;

namespace Infrastructure.Interfaces.DataAcess
{
    public interface IDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }
    }
}
