using Microsoft.EntityFrameworkCore;
using ShopOnline.WebApi.Data;
using ShopOnline.WebApi.Repositories;
using ShopOnline.WebApi.Repositories.Contracts;
using Newtonsoft.Json;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<ShopOnlineDBContext>(options =>
{
    options.UseSqlServer(Environment.GetEnvironmentVariable("ShopOnlineCS"));
});
builder.Services.AddScoped<IPoductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
{
    policy.WithOrigins("http://localhost:5121", "https://localhost:7232")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType);
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
