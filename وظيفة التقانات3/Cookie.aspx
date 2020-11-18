<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="وظيفة_التقانات3.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        <asp:Button ID="Button1" runat="server" Text="Create Cookie" OnClick="Button1_Click" /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" CssClass="am" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="Button2" runat="server" Text="Retrieve Cookie" OnClick="Button2_Click" /><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

    </div>
    </form>
</body>
</html>
