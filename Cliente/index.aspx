<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Cliente.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblFactorA" runat="server" Text="Factor A:"></asp:Label>
            <asp:TextBox ID="txtFactorA" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblFactorB" runat="server" Text="Factor B:"></asp:Label>
            <asp:TextBox ID="txtFactorB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCalcularModulo" runat="server" Text="Calcular Módulo" OnClick="btnCalcularModulo_Click" /> 
        </p>
        <asp:Label ID="lblResultado" runat="server" Text="El Resultado del Módulo es: 0"></asp:Label>
    </form>
</body>
</html>
