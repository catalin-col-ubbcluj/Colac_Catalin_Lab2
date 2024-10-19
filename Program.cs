using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Colac_Catalin_Lab2.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Colac_Catalin_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Colac_Catalin_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Colac_Catalin_Lab2Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
