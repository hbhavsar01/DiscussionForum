<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTopic.aspx.cs" Inherits="DiscussionForum.AddTopic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Add New Topic<br />
    <asp:TextBox ID="txttopic" runat="server"></asp:TextBox>
        <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Topic Description"></asp:Label>
        <br />
        <br />
        &nbsp;
    <asp:TextBox ID="contentTB" Rows="8" TextMode="MultiLine" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnsbmit" Text="Submit" runat="server" onclick="btnsbmit_Click" />
         
    


    </div>
    </form>
</body>
</html>
