using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.WebAPI
{
    public class ArtDto
    {
        public string Titulo { get; set; }
        public string ImagenURL{ get; set; }
        public string ArticuloURL { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string NombreCompleto { get; set; }
        public string Contenido { get; set; }
        public string Descripcion { get; set; }
        public string NombreCategoria { get; set; }
        public string NombrePais { get; set; }
        public string NombreFuente { get; set; }
    }
}
