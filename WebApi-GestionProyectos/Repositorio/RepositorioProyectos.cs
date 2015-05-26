using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos.Repositorio
{
    public class RepositorioProyectos:Repositorio<ProyectoViewModel,Proyecto>
    {
        public RepositorioProyectos(GestionProyectosEntities context) : base(context)
        {
            
        }
        
        public List<ProyectoViewModel> GetByNombre(String nombre)
        {
            return Get(o => o.nombre.Contains(nombre));
        }

        public List<ProyectoViewModel> GetByFechaCreacion(DateTime fechaCreacion)
        {
            return Get(o => o.fechaCreacion == fechaCreacion);
        }

        public List<ProyectoViewModel> GetByFechaFin(DateTime fechaFin)
        {
            return Get(o => o.fechaFin == fechaFin);
        }

        public List<ProyectoViewModel> GetByEstado(int idEstado)
        {
            return Get(o => o.idEstado == idEstado);
        }

        public List<ProyectoViewModel> GetByPrioridad(int idPrioridad)
        {
            return Get(o => o.idPrioridad == idPrioridad);
        }

        public List<ProyectoViewModel> GetByDescripcion(string descripcion)
        {
            return Get(o => o.descripcion.Contains(descripcion));
        }

        public void GetUsuarioProyectoTareaGrupo(int idUsuario, int idProyecto, int idGrupo)
        {

            

        }
        //public int GetMax()
        //{
        //    GestionProyectosEntities dato = new GestionProyectosEntities();
        //    var identificador = dato.Proyecto.Select(o => o.id).Max();
        //    return identificador;
        //} 
        
    }
}