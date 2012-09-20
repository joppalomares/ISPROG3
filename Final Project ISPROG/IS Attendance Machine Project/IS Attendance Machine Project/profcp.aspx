<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profcp.aspx.cs" Inherits="IS_Attendance_Machine_Project.profcp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="bgnew.jpg">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Check Attendance" />
    
    </div>
    </form>
</body>
</html>
