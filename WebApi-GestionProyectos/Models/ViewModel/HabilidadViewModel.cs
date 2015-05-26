using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class HabilidadViewModel : IViewModel<Habilidad>
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Habilidad ToModel()
        {
            var datos = new Habilidad()
            {
                id = id,
                nombre = nombre
            };
            return datos;
        }

        public void FromModel(Habilidad model)
        {
            id = model.id;
            nombre = model.nombre;
        }

        public void UpdateModel(Habilidad model)
        {
            model.id = id;
            model.nombre = nombre;
        }

        public int[] GetPk()
        {
            throw new NotImplementedException();
        }
    }
}