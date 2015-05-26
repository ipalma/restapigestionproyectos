using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class Proyecto_Tarea_GrupoViewModel : IViewModel<Proyecto_Tarea_Grupo>
    {
        public int idUsuario { get; set; }
        public String NombreUsuario { get; set; }
        public int idProyecto { get; set; }
        public int idGrupo { get; set; }
        //public String NombreGrupo { get; set; } //Comentado hasta la resolución del problema que aparece con el filtro por usuario.
        public Nullable<int> jefeGrupo { get; set; }
        //public String NombreJefe { get; set; } //Comentado hasta que se resuelva la relación usuario-proyecto_tarea_grupo;

        //public virtual Grupo Grupo { get; set; }
        public virtual String Proyecto { get; set; }
        public virtual List<Tarea> Tarea { get; set; }
       // public virtual Usuario Usuario { get; set; }

        public Proyecto_Tarea_Grupo ToModel()
        {
            var model = new Proyecto_Tarea_Grupo()
            {
                idUsuario = idUsuario,
                idProyecto = idProyecto,
                idGrupo = idGrupo,
                jefeGrupo = jefeGrupo,
            };
            return model;
        }

        public void FromModel(Proyecto_Tarea_Grupo model)
        {
            idUsuario = model.idUsuario;
            idProyecto = model.idProyecto;
            idGrupo = model.idGrupo;
            jefeGrupo = model.jefeGrupo;

            try
            {
                Tarea = model.Tarea.Select(t => new Tarea()
                {
                    id = t.id,
                    nombre = t.nombre,
                    idEstado = t.idEstado,
                    idPrioridad = t.idPrioridad,
                    tiempoEstimado = t.tiempoEstimado,
                    idUsuarioAsignado = t.idUsuarioAsignado,
                    fechaAsignacion = t.fechaAsignacion,
                    descripcion = t.descripcion,
                    comentarios = t.comentarios,
                    fechaCreacion = t.fechaCreacion,
                    idUsuarioCreador = t.idUsuarioCreador

                }).ToList();

                NombreUsuario = model.Usuario.nombre;
                //NombreGrupo = model.Grupo.nombre; //Comentado hasta que se resuelva el problema que hay con el filtrado por usuario.
                //NombreJefe = model.Usuario.nombre; //Comentado hasta que se resuelva la relación usuario-proyecto_tarea_grupo;
                Proyecto = model.Proyecto.nombre;

                //Tarea = model.Tarea.Select(o => new TareaViewModel()
                //{
                //    id = o.id,
                //    nombre = o.nombre
                //}).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void UpdateModel(Proyecto_Tarea_Grupo model)
        {
            model.idUsuario = idUsuario;
            model.idProyecto = idProyecto;
            model.idGrupo = idGrupo;
            model.jefeGrupo = jefeGrupo;
        }

        public int[] GetPk()
        {
            return new[] {idGrupo, idProyecto, idUsuario};
        }
    }
}