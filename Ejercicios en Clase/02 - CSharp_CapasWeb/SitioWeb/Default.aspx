<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #form1{
            margin: 10px auto;
            width: 70%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>

                <h1>Listado de Clientes </h1>
                <hr />
            </div>
            <div>
                Nombre del Cliente: <asp:TextBox ID ="txtNombre" runat ="server"
                    width="285px"></asp:TextBox>
                <asp:Button ID ="btnBuscar" runat ="server" Text="Buscar" />

            </div>

            <div>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No hay datos para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="Modificar" runat="server" CommandArgument='<%# Eval("ID_CLIENTE").ToString() %>' CommandName="Modificar">Modificar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="InkEliminar" runat="server" CommandArgument='<%# Eval("ID_CLIENTE").ToString() %>' CommandName="Eliminar">Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField></asp:TemplateField>
                        <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" />
                        <asp:BoundField DataField="TELEFONO" HeaderText="Teléfono" />
                        <asp:BoundField DataField="DIRECCION" HeaderText="Dirección" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </div>
        </div>

    </form>
</body>
</html>
