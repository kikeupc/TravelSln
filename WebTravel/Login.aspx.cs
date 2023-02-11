using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTravel
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool autenticado = false;
            autenticado= LoginCorrecto(loginUsuario.UserName, loginUsuario.Password);
            e.Authenticated = autenticado;
            if (autenticado) {
                Response.Redirect("Vistas/ConsultaLibros.aspx");
            }
        }


        private bool LoginCorrecto(string Usuario, string Contrasena)
        {
            string usuario = ConfigurationManager.AppSettings["usuario"];
            string contrasena = ConfigurationManager.AppSettings["contrasena"];
            if (Usuario.Equals(usuario) && Contrasena.Equals(contrasena))
                return true; return false;
        }
    }
}