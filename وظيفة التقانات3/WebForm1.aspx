<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="وظيفة_التقانات3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center; background-color:aqua;">
        <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtTo" runat="server"></asp:TextBox><br />
        <asp:Button ID="Move" runat="server" Text="Move"  OnClick="Move_Click"/>
    </div>
    </form>
</body>
</html>
