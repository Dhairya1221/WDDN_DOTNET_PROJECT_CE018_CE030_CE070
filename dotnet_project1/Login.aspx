<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="dotnet_project1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Mainpage.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            font-weight: 700;
            font-style: italic;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            background-color: #8EA49B;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                  <li><a href="Mainpage.aspx">Home</a></li>
                  <li><a href="Login.aspx">LOG IN</a></li>
                  <li><a href="Signup.aspx">SIGN UP</a></li>
                  <li><a href="Homepage.aspx">ADD NEWS</a></li>
            </ul>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        LOGIN<br />
        <br />
        EMAIL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="passtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
