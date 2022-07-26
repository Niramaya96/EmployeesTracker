using DataAcess.MsSQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));



var app = builder.Build();
app.MapGet("/", (AppDbContext db) => db.Employees.ToList());

app.Run();



