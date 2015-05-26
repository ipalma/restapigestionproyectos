using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos.Repositorio
{
    public class RepositorioVistaDatosUsuario:Repositorio<VistaDatosUsuarioViewModel, vistaDatosUsuario>
    {
        public RepositorioVistaDatosUsuario(GestionProyectosEntities context)
            : base(context)
        {
            
        }
        public List<VistaDatosUsuarioViewModel> GetByNombre(String nombre)
        {
            return Get(o => o.nombre.Contains(nombre));
        }

        public List<VistaDatosUsuarioViewModel> GetByApellido(String apellido)
        {
            return Get(o => o.apellido.Contains(apellido));
        }

        public List<VistaDatosUsuarioViewModel> GetByEmail(String email)
        {
            return Get(o => o.email.Contains(email));
        }

        public List<VistaDatosUsuarioViewModel> GetByProyecto(String proyecto)
        {
            return Get(o => o.proyecto.Contains(proyecto));
        }
    }
}