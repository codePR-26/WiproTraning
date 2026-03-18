using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp2.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("categ")]
            
        public string CategId { get; set; }

        public string Description { get; set; }
        public int Category { get; set; } // Add this property to fix CS1061

    }
}
