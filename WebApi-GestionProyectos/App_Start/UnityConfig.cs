using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Repositorio;
using Unity.WebApi;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);


            //mcl
            container.RegisterType<DbContext, GestionProyectosEntities>();

            container.RegisterType<IRepositorio<GrupoViewModel, Grupo>, Repositorio<GrupoViewModel, Grupo>>();
            container.RegisterType<IRepositorio<HabilidadViewModel, Habilidad>, Repositorio<HabilidadViewModel, Habilidad>>();
            container.RegisterType<IRepositorio<PermisoViewModel, Permiso>, Repositorio<PermisoViewModel, Permiso>>();
            container.RegisterType<IRepositorio<PrioridadViewModel, Prioridad>, Repositorio<PrioridadViewModel, Prioridad>>();
            container.RegisterType<IRepositorio<UsuarioViewModel, Usuario>, Repositorio<UsuarioViewModel, Usuario>>();
            container.RegisterType<IRepositorio<EstadoTareaViewModel, EstadoTarea>, Repositorio<EstadoTareaViewModel, EstadoTarea>>();
            container.RegisterType<IRepositorio<EstadoProyectoViewModel, EstadoProyecto>, Repositorio<EstadoProyectoViewModel, EstadoProyecto>>();
            container.RegisterType<IRepositorio<TareaViewModel, Tarea>, Repositorio<TareaViewModel, Tarea>>();
            container.RegisterType<IRepositorio<Proyecto_Tarea_GrupoViewModel, Proyecto_Tarea_Grupo>, Repositorio<Proyecto_Tarea_GrupoViewModel, Proyecto_Tarea_Grupo>>();
            container.RegisterType<IRepositorio<ProyectoViewModel, Proyecto>, Repositorio<ProyectoViewModel, Proyecto>>();
            container.RegisterType<IRepositorio<VistaDatosUsuarioViewModel, vistaDatosUsuario>, Repositorio<VistaDatosUsuarioViewModel, vistaDatosUsuario>>();
            container.RegisterType<IRepositorio<MensajeViewModel, Mensaje>, Repositorio<MensajeViewModel, Mensaje>>();


            //.mcl


        }
    }
}