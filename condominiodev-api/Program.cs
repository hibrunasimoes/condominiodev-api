using condominiodev_api.Database;
using condominiodev_api.Database.Repositories;
using condominiodev_api.Interfaces.Repository;
using condominiodev_api.Interfaces.Service;
using condominiodev_api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CondominioDevDbContext>();

// Add services to the container.
builder.Services.AddScoped<IHabitanteRepository,HabitanteRepository>();
builder.Services.AddScoped<IHabitanteService,HabitanteService>();
builder.Services.AddControllers();

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

