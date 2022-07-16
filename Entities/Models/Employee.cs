namespace Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateOnly DateOfBirth { get; set; } 
        public string Adress { get; set; } = null!;
        public Department Department { get; set; } = null!;
        public string? Description { get; set; }


    }
}