<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculate.aspx.cs" Inherits="WebApplication2.Calculate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Calculate<br />
            <br />
            Number 1:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="167px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            <br />
            Number 2:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="167px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
