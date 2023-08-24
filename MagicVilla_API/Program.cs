using MagicVilla_API.Datos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Cada vez que se instala un paquete este debe de a�adirse aqui como servicio

builder.Services.AddControllers().AddNewtonsoftJson(); //Aqui se a�adio para poder trabajar con httppatch
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); //Asi se indica que utilice el defaultconnection 
    //definido en appsettings.json despues de haber creado la clase ApplicationDbcontext 
});

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
