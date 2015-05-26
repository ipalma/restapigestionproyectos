using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;

namespace WebApi_GestionProyectos.Models.ViewModel
{
    public class VistaDatosUsuarioViewModel : IViewModel<vistaDatosUsuario>
    {
        public int idUsuario { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string foto { get; set; }
        public int idGrupo { get; set; }
        public string grupo { get; set; }
        public int idProyecto { get; set; }
        public string proyecto { get; set; }
        public Nullable<int> jefeGrupo { get; set; }


        public vistaDatosUsuario ToModel()
        {
            var model = new vistaDatosUsuario()
            {
                idUsuario = idUsuario,
                id = id,
                nombre = nombre,
                apellido = apellido,
                email = email,
                foto = foto,
                idGrupo = idGrupo,
                grupo = grupo,
                idProyecto = idProyecto,
                proyecto = proyecto,
                jefeGrupo = jefeGrupo
            };
            return model;
        }

        public void FromModel(vistaDatosUsuario model)
        {
            idUsuario = model.idUsuario;
            id = model.id;
            nombre = model.nombre;
            apellido = model.apellido;
            email = model.email;
            foto = model.foto;
            idGrupo = model.idGrupo;
            grupo = model.grupo;
            idProyecto = model.idProyecto;
            proyecto = model.proyecto;
            jefeGrupo = model.jefeGrupo;

        }

        public void UpdateModel(vistaDatosUsuario model)
        {
            model.idUsuario = idUsuario;
            model.id = id;
            model.nombre = nombre;
            model.apellido = apellido;
            model.email = email;
            model.foto = foto;
            model.idGrupo = idGrupo;
            model.grupo = grupo;
            model.idProyecto = idProyecto;
            model.proyecto = proyecto;
            model.jefeGrupo = jefeGrupo;
        }

        public int[] GetPk()
        {
            return new[] { id };
        }
    }
}