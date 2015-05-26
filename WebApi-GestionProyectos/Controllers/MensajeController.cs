using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;
using WebApi_GestionProyectos.Repositorio;

namespace WebApi_GestionProyectos.Controllers
{
    public class MensajeController : ApiController
    {
        private GestionProyectosEntities db = new GestionProyectosEntities();

        IRepositorio<MensajeViewModel, Mensaje> _mensaje;

        RepositorioUsuarios repo = new RepositorioUsuarios(new GestionProyectosEntities());
        RepositorioMensaje repo2 = new RepositorioMensaje(new GestionProyectosEntities());

        public MensajeController(IRepositorio<MensajeViewModel, Mensaje> mensaje )
        {
            _mensaje = mensaje;
        }

        // GET: api/Mensaje
        public IEnumerable<MensajeViewModel> GetMensaje()
        {
            return _mensaje.Get();
        }

        // GET: api/Mensaje/5
        public MensajeViewModel Get(int id)
        {
            return _mensaje.Get(id);
        }

        // GET: api/Mensaje?idDest=5
        public IEnumerable<MensajeViewModel> GetRecibidos(int idDest)
        {
            return repo2.GetByRecibidos(idDest);
        }

        // PUT: api/Mensaje/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMensaje(int id, Mensaje mensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mensaje.Id)
            {
                return BadRequest();
            }

            db.Entry(mensaje).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MensajeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Mensaje
        [ResponseType(typeof(Mensaje))]
        public IHttpActionResult PostMensaje(Mensaje mensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Mensaje.Add(mensaje);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mensaje.Id }, mensaje);
        }

        // DELETE: api/Mensaje/5
        [ResponseType(typeof(Mensaje))]
        public IHttpActionResult DeleteMensaje(int id)
        {
            Mensaje mensaje = db.Mensaje.Find(id);
            if (mensaje == null)
            {
                return NotFound();
            }

            db.Mensaje.Remove(mensaje);
            db.SaveChanges();

            return Ok(mensaje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MensajeExists(int id)
        {
            return db.Mensaje.Count(e => e.Id == id) > 0;
        }
    }
}