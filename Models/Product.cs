using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW04.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        [Display(Name="產品名稱")]
        public string Name { get; set; }
        [Required]
        [Display(Name="價格 (NTD)")]
        public decimal Price { get; set; }
    }
}
