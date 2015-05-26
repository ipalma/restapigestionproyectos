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
    public class ProyectoController : ApiController
    {

        RepositorioProyectos repo = new RepositorioProyectos(new GestionProyectosEntities());

        #region Métodos Get
            // GET: api/Proyecto
            public IEnumerable<ProyectoViewModel> Get()
            {
                return repo.Get();
            }

            // GET: api/Proyecto/5
            [HttpGet]
            public ProyectoViewModel GetById(int id)
            {
                return repo.Get(id);
            }

            [HttpGet]
            public List<ProyectoViewModel> GetByNombre(String nombre)
            {
                var datos = repo.GetByNombre(nombre);
                return datos;
            }

            [HttpGet]
            public List<ProyectoViewModel> GetByFechaCreacion(DateTime fechaCreacion)
            {
                var datos = repo.GetByFechaCreacion(fechaCreacion);
                return datos;
            }

            [HttpGet]
            public List<ProyectoViewModel> GetByFechaFin(DateTime fechaFin)
            {
                var datos = repo.GetByFechaFin(fechaFin);
                return datos;
            }

            [HttpGet]
            public List<ProyectoViewModel> GetByEstado(int idEstado)
            {
                var datos = repo.GetByEstado(idEstado);
                return datos;
            }

            [HttpGet]
            public List<ProyectoViewModel> GetByPrioridad(int idPrioridad)
            {
                var datos = repo.GetByPrioridad(idPrioridad);
                return datos;
            }

            [HttpGet]
            public List<ProyectoViewModel> GetByDescripcion(string descripcion)
            {
                var datos = repo.GetByDescripcion(descripcion);
                return datos;
            }

            //[HttpGet]
            //public int GetMax()
            //{
            //    var datos = repo.GetMax();
            //    return datos;
            //}
        #endregion

        // POST: api/Proyecto
        public void Post([FromBody]ProyectoViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Proyecto/5
        public void Put(int id, [FromBody]ProyectoViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Proyecto/5
        public void Delete(int id)
        {
            repo.Borrar(id);
        }
    }
}

/*
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

    public class ProyectoController : ApiController
    {

        RepositorioProyectos repo = new RepositorioProyectos(new GestionProyectosEntities());

        #region Métodos Get
        // GET: api/Proyecto
        public IEnumerable<ProyectoViewModel> Get()
        {
            return repo.Get();
        }

        // GET: api/Proyecto/5
        [HttpGet]
        public ProyectoViewModel GetById(int id)
        {
            return repo.Get(id);
        }

        [HttpGet]
        public List<ProyectoViewModel> GetByNombre(String args)
        {
            var datos = repo.GetByNombre(args);
            return datos;
        }

        [HttpGet]
        public List<ProyectoViewModel> GetByFechaCreacion(DateTime args)
        {
            var datos = repo.GetByFechaCreacion(args);
            return datos;
        }

        [HttpGet]
        public List<ProyectoViewModel> GetByFechaFin(DateTime args)
        {
            var datos = repo.GetByFechaFin(args);
            return datos;
        }

        [HttpGet]
        public List<ProyectoViewModel> GetByEstado(int args)
        {
            var datos = repo.GetByEstado(args);
            return datos;
        }

        [HttpGet]
        public List<ProyectoViewModel> GetByPrioridad(int args)
        {
            var datos = repo.GetByPrioridad(args);
            return datos;
        }

        #endregion

        // POST: api/Proyecto
        public void Post([FromBody]ProyectoViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Proyecto/5
        public void Put(int id, [FromBody]ProyectoViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Proyecto/5
        public void Delete(int id)
        {
            repo.Borrar(id);
        }
    }
}

 */
