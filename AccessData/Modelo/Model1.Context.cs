﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessData.Modelo
{
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.EntityClient;

    public partial class BDTravelEntities : DbContext
    {
        public BDTravelEntities()
            : base(ObtenerConexionSql())
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Autores_has_libros> Autores_has_libros { get; set; }

        /// <summary>
        /// Obtiene conexion de entityframewrok
        /// </summary>
        /// <returns></returns>
        public static string ObtenerConexionSql()
        {
            // Inicializa el EntityConnectionStringBuilder. (Construye cadena de conexion de entityframework)
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            string conexion = System.Configuration.ConfigurationManager.AppSettings["cadenaConexion"];
            
            //Establece el proveedor de la cadena de conexion
            entityBuilder.Provider = "System.Data.SqlClient"; 

            // Establece el provider-specific connection string.          
            entityBuilder.ProviderConnectionString = conexion + ";MultipleActiveResultSets=True;App=EntityFramework;"; 

            // Establece la metadata de entityframework. 
            entityBuilder.Metadata = "res://*/Modelo.Model1.csdl|res://*/Modelo.Model1.ssdl|res://*/Modelo.Model1.msl";
           
            return entityBuilder.ToString();
        }
    }
}
