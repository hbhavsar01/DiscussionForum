<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="DiscussionForum.UserCtrl.View" %>
<table width = "100%">
    <tr>
        <td>
            <asp:ImageButton ID ="ShowImage" runat="server" ImageUrl="~/Styles/post.gif" />
        </td>
    </tr>  

    <asp:Repeater ID="topics" runat="server">
        <ItemTemplate>
        <table width = "100%">
            <tr>
                <th colspan = "2">Topics</th>
                <th>Replies</th>
                <th>Authors</th>
                <th>Last Post</th>
            </tr>
            <tr>
                 <td>
                      <img src ="../Styles/new.gif" height="25" width="25" title ="New post" alt ="New Post" />
                 </td>
                 <td>
                      <asp:LinkButton ID ="selecttopic" runat="server" Text='<%#Eval(TopicTitle)%>'></asp:LinkButton>
                 </td>
            </tr>


           
        </table>
         </ItemTemplate>
    
    </asp:Repeater>


</table>
