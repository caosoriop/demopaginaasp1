﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoPagina1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class paginaweb2Entities : DbContext
    {
        public paginaweb2Entities()
            : base("name=paginaweb2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<contacto> contacto { get; set; }
        public virtual DbSet<imagenproducto> imagenproducto { get; set; }
        public virtual DbSet<lineasubcategoria> lineasubcategoria { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<subcategoria> subcategoria { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}