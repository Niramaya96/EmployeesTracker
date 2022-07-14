
using Microsoft.EntityFrameworkCore;

namespace DataAcess
{
    internal interface IDbContext
    {
        DbSet<Employee> Employees { get; }

        DbSet<Department> Departments { get; }

    }
}
