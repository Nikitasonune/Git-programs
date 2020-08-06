<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDelete.aspx.cs" Inherits="RegistrationFormCRUD.UpdateDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <strong>Update And Delete Record</strong></p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:GridView ID="GridView1" runat="server">
                <EmptyDataTemplate>
                    <span class="auto-style2">First Name</span>
                </EmptyDataTemplate>
            </asp:GridView>
        </p>
    </form>
</body>
</html>
