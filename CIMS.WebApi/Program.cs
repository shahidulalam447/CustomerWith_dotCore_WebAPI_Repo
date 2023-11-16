using CIMS.DAL;
using CIMS.DAL.Interface;
using CIMS.Repo.Implementation;
using CIMS.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("appCon"),a=>a.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(IGenericRepo<>));
builder.Services.AddScoped<ICustomerRepo,CustomerRepo>();
builder.Services.AddScoped<ICountryRepo,CountryRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseAuthorization();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
