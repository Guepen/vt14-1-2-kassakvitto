<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kassakvitto.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kassakvitto</title>
    <link href="Content/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kassakvitto</h1>
        <p>Total köpesumma:</p>
        <p><asp:TextBox ID="Input" runat="server"></asp:TextBox>kr 
            <asp:RequiredFieldValidator CssClass="Fel" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet kan inte lämnas tomt" ControlToValidate="Input" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:CompareValidator CssClass="Fel" ID="ValueCheck" runat="server" ErrorMessage="Ange en total köpesumma som är större än 0" Display="Dynamic" Operator="GreaterThan" Type="Double" ControlToValidate="Input" ></asp:CompareValidator>

        </p>
         
       
        <div>
        <asp:Button ID="Send" runat="server" Text="Beräkna rabatt" OnClick="Send_Click" />
            </div>
         </div>

        <div>
            <asp:Panel CssClass="Panel" ID="Output" runat="server" Visible="false">
                <h1>Kullaffären</h1>
                <p>Öppettider 23-00</p>
                <div>
                    <p>Totalt: <asp:Label ID="Total" runat="server" Text="" ></asp:Label></p>
        </div>

        <div>
            <p>Rabattsats: <asp:Label ID="DiscountRate" runat="server" Text=""></asp:Label> </p>
        </div>
        <div>   
            <p>Rabatt: <asp:Label ID="Discount" runat="server" Text=""></asp:Label></p>     
               
        </div>

                <div>
                    <p>Att betala:<asp:Label ID="PayValue" runat="server" Text=""></asp:Label> </p>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
