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
    
    public partial class vistaDatosUsuario
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
    }
}
