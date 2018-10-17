using ApiPublicacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPublicacion.Controllers
{
    public class PublicacionController : ApiController
    {
        //Listar
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new MiPublicacionContext())
            {
                return context.Publicaciones.ToList();
            }
        }

        //Listar por Id
        [HttpGet]
        public Publicacion Get(int id)
        {
            using (var context = new MiPublicacionContext())
            {
                return context.Publicaciones.FirstOrDefault(x=> x.Id ==id);
            }
        }

        //Adicionar
        [HttpPost]
        public IHttpActionResult Post(Publicacion publicacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new MiPublicacionContext())
            {
                context.Publicaciones.Add(publicacion);
                context.SaveChanges();
                return Ok(publicacion);
            } 
        }
        //actualizar
        [HttpPut]
        public Publicacion Put(Publicacion publicacion)
        {
            using (var context = new MiPublicacionContext())
            {
                var publicacionAct = context.Publicaciones.FirstOrDefault(x => x.Id == publicacion.Id);

                publicacionAct.MeDiscusta = publicacion.MeDiscusta;
                publicacionAct.Megusta = publicacion.Megusta;
                publicacionAct.Usuario = publicacion.Usuario;
                publicacionAct.VecesCompartido = publicacion.VecesCompartido;
                publicacionAct.FechaPublicacion = publicacion.FechaPublicacion;
                publicacionAct.Descripcion = publicacion.Descripcion;
                publicacionAct.EsPrivada = publicacion.EsPrivada;

                context.SaveChanges();
                return publicacion;
            }
        }

        //Eliminar
        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new MiPublicacionContext())
            {
                var publicacionDel = context.Publicaciones.FirstOrDefault(x => x.Id == id);
                context.Publicaciones.Remove(publicacionDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}
