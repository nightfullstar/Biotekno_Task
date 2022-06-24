using Biotekno_Task.Api;
using Biotekno_Task.Api.Infrastructure.Providers;
using Biotekno_Task.Api.Infrastructure.Interfaces;
using Biotekno_Task.Api.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Biotekno_Task.Api.Infrastructure.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddMediatR(typeof(Program).Assembly);
builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});


builder.Services.AddScoped(typeof(IMediator), typeof(Mediator));
builder.Services.AddScoped(typeof(IOrderRepository),typeof(OrderRepository));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddTransient(typeof(ICacheService), typeof(CacheService));
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
