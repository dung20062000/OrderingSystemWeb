using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models.DTOs
{
    public class MenuItemDto
    {
        [Required]
        [MaxLength(255)]
        public string? ItemName { get; set; }

        public string? SortDescription { get; set; }

        public string? ItemDescription { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }

        public decimal? Discount { get; set; }

        //[ForeignKey("DiscountID")]
        //public Discount Discount { get; set; }

    }
}
