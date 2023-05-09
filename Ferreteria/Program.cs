



using DataAccess.DAO;
using DataAccess.INTERFACES;
using DataAccess.SQLDATA;
using Ferreteria.EndPoints;
using Microsoft.OpenApi.Models;

string MyCors = "_MyCorss";

// ---------------------------------------------------------------------------------------------------
var builder = WebApplication.CreateBuilder(args);

var contactInfo = new OpenApiContact()
{
    Name = "Yen C�ceres",
    Email = "ti@andesindustrial.cl",
    Url = new Uri("https://www.andesindutrial.cl")
};

var Licensia = new OpenApiLicense()
{
    Name = "Private",
};

var info = new OpenApiInfo()
{
    Version = "v1",
    Title = "API Informes",
    Description = "Consulta de informes Andes Industrial",
    Contact = contactInfo,
    License = Licensia,
};

// Secci�n de builder and  Add services
// ---------------------------------------------------------------------------------------------------

#region Servicios Cors

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyCors, builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().WithMethods("GET", "POST", "DELETE");
    });

});

#endregion

#region Servicios para levantar Swagger

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

#region Servicio de inyeccion de dependencias

builder.Services.AddSingleton<ISqlDao, SqlDao>();


#endregion

#region Servicio de acceso a datos


builder.Services.AddSingleton<IAccessoRegionCiudadComunaDao, AccessoRegionCiudadComunaDao>();
builder.Services.AddSingleton<IAccessoClienteDireccion,AccessoClienteDireccion >();
builder.Services.AddSingleton<IAccessoProductos, AccessoProductos>();

#endregion

var app = builder.Build();

#region Configure the HTTP request pipeline and UseCors

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyCors);
#endregion

#region ConfigurarEndpoints

app.ConfigurarEndpoints(builder.Configuration["AGSettings:versionApi"]);

#endregion

app.UseHttpsRedirection();

app.Run();

