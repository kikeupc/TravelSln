using AccessData;
using AccessData.Modelo;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProyecto
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Valida si el metodo obtener libros contiene registros
        /// </summary>
        [Test]      
        public void TestCantidadLibros()
        {
            AccesoDatos acceso = new AccesoDatos();
            var result = acceso.ObtenerLibros();

            Assert.True(result.Count == 0);
        }


        /// <summary>
        /// Valida que el tipo devuelto por el metodo ObtenerLibros sea de tipo List<Libros>
        /// </summary>
        [Test]
        public void TestObtenerPeliculas()
        {
            AccesoDatos acceso = new AccesoDatos();
            var result = acceso.ObtenerLibros();

            Assert.IsInstanceOf<List<Libros>>(result);
        }


        /// <summary>
        /// Valida que el tipo devuelto por el metodo ObtenerLibros sea de tipo List<DetalleLibro>
        /// </summary>
        [Test]
        [TestCase(200099220)]
        public void ObtenerLibrosISBN(int isbn)
        {
            AccesoDatos acceso = new AccesoDatos();
            var result = acceso.ObtenerLibrosPorISBN(isbn);

            Assert.IsInstanceOf<List<DetalleLibro>>(result);
        }
    }
}