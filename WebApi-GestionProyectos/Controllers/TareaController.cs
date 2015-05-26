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
    public class TareaController : ApiController
    {
        RepositorioTareas repo = new RepositorioTareas(new GestionProyectosEntities());
        readonly IRepositorio<TareaViewModel, Tarea> _tarea;
        public TareaController(IRepositorio<TareaViewModel, Tarea> tarea )
        {
            _tarea = tarea;
        }

        // GET: api/Tarea
        public IEnumerable<TareaViewModel> Get()
        {
            return _tarea.Get();
        }

        // GET: api/Tarea/5
        [HttpGet]
        public TareaViewModel Get(int id)
        {
            return _tarea.Get(id);
        }

        [HttpGet]
        public List<TareaViewModel> GetByNombre(string nombre)
        {
            var datos = repo.GetByNombre(nombre);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByfechaCreacion(DateTime fechaCreacion)
        {
            var datos = repo.GetByFechaCreacion(fechaCreacion);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByfechaAsignacion(DateTime fechaAsignacion)
        {
            var datos = repo.GetByfechaAsignacion(fechaAsignacion);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetBytiempoEstimado(int tiempoEstimado)
        {
            var datos = repo.GetBytiempoEstimado(tiempoEstimado);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetBydescripcion(string descripcion)
        {
            var datos = repo.GetBydescripcion(descripcion);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByidUsuarioAsignado(int idusuarioAsignado)
        {
            var datos = repo.GetByidUsuarioAsignado(idusuarioAsignado);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByidProyecto(int idproyecto)
        {
            var datos = repo.GetByidProyecto(idproyecto);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByidGrupo(int idgrupo)
        {
            var datos = repo.GetByidGrupo(idgrupo);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByidEstado(int idestado)
        {
            var datos = repo.GetByidEstado(idestado);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByidPrioridad(int idprioridad)
        {
            var datos = repo.GetByidPrioridad(idprioridad);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetBycomentarios(string comentarios)
        {
            var datos = repo.GetBycomentarios(comentarios);
            return datos;
        }

        [HttpGet]
        public List<TareaViewModel> GetByidUsuarioCreador(string idusuarioCreador)
        {
            var datos = repo.GetByidUsuarioCreador(idusuarioCreador);
            return datos;
        }

        
        // POST: api/Tarea

        public void Post([FromBody]TareaViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Tarea/5
        public void Put(int id, [FromBody]TareaViewModel value)
        {
            _tarea.Actualizar(value);
        }
        
        // DELETE: api/Tarea/5
        public void Delete(int id)
        {
            _tarea.Borrar(id);
        }
    }
}
