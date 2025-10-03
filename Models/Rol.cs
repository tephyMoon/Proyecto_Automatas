namespace ProyectoLenguajes.Api.Models
{
    // Representa la tabla Roles de la base de datos
    public class Rol
    {
        public int IdRol { get; set; }
        public string? Rol_Nombre { get; set; } // Ajustado para que coincida con el posible nombre en la BD
    }
}