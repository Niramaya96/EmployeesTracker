namespace Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Adress { get; set; }
        public Department Department { get; set; }
        public string? Description { get; set; }


    }
}