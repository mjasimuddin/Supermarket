using API.Extensions;
using API.Helpers;
using AutoMapper;
using BLL.Entites;
using BLL.Entities.Identity;
using BLL.Interfaces;
using DAL.Data;
using DAL.Identity;
using DAL.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddTransient<IProductRepository, ProductRepository>();
//builder.Services.AddTransient<IGenericRepository<ProductBrand>, GenericRepository<ProductBrand>>();
//builder.Services.AddTransient<IGenericRepository<ProductType>, GenericRepository<ProductType>>();
//builder.Services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();

//builder.Services.AddTransient<ITokenService, TokenService>();



builder.Services.AddControllers();

builder.Services.AddDbContext<StoreContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<AppIdentityDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection")));


builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddApplicationServices();
builder.Services.AddIdentityServices(builder.Configuration);

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

            var userManager = services.GetRequiredService<UserManager<AppUser>>();
            var identityContext = services.GetRequiredService<AppIdentityDbContext>();
            await identityContext.Database.MigrateAsync();
            await AppIdentityDbContextSeed.SeedUserAsync(userManager);

        }
    catch
    {
        throw;
    }
}


#if DEBUG
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot")),
    RequestPath = new PathString("/wwwroot")
});
#endif


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseStaticFiles();

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
