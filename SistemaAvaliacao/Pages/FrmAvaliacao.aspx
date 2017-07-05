<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAvaliacao.aspx.cs" Inherits="SistemaAvaliacao.Pages.FrmAvaliacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../Styles/FrmAvaliacao.css" />
</head>
<body>
    <asp:Label ID="lb_titulo" runat="server" Text=""></asp:Label>
    <form id="form_avaliacao" class="avaliacao" runat="server">
        <asp:Button ID="bt_finalizar" runat="server" Text="Finalizar" OnClick="bt_finalizar_Click" />
    </form>
</body>
</html>
