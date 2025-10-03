using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoLenguajes.Api.Data;
using ProyectoLenguajes.Api.Models;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    // Inyectamos el DbContext para poder usarlo en nuestros métodos
    public UsuariosController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("registro")]
    public async Task<IActionResult> RegistrarUsuario([FromBody] RegistroRequest request)
    {
        // Verificamos si el correo ya está en uso
        if (await _context.Usuarios.AnyAsync(u => u.Email_Usuario == request.Email_Usuario))
        {
            return BadRequest(new { message = "El correo electrónico ya está registrado." });
        }

        // Ciframos la contraseña
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password_Usuario);

        var nuevoUsuario = new Usuario
        {
            Nombres_Usuario = request.Nombres_Usuario,
            Apellidos_Usuario = request.Apellidos_Usuario,
            Email_Usuario = request.Email_Usuario,
            Password_Usuario = passwordHash,
            Celular_Usuario = request.Celular_Usuario,
            Fecha_Nacimiento_Usuario = request.Fecha_Nacimiento_Usuario,
            // Por defecto el rol es Analista (ID 4) [cite: 45]
            Id_Rol_Usuario = 4,
            Notificaciones_Correo_Usuario = request.Notificaciones_Correo_Usuario,
            Notificaciones_WhatsApp_Usuario = request.Notificaciones_WhatsApp_Usuario
        };

        // Guardamos el nuevo usuario en la base de datos
        _context.Usuarios.Add(nuevoUsuario);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Usuario registrado exitosamente" });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest login)
    {
        // Buscamos al usuario por su correo electrónico
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email_Usuario == login.Email);

        if (usuario == null)
        {
            // Si no encontramos al usuario, devolvemos un error.
            // Usamos un mensaje genérico por seguridad.
            return Unauthorized(new { message = "Credenciales inválidas" });
        }

        // Verificamos que la contraseña sea correcta
        bool esPasswordValido = BCrypt.Net.BCrypt.Verify(login.Password, usuario.Password_Usuario);

        if (!esPasswordValido)
        {
            return Unauthorized(new { message = "Credenciales inválidas" });
        }
        
    // Si las credenciales son correctas, en el futuro aquí generarás el token JWT
        return Ok(new { message = "Login exitoso!", token = "aqui_ira_el_jwt_token_en_el_futuro" });
    }
}

// Clases DTO (Data Transfer Object) para manejar las peticiones de forma limpia

public class LoginRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class RegistroRequest
{
    public string Nombres_Usuario { get; set; }
    public string Apellidos_Usuario { get; set; }
    public string Email_Usuario { get; set; }
    public string Password_Usuario { get; set; }
    public string Celular_Usuario { get; set; }
    public DateTime Fecha_Nacimiento_Usuario { get; set; }
    public bool Notificaciones_Correo_Usuario { get; set; }
    public bool Notificaciones_WhatsApp_Usuario { get; set; }
}