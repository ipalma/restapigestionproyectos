//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi_GestionProyectos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mensaje
    {
        public int Id { get; set; }
        public int idRem { get; set; }
        public string fotoRem { get; set; }
        public int idDest { get; set; }
        public System.DateTime fecha { get; set; }
        public string contenido { get; set; }
        public string nombreRem { get; set; }
        public string emailRem { get; set; }
        public int estado { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual EstadoMensaje EstadoMensaje { get; set; }
    }
}
