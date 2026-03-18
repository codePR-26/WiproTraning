using CollegeManagementSystem.Models;
using System.Collections.Generic;

public class Dept
{
    public int DeptId { get; set; }
    public string DeptName { get; set; }

    // Navigation
    public ICollection<Student> Students { get; set; }
    public ICollection<Professor> Professors { get; set; }
}
