using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAcess
{
    public interface IDbContext
    {
        DbSet<Employee> Employees { get; }
        DbSet<Department> Departments { get; }
    }
}
