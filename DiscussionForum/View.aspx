<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="DiscussionForum.View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="forumline" border="0" cellpadding="2" cellspacing="1" width="100%">
    <tr>
   
        <td class="maintitle"><asp:Label ID="TitleLable" runat="server" Text="TitleLebel"></asp:Label></td>
    </tr>
    <tr>
        <td><asp:ImageButton ID="NewTopic" runat="server" ImageUrl="~/Styles/post.gif" 
                onclick="NewTopic_Click" /></td>
       
                       
        </tr>
        
<asp:Repeater ID ="ShowAddTopicByForumName" runat="server">
    <ItemTemplate>
       <tr>
            <table class="forumline" border="0" cellpadding="2" cellspacing="1" width="100%">
           <tr>
                <th colspan="2">Topics </th>
                <th>Replies</th>
                <th>Author</th>
                <th>Last Post</th>
            </tr>
            <tr>
                <td class="row1" height="34"><asp:ImageButton ID ="img" runat="server" ImageUrl="~/Styles/new.gif" /></td>
                <!--
                <td class="row1" width="100%"><asp:Label ID="chk" runat="server" Text='<%#Eval("Title") %>'></asp:Label></td>-->

                 <td class="row1" width="100%"><a href="viewtopic.aspx?topicTitle=<%#Eval("Title") %> "> <%#Eval("Title") %></a>
                 
                 
                         
                 <td class="row2" align="center"><%#Eval("NumberOfPosts")%></td>
                <td class="row3" align="center" nowrap="nowrap"><%#Eval("Author") %></td>
                <td class="row2" align="center">Last Post</td>
            </tr>
            
            </table>
        
        </tr>
    </ItemTemplate>
</asp:Repeater>


</table>
</asp:Content>
