using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;
using WebApi_GestionProyectos.Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class UsuarioViewModel : IViewModel<Usuario>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string foto { get; set; }

        public ICollection<Habilidad> Habilidad { get; set; }
        public List<Proyecto_Tarea_GrupoViewModel> Proyecto_Tarea_Grupo { get; set; }
        public List<Mensaje> Mensaje { get; set; }

        public int numeroTareas { get; set; }

        public Usuario ToModel()
        {
            var datos = new Usuario()
            {
                id = id,
                nombre = nombre,
                apellido = apellido,
                email = email,
                password = password,
                foto = foto
              
            };
            return datos;
        }

        public void FromModel(Usuario model)
        {
            id = model.id;
            nombre = model.nombre;
            apellido = model.apellido;
            email = model.email;
            password = model.password;
            foto = model.foto;

            try
            {
                Mensaje = model.Mensaje.Select(o => new Mensaje()
                {
                    Id = o.Id,
                    idRem = o.idRem,
                    fotoRem = o.fotoRem,
                    idDest = o.idDest,
                    fecha = o.fecha,
                    contenido = o.contenido,
                    nombreRem = o.nombreRem,
                    emailRem = o.emailRem
                }).ToList();

                Habilidad = model.Habilidad.Select(o => new Habilidad()
                {
                    id = o.id,
                    nombre = o.nombre
                }).ToList();

                Proyecto_Tarea_Grupo = model.Proyecto_Tarea_Grupo.Select( o => new Proyecto_Tarea_GrupoViewModel()
                {
                    idGrupo = o.idGrupo,
                    idProyecto = o.idProyecto,
                    idUsuario = o.idUsuario,
                    jefeGrupo = o.jefeGrupo,
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
                        idUsuarioCreador = t.idUsuarioCreador,
                    }).OrderBy(p => p.idPrioridad).ToList(),
                    }).ToList();

                numeroTareas = model.Proyecto_Tarea_Grupo.Select(o => o.Tarea).Count();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateModel(Usuario model)
        {
            model.id = id;
            model.nombre = nombre;
            model.apellido = apellido;
            model.email = model.email;
            model.password = model.password;
            model.foto = foto;
            model.Habilidad = Habilidad;
        }

        public int[] GetPk()
        {
            return new[] { id };
        }
    }
}