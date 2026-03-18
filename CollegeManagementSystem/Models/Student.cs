using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Foreign key
        public int DeptId { get; set; }

        // Navigation
        public Dept Dept { get; set; }
    }

}
