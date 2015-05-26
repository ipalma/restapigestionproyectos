using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class ProyectoViewModel : IViewModel<Proyecto>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public int idEstado { get; set; }
        public int idPrioridad { get; set; }

        public IEnumerable<String> usuariosEmail { get; set; }
        public IEnumerable<String> usuariosFoto { get; set; }

        public ICollection<UsuarioViewModel> usuarios { get; set; }

        //public virtual EstadoProyecto EstadoProyecto { get; set; }
        //public virtual Prioridad Prioridad { get; set; }
        public virtual ICollection<Proyecto_Tarea_Grupo> UsuariosDelGrupo { get; set; }
        public virtual ICollection<Tarea> TareasDelProyecto { get; set; }

        public Proyecto ToModel()
        {
            var model = new Proyecto()
            {
                id = id,
                nombre = nombre,
                fechaInicio = fechaInicio,
                fechaFin = fechaFin,
                descripcion = descripcion,
                fechaCreacion = fechaCreacion,
                idEstado = idEstado,
                idPrioridad = idPrioridad
            };
            return model;
        }

        public void FromModel(Proyecto model)
        {
            id = model.id;
            nombre = model.nombre;
            fechaInicio = model.fechaInicio;
            fechaFin = model.fechaFin;
            descripcion = model.descripcion;
            fechaCreacion = model.fechaCreacion;
            idEstado = model.idEstado;
            idPrioridad = model.idPrioridad;

            try
            {

                usuarios = model.Proyecto_Tarea_Grupo.Select(o => o.Usuario).Select(u => new UsuarioViewModel()
                {
                    id = u.id,
                    email = u.email,
                    foto = u.foto,
                    numeroTareas = u.Proyecto_Tarea_Grupo.Select(o => o.Tarea).Count(),
                    nombre = u.nombre
                    
                }).ToList();

               // usuariosEmail = model.Proyecto_Tarea_Grupo.Select(o => o.Usuario.email);
               // usuariosFoto = model.Proyecto_Tarea_Grupo.Select(o => o.Usuario.foto);
                //TareasDelProyecto = model. Tarea_Proyecto.Select(t => new Tarea()
                //{
                //    id = t.id,
                //    nombre = t.nombre,
                //    idEstado = t.idEstado,
                //    idPrioridad = t.idPrioridad,
                //    tiempoEstimado = t.tiempoEstimado,
                //    idUsuarioAsignado = t.idUsuarioAsignado,
                //    fechaAsignacion = t.fechaAsignacion,
                //    descripcion = t.descripcion,
                //    comentarios = t.comentarios,
                //    fechaCreacion = t.fechaCreacion,
                //    idUsuarioCreador = t.idUsuarioCreador
                //}).ToList();

                UsuariosDelGrupo = model.Proyecto_Tarea_Grupo.Select(o => new Proyecto_Tarea_Grupo()
                {
                    idGrupo = o.idGrupo,
                    idProyecto = o.idProyecto,
                    idUsuario = o.idUsuario,
                    jefeGrupo = o.jefeGrupo,
                    //Grupo = o.Grupo,
                    //Proyecto = o.Proyecto,
                    //Usuario = o.Usuario,
                    Tarea = o.Tarea.Select(t => new Tarea()
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
                       
                    }).ToList(),

                    
                    //Tarea = model..(t => new TareaViewModel()
                    //{
                    //    id = 
                    //    nombre = nombre,
                    //    fechaCreacion = fechaCreacion,
                    //    idEstado = idEstado
                    //}).ToList()
                }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void UpdateModel(Proyecto model)
        {
            model.id = id;
            model.nombre = nombre;
            model.fechaInicio = fechaInicio;
            model.fechaFin = fechaFin;
            model.descripcion = descripcion;
            model.fechaCreacion = fechaCreacion;
            model.idEstado = idEstado;
            model.idPrioridad = idPrioridad;
            
            //model.TODO = model.TODO.Select(o => new Proyecto_Tarea_Grupo()
            //    {
            //        o.idGrupo = idGrupo,
            //        o.idProyecto = idProyecto,
            //        o.idUsuario = idUsuario
            //    }).ToList();

        }

        public int[] GetPk()
        {
            return new[] {id};
        }
    }
}