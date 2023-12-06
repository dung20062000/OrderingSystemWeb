using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; } // Ví dụ: admin, employee, manager, customer

        public DateTime Create_at { get; set; } = DateTime.Now; // Thiết lập giá trị mặc định khi tạo mới
        public DateTime Update_at { get; set; } = DateTime.Now; // Thiết lập giá trị mặc định khi tạo mới
    }
}
