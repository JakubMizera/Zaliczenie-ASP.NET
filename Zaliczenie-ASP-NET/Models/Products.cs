using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zaliczenie_ASP_NET.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        public string Info { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
