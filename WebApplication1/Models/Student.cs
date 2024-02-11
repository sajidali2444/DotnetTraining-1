namespace WebApplication1.Models
{
    public class Student
    {
        public Student() { }
        public Student(string firstName, string lastName, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
        }
        public Student(string firstName, string lastName, string phone, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
        }

        public int Register(Student student)
        {
            var data = student;
            return data.Id;
        }
        private int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = "ABC as default value";
        public string? Email { get; set; }
        public string Phone { get; set; }
        public char ? Gender { get; set; } //M,F
        public bool IsActive { get; set; }//true/false
        
    }
}
