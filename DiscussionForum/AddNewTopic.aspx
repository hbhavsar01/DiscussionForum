<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddNewTopic.aspx.cs" Inherits="DiscussionForum.AddNewTopic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" cellpadding="2" cellspacing="2" width="100%">
    <tbody><tr>
	    <td class="maintitle"><asp:Label ID= "lblforum" Text="Post a new topic" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td class="nav">Post a new topic</td>
    </tr>
</tbody></table>


<table class="forumline" border="0" cellpadding="3" cellspacing="1" width="100%">
     <tbody><tr>
            <th colspan="2">Post a new topic</th>
        </tr>
     <tr>
            <td class="row1" align="right" width="22%"><span class="explaintitle">Subject:</span></td>
            <td class="row2" width="78%"><asp:TextBox ID="txtSub" runat="server" size="45" maxlength="60" style="width: 480px;"></asp:TextBox>
            </td>
     </tr>

     <tr id="subject_error_tbl" style="">
        <td class="row1" align="right" width="22%"><span class="explaintitle"></span></td>
        <td class="row2"><span class="explaintitle">You must specify a subject when posting a new topic.</span></td>
    </tr>

     <tr>
           <td align="right"><span class="explaintitle">Message body:</span></td>         
           <td colspan="10">
           <asp:TextBox ID="txtDescription" runat="server" Height="317px" Width="629px"></asp:TextBox>                
        </td>
     </tr>
     
    <tr>
        <td class="cat" colspan="2" align="center" height="28"><asp:Button ID="btnsubmit" 
                runat="server" Text="Submit" onclick="btnsubmit_Click" /></td>
    
    </tr>

</tbody></table>

</asp:Content>
