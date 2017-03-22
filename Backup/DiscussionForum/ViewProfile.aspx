<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="DiscussionForum.ViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%" border="0" cellspacing="0" cellpadding="10">
    <tr>
	<td class="maintitle">Viewing profile :: </td>
</tr>
<tr>
<td class="nav"><a href="Home.aspx"></a> &raquo; Viewing profile :: </td>
</tr>

</table>


<table class="forumline" border="0" cellpadding="2" cellspacing="1" width="100%">
           
	<tr>
        <th>First Name</th>
		
		<th>Last Name</th>
		<th>Date Joined</th>
		<th>Email</th>
       </tr>
 

<tr>
    <asp:Repeater ID="showprofile" runat="server">
        <ItemTemplate>
            <tr>
                <table class="forumline" border="0" cellpadding="2" cellspacing="1" width="100%">
        
                    <tr >
                        <td class="row2"  align="center" ><%#Eval("FirstName") %></td>
                        <td class="row2" align="center"> <%#Eval("LastName") %></td>                       
                        <td class="row2" align="center"><%#Eval("DateJoin") %></td>
                         <td class="row2" align="center"><%#Eval("email") %></td>
                         
                    </tr>
                </table>
            </tr>
        </ItemTemplate>
    
    </asp:Repeater>          
</tr>
</table>
</asp:Content>
