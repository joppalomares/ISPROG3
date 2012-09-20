
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maintenance.aspx.cs" Inherits="IS_Attendance_Machine_Project.maintenance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style4
        {
            width: 467px;
        }
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
        .style5
        {
            width: 897px;
            margin-left: 40px;
        }
        .style6
        {
            width: 896px;
        }
        .style7
        {
            width: 63px;
        }
        .style8
        {
            width: 897px;
            margin-left: 40px;
            height: 137px;
        }
    </style>
</head>
<body background="bgnew.jpg">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style5" colspan="7">
    
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
                    <asp:Button ID="btnlogout" runat="server" Text="Log out" 
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
                    <asp:Label ID="Label13" runat="server" Text="MAINTENANCE" ForeColor="White"></asp:Label>
                </td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Label ID="Label19" runat="server"></asp:Label>
                </td>
                <td class="style3">
                    &nbsp;</td>
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
        </table>
                </td>
            </tr>
            <tr>
                <td class="style5" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Student CRUD" ForeColor="White"></asp:Label>
                </td>
                <td class="style5" colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="Subject CRUD" ForeColor="White"></asp:Label>
                </td>
                <td class="style5" colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Faculty CRUD" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5" colspan="2">
                    &nbsp;</td>
                <td class="style5" colspan="2">
                    &nbsp;</td>
                <td class="style5" colspan="2">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label4" runat="server" Text="ID" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxid" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Label ID="Label10" runat="server" Text="First name" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxfirstnameforprof" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label5" runat="server" Text="First name" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxfirstn" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:Label ID="Label8" runat="server" Text="Code" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxcode" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:Label ID="Label11" runat="server" Text="Last name" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxlastnameforprof" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label6" runat="server" Text="Last name" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxlastn" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:Label ID="Label9" runat="server" Text="Section" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxsection" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:Label ID="Label12" runat="server" Text="User type" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Professor</asp:ListItem>
                        <asp:ListItem>Chairman</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label7" runat="server" Text="Course" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxcourse" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Label ID="Label15" runat="server" Text="Username" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxusername" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Label ID="Label16" runat="server" Text="Password" ForeColor="White"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtboxpassword" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;&nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Button ID="btnaddstud" runat="server" Text="ADD" 
                        onclick="btnaddstud_Click" />
                    <asp:Button ID="btneditstud" runat="server" Text="EDIT" 
                        onclick="btneditstud_Click" />
                    <asp:Button ID="btndeletestud" runat="server" Text="DELETE" 
                        onclick="btndeletestud_Click" />
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Button ID="btnsubjadd" runat="server" Text="ADD" 
                        onclick="btnsubjadd_Click" />
                    <asp:Button ID="btnsubjedit" runat="server" Text="EDIT" 
                        onclick="btnsubjedit_Click" />
                    <asp:Button ID="btnsubjdelete" runat="server" Text="DELETE" 
                        onclick="btnsubjdelete_Click" />
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Button ID="btnfacadd" runat="server" Text="ADD" 
                        onclick="btnfacadd_Click" />
                    <asp:Button ID="btnfacedit" runat="server" Text="EDIT" 
                        onclick="btnfacedit_Click" />
                    <asp:Button ID="btnfacdelete" runat="server" Text="DELETE" 
                        onclick="btnfacdelete_Click" />
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        style="height: 26px" Text="Add Subject" />
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:FileUpload ID="FileUpload" runat="server" />
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Add Subject" />
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5" colspan="2">
                    <asp:Button ID="btnupload" runat="server" Text="Upload Student" 
                        onclick="btnupload_Click" />
                </td>
                <td class="style5" colspan="2">
                    &nbsp;</td>
                <td class="style5" colspan="2">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2">
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                    </td>
                <td class="style8" colspan="2">
                    <asp:GridView ID="gridviewuploadedfile" runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="style8" colspan="2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style5" colspan="2">
                    <asp:GridView ID="gridviewstudent" runat="server" 
                        onselectedindexchanged="gridviewstudent_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="style5" colspan="2">
                    <asp:GridView ID="gridviewsubject" runat="server" 
                        onselectedindexchanged="gridviewsubject_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="style5" colspan="2">
                    <asp:GridView ID="gridviewfaculty" runat="server" 
                        onselectedindexchanged="gridviewfaculty_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
