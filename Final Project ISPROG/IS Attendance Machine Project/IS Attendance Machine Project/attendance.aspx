<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="attendance.aspx.cs" Inherits="IS_Attendance_Machine_Project.attendance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style6
        {
            width: 896px;
        }
        
        .style4
        {
            width: 240px;
        }
        .style1
        {
        }
        .style2
        {
        }
        .style3
        {
            width: 571px;
        }
        .style7
        {
            width: 63px;
        }
        .style8
        {
            height: 34px;
        }
    </style>
</head>
<body background="bgnew.jpg">
    <form id="form1" runat="server">
    <div>
        <table class="style6">
            <tr>
                <td class="style4">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    <asp:Button ID="btnlogout" runat="server" Text="Log out" 
                        onclick="btnlogout_Click" />
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    <asp:Button ID="btnmaintenance" runat="server" Text="MAINTENANCE" 
                        onclick="btnmaintenance_Click" />
                </td>
                <td class="style2" colspan="2">
                    <asp:Button ID="btnattendance" runat="server" Text="ATTENDANCE" 
                        onclick="btnattendance_Click" />
                </td>
                <td class="style3" colspan="3">
                    <asp:Button ID="btnreports" runat="server" Text="REPORTS" 
                        onclick="btnreports_Click" />
                </td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label3" runat="server" Text="ATTENDANCE" ForeColor="White"></asp:Label>
                </td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="Date" ForeColor="White"></asp:Label>
                </td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    <asp:Label ID="Label2" runat="server" Text="Status" ForeColor="White"></asp:Label>
                </td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4" rowspan="4">
                    <asp:GridView ID="gridviewstud" runat="server" 
                        onselectedindexchanged="gridviewstud_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style1">
                    <asp:Button ID="btnpresent" runat="server" Text="Present" 
                        onclick="btnpresent_Click" />
                </td>
                <td class="style7" rowspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2">
                    <asp:TextBox ID="txtboxdate" runat="server"></asp:TextBox>
                </td>
                <td class="style8" colspan="2">
                    </td>
                <td class="style8" colspan="2">
                    </td>
                <td class="style8" colspan="2">
                    <asp:Button ID="btnabsent" runat="server" Text="Absent" 
                        onclick="btnabsent_Click" />
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
                <td class="style1" colspan="2">
                    &nbsp;</td>
                <td class="style1" colspan="2">
                    &nbsp;</td>
                <td class="style1" colspan="2">
                    <asp:Button ID="btnlate" runat="server" Text="Late" onclick="btnlate_Click" />
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                    &nbsp;</td>
                <td class="style1" colspan="2">
                    &nbsp;</td>
                <td class="style1" colspan="2">
                    &nbsp;</td>
                <td class="style1" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:GridView ID="gridviewattendance" runat="server" 
                        onselectedindexchanged="gridviewattendance_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    &nbsp;</td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style1" colspan="3">
                    <asp:TextBox ID="tbxidnumber" runat="server"></asp:TextBox>
                </td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:TextBox ID="txtboxforid" runat="server"></asp:TextBox>
                </td>
                <td class="style1" colspan="3">
                    <asp:TextBox ID="tbxattendancestatus" runat="server"></asp:TextBox>
                </td>
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td class="style3" colspan="3">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
