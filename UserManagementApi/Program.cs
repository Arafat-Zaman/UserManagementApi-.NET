using Microsoft.EntityFrameworkCore;
using UserManagementApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure Entity Framework with In-Memory Database
builder.Services.AddDbContext<UserContext>(options =>
    options.UseInMemoryDatabase("UserList"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
