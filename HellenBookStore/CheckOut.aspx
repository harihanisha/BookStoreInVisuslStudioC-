<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="HellenBookStore.CheckOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
    
    
    
    <asp:Table ID="Table1" runat="server" Height="305px" Width="739px">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label5" runat="server" Text="Phone Number"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label6" runat="server" Text="Email Address"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxEmailAddress" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label7" runat="server" Text="Credit Card Number"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxCreditCardNumber" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label8" runat="server" Text="Shipping Address"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxShippingAddress" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label9" runat="server" Text="SubTotal"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxSubTotal" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label10" runat="server" Text="Tax"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxTax" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server"> <asp:Label ID="Label11" runat="server" Text="Total"></asp:Label></asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox ID="TextBoxTotal" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="ButtonShipOrder" runat="server" Text="Ship Order" OnClick="ButtonShipOrder_Click" />
</asp:Content>
