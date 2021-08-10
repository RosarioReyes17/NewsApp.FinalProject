using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsApp.WebAPI.Models
{
    [Table("PAISES")]
    public partial class Paise
    {
        public Paise()
        {
            Articulos = new HashSet<Articulo>();
        }

        [Key]
        public int IdPais { get; set; }
        [StringLength(50)]
        public string NombrePais { get; set; }

        [InverseProperty(nameof(Articulo.IdPaisNavigation))]
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
