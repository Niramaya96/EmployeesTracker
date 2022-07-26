using Infrastructure.Interfaces.DataAcess;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAcess.MsSQL
{
    public class AppDbContext : DbContext, IDbContext, IReadDbContext
    {
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;

        IQueryable<Employee> IReadDbContext.Employees => Employees.AsNoTracking();
        IQueryable<Department> IReadDbContext.Departments => Departments.AsNoTracking();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOne(c => c.Department)
                                           .WithMany(u => u.Employees)
                                           .HasForeignKey(c => c.DepartmentId)
                                           .OnDelete(DeleteBehavior.Cascade)
                                           .IsRequired();

            modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, Name = "Dev" },
            new Department { Id = 2, Name = "Marketing" },
            new Department { Id = 3, Name = "Art" });

            modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 11, DepartmentId = 1, FirstName = "Максим" },
            new Employee { Id = 12, DepartmentId = 2, FirstName = "Иван" },
            new Employee { Id = 13, DepartmentId = 3, FirstName = "Дмитрий" });




        }

       
    }
}