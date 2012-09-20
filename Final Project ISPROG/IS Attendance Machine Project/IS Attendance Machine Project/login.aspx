<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="IS_Attendance_Machine_Project.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 269px;
        }
        .style3
        {
        }
        .style5
        {
            width: 154px;
        }
        .style6
        {
            width: 41px;
        }
        .style7
        {
            width: 154px;
            height: 270px;
        }
        .style8
        {
            width: 41px;
            height: 270px;
        }
        .style9
        {
            width: 269px;
            height: 270px;
        }
        .style10
        {
            height: 270px;
        }
    </style>
</head>
<body background="bgnew.jpg">
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;
    
        <center><table style="width:100%;">
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3" colspan="4" rowspan="4">
                    <center><asp:Image ID="Image1" runat="server" ImageUrl="~/1.jpg" /></center>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" colspan="5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td class="style8">
                    <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/loginbox.jpg" 
                        Height="469px" Width="785px">
&nbsp;<br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" ForeColor="#E10000" 
                            Text="Invalid username and password"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="White" 
                            Text="Username"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:TextBox ID="txtboxun" runat="server" style="text-align: center" 
                            Width="162px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="White" 
                            Text="Password"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtboxpw" runat="server" TextMode="Password" Width="162px"></asp:TextBox>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnlogin" runat="server" Font-Size="Medium" 
                            onclick="btnlogin_Click" Text="Log in" />
                    </asp:Panel>
                </td>
                <td class="style9">
                    &nbsp;</td>
                <td class="style10">
                    </td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table></center>
    
    </div>
    </form>
</body>
</html>
