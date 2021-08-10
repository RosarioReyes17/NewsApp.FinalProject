using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewsApp.WebAPI.Models
{
    [Table("USUARIOS")]
    public partial class Usuario
    {
        public Usuario()
        {
            Autores = new HashSet<Autore>();
        }

        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(400)]
        public string NombreMostrar { get; set; }
        [Required]
        [StringLength(40)]
        public string NombreUsuario { get; set; }
        [Required]
        [StringLength(400)]
        public string Clave { get; set; }

        [InverseProperty(nameof(Autore.IdUsuarioNavigation))]
        public virtual ICollection<Autore> Autores { get; set; }
    }
}
