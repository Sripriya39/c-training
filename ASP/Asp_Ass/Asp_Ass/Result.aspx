<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="LineEndingIssue.Result" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Line Ending Issue Result</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Summary of your details:</h1>
        <table>
            <tr>
                <td>Name:</td>
                <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Family Name:</td>
                <td><asp:Label ID="lblFamilyName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Address:</td>
                <td><asp:Label ID="lblAddress" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>City:</td>
                <td><asp:Label ID="lblCity" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Zip Code:</td>
                <td><asp:Label ID="lblZipCode" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Phone:</td>
                <td><asp:Label ID="lblPhone" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>E-mail Address:</td>
                <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html