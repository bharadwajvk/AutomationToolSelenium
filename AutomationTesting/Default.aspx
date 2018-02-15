<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AutomationTesting.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Vendo Automation Tool</h1>
        <p>Please enter below details for Automation Testing of the website.</p>
        <br />
        <br />
        <br />
        <label>Website URL: </label> <asp:TextBox runat="server" ID="webSiteUrl"></asp:TextBox><br /><br />
        <label>Include Fulfillment Testing ? </label> 
        <asp:RadioButtonList id="fulfillmentTesting" runat="server">
         <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
         <asp:ListItem Text="No" Value="0"></asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <label>Include Payment Gateway Testing ? </label> 
        <asp:RadioButtonList id="paymentTesting" runat="server">
         <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
         <asp:ListItem Text="No" Value="0"></asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <label>Want to provide a credit card number ? (If nothing is provide test run with test cards)</label>
        <asp:TextBox runat="server" ID="creditCardTesting"></asp:TextBox>
        <br />
        <br />
        <asp:Button text="Run Test" runat="server" ID="runTest" OnClick="runTest_Click"/>
    <div>
        <br /><br />
    <label>Please find below the results of the Automation Tests run for given details.</label>
        <br />
        <asp:GridView ID="resultGrid" runat="server">
            
        </asp:GridView>
    </div>
    </form>
</body>
</html>
