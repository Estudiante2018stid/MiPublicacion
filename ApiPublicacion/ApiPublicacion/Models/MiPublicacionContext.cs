using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiPublicacion.Models
{
    
    public class MiPublicacionContext : DbContext
    {
        public MiPublicacionContext() : base("PublicacionConnection")
        {

        }
        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}