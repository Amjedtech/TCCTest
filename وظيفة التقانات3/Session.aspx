<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="وظيفة_التقانات3.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Emaillbl" runat="server" Text="Enter Your Email :"></asp:Label><asp:TextBox ID="email" name="email" runat="server"></asp:TextBox> <br \ />
        <asp:Label ID="Passwordlbl" runat="server" Text="Enter Your Password :"></asp:Label><asp:TextBox ID="password" name="password" runat="server"></asp:TextBox> <br \ /> 
        <asp:Button ID="LogIn" runat="server" Text="Log In" OnClick="LogIn_Click" />
        <hr />
        <asp:Label ID="Show" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
