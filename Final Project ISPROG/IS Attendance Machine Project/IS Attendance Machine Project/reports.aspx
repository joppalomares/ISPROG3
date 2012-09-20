<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reports.aspx.cs" Inherits="IS_Attendance_Machine_Project.reports" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style4
        {
            width: 240px;
        }
        .style3
        {
            width: 571px;
        }
        .style7
        {
            width: 63px;
        }
        .style6
        {
            width: 896px;
        }
        </style>
</head>
<body bgcolor="#33cc33" background="bgnew.jpg">
    <form id="form1" runat="server">
    <div>
    
        <table class="style6">
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    <asp:Button ID="btnlogout" runat="server" Text="Logout" 
                        onclick="btnlogout_Click" />
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
                <td class="style7">
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
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" Text="CRYSTAL REPORTS" ForeColor="White"></asp:Label>
                </td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
        </table>
        <p>
        </p>
        <table class="style6">
            <tr>
                <td class="style4">
                    <asp:Button ID="btnreportforattendance" runat="server" 
                        onclick="btnreportforattendance_Click" Text="Attendance Report" />
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Button ID="btnreportforstudent" runat="server" 
                        onclick="btnreportforstudent_Click" Text="Student Report" />
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Button ID="btnreportforprof" runat="server" 
                        onclick="btnreportforprof_Click" Text="Professor Report" />
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Button ID="btnreportforsubj" runat="server" 
                        onclick="btnreportforsubj_Click" Text="Subject Report" />
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" 
        ForeColor="White" NavigateUrl="~/audittrails.aspx">View Audit Trails</asp:HyperLink>
    </form>
</body>
</html>
