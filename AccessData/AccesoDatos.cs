using AccessData.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData
{
    /// <summary>
    /// Funcionalidades para acceso a datos por entity framework
    /// </summary>
    public class AccesoDatos
    {

        List<Libros> listLibros = new List<Libros>();
        /// <summary>
        /// Obtiene listado de todos los libros
        /// </summary>
        /// <returns>Lista de libros</returns>
        public List<Libros> ObtenerLibros()
        {
            try {
                using (BDTravelEntities bd = new BDTravelEntities())
                {
                    listLibros = bd.Libros.ToList();
                }

                return listLibros;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }            
        }

        /// <summary>
        /// Obtiene libros por ISBN
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Detalles de libro consultado</returns>
        public List<DetalleLibro> ObtenerLibrosPorISBN(int isbn)
        {
            try
            {
                List<DetalleLibro> listaDetalle = new List<DetalleLibro>();
                using (BDTravelEntities ap = new BDTravelEntities())
                {

                    var detalleLibro = (from p in ap.Libros
                                        join e in ap.Autores_has_libros
                                        on p.ISBN equals e.libros_ISBN
                                        where p.ISBN == isbn
                                        select new
                                        {
                                            NombreAutor = e.Autores.nombre,
                                            ApellidoAutor = e.Autores.apellidos,
                                            Editorial = p.Editoriales.nombre,
                                            NumPaginas = p.n_paginas,
                                        }).ToList();


                    foreach (var p in detalleLibro)
                    {
                        DetalleLibro detalle = new DetalleLibro();
                        detalle.NombreAutor = p.NombreAutor;
                        detalle.ApellidoAutor = p.ApellidoAutor;
                        detalle.Editorial = p.Editorial;
                        detalle.NumPaginas = int.Parse(p.NumPaginas);

                        listaDetalle.Add(detalle);
                    }
                }

                return listaDetalle;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}
