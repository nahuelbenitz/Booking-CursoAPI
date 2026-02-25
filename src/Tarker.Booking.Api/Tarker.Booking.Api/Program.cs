using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;
using Tarker.Booking.Persistence.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseService>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IDataBaseService, DataBaseService>();


var app = builder.Build();


app.Run();
