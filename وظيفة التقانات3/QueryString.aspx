<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString.aspx.cs" Inherits="وظيفة_التقانات3.QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Your Name :"></asp:Label><asp:TextBox ID="name" name="name" runat="server"></asp:TextBox> <br \ />
        <asp:Label ID="Label2" runat="server" Text="Enter Your Age :"></asp:Label><asp:TextBox ID="age" name="age" runat="server"></asp:TextBox> <br \ />  <hr />
        <asp:Label ID="Label3" runat="server" Text="Query String"></asp:Label><br />         
        <asp:Button ID="Button1" runat="server" Text="Send By QueryString" OnClick="Button1_Click" />  <hr />
        <asp:Label ID="Label4" runat="server" Text="View State"></asp:Label><br />     
        <asp:Button ID="Button2" runat="server" Text="Set View State" OnClick="Button2_Click" />  
        <asp:Button ID="Button3" runat="server" Text="Restore View State" OnClick="Button3_Click" />  <hr />



             

    </div>
    </form>
</body>
</html>
