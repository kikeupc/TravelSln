using System;
using System.Collections.Generic;
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
            if (Usuario.Equals("travel") && Contrasena.Equals("travel.123456"))
                return true; return false;
        }
    }
}