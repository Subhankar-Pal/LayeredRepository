using EmployeeRepositories;
using EmployeeRepositories.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
     .AddJsonFile("appsettings.json")
     .AddEnvironmentVariables() // read environment variable from launchsetting
     .Build();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EfCoreDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();

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

app.Run();
