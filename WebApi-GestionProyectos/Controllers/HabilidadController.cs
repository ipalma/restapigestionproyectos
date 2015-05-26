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
    public class HabilidadController : ApiController
    {
        readonly IRepositorio<HabilidadViewModel, Habilidad> _habilidad;
        public HabilidadController(IRepositorio<HabilidadViewModel, Habilidad> habilidad)
        {
            _habilidad = habilidad;
        }

        // GET: api/habilidad
        public IEnumerable<HabilidadViewModel> Get()
        {
            return _habilidad.Get();
        }

        // GET: api/habilidad/5
        public HabilidadViewModel Get(int id)
        {
            return _habilidad.Get(id);
        }

        // POST: api/habilidad
        public void Post([FromBody]HabilidadViewModel value)
        {
            _habilidad.Add(value);
        }

        // PUT: api/habilidad/5
        public void Put(int id, [FromBody]HabilidadViewModel value)
        {
            _habilidad.Actualizar(value);
        }

        // DELETE: api/habilidad/5
        public void Delete(int id)
        {
            _habilidad.Borrar(id);
        }
    }
}
