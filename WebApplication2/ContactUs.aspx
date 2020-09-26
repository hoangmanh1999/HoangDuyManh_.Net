<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="WebApplication2.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 23px;
            width: 189px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ContactUs<br />
            <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            <br />
            Category:&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True" Text="==Select==" Value="==Select=="></asp:ListItem>
                <asp:ListItem  Text="News" Value="News"></asp:ListItem>
                <asp:ListItem  Text="Report" Value="Report"></asp:ListItem>
                <asp:ListItem  Text="System" Value="System"></asp:ListItem>

            </asp:DropDownList>
            <br />
            <br />
            Description:&nbsp;
            <textarea id="TextArea1" name="S1"></textarea><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
