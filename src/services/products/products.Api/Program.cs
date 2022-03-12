using Microsoft.EntityFrameworkCore;
using products.Api;
using products.Infrustructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddServiceRegistery();
builder.AddInfrustructureServices();
builder.AddApplicationServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
