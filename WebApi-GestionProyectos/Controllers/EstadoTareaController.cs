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
    public class EstadoTareaController : ApiController
    { 
        readonly IRepositorio<EstadoTareaViewModel, EstadoTarea> _estadoTarea;
        public EstadoTareaController(IRepositorio<EstadoTareaViewModel, EstadoTarea> EstadoTarea)
        {
            _estadoTarea = EstadoTarea;
        }

        // GET: api/EstadoTarea
        public IEnumerable<EstadoTareaViewModel> Get()
        {
            return _estadoTarea.Get();
        }

        // GET: api/EstadoTarea/5
        public EstadoTareaViewModel Get(int id)
        {
            return _estadoTarea.Get(id);
        }

        // POST: api/EstadoTarea
        public void Post([FromBody]EstadoTareaViewModel value)
        {
            _estadoTarea.Add(value);
        }

        // PUT: api/EstadoTarea/5
        public void Put(int id, [FromBody]EstadoTareaViewModel value)
        {
            _estadoTarea.Actualizar(value);
        }

        // DELETE: api/EstadoTarea/5
        public void Delete(int id)
        {
            _estadoTarea.Borrar(id);
        }
    }
}
