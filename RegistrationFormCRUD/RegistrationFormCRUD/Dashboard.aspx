<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="RegistrationFormCRUD.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style3 {
            font-weight: bold;
        }
    </style>
</head>
<body style="background-color:lightgrey">
    <form id="form1" runat="server">
        <p class="auto-style1">
            <strong>Welcome To User Dashboard</strong></p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Show All Record" />
            </strong>
        </p>
    </form>
</body>
</html>
