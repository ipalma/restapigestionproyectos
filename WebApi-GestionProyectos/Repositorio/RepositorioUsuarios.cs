using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using Microsoft.Ajax.Utilities;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;
using WebApi_GestionProyectos.Utils;
using WebGrease.Css.Extensions;

namespace WebApi_GestionProyectos.Repositorio
{
    public class RepositorioUsuarios : Repositorio<UsuarioViewModel, Usuario>
    {
        public RepositorioUsuarios(DbContext context) : base(context)
        {
        }

        public List<UsuarioViewModel> GetByNombre(String nombre)
        {
            return Get(o => o.nombre.Contains(nombre));
        }

        public List<UsuarioViewModel> GetByApellido(String apellido)
        {
            return Get(o => o.apellido.Contains(apellido));
        }

        public List<UsuarioViewModel> GetByEmail(String email)
        {
            return Get(o => o.email.Contains(email));
        }

        public List<UsuarioViewModel> GetByHabilidades(String habilidad)
        {
            var h =  Get(u => u.Habilidad.Any(o=>o.nombre==habilidad));
            return h;
        }

        public UsuarioViewModel GetByLogin(String email, String password)
        {
            String pwd;
             pwd = SeguridadUtils.Sha1Hash(password);
            var us = Get(o => o.email == email & o.password == pwd);

            return (us.First());
        }
        public List<UsuarioViewModel> GetByProyecto(int idProyecto)
        {
            var ptg = Context.Set<Proyecto_Tarea_Grupo>()
                .Where(o => o.idProyecto == idProyecto)
                .Select(o => o.idUsuario);

            var us = Get(o => ptg.Contains(o.id));
            return (us);
        }

        public override UsuarioViewModel Add(UsuarioViewModel model)
        {

            var ida = model.Habilidad.Select(o => o.id).ToArray();

            var hab = Context.Set<Habilidad>().Where(o => ida.Contains(o.id));

            model.password = SeguridadUtils.Sha1Hash(model.password);

            var datos = model.ToModel();

            datos.Habilidad = hab.ToList();
            DbSet.Add(datos);

            Context.SaveChanges();
            model.FromModel(datos);
            return model;
        }

        public int Actualizar2(UsuarioViewModel model)
        {
            var ida = model.Habilidad.Select(o => o.id).ToArray();
            var hab = Context.Set<Habilidad>().Where(o => ida.Contains(o.id)).ToList();

            var datos = GetModelDesdeViewModel(model);
            model.Habilidad = hab;

            model.UpdateModel(datos);
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

        public List<UsuarioViewModel> GetMisContactos(int idUs)
        {
            var ptg = Context.Set<Proyecto_Tarea_Grupo>()
                .Where(o => o.idUsuario == idUs)
                .Select(o => o.Proyecto.Proyecto_Tarea_Grupo);
            var usu = new List<UsuarioViewModel>();

            foreach (var item in ptg)
            {
                foreach (var ptg2 in item)
                {
                    var u = new UsuarioViewModel()
                    {
                        id = ptg2.Usuario.id,
                        nombre = ptg2.Usuario.nombre,
                        apellido = ptg2.Usuario.apellido,
                        email = ptg2.Usuario.email,
                        password = ptg2.Usuario.password,
                        foto = ptg2.Usuario.foto
                    };
                    usu.Add(u);
                }
            }

            usu  = usu.DistinctBy(o => o.id).ToList();
            usu.Remove(usu.Find(o => o.id == idUs));

            return usu;
        }

        static public void CreateOdbcConnection()
        {
            string connectionString = "Driver={SQL Server Native Client 10.0};" +
                                      "Server=tcp:jwavgi6ayo.database.windows.net,1433;" +
                                      "Database=GestionProyectos;" +
                                      "Uid=Alumno@jwavgi6ayo;" +
                                      "Pwd={Mcsd2014};" +
                                      "Encrypt=yes;" +
                                      "Connection Timeout=30";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
            }
        }
        
    }
}