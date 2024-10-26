using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PiecesOfArt;
using PiecesOfArt.Interface;
using PiecesOfArt.Models;
using PiecesOfArt.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILoyaltyCardRepository, LoyaltyCardRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieceOfArtRepository, PieceOfArtRepository>();



builder.Services.AddDbContext<ApppDbContext>(
    options =>options.UseSqlServer(builder.Configuration.GetConnectionString("Connec")));

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
