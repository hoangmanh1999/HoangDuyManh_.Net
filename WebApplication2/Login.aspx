<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login Page</div>
        <p>
            Username:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="144px"></asp:TextBox>
        </p>
        Passworld:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="144px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Login" />
        </p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
