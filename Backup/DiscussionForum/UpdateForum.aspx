﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateForum.aspx.cs" Inherits="DiscussionForum.UpdateForum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AutoGenerateDeleteButton="True" AutoGenerateEditButton="True"        
            AllowPaging="True" AllowSorting="True"
            OnRowCancelingEdit="GridView1_RowCancelingEdit"
            OnRowEditing="GridView1_RowEditing"
            OnRowUpdating="GridView1_UpdateRecord" DataKeyNames="ID" >
                                           
           
           
           
           

    <Columns>
    <asp:TemplateField HeaderText ="ID" >   
        <ItemTemplate > <%#Eval("ID") %></ItemTemplate>
    </asp:TemplateField>

    <asp:TemplateField HeaderText="Name" >
	    <ItemTemplate > <%#Eval("Name") %></ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
            <EditItemTemplate>
               <asp:TextBox ID="txtname" runat="server"
                    Text='<%# Eval("Name") %>'></asp:TextBox>
             </EditItemTemplate>
     </asp:TemplateField>

      
    
        
    </Columns>
</asp:GridView> 
  </div> 
  
    </form>
</body>
</html>
