using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class EstadoMensajeViewModel
    {

        public int Id { get; set; }
        public string nombre { get; set; }

        public virtual List<Mensaje> Mensaje { get; set; }

        public EstadoMensaje ToModel()
        {
            var model = new EstadoMensaje()
            {
                Id = Id,
                nombre = nombre
            };
            return model;
        }

        public void FromModel(EstadoMensaje model)
        {
            Id = model.Id;
            nombre = model.nombre;
        }

        public void UpdateModel(EstadoMensaje model)
        {
            model.Id = Id;
            nombre = model.nombre;
        }

        public int[] GetPk()
        {
            return new[] { Id };
        }
    }
}