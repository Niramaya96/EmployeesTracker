using Models;
using System.Linq;

namespace DataAcess
{
    public interface IReadDbContext
    {
        IQueryable<Employee> Employees { get; }
        IQueryable<Department> Departments { get; }
    }
}
