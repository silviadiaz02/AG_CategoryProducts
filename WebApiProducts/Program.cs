using Microsoft.EntityFrameworkCore;
using webApiProducts.Business;
using WebApiProducts.Business.Interfaces;
using WebApiProducts.Data.Models;
using WebApiProducts.Repository;
using WebApiProducts.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var SpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: SpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:4200")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                      });
});
var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddDbContext<DbproductosContext>(options =>
{
    options.UseSqlServer(connectionString);
});
builder.Services.AddScoped<IProductBusiness, ProductBusiness>();
builder.Services.AddScoped<ICategoryBusiness, CategoryBusiness>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(SpecificOrigins);

app.Run();
