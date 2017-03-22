<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="DiscussionForum.AdminPanel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Role :<asp:TextBox ID="txtRoleName" runat="server">
	</asp:TextBox>
	<br />
	<asp:Button ID="btnAddRole" runat="server" Text="Add Role" 
			onclick="btnAddRole_Click" />
    
    
    </div>
    </form>
</body>
</html>
