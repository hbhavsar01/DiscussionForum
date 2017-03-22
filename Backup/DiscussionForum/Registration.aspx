<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="DiscussionForum.Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Please Fill the following Information</td>
        
        </tr>
        <tr>
        <td colspan="3"><asp:Label ID="msg" runat="server" ></asp:Label></td>
        </tr>
      
        <tr>
             <td>User Name</td>
             <td><asp:TextBox ID ="txtUsername" runat="server"></asp:TextBox></td>
               <td><asp:RequiredFieldValidator id="UserNameRequiredFieldValidator" runat="server"
                                      ControlToValidate="txtUsername" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
   
             


        </tr>
        <tr>
            <td> Password</td>
            <td><asp:TextBox ID ="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator id="PasswordRequiredValidator" runat="server"
                                      ControlToValidate="txtPassword" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
   
            
        </tr>
        <tr>
            <td>Conform Password</td>
            <td><asp:TextBox ID="PasswordConfirmTextbox" runat="server" TextMode="Password"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="PasswordConfirmRequiredValidator" runat="server"
                                      ControlToValidate="PasswordConfirmTextbox" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" />
          <asp:CompareValidator id="PasswordConfirmCompareValidator" runat="server"
                                      ControlToValidate="PasswordConfirmTextbox" ForeColor="red"
                                      Display="Static" ControlToCompare="txtPassword"
                                      ErrorMessage="Confirm password must match password." /></td>
  
        </tr>
        <tr>
            <td>First Name</td>
            <td><asp:TextBox ID ="txtFName" runat="server"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="FNameRequiredValidator" runat="server"
                                      ControlToValidate="txtFName" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
    
           
            
        </tr>
        <tr>
            <td>Last Name</td>
            <td><asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="LNameRequiredFieldValidator" runat="server"
                                      ControlToValidate="txtLName" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
    
        
        </tr>
        <tr>
            <td>Date of Birth</td>
            <td><asp:TextBox ID="txtDOB" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
            <td><asp:Calendar ID="txtCalender" runat="server" 
                    onselectionchanged="txtCalender_SelectionChanged"></asp:Calendar></td>
            
          
        </tr>
        
       
        <tr>
            <td> Date Join</td>
            <td><asp:TextBox ID="txtDatejoin" runat="server"></asp:TextBox></td>
              <td><asp:RequiredFieldValidator id="DateJoinRequiredFieldValidator" runat="server"
                                      ControlToValidate="txtDatejoin" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
    
            
            
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID ="txtEmail" runat="server"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="EmailRequiredValidator" runat="server"
                                      ControlToValidate="txtEmail" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
    
        </tr>
        <tr>
            <td>
                <asp:Button ID ="SubmitBtn" Text="Submit" runat="server" 
                    onclick="SubmitBtn_Click" />
                <asp:Button ID="ResetBtn" runat="server" onclick="Button1_Click" Text="Reset" />
            </td>
         </tr>
    
    
    </table>

    
    </div>
    </form>
</body>
</html>
