using EcommerceAPI.Data;
using EcommerceAPI.Models.Domain;
using EcommerceAPI.Models.DTOs;
using EcommerceAPI.Repositories.Implementaion;
using EcommerceAPI.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    public class MenuItemController : BaseApiController
    {
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly ApplicationDbContext _context;

        public MenuItemController(IMenuItemRepository menuItemRepository, ApplicationDbContext context)
        {
            _menuItemRepository = menuItemRepository;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(MenuItemDto menuItemDto)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(menuItemDto.ItemName))
            {
                return BadRequest("Tên món không được trống.");
            }

            if (menuItemDto.Price < 0)
            {
                return BadRequest("Giá sản phẩm phải lớn hơn hoặc bằng 0.");
            }

            // Kiểm tra trùng lặp
            if (await _context.MenuItems.AnyAsync(p => p.ItemName == menuItemDto.ItemName))
            {
                return BadRequest("Sản phẩm với tên đã tồn tại.");
            }

            var item = new MenuItem
            {
                ItemName = menuItemDto.ItemName,
                SortDescription = menuItemDto.SortDescription,
                ItemDescription = menuItemDto.ItemDescription,
                Price = menuItemDto.Price,
                ImageUrl = menuItemDto.ImageUrl,
                Discount = menuItemDto.Discount,
            };

            await _menuItemRepository.CreateAsync(item);

            var response = new MenuItemDto
            {
                ItemName = menuItemDto.ItemName,
                SortDescription = menuItemDto.SortDescription,
                ItemDescription = menuItemDto.ItemDescription,
                Price = menuItemDto.Price,
                ImageUrl = menuItemDto.ImageUrl,
                Discount = menuItemDto.Discount,
            };

            return Ok(response);

        }
    }
}
