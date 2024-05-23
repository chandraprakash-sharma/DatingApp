using API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//add data context as service
//adding as service in this file



builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt=>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));    
});

var app = builder.Build();
 
app.UseHttpsRedirection();

app.UseHttpsRedirection();

app.UseAuthentication();

app.MapControllers();

app.Run();