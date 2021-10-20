<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mainpage.aspx.cs" Inherits="dotnet_project1.Mainpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Mainpage.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            background-color: #FFFFFF;
        }
    </style>
</head>
<body style="background-color: #FFFFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="margin-left: 80px">
        </div>
        <div>
            <ul>
                  <li><a class="active" href="Mainpage.aspx">Home</a></li>
                  <li><a href="Login.aspx">LOG IN</a></li>
                  <li><a href="Signup.aspx">SIGN UP</a></li>
                  <li><a href="Homepage.aspx">ADD NEWS</a></li>
                  <li>&nbsp;s</li>
            </ul>
        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div style="margin-left: 360px">
            <asp:GridView ID="GridView1" runat="server" BorderStyle="None" CellPadding="25" GridLines="None" Height="232px" Width="1106px" ShowHeader="False" style="font-weight: 700; font-style: italic; font-size: large">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
