<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuBar.ascx.cs" Inherits="DiscussionForum.UserCtrl.MenuBar" %>
<table border="0" cellpadding="2" cellspacing="0" width="100%">
			<tbody><tr> 
				<td class="topnav" align="center">&nbsp;<a href="http://www.warez-bb.org/faq.php?sid=cf28221f6e7c5ceeec4466cf93314ed0">
                FAQ</a>&nbsp; &#8226;&nbsp; <b><a href="http://www.warez-bb.org/search.php?sid=cf28221f6e7c5ceeec4466cf93314ed0">Search</a></b>
				&nbsp;&#8226; &nbsp;<a href="http://www.warez-bb.org/memberlist.php?sid=cf28221f6e7c5ceeec4466cf93314ed0">Memberlist</a>

				&nbsp;&#8226; &nbsp;<a href="http://www.warez-bb.org/groupcp.php?sid=cf28221f6e7c5ceeec4466cf93314ed0">Usergroups</a>
				&nbsp;&#8226; &nbsp;<a href="http://www.warez-bb.org/profile.php?mode=register">Register</a>
				&nbsp;&#8226; &nbsp;<a href="http://www.warez-bb.org/privmsg.php?folder=inbox&amp;sid=cf28221f6e7c5ceeec4466cf93314ed0">
                Log in to check your private messages</a>&nbsp; &#8226; &nbsp;
                <!--<a href="http://www.warez-bb.org/profile.php?mode=editprofile&amp;sid=cf28221f6e7c5ceeec4466cf93314ed0">Profile</a>&nbsp; -->
                <asp:LinkButton ID="lnkprofile" runat="server" Text="Profile" 
                        onclick="lnkprofile_Click"></asp:LinkButton>

				    •
                <asp:Label ID="lbldisplay" runat="server"></asp:Label>	
                <asp:LinkButton ID="lnklogout" runat="server" Text="log out" 
                        onclick="lnklogout_Click"></asp:LinkButton>		</td>

			</tr>
			<tr>
				<td class="topnav" align="center">&nbsp;<b><a href="javascript:bookmarksite('Warez%20Bulletin%20Board%20-%20Warez-BB%20-%20Appz,%20gamez,%20movies,%20eBooks...',%20'http://www.warez-bb.org')">Add to favorites</a></b>&nbsp; &#8226;
				&nbsp;<a href="http://www.warez-bb.org/memberlist.php?auth=gratitude&amp;sid=cf28221f6e7c5ceeec4466cf93314ed0">Gratitude List</a>&nbsp; &#8226;
				&nbsp;<a href="http://www.warez-bb.org/memberlist.php?auth=staff&amp;sid=cf28221f6e7c5ceeec4466cf93314ed0">Staff List</a>&nbsp; &#8226; 
				&nbsp;<b><a href="http://www.warez-shop.org/" target="_blank">Shop</a></b>&nbsp; &#8226;

				&nbsp;<b><a href="http://wad.io/" target="_blank">Radio</a></b>&nbsp; &#8226;
				&nbsp;<b><a href="http://www.warez-bb.org/viewtopic.php?t=4766499" target="_blank">Chat</a></b>&nbsp; &#8226;
				&nbsp;<b><a href="http://readthescene.org/" target="_blank">Mag</a></b>
				</td>
			</tr>
		</tbody></table>
