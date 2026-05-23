using System.ComponentModel.DataAnnotations;

namespace StoreProcedureWithASP.Net_Framework.Models
{
    public class ProductModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string product_name { get; set; }

        [Required]
        public int price { get; set; }

        [Required]
        public int quantity { get; set; }

        public string remarks { get; set; }
    }
}