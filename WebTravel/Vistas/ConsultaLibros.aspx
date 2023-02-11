<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaLibros.aspx.cs" Inherits="WebTravel.Vistas.ConsultaLibros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        body {
            font-family: Arial;
            font-size: 10pt;
        }

        .Grid td {
            background-color: #A1DCF2;
            color: black;
            font-size: 10pt;
            line-height: 200%
        }

        .Grid th {
            background-color: #3AC0F2;
            color: White;
            font-size: 10pt;
            line-height: 200%
        }

        .ChildGrid td {
            background-color: #eee !important;
            color: black;
            font-size: 10pt;
            line-height: 200%
        }

        .ChildGrid th {
            background-color: #6C6C6C !important;
            color: White;
            font-size: 10pt;
            line-height: 200%
        }
    </style>
      
    <script type="text/javascript" src="../Scripts/jquery.min.js"></script>
    <script type="text/javascript">
        $("[src*=plus]").live("click", function () {
            $(this).closest("tr").after("<tr><td></td><td colspan = '999'>" + $(this).next().html() + "</td></tr>")
            $(this).attr("src", "../images/minus.png");
        });
        $("[src*=minus]").live("click", function () {
            $(this).attr("src", "../images/plus.png");
            $(this).closest("tr").next().remove();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvLibros" runat="server" AutoGenerateColumns="false" CssClass="Grid"
                DataKeyNames="ISBN" OnRowDataBound="OnRowDataBound">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <img alt="" style="cursor: pointer" src="../images/plus.png" />
                            <asp:Panel ID="pnlLibros" runat="server" Style="display: none">
                                <asp:GridView ID="gvLibrosDetalle" runat="server" AutoGenerateColumns="false" CssClass="ChildGrid" Width="100%">
                                    <Columns>
                                        <asp:BoundField ItemStyle-Width="150px" DataField="NombreAutor" HeaderText="Nombre Autor" />
                                        <asp:BoundField ItemStyle-Width="150px" DataField="ApellidoAutor" HeaderText="Apellido Autor" />
                                        <asp:BoundField ItemStyle-Width="150px" DataField="Editorial" HeaderText="Editorial" />
                                        <asp:BoundField ItemStyle-Width="150px" DataField="NumPaginas" HeaderText="No. Paginas" />
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField ItemStyle-Width="150px" DataField="ISBN" HeaderText="ISBN" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="Titulo" HeaderText="Titulo" />                    
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
