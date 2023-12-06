// ServiceRegistration.cs
using EcommerceAPI.Repositories.Implementaion;
using EcommerceAPI.Repositories.Interface;

namespace EcommerceAPI
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMenuItemRepository, MenuItemRepository>();
            // Đăng ký các dịch vụ khác (nếu có)
        }
    }
}
