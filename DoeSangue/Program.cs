using DoeSangue.Applications.Command.CreateBloodStock;
using DoeSangue.Applications.Command.CreateDonor;
using DoeSangue.Applications.Queries;
using DoeSangue.Applications.Queries.GetAllDonation;
using DoeSangue.Domain.Repositories;
using DoeSangue.Infrastructure.Persistence;
using DoeSangue.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DoeSangueDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DoeSanguecs")));
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateBloodStockCommand).Assembly));

// Register your services here before building the application
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IBloodStockRepository, BloodStockRepository>();
builder.Services.AddScoped<IDonationRepository, DonationRepository>();
builder.Services.AddScoped<IDonorsRepository, DonorsRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



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
