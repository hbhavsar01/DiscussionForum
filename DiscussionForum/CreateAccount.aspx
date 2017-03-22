<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="DiscussionForum.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/fishbane.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
        <tr>
	        <td class="maintitle">Profile Information</td>
        </tr>
        <tr>
            <td class="nav">Profile Information</td>
        </tr>
    </table>

<table border="0" cellpadding="3" cellspacing="1" width="100%" class="forumline">
    <tr>
        <th colspan="2">Registration Information</th>
     </tr>
     <tr>
        <td height="22" colspan="2" class="row2"><span class="gensmall">Items marked with a * are required unless stated otherwise.</span></td>
      </tr>


      <tr>
        <td><asp:Label ID="msg" runat="server" Visible="False"></asp:Label></td>
      </tr>
    
    <tr>
        <td class="row1" width="38%"><span class="explaintitle">Username:</span> *</td>
        <td class="row2" width="42%">
                <asp:TextBox ID ="txtUsername" runat="server"></asp:TextBox></td>
         <td><asp:RequiredFieldValidator id="UserNameRequiredFieldValidator" runat="server"
                                      ControlToValidate="txtUsername" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" />
         </td>
       

        
           
    </tr>
    <tr>
        <td class="row1" width="38%"><span class="explaintitle"> Password:</span> *</td>
            <td class="row2" width="62%">          
                 <asp:TextBox ID ="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="PasswordRequiredValidator" runat="server"
                                      ControlToValidate="txtPassword" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" />
              </td>
   
    </tr>
    <tr>
        <td class="row1" width="38%"><span class="explaintitle"> Conform Password:</span> *</td>
            <td class="row2" width="22%"><asp:TextBox ID="PasswordConfirmTextbox" runat="server" TextMode="Password"></asp:TextBox></td>
             <td ><asp:RequiredFieldValidator id="PasswordConfirmRequiredValidator" runat="server"
                                      ControlToValidate="PasswordConfirmTextbox" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" />
          <asp:CompareValidator id="PasswordConfirmCompareValidator" runat="server"
                                      ControlToValidate="PasswordConfirmTextbox" ForeColor="red"
                                      Display="Static" ControlToCompare="txtPassword"
                                      ErrorMessage="Confirm password must match password." />
        </td>
    </tr>
    <tr>
        <td class="row1" width="38%"><span class="explaintitle">First Name :</span> *</td>
            <td class="row2" width="62%"><asp:TextBox ID ="txtFName" runat="server"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="FNameRequiredValidator" runat="server"
                                      ControlToValidate="txtFName" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
    
    </tr>
    <tr>
         <td class="row1" width="38%"><span class="explaintitle">Last Name:</span> *</td>
            <td class="row2" width="62%"><asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="LNameRequiredFieldValidator" runat="server"
                                      ControlToValidate="txtLName" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
    
    
    </tr>
    <tr>
         <td class="row1" width="38%"><span class="explaintitle">Date of Birth:</span> *</td>
            <td class="row2" width="62%"><asp:TextBox ID="txtDOB" runat="server"></asp:TextBox></td>
         
    </tr>
    <tr>
            <td ><asp:Calendar ID="txtCalender" runat="server" 
                    onselectionchanged="txtCalender_SelectionChanged" ></asp:Calendar></td>
            
          
    </tr>
    <tr>
        <td class="row1" width="38%"><span class="explaintitle">Email:</span> *</td>
            <td class="row2" width="62%"><asp:TextBox ID ="txtEmail" runat="server"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator id="EmailRequiredValidator" runat="server"
                                      ControlToValidate="txtEmail" ForeColor="red"
                                      Display="Static" ErrorMessage="Required" /></td>
    
    </tr>
    <tr>
        <td class="cat" colspan="2" align="center"><asp:Button ID="btnSubmit" 
                runat="server" Text="Submit" onclick="btnSubmit_Click1" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" />
        </td>
</tr>
</table>
 
</asp:Content>
