<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="viewtopic.aspx.cs" Inherits="DiscussionForum.viewtopic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%" cellspacing="2" cellpadding="2" border="0">
<tr> 
    <td nowrap="nowrap"><img src="Styles/post.gif"  width="82" height="25" alt="Post new topic" title="Post new topic"/>
               <img src="Styles/reply.gif"  width="82" height="25" alt="Post new topic" title="Post new topic"/>

   </td>
</tr>
</table>
  <table class="forumline" width="100%" cellspacing="1" cellpadding="3" border="0">
        <tr>
            <th width="86%">Message</th>
        </tr>  
           
        <tr>      
             <asp:Repeater ID="GetDescriptionRepeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <table>
                            <tr>
                                <td valign="top" class="postbody">
                                <%#Eval("Description")%>
                                </td>
                            </tr>
                        
                        </table>                        
                    </tr>
                
                </ItemTemplate>          
             </asp:Repeater>
            </tr><br /><br /><br />
             <!-- -->
             <tr>
                                 <td valign="bottom" nowrap="nowrap" class="row2">
                      <img src="Styles/icon_profile.gif"  width="59" height="18" class="imgtopic" alt="View user's profile" title="View user's profile" border="0"  />
                      <img src="Styles/icon_pm.gif" width="59" height="18" class="imgtopic" alt="Send private message" title="Send private message" border="0" />
                      </td>

             </tr>
             
          <tr>
          <asp:Repeater ID="ShowPosts" runat="server">
            <ItemTemplate>
                <tr>
                    <table>
                        <tr>
                            <td valign="top" class="postbody"><%#Eval("Postcontent")%>                  
                            </td>
                        </tr>
                    </table>
                </tr>
            </ItemTemplate>
        
        </asp:Repeater>
        </tr>

        
        
        <tr>            
            <th class="row1" align="left"><b>Quick Reply</b></th>
         </tr>
        </table>
        
      
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td class='row1' valign='top'>      
                   <!-- <textarea name='message' rows="5" id="message" cols="100%" style="width:100%;height:80px"></textarea><br />-->

                    <asp:TextBox ID="txtReply" Rows="5" TextMode="MultiLine" runat="server" Width="100%"></asp:TextBox>


                     
                     </td></tr>
            <tr>

             <td class="cat" colspan="2" align="center" height="28"><asp:Button ID="Submitbtn" 
                runat="server" Text="Submit" onclick="btnsubmit_Click" /></td></tr>
       
        </table>
        </asp:Content>
