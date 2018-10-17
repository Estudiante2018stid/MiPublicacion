using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiPublicacion.Models
{
    [Table("Publicacion")]
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }

        [MaxLength (50)]
        [Required]
        public string Usuario { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }

        public int Megusta { get; set; }

        public int MeDiscusta { get; set; }

        public int VecesCompartido { get; set; }

        public bool EsPrivada { get; set; }
    }
}