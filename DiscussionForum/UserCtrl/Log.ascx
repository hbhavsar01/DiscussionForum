<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Log.ascx.cs" Inherits="DiscussionForum.UserCtrl.Log" %>
<table class="forumline" width="100%" border="0" cellpadding="3" cellspacing="1">
	<tbody><tr>
		<td class="cat">Log in</td>
	</tr>
	<tr>
		<td class="row1" align="center">
		<table border="0" cellpadding="2" cellspacing="0">
		<tbody><tr> 
			<td class="gensmall">Username:&nbsp;</td>
			<td><input class="post" name="username" size="10" type="text"></td>
			<td class="gensmall">&nbsp;&nbsp;&nbsp;Password:</td>
			<td><input class="post" name="password" size="10" maxlength="32" type="password"></td>
			<td class="gensmall">&nbsp;&nbsp;&nbsp;Log me on automatically each visit</td>
			<td><input class="text" name="autologin" checked="checked" type="checkbox"></td>
			<td>&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" CssClass="mainoption" Text="Login" />
            </td>
		</tr>
		</tbody></table>
		</td>
	</tr>
</tbody></table>