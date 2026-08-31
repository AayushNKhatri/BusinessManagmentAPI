using BusinessManagment.DomainLayer.Configuration;
using BusinessManagment.PresentaionLayer.Config;
using BusinessManagment.PresentaionLayer.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDBContext>(option =>
{
    option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddIdentityConfiguration();

var app = builder.Build();
app.ApplyPendingMigrations();
app.UseMiddleware<GlobalExeption>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
