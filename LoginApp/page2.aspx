<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page2.aspx.cs" Inherits="Greetings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#E6E6FA"">
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage" Text="WELCOME TO AIRLINES INTERNATIONAL" runat="server"></asp:Label>

    &nbsp;<br />

    <asp:Label ID="Label2" runat="server" Text="Please Select Your Destination: "></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server"> 

        </asp:DropDownList>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Proceed" /> 
    
    </div>
    </form>
</body"#E6E6FA">
</html>
