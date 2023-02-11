using AccessData.Modelo;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTravel.Vistas
{
    public partial class ConsultaLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvLibros.DataSource = GetData();
                gvLibros.DataBind();
            }
        }

        /// <summary>
        /// Obtiene los libros para mostrarlos en la grilla
        /// </summary>
        /// <returns></returns>
        private static List<Libros> GetData()
        {
            LibroNegocio libro = new LibroNegocio();
            List<Libros> lstLibros = new List<Libros>();
            lstLibros = libro.ObtenerLibros();

            return lstLibros;
        }

        /// <summary>
        /// Este evento se lanza para obtener fila detalle en la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int isbn =int.Parse(gvLibros.DataKeys[e.Row.RowIndex].Value.ToString());
                GridView gvLibrosDetalle = e.Row.FindControl("gvLibrosDetalle") as GridView;

                LibroNegocio detalle = new LibroNegocio();
                List<DetalleLibro> lstLibrosDetalle = new List<DetalleLibro>();
                detalle.isbn = isbn;
                lstLibrosDetalle = detalle.ObtenerLibrosPorISBN();

                gvLibrosDetalle.DataSource = lstLibrosDetalle;
                gvLibrosDetalle.DataBind();
            }
        }
    }
}