<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteRecord.aspx.cs" Inherits="RegistrationFormCRUD.ShowRecord" %>

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
            width: 70%;
        }
        .auto-style3 {
            width: 125px;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            font-weight: bold;
        }
    </style>
</head>
<body style="background-color:lightgrey">
    <form id="form1" runat="server">
        <p class="auto-style1">
            <strong>Delete Record</strong></p>
        <p class="auto-style1">
            &nbsp;</p>
        <table align="center" class="auto-style2">
            <tr>
                <td class="auto-style3">First Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter UserId first" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Last Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style5" OnClick="Button1_Click" Text="Delete" style="height: 26px" />
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    </body>
</html>
