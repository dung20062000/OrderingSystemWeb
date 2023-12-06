using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models.Domain
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }


        // Các trường khác của Category
        //public ICollection<MenuCategoryItem> MenuCategoryItems { get; set; }
    }
}
