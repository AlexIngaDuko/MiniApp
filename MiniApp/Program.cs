using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Models; // 👈 IMPORTANTE
using MiniApp.Data;

var builder = WebApplication.CreateBuilder(args);

// PRUEBA
var conn = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine("CONEXIÓN:");
Console.WriteLine(conn);

// Servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// 
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MiniApp API",
        Version = "v1"
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiniApp API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();