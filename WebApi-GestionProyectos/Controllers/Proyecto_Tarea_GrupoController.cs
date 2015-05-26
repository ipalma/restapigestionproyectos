using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public class Proyecto_Tarea_GrupoController : ApiController
    {
        RepositorioProyecto_Tarea_Grupo repo = new RepositorioProyecto_Tarea_Grupo(new GestionProyectosEntities());

        //readonly IRepositorio<Proyecto_Tarea_GrupoViewModel, Proyecto_Tarea_Grupo> _Proyecto_Tarea_Grupo;

        /*public Proyecto_Tarea_GrupoController(IRepositorio<Proyecto_Tarea_GrupoViewModel, Proyecto_Tarea_Grupo> Proyecto_Tarea_Grupo )
        {
            _Proyecto_Tarea_Grupo = Proyecto_Tarea_Grupo;
        }*/

        [HttpGet]
        public IEnumerable<Proyecto_Tarea_GrupoViewModel> UsuarioNumero(int args)
        {
            var datos = repo.GetPoridUsuario(args);
            return datos;
        }



        // GET: api/Proyecto_Tarea_Grupo
        public IEnumerable<Proyecto_Tarea_GrupoViewModel> Get()
        {
            return repo.Get();
        }

        // GET: api/Proyecto_Tarea_Grupo/5
        public Proyecto_Tarea_GrupoViewModel Get(int id)
        {
            return repo.Get(id);
        }

        // POST: api/Proyecto_Tarea_Grupo
        public void Post([FromBody]Proyecto_Tarea_GrupoViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Proyecto_Tarea_Grupo/5
        public void Put(int id, [FromBody]Proyecto_Tarea_GrupoViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Proyecto_Tarea_Grupo/5
        public void Delete(int id)
        {
            repo.Borrar(id);
        }

        public void Delete(int idUsuario, int idProyecto)
        {
            //repo.Borrar2(o=> o.idUsuario == idUsuario && o.idProyecto == idProyecto);
            repo.Borrar2(idUsuario, idProyecto);
        }
    }
}
