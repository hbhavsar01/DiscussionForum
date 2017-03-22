<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteRecord.aspx.cs" Inherits="DiscussionForum.DeleteRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="delgrid" runat="server" AutoGenerateColumns="False" Width="40%">
    <Columns>
        <asp:TemplateField HeaderText ="Delete">
            <ItemTemplate>
                <asp:CheckBox ID ="CheckBox1" runat="server" />
            </ItemTemplate>        

        </asp:TemplateField>
      
            <asp:BoundField DataField="ID" HeaderText=" ID">
          </asp:BoundField>

            <asp:BoundField DataField="Name" HeaderText=" Name">
           </asp:BoundField>
    

          <asp:BoundField DataField="IsActive" HeaderText="IsActive">
             </asp:BoundField>
    
    </Columns>
    
    
    
    </asp:GridView>
    <br />
<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete"  />
    

  
    
    </div>
    </form>
</body>
</html>
