using API.Helpers;
using AutoMapper;
using BLL.Entites;
using BLL.Interfaces;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IGenericRepository<ProductBrand>, GenericRepository<ProductBrand>>();
builder.Services.AddTransient<IGenericRepository<ProductType>, GenericRepository<ProductType>>();
builder.Services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();


builder.Services.AddControllers();

builder.Services.AddDbContext<StoreContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);

var app = builder.Build();

SeedDatabase();

async void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    try
    {
        var services = scope.ServiceProvider;
        var loggerFactory = services.GetRequiredService<ILoggerFactory>();

        var scopedContext = services.GetRequiredService<StoreContext>();
        await scopedContext.Database.MigrateAsync();
        await StoreContextSeed.SeedAsync(scopedContext, loggerFactory);
    }
    catch
    {
        throw;
    }
}
    

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseStaticFiles();

app.UseAuthentication();

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
