using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsApp.WebAPI.Models
{
    [Table("ARTICULOS")]
    public partial class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        [Column("ArticuloURL")]
        public string ArticuloUrl { get; set; }
        [Column("ImagenURL")]
        public string ImagenUrl { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaPublicacion { get; set; }
        public string Contenido { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdPais { get; set; }
        public int? IdFuente { get; set; }
        public int? IdAutor { get; set; }

        [ForeignKey(nameof(IdAutor))]
        [InverseProperty(nameof(Autore.Articulos))]
        public virtual Autore IdAutorNavigation { get; set; }
        [ForeignKey(nameof(IdCategoria))]
        [InverseProperty(nameof(Categoria.Articulos))]
        public virtual Categoria IdCategoriaNavigation { get; set; }
        [ForeignKey(nameof(IdFuente))]
        [InverseProperty(nameof(Fuente.Articulos))]
        public virtual Fuente IdFuenteNavigation { get; set; }
        [ForeignKey(nameof(IdPais))]
        [InverseProperty(nameof(Paise.Articulos))]
        public virtual Paise IdPaisNavigation { get; set; }
    }
}
