using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogAlkemy.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Titulo { get; set; }


        [Required]
        [StringLength(300, MinimumLength = 3)]
        public string Contenido { get; set; }

        public byte[] Imagen { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Categoria { get; set; }
        public DateTime Fecha { get; set; }


   }
}