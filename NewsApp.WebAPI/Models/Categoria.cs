using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsApp.WebAPI.Models
{
    [Table("CATEGORIAS")]
    public partial class Categoria
    {
        public Categoria()
        {
            Articulos = new HashSet<Articulo>();
        }

        [Key]
        public int IdCategoria { get; set; }
        [StringLength(50)]
        public string NombreCategoria { get; set; }

        [InverseProperty(nameof(Articulo.IdCategoriaNavigation))]
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
