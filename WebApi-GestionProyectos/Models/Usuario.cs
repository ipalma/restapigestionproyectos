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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Proyecto_Tarea_Grupo = new HashSet<Proyecto_Tarea_Grupo>();
            this.Habilidad = new HashSet<Habilidad>();
            this.Mensaje = new HashSet<Mensaje>();
            this.Mensaje1 = new HashSet<Mensaje>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string foto { get; set; }
    
        public virtual ICollection<Proyecto_Tarea_Grupo> Proyecto_Tarea_Grupo { get; set; }
        public virtual ICollection<Habilidad> Habilidad { get; set; }
        public virtual ICollection<Mensaje> Mensaje { get; set; }
        public virtual ICollection<Mensaje> Mensaje1 { get; set; }
    }
}
