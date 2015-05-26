using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class TareaViewModel : IViewModel<Tarea>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaAsignacion { get; set; }
        public Nullable<int> tiempoEstimado { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> idUsuarioAsignado { get; set; }
        public int idProyecto { get; set; }
        public Nullable<int> idGrupo { get; set; }
        public int idEstado { get; set; }
        public int idPrioridad { get; set; }
        public string comentarios { get; set; }
        public string idUsuarioCreador { get; set; }
        public string nombreUsuarioAsignado { get; set; }
        public string nombreProyecto { get; set; }
        public string nombreGrupo { get; set; }
        public string nombreEstado { get; set; }
        public string nombrePrioridad { get; set; }
        public string nombreUsuarioCreador { get; set; }
       


        //public virtual EstadoTarea EstadoTareax { get; set; }
        //public virtual Prioridad Prioridadx { get; set; }

        //public virtual EstadoTarea EstadoTarea { get; set; }
        //public virtual Prioridad Prioridad { get; set; }
        //public virtual Proyecto_Tarea_Grupo Proyecto_Tarea_Grupo { get; set; }


        public Tarea ToModel()
        {
            var model = new Tarea()
            {
                id = id,
                nombre = nombre,
                fechaCreacion = fechaCreacion,
                fechaAsignacion = fechaAsignacion,
                tiempoEstimado = tiempoEstimado,
                descripcion = descripcion,
                idUsuarioAsignado = idUsuarioAsignado,
                idProyecto = idProyecto,
                idGrupo = idGrupo,
                idEstado = idEstado,
                idPrioridad = idPrioridad,
                comentarios = comentarios,
                idUsuarioCreador = idUsuarioCreador

                //EstadoTarea = EstadoTarea,
                //Prioridad = Prioridad
              
            };
            return model;
        }

        public void FromModel(Tarea model)
        {
            id = model.id;
            nombre = model.nombre;
            fechaCreacion = model.fechaCreacion;
            fechaAsignacion = model.fechaAsignacion;
            tiempoEstimado = model.tiempoEstimado;
            descripcion = model.descripcion;
            idUsuarioAsignado = model.idUsuarioAsignado;
            idProyecto = model.idProyecto;
            idGrupo = model.idGrupo;
            idEstado = model.idEstado;
            idPrioridad = model.idPrioridad;
            comentarios = model.comentarios;
            idUsuarioCreador = model.idUsuarioCreador;

            //EstadoTarea = model.EstadoTarea;
            //Prioridad = model.Prioridad;

            //EstadoTarea = model.EstadoTarea.Select(o => new EstadoTarea()
            //{
            //    id = o.id,
            //    nombre = o.nombre
            //}).ToList();
            try
            {
                nombreUsuarioAsignado = model.Proyecto_Tarea_Grupo.Usuario.nombre;
                nombreProyecto = model.Proyecto_Tarea_Grupo.Proyecto.nombre;
                nombreGrupo = model.Proyecto_Tarea_Grupo.Grupo.nombre;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            try
            {
              
               
                nombreEstado = model.EstadoTarea.nombre;
                nombrePrioridad = model.Prioridad.nombre;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateModel(Tarea model)
        {
            model.id = id;
            model.nombre = nombre;
            model.fechaCreacion = fechaCreacion;
            model.fechaAsignacion = fechaAsignacion;
            model.tiempoEstimado = tiempoEstimado;
            model.descripcion = descripcion;
            model.idUsuarioAsignado = idUsuarioAsignado;
            model.idProyecto = idProyecto;
            model.idGrupo = idGrupo;
            model.idEstado = idEstado;
            model.idPrioridad = idPrioridad;
            model.comentarios = comentarios;
            model.idUsuarioCreador = idUsuarioCreador;

            //model.EstadoTarea = EstadoTarea;
            //model.Prioridad = Prioridad;
        }

        public int[] GetPk()
        {
            return new[] {id};
        }
    }
}