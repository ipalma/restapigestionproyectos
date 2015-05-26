using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;
using WebApi_GestionProyectos.Repositorio;

namespace WebApi_GestionProyectos.Controllers
{
    [Authorize]
    public class VistaDatosUsuarioController : ApiController
    {
        RepositorioVistaDatosUsuario repo = new RepositorioVistaDatosUsuario(new GestionProyectosEntities());

        public IEnumerable<VistaDatosUsuarioViewModel> Get()
        {
            return repo.Get();
        }
        
        [HttpGet]
        public VistaDatosUsuarioViewModel GetById(int id)
        {
            return repo.Get(id);
        }

        [HttpGet]
        public List<VistaDatosUsuarioViewModel> GetByNombre(String nombre)
        {
            var datos = repo.GetByNombre(nombre);
            return datos;
        }

        [HttpGet]
        public List<VistaDatosUsuarioViewModel> GetByApellido(String apellido)
        {
            var datos = repo.GetByApellido(apellido);
            return datos;
        }

        [HttpGet]
        public List<VistaDatosUsuarioViewModel> GetByEmail(String email)
        {
            var datos = repo.GetByEmail(email);
            return datos;
        }

        [HttpGet]
        public List<VistaDatosUsuarioViewModel> GetByProyecto(String proyecto)
        {
            var datos = repo.GetByProyecto(proyecto);
            return datos;
        }

        public void Post([FromBody]VistaDatosUsuarioViewModel value)
        {
            repo.Add(value);
        }

        public void Put(int id, [FromBody]VistaDatosUsuarioViewModel value)
        {
            repo.Actualizar(value);
        }

        public void Delete(int id)
        {
            repo.Borrar(id);
        }
    }
}
