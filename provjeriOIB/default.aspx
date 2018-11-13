<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="provjeriOIB._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Provjeri OIB</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Provjeri OIB</h1>
            <asp:Label ID="lblInsertOIB" runat="server" Text="Insert OIB: "></asp:Label>
            <asp:TextBox ID="tbOIB" runat="server"></asp:TextBox>
            <asp:Button ID="btnSendOIB" runat="server" Text="Send" OnClick="btnSendOIB_Click" />
            <asp:Label ID="lblOutput" runat="server" Text="" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
