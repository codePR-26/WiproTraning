namespace CollegeManagementSystem.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }

        // Foreign key
        public int DeptId { get; set; }

        // Navigation
        public Dept Dept { get; set; }
    }

}
