<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kassakvitto.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kassakvitto</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kassakvitto</h1>
        <asp:TextBox ID="Input" runat="server"></asp:TextBox>
        <p></p>
        <asp:Button ID="Send" runat="server" Text="Beräkna rabatt" OnClick="Send_Click" />
        <asp:RequiredFieldValidator ID="NotEmpty" runat="server" ErrorMessage="Fältet kan inte lämnas tomt" ControlToValidate="Input" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CheckValue" runat="server" ErrorMessage="Ange ett positivt tal" ControlToValidate="Input" Type="Double" Operator="GreaterThan" ValueToCompare="0" Display="Dynamic"></asp:CompareValidator>
         </div>
    </form>
</body>
</html>
