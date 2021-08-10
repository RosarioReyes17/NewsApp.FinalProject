using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsApp.WebAPI.Models
{
    [Table("FUENTES")]
    public partial class Fuente
    {
        public Fuente()
        {
            Articulos = new HashSet<Articulo>();
        }

        [Key]
        public int IdFuente { get; set; }
        [StringLength(50)]
        public string NombreFuente { get; set; }

        [InverseProperty(nameof(Articulo.IdFuenteNavigation))]
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
