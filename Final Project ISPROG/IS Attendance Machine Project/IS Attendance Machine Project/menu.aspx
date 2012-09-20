<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="IS_Attendance_Machine_Project.menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 137px;
        }
        .style2
        {
            width: 128px;
        }
        .style3
        {
            width: 571px;
        }
        .style4
        {
            width: 467px;
        }
    </style>
</head>
<body bgcolor="#33cc33" background="bgnew.jpg">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Log out" 
                        onclick="Button4_Click" />
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1">
                    <asp:Button ID="btnmaintenance" runat="server" Text="MAINTENANCE" 
                        onclick="btnmaintenance_Click" />
                </td>
                <td class="style2">
                    <asp:Button ID="btnattendance" runat="server" Text="ATTENDANCE" 
                        onclick="btnattendance_Click" Visible="False" />
                </td>
                <td class="style3">
                    <asp:Button ID="btnreports" runat="server" Text="REPORTS" 
                        onclick="btnreports_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Label ID="lblwelcomenotif" runat="server" Text="Welcome note" 
                Visible="False" ForeColor="White"></asp:Label>
        </p>
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
