<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Student_registeration.Login" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <p>
            Login here!</p>
        <table cellpadding="3" cellspacing="4" style="width: 100%">
            <tr>
                <td style="width: 222px">Email_Id</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 222px">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 222px">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
            </tr>
        </table>
    </form>

</asp:Content>
