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
    //[Authorize]
    public class UsuarioController : ApiController
    {
        IRepositorio<UsuarioViewModel, Usuario> _usuario;
        RepositorioUsuarios repo = new RepositorioUsuarios(new GestionProyectosEntities());

        public UsuarioController(IRepositorio<UsuarioViewModel, Usuario> usuario )
        {
            _usuario = usuario;
        }

        // GET: api/Usuario
        public IEnumerable<UsuarioViewModel> Get()
        {
            return _usuario.Get();
        }

        // GET: api/Usuario/5
        [HttpGet]
        //[Authorize(Roles = "jefes")]
        public UsuarioViewModel Get(int id)
        {
            return _usuario.Get(id);
        }

        [HttpGet]
        public List<UsuarioViewModel> PorNombre(String nombre)
        {
            var datos = repo.GetByNombre(nombre);
            return datos;
        }

        [HttpGet]
        public List<UsuarioViewModel> PorApellido(String apellido)
        {
            var datos = repo.GetByApellido(apellido);
            return datos;
        }

        [HttpGet]
        public List<UsuarioViewModel> PorEmail(String email)
        {
            var datos =  repo.GetByEmail(email);
            return datos;
        }

        [HttpGet]
        public List<UsuarioViewModel> PorHabilidad(String habilidad)
        {
            var datos = repo.GetByHabilidades(habilidad);
            return datos;
        }

        [HttpGet]
        public UsuarioViewModel Login(String email, String password)
        {
            var datos = repo.GetByLogin(email, password);
            return datos;
        }
        
        [HttpGet]
        public List<UsuarioViewModel> GetPorProyecto(int idProyecto)
        {
            var datos = repo.GetByProyecto(idProyecto);
            return datos;
        }

        [HttpGet]
        public List<UsuarioViewModel> GetContactos(int idUsuario)
        {
            return repo.GetMisContactos(idUsuario);
        }

        [HttpPost]
        public UsuarioViewModel LoginPost(String email, String password)
        {
            var datos = repo.GetByLogin(email, password);
            return datos;
        }

        // POST: api/Usuario
        public void Post([FromBody]UsuarioViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]UsuarioViewModel value)
        {
            repo.Actualizar2(value);
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
            _usuario.Borrar(id);
        }
    }
}
