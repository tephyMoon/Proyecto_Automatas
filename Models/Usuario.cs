using System.ComponentModel.DataAnnotations;

namespace ProyectoLenguajes.Api.Models
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        public string Nombres_Usuario { get; set; } = string.Empty;
        public string Apellidos_Usuario { get; set; } = string.Empty;
        public string Password_Usuario { get; set; } = string.Empty;
        public int Estado_Usuario { get; set; } = 1;
        public DateTime Fecha_Nacimiento_Usuario { get; set; }
        public string Email_Usuario { get; set; } = string.Empty;
        public string Celular_Usuario { get; set; } = string.Empty;
        public bool Notificaciones_Correo_Usuario { get; set; }
        public bool Notificaciones_WhatsApp_Usuario { get; set; }
        public int Id_Rol_Usuario { get; set; }
        public DateTime Fecha_Creacion_Usuario { get; set; } = DateTime.UtcNow;
    }
}