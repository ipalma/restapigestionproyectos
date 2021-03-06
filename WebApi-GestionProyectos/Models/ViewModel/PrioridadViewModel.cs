﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class PrioridadViewModel : IViewModel<Prioridad>
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Prioridad ToModel()
        {
            var datos = new Prioridad()
            {
                id = id,
                nombre = nombre
            };
            return datos;
        }

        public void FromModel(Prioridad model)
        {
            id = model.id;
            nombre = model.nombre;
        }

        public void UpdateModel(Prioridad model)
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