using EcommerceAPI.Data;
using EcommerceAPI.Models.Domain;
using EcommerceAPI.Repositories.Interface;

namespace EcommerceAPI.Repositories.Implementaion
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly ApplicationDbContext _context;

        public MenuItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<MenuItem> CreateAsync(MenuItem menuItem)
        {
            await _context.AddAsync(menuItem);
            await _context.SaveChangesAsync();

            return menuItem;
        }
    }
}
