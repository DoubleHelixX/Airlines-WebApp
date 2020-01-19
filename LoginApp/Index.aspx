<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#E6E6FA">
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage" Text="WELCOME TO AIRLINES INTERNATIONAL" runat="server"></asp:Label>

    &nbsp;<br />

    <asp:Label ID="Label1" runat="server" Text="Please select where you are boarding from: "></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>New York</asp:ListItem>
            <asp:ListItem>California</asp:ListItem>
            <asp:ListItem>Texas</asp:ListItem>
            <asp:ListItem>Russia</asp:ListItem>
            <asp:ListItem>China</asp:ListItem>
        </asp:DropDownList>
        <br />
        
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Proceed" />
        
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
