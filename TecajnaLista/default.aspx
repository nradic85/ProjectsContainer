<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TecajnaLista._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tečajna lista</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tečajna lista</h1>
        </div>
        <div>
            <h2>Kupujem kune:</h2>
            <p>Odaberi valutu koju prodaješ:</p>
            <asp:DropDownList ID="ddlValuta1" runat="server"></asp:DropDownList>
            <p>Unesi iznos valute koji želiš prodati:</p>
            <asp:TextBox ID="tbStranaValuta" runat="server"></asp:TextBox>
            <asp:Label ID="lblKukujemKune" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
        <div>
            <h2>Prodajem kune:</h2>
            <p>Unesi koji iznos kuna želiš prodati:</p>
            <asp:TextBox ID="tbDomacaValuta" runat="server"></asp:TextBox>
            <p>Odaberi koju valutu želiš kupiti:</p>
            <asp:DropDownList ID="ddlValuta2" runat="server"></asp:DropDownList>
            <asp:Label ID="lblProdajemKune" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
