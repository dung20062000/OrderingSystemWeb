using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models.Domain
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? ItemName { get; set; }

        public string? SortDescription { get; set; }

        public string? ItemDescription { get; set; }
        public string? ImageUrl { get; set; } // Đường dẫn hoặc lưu trữ ảnh

        public decimal? Discount { get; set; } // Dấu ? cho phép giá trị nullable (có thể null)

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public int? DiscountId { get; set; }

        public int CategoryId { get; set; }

        public DateTime Create_at { get; set; } = DateTime.Now; // Thiết lập giá trị mặc định khi tạo mới
        public DateTime Update_at { get; set; } = DateTime.Now; // Thiết lập giá trị mặc định khi tạo mới

        [ForeignKey("CreatedByUserID")]
        public User? CreatedByUser { get; set; }

        [ForeignKey("UpdatedByUserID")]
        public User? UpdatedByUser { get; set; }

    }
}
