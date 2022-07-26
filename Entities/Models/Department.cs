

namespace Models
{
    public class Department 
    {
        
        public int Id { get; set; } 
        public string Name { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; } = null!;

    }
    
}
