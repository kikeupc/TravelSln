using AccessData.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DetalleLibro> listaDetalle = new List<DetalleLibro>();
            string conexion = @"Data Source=DESKTOP-DPC458F\SQLEXPRESS; Initial Catalog=BDTravel; user ID=sa; password=123456; Integrated Security=True;";
            using (BDTravelEntities ap = new BDTravelEntities())
            {
               
                var detalleLibro = (from p in ap.Libros
                                    join e in ap.Autores_has_libros                                    
                                    on p.ISBN equals e.libros_ISBN
                                   
                                    where p.ISBN == 200099220
                                    select new
                                    {                                        
                                        NombreAutor=e.Autores.nombre,
                                        ApellidoAutor = e.Autores.apellidos,
                                        Editorial =p.Editoriales.nombre,
                                        NumPaginas = p.n_paginas,
                                    }).ToList();


                foreach (var p in detalleLibro) {
                    DetalleLibro detalle = new DetalleLibro();
                    detalle.NombreAutor = p.NombreAutor;
                    detalle.ApellidoAutor = p.ApellidoAutor;
                    detalle.Editorial = p.Editorial;
                    detalle.NumPaginas = int.Parse(p.NumPaginas);

                    listaDetalle.Add(detalle);
                }

                Console.ReadKey();
            }
        }
    }
}
