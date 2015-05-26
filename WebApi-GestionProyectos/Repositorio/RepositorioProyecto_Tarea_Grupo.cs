using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Repositorio;
using WebApi_GestionProyectos.Controllers;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos.Repositorio
{
    public class RepositorioProyecto_Tarea_Grupo:Repositorio<Proyecto_Tarea_GrupoViewModel, Proyecto_Tarea_Grupo>
    {
        
        public RepositorioProyecto_Tarea_Grupo(DbContext context) : base(context)
        {
        }

        public IEnumerable<Proyecto_Tarea_GrupoViewModel> GetPoridUsuario(int idUsuario)
        {


            var ids = new List<int>();

            var proyectos = Get(o => o.idUsuario == idUsuario).ToList();
            var pf = new List<Proyecto_Tarea_GrupoViewModel>();

            foreach (var proyectoTareaGrupoViewModel in proyectos)
            {
                if (!ids.Contains(proyectoTareaGrupoViewModel.idProyecto)) { 
                   
                    ids.Add(proyectoTareaGrupoViewModel.idProyecto);
                    pf.Add(proyectoTareaGrupoViewModel);
                }
            
            }
            
            return pf;

        }

        public int Borrar2(int idUsu, int idProy)
        {
            var datos = DbSet.Where(o => o.idProyecto == idProy && o.idUsuario == idUsu);
            DbSet.Remove(datos.First());
            int n = 0;
            try
            {
                n = Context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return n;

        }

    }
}
