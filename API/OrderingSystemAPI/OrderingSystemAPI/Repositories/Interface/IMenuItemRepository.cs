using EcommerceAPI.Models.Domain;

namespace EcommerceAPI.Repositories.Interface
{
    public interface IMenuItemRepository
    {
        Task<MenuItem> CreateAsync(MenuItem product);
    }
}
