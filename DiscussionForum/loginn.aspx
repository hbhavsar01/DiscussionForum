<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="loginn.aspx.cs" Inherits="DiscussionForum.loginn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table width="100%" cellspacing="2" cellpadding="2" border="0">
    <tr>
	    <td class="maintitle">Log in</td>
    </tr>
    <tr>
        <td class="nav">Log in</td>
    </tr>
</table>

<table width="100%" cellpadding="4" cellspacing="1" border="0" class="forumline" align="center">
	<tr>
		<th colspan="2" align="center">Log in</th>
	</tr>

	<tr>
		<td class="row3" colspan="2" align="center">
			<span class="gensmall">
						Please enter your username and password to log in.			</span>
		</td>

	</tr>
    <tr>
		<td width="50%" class="row1" align="center">

			<span class="gensmall">
						In order to login you must be registered.<br />Registering takes only a few seconds but gives you increased<br />capabilities.
                         The board administrator may also grant additional<br />permissions to registered users. Before you login please ensure you
                         <br />are familiar with our terms of use and related policies. Please<br />ensure you read any forum rules as you navigate around the board.									</span>
			<br /><br />
			<span class="genmed">
			

			</span>
		</td>
		<td width="50%" class="row2">
			<table border="0" cellpadding="3" cellspacing="1" width="100%">
				<tr>
					<td><b class="gensmall">Username:</b></td>
					 <td width="100%"><asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
						<br />
                        <a class="gensmall" href="CreateAccount.aspx">Create an Account</a>
					</td>
				</tr>
				<tr>
					<td><b class="gensmall">Password:</b></td>
					<td width="100%"><asp:TextBox ID="txtpasswd" runat="server" TextMode = "Password"></asp:TextBox>
						<br />
						<a class="gensmall" >I forgot my password</a> |
                         <a class="gensmall">I forgot my username</a>

					</td>
				</tr>
								<tr>
					<td><span class="gensmall"><b>Options:</b></span></td>
					<td width="100%"><span class="gensmall"><input type="checkbox" checked="checked" name="autologin" tabindex="3" />Log me on automatically each visit<br /><input type="checkbox" name="hideonline" tabindex="4" />Hide my online status this session</span></td>
				</tr>
							</table>

		</td>
	</tr>
	<tr>
		<td class="cat" colspan="2" align="center"><asp:Button ID="btnlogin" runat="server" 
                Text="Log in" onclick="btnlogin_Click" />
        </td>
	</tr>
    </table>

</asp:Content>
