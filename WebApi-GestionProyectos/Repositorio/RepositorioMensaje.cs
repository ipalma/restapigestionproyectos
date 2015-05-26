using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Repositorio;
using WebApi_GestionProyectos.Models;
using WebApi_GestionProyectos.Models.ViewModel;

namespace WebApi_GestionProyectos.Repositorio
{
    public class RepositorioMensaje : Repositorio<MensajeViewModel, Mensaje>
    {
        public RepositorioMensaje(DbContext context) : base(context)
        {

        }

        public List<MensajeViewModel> GetByEnviados(int id)
        {
            return Get(o => o.idRem == id);
        }
        public List<MensajeViewModel> GetByRecibidos(int id)
        {
            return Get(o => o.idDest == id);
        }
        public List<MensajeViewModel> GetByconversacion(int idR, int idD)
        {
            return Get(o => o.idRem == idR && o.idDest == idD);
        }
    }
}