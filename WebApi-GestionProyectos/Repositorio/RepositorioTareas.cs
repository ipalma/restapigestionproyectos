using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos.Repositorio
{
    public class RepositorioTareas : Repositorio<TareaViewModel, Tarea>
    {
         public RepositorioTareas(DbContext context) : base(context)
        {
        }

        public List<TareaViewModel> GetByNombre(String nombre)
        {
            return Get(o => o.nombre.Contains(nombre));
        }

        public List<TareaViewModel> GetByFechaCreacion(DateTime fechaCreacion)
        {
            return Get(o => o.fechaCreacion == fechaCreacion);
        }

        public List<TareaViewModel> GetByfechaAsignacion(DateTime fechaAsignacion)
        {
            return Get(o => o.fechaAsignacion == fechaAsignacion);
        }


        public List<TareaViewModel> GetBytiempoEstimado(int tiempoEstimado)
        {
            return Get(o => o.tiempoEstimado == tiempoEstimado);
        }

        public List<TareaViewModel> GetBydescripcion(String descripcion)
        {
            return Get(o => o.descripcion.Contains(descripcion));
        }

        public List<TareaViewModel> GetByidUsuarioAsignado(int idusuarioAsignado)
        {
            return Get(o => o.idUsuarioAsignado == idusuarioAsignado);
        }

        public List<TareaViewModel> GetByidProyecto(int idproyecto)
        {
            return Get(o => o.idProyecto == idproyecto);
        }
       
        public List<TareaViewModel> GetByidGrupo(int idgrupo)
        {
            return Get(o => o.idGrupo == idgrupo);
        }

        public List<TareaViewModel> GetByidEstado(int idestado)
        {
            return Get(o => o.idEstado == idestado);
        }

        public List<TareaViewModel> GetByidPrioridad(int idprioridad)

        {
            return Get(o => o.idPrioridad == idprioridad);
        }

        public List<TareaViewModel> GetBycomentarios(string comentarios)
        {
            return Get(o => o.comentarios.Contains(comentarios));
        }

        public List<TareaViewModel> GetByidUsuarioCreador(string idusuarioCreador)
        {
            return Get(o => o.idUsuarioCreador == idusuarioCreador);
        } 
    }
}