<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DiscussionForum._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table cellpadding="0px" cellspacing="0px"   style="width:100%;">
<tr> 
        <td> <asp:Button ID ="Button1" Text ="Create" runat="server" 
            onclick="Createbtn_Click" />
   </td>
   <td> <asp:Button ID ="Button2" Text = "Update" runat="server" 
            onclick="Updatebtn_Click" />
   </td>
   <td> <asp:Button ID="Button3" Text="Delete" runat="server" onclick="Deletebtn_Click" />
</td>
    </tr>
    
    </table>
    </form>
</body>
</html>
