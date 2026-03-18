using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebAPI.Models
{
    public class Employees
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [ForeignKey("Dept")]

        public int DeptId { get; set; }

        public Department Dept { get; set; }
    }
}
