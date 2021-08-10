using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsApp.WebAPI.Models
{
    [Table("AUTORES")]
    public partial class Autore
    {
        public Autore()
        {
            Articulos = new HashSet<Articulo>();
        }

        [Key]
        public int IdAutor { get; set; }
        [StringLength(100)]
        public string NombreCompleto { get; set; }
        public int? IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Usuario.Autores))]
        public virtual Usuario IdUsuarioNavigation { get; set; }
        [InverseProperty(nameof(Articulo.IdAutorNavigation))]
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
