namespace AppEstudiantes.Data;

using System.Text.Json.Serialization;
public class Estudiante
    {
        [JsonPropertyName("id_estudiante")]
        public Int32 Id_estudiante { get; set; }

        [JsonPropertyName("carnet")]
        public string? Carnet { get; set; }
     
        [JsonPropertyName("nombres")]
        public string? Nombres { get; set; }

        [JsonPropertyName("apellidos")]
        public string? Apellidos { get; set; }

        [JsonPropertyName("direccion")]
        public string? Direccion { get; set; }

        [JsonPropertyName("telefono")]
        public string? Telefono { get; set; }

        [JsonPropertyName("correo_electronico")]
        public string? Correo_electronico { get; set; }
 
        [JsonPropertyName("id_tipo_sangre")]
        public Int32 Id_tipo_sangre { get; set; }
        
        [JsonPropertyName("fecha_nacimiento")]
        public DateTime? Fecha_nacimiento { get; set; }

    }