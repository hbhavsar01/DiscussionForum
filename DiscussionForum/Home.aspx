<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DiscussionForum.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 915px;
        }
        .style3
        {
            width: 93px;
        }
        .style4
        {
            width: 71px;
        }
    </style>

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <table class="forumline" border="0" cellpadding="2" cellspacing="1" width="100%">
           
	<tr>
        <th class="style1">Forum</th>
		
		<th class="style3">Topics</th>
		<th class="style4">Posts</th>
		<th>Last Post</th>
       </tr>
   
   
    <asp:Repeater ID ="ParentRepeater" runat="server" 
        onitemdatabound="ParentRepeater_ItemDataBound" >
         
        <ItemTemplate>
            
          <!--  <tr style="display: none;" id="cat_id_2_c">-->
          <tr>
            <table>
                <tr>
                                         
                    <td class="cat" colspan="3"><span style="float: right;width: auto !important;">
                        <asp:Label ID="FCName" runat="server" text='<%#Eval("ForumCatName") %>'></asp:Label></td>
                </tr>
            </table></tr>   
            
            <asp:Repeater ID="ChildRepeater"   runat="server"  >
                <ItemTemplate>
                    <tr>
                    <table>
                       
                        <tr style="" id="cat_id_3_f[1]">
                            <td class="row1" height="45"><img src="Styles/new.gif" class="imgfolder" alt="New posts" title="New posts" height="25" width="25" /></td>                          
                            <td class="row1" width="100%">
                          
                          <!--  <asp:LinkButton ID="FName" runat="server" CommandName="select" Text='<%#Eval("ForumName") %>'></asp:LinkButton></td>  -->   
                                                  
                          <a href="View.aspx?ForumName=<%#Eval("ForumName") %> "> <%#Eval("ForumName") %></a>                      
                          
                           <td class="row2" align="center">
                             <%#Eval("NumberOfTopics") %></td>

                            <td class="row2" align="center">
                           
                            <%#Eval("NumberOfPosts") %></td>

                            <td class="row3" align="center" nowrap="nowrap">
                           
                            Last Post</td>
                        </tr>
                        
                     </table></tr>
                </ItemTemplate>
            </asp:Repeater>    
        </ItemTemplate>
       
    </asp:Repeater>

</table>
</asp:Content>
