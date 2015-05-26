using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class GrupoViewModel : IViewModel<Grupo>
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Grupo ToModel()
        {
            var datos = new Grupo()
            {
                id = id,
                nombre = nombre
            };
            return datos;
        }

        public void FromModel(Grupo model)
        {
            id = model.id;
            nombre = model.nombre;
        }

        public void UpdateModel(Grupo model)
        {
            model.id = id;
            model.nombre = nombre;
        }

        public int[] GetPk()
        {
            return new[] { id };
        }
    }
}