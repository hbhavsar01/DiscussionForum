﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddName.aspx.cs" Inherits="DiscussionForum.AddName" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
        <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br /><br />
     <asp:Label ID="Label1" runat="server" Text="IsActive"></asp:Label>
        <asp:TextBox ID="txtisactive" runat="server"></asp:TextBox>

        <br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" 
            onclick="btnsubmit_Click" />

    
    
    </div>
    </form>
</body>
</html>
