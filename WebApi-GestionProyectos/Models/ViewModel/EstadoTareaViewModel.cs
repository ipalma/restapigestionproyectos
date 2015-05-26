using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class EstadoTareaViewModel :IViewModel<EstadoTarea>
    {
        public int Id { get; set; }
        public string nombre { get; set; }

        public EstadoTarea ToModel()
        {
            var model = new EstadoTarea()
            {
                Id = Id,
                nombre = nombre
            };
            return model;
        }

        public void FromModel(EstadoTarea model)
        {
            Id = model.Id;
            nombre = model.nombre;
        }

        public void UpdateModel(EstadoTarea model)
        {
            model.Id = Id;
            nombre = model.nombre;
        }

        public int[] GetPk()
        {
            return new[] {Id};
        }
    }
}