using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Management1
{
    class ArtFormDto
    {
        public int IdArticulo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
       
        public string ArticuloUrl { get; set; }
      
        public string ImagenUrl { get; set; }
        
        public DateTime? FechaPublicacion { get; set; }
        public string Contenido { get; set; }

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public int IdPais { get; set; }
        public string NombrePais { get; set; }

        public int IdFuente { get; set; }
        public string NombreFuente { get; set; }

        public int IdAutor { get; set; }
        public string NombreCompleto { get; set; }


    }
}
