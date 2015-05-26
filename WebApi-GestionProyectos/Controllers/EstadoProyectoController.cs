using System.Collections.Generic;
using System.Web.Http;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos.Controllers
{
    //[Authorize]
    public class EstadoProyectoController : ApiController
    {
        readonly private IRepositorio<EstadoProyectoViewModel, EstadoProyecto> _estadoProyecto;

        public EstadoProyectoController(IRepositorio<EstadoProyectoViewModel, EstadoProyecto> EstadoProyecto)
        {
            _estadoProyecto = EstadoProyecto;
        }


        // GET: api/EstadoProyecto
        public IEnumerable<EstadoProyectoViewModel> Get()
        {
            return _estadoProyecto.Get();
        }

        // GET: api/EstadoProyecto/5
        public EstadoProyectoViewModel Get(int id)
        {
            return _estadoProyecto.Get(id);
        }

        // POST: api/EstadoProyecto
        public void Post([FromBody]EstadoProyectoViewModel value)
        {
            _estadoProyecto.Add(value);
        }

        // PUT: api/EstadoProyecto/5
        public void Put(int id, [FromBody]EstadoProyectoViewModel value)
        {
            _estadoProyecto.Actualizar(value);
        }

        // DELETE: api/EstadoProyecto/5
        public void Delete(int id)
        {
            _estadoProyecto.Borrar(id);
        }
    }
}
