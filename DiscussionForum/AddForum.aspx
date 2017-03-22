<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddForum.aspx.cs" Inherits="DiscussionForum.AddForum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID ="txtForumCategory" Text ="Select a  Form Category" runat="server">
    </asp:Label>
    <br />     
    
        
    <asp:DropDownList ID ="DropDownList1"  runat="server" 
            onselectedindexchanged="SelectedIndexChange_forumcategory" AutoPostBack="True" DataTextField="Name"  DataValueField ="CategoryId" />
    <br/>
    <asp:Label ID ="txtForumSubCategory" Text="Select a forum" runat="server"></asp:Label>
    <br />
    <asp:DropDownList ID ="DropDownList2" runat="server"
     onselectedindexchanged="SelectedIndexChange_forum" AutoPostBack="false" DataTextField="Name"  DataValueField ="ForumId" >
      
    </asp:DropDownList>
    <br /><br /><br />
        Add New Topic<br />
    <asp:TextBox ID="txttopic" runat="server" ontextchanged="txttopic_TextChanged"></asp:TextBox>
        <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Topic Description"></asp:Label>
        <br />
        <br />
        &nbsp;
    <asp:TextBox ID="contentTB" Rows="8" TextMode="MultiLine" runat="server"></asp:TextBox>
    <br /> <br /> <br />
    <asp:Button ID="btnsbmit" Text="Submit" runat="server" onclick="btnsbmit_Click" /><br />
    <asp:Label ID="lblcreated" runat="server" ></asp:Label>
    
    
           
   
        <br />
        <br />
    
    
           
   
    </div>
    </form>
</body>
</html>
