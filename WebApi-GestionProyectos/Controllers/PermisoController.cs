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
    public class PermisoController : ApiController
    {
         readonly IRepositorio<PermisoViewModel, Permiso> _permiso;
         public PermisoController(IRepositorio<PermisoViewModel, Permiso> permiso)
        {
            _permiso = permiso;
        }

        // GET: api/Permiso
         public IEnumerable<PermisoViewModel> Get()
        {
            return _permiso.Get();
        }

        // GET: api/Permiso/5
         public PermisoViewModel Get(int id)
        {
            return _permiso.Get(id);
        }

        // POST: api/Permiso
         public void Post([FromBody]PermisoViewModel value)
        {
            _permiso.Add(value);
        }

        // PUT: api/Permiso/5
         public void Put(int id, [FromBody]PermisoViewModel value)
        {
            _permiso.Actualizar(value);
        }

        // DELETE: api/Permiso/5
        public void Delete(int id)
        {
            _permiso.Borrar(id);
        }
    }
}
