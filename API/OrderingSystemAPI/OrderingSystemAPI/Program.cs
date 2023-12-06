using EcommerceAPI;
using EcommerceAPI.Data;
using EcommerceAPI.Repositories.Implementaion;
using EcommerceAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//kết nối với DB
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


// Gọi phương thức đăng ký dịch vụ từ lớp ServiceRegistration
builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure middleware và các cài đặt khác ở đây...

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
