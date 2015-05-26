using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class MensajeViewModel : IViewModel<Mensaje>
    {
        public int Id { get; set; }
        public int idRem { get; set; }
        public string fotoRem { get; set; }
        public int idDest { get; set; }
        public System.DateTime fecha { get; set; }
        public string contenido { get; set; }
        public string nombreRem { get; set; }
        public string emailRem { get; set; }
        public int estado { get; set; }

        public List<Usuario> Usuario { get; set; }
        public List<Usuario> Usuario1 { get; set; }
        public EstadoMensaje EstadoMensaje { get; set; }

        public Mensaje ToModel()
        {
            var model = new Mensaje()
            {
                Id = Id,
                idRem = idRem,
                fotoRem = fotoRem,
                idDest = idDest,
                fecha = fecha,
                contenido = contenido,
                nombreRem = nombreRem,
                emailRem = emailRem,
                estado = estado
            };
            return model;
        }

        public void FromModel(Mensaje model)
        {
            Id = model.Id;
            idRem = model.idRem;
            fotoRem = model.fotoRem;
            nombreRem = model.nombreRem;
            emailRem = model.emailRem;
            idDest = model.idDest;
            fecha = model.fecha;
            contenido = model.contenido;
            estado = model.estado;
            EstadoMensaje = new EstadoMensaje()
            {
                Id = model.EstadoMensaje.Id,
                nombre = model.EstadoMensaje.nombre
            };
        }

        public void UpdateModel(Mensaje model)
        {
            model.Id = Id;
            model.idRem =idRem;
            model.fotoRem = fotoRem;
            model.idDest = idDest;
            model.fecha = fecha;
            model.contenido = contenido;
            model.nombreRem = nombreRem;
            model.emailRem = emailRem;
            model.estado = estado;
        }

        public int[] GetPk()
        {
            return new[] { Id };
        }
    }
}