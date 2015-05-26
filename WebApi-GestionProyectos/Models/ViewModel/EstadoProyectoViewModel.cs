using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class EstadoProyectoViewModel : IViewModel<EstadoProyecto>
    {
        public int Id { get; set; }
        public string nombre { get; set; }

        public EstadoProyecto ToModel()
        {
            var model = new EstadoProyecto()
            {
                Id = Id,
                nombre = nombre
            };
            return model;
        }

        public void FromModel(EstadoProyecto model)
        {
            Id = model.Id;
            nombre = model.nombre;
        }

        public void UpdateModel(EstadoProyecto model)
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