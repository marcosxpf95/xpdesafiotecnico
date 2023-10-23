using Microsoft.EntityFrameworkCore;
using XPDesafioTecnico.Services;
using XPDesafioTecnico.Services.Interfaces;
using XPDesafioTecnico.Repository;
using XPDesafioTecnico.Repository.Interfaces;
using XPDesafioTecnico.Mapping;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Configurações do DbContext
builder.Services.AddDbContext<DesafioTecnicoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DesafioTecnicoDbConnection"));
}, ServiceLifetime.Transient);

// Add services to the container.
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//Services
builder.Services.AddScoped<IClienteService, ClienteService>();

//Repositories
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DesafioTecnicoContext>();
    dbContext.Database.Migrate();
}

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
