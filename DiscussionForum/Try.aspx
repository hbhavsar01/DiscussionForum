﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Try.aspx.cs" Inherits="DiscussionForum.Try" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateDeleteButton="true" AutoGenerateColumns="false"
            AutoGenerateEditButton="True" 
            onrowediting="GridView1_RowEditing" 
              onrowcancelingedit="GridView1_RowCancelingEdit"
              onpageindexchanging="GridView1_PageIndexChanging"
               onrowdeleting="GridView1_RowDeleting" onrowupdating="GridView1_RowUpdating"


 
           >         
            
             
                 <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="IsActive" HeaderText="IsActive" />
            
          </Columns>
        </asp:GridView>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>

    </div>
    </form>
</body>
</html>
