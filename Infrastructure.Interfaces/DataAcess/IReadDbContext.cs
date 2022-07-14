using Models;

namespace Infrastructure.Interfaces.DataAcess
{
    public interface IReadDbContext
    {
        IQueryable<Employee> Employees { get; }

        IQueryable<Department> Departments { get; }
    }
}
