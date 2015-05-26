using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class PermisoViewModel : IViewModel<Permiso>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Permiso ToModel()
        {
            var datos = new Permiso()
            {
                id = id,
                nombre = nombre
            };
            return datos;
        }

        public void FromModel(Permiso model)
        {
            id = model.id;
            nombre = model.nombre;
        }

        public void UpdateModel(Permiso model)
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