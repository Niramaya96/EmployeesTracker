

namespace Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        
        public string Surname { get; set; }

        public DateOnly DateOfBirth { get; set; }
        public string Adress { get; set; }
        public Department Department { get; set; }
        public string? Description { get; set; }


    }
}
