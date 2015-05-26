using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos.Controllers
{
    //[Authorize]
    public class PrioridadController : ApiController
    {

        readonly IRepositorio<PrioridadViewModel, Prioridad> _prioridad;
         public PrioridadController(IRepositorio<PrioridadViewModel, Prioridad> prioridad)
        {
            _prioridad = prioridad;
        }

        // GET: api/Prioridad
        public IEnumerable<PrioridadViewModel> Get()
        {
            return _prioridad.Get();
        }

        // GET: api/Prioridad/5
        public PrioridadViewModel Get(int id)
        {
            return _prioridad.Get(id);
        }

        // POST: api/Prioridad
        public void Post([FromBody]PrioridadViewModel value)
        {
             _prioridad.Add(value);
        }

        // PUT: api/Prioridad/5
        public void Put(int id, [FromBody]PrioridadViewModel value)
        {
             _prioridad.Actualizar(value);
        }

        // DELETE: api/Prioridad/5
        public void Delete(int id)
        {
             _prioridad.Borrar(id);
        }
    }
}
