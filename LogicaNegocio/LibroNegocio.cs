using AccessData;
using AccessData.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    /// <summary>
    /// Contiene  funcionalidades de validacion de negocio
    /// </summary>
    public class LibroNegocio
    {
        public int isbn { get; set; }

        /// <summary>
        /// Obtiene listado de libros
        /// </summary>
        /// <returns></returns>
        public List<Libros> ObtenerLibros()
        {
            AccesoDatos acceso = new AccesoDatos();

            List<Libros> lstLibros = new List<Libros>();
            lstLibros = acceso.ObtenerLibros();
            return lstLibros;
        }

        /// <summary>
        /// Obtiene detalle de libro por ISBN
        /// </summary>
        /// <returns></returns>
        public List<DetalleLibro> ObtenerLibrosPorISBN()
        {
            AccesoDatos acceso = new AccesoDatos();

            List<DetalleLibro> lstLibroDetalle = new List<DetalleLibro>();
            lstLibroDetalle = acceso.ObtenerLibrosPorISBN(isbn);
            return lstLibroDetalle;
        }
    }
}
