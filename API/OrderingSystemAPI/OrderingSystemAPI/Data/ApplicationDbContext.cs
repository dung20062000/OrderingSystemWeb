using EcommerceAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data
{
    public class ApplicationDbContext : DbContext //khai báo lớp và thừa kế lớp DbContext của entity
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        //cấu hình Relationship của bảng
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MenuCategoryItem>()
        //        .HasKey(mc => new { mc.MenuItemId, mc.CategoryId });

        //    modelBuilder.Entity<MenuCategoryItem>()
        //        .HasOne(mc => mc.MenuItem)
        //        .WithMany(mi => mi.MenuCategoryItems)
        //        .HasForeignKey(mc => mc.MenuItemId);

        //    modelBuilder.Entity<MenuCategoryItem>()
        //        .HasOne(mc => mc.Category)
        //        .WithMany(c => c.MenuCategoryItems)
        //        .HasForeignKey(mc => mc.CategoryId);
        //}
    }
}
