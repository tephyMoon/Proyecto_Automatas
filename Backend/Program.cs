using Microsoft.EntityFrameworkCore;
using ProyectoLenguajes.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// --- INICIO DE CONFIGURACIÓN ---

// 1. Configurar CORS para permitir peticiones desde el frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowNuxtApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // La URL donde correrá tu app Nuxt
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// 2. Obtener la cadena de conexión de appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 3. Registrar el DbContext para que la app sepa cómo conectar a MySQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);


// --- FIN DE CONFIGURACIÓN ---

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// --- USAR CORS ---
app.UseCors("AllowNuxtApp"); // Aplicar la política de CORS que definimos

app.UseAuthorization();

app.MapControllers();

app.Run();