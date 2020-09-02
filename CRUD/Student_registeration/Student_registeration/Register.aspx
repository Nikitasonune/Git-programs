<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Student_registeration.Register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form  runat="server" style="background-color:darkgray">
    <p class="auto-style2">
    Student Registeration Form</p>
<p class="auto-style2">
    &nbsp;</p>
<table cellpadding="5" cellspacing="5" class="auto-style3">
    <tr>
        <td class="auto-style5">First_Name</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox1" runat="server" Width="125px"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="First name required" Font-Bold="False" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Last_Name</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Last name required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Mobile No</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="RegularExpressionValidator" ForeColor="#CC0000" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Gender</td>
        <td class="auto-style7">
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="r1" Text="Male" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="r1" Text="Female" />
&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="r1" Text="Others" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Date of Birth</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Birth date required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Corresspond Address</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Permanent Address</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="Address required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Stream</td>
        <td class="auto-style7">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Computer/It</asp:ListItem>
                <asp:ListItem>Electronics</asp:ListItem>
                <asp:ListItem>Electrical</asp:ListItem>
                <asp:ListItem>Mechanical</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Course</td>
        <td class="auto-style7">
            <asp:CheckBox ID="CheckBox1" runat="server" Text=".Net" />
&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Java" />
&nbsp;
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Python" />
&nbsp;
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Php" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">Email Id</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox7" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox7" ErrorMessage="Email id is must" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">password</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox9" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="at least one number, one lowercase and one uppercase letter" ValidationExpression="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}" ControlToValidate="TextBox9" ForeColor="#CC0000"></asp:RegularExpressionValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">confirm password</td>
        <td class="auto-style7">
            <asp:TextBox ID="TextBox10" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox9" ControlToValidate="TextBox10" ErrorMessage="Password does not match" ForeColor="#CC0000"></asp:CompareValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">photo</td>
        <td class="auto-style8">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">Status</td>
        <td class="auto-style8">
            <asp:CheckBox ID="CheckBox5" runat="server" Text="Active" />
        </td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" />
        </td>
        <td class="auto-style4">&nbsp;</td>
    </tr>
</table>
<p class="auto-style2">
    &nbsp;</p>
        </form>
</asp:Content>
