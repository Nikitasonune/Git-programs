<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAX.aspx.cs" Inherits="WebApplicationAJAX.AJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Enter Number
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 26px" Text="Button" />
        </p>
        <p>
            Outside update panel</p>
        <p>
            Enter age
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
