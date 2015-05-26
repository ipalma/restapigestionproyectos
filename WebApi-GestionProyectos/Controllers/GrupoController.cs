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
    public class GrupoController : ApiController
    {
        readonly IRepositorio<GrupoViewModel, Grupo> _grupo;
        public GrupoController(IRepositorio<GrupoViewModel, Grupo> grupo)
        {
            _grupo = grupo;
        }

        // GET: api/Grupo
        public IEnumerable<GrupoViewModel> Get()
        {
            return _grupo.Get();
        }

        // GET: api/Grupo/5
        public GrupoViewModel Get(int id)
        {
            return _grupo.Get(id);
        }

        // POST: api/Grupo
        public void Post([FromBody]GrupoViewModel value)
        {
            _grupo.Add(value);
        }

        // PUT: api/Grupo/5
        public void Put(int id, [FromBody]GrupoViewModel value)
        {
            _grupo.Actualizar(value);
        }

        // DELETE: api/Grupo/5
        public void Delete(int id)
        {
            _grupo.Borrar(id);
        }
    }
}
