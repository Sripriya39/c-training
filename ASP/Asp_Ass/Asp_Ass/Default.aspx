<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductSelector.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Selector</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Product Selector</h1>
        <table>
            <tr>
                <td>Name:</td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Family Name:</td>
                <td><asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Address:</td>
                <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>City:</td>
                <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Zip Code:</td>
                <td><asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone:</td>
                <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>E-mail Address:</td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Product:</td>
                <td>
                    <asp:DropDownList ID="ddlProduct" runat="server">
                        <asp:ListItem Value="">Select a product</asp:ListItem>
                        <asp:ListItem Value="Phone">Phone</asp:ListItem>
                        <asp:ListItem Value="Laptop">Laptop</asp:ListItem>
                        <asp:ListItem Value="PC">PC</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Image:</td>
                <td><asp:Image ID="imgProduct" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
                </td>
            </tr>
            <tr>
                <td>Price:</td>
                <td><asp:Label ID="lblPrice" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>