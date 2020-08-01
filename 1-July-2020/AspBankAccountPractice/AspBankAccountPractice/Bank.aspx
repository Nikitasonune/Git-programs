<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bank.aspx.cs" Inherits="AspBankAccountPractice.Bank" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 257px;
        }
        .auto-style4 {
            width: 257px;
            text-align: left;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            margin-bottom: 0px;
        }
        .auto-style7 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>State Bank of India<br />
            </strong>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Enter Your Name"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server" Width="173px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="Enter Amount"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style6" Width="166px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Deposit" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Withdrawal" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>
                        <asp:Label ID="Label3" runat="server" Text="Status"></asp:Label>
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <p class="auto-style7">
        &nbsp;</p>
</body>
</html>
