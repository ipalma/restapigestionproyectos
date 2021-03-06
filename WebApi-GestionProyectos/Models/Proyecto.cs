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
    
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Proyecto_Tarea_Grupo = new HashSet<Proyecto_Tarea_Grupo>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public int idEstado { get; set; }
        public int idPrioridad { get; set; }
    
        public virtual EstadoProyecto EstadoProyecto { get; set; }
        public virtual Prioridad Prioridad { get; set; }
        public virtual ICollection<Proyecto_Tarea_Grupo> Proyecto_Tarea_Grupo { get; set; }
    }
}
