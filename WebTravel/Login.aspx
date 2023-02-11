<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebTravel.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login runat="server" ID="loginUsuario" OnAuthenticate="Login1_Authenticate" LoginButtonText="Ingresar" PasswordLabelText="Contraseña:" RememberMeText="Recordarme la proxima vez." TitleText=""
                UserNameLabelText="Usuario:">
            </asp:Login>
        </div>
    </form>
</body>

</html>
