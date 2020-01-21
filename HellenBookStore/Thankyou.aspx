<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Thankyou.aspx.cs" Inherits="HellenBookStore.Thankyou" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Thank you for your order</h1>
    
     <h2>Customer details </h2>

        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

    <h2>Order details </h2>

        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>

    <h2>Order Items details </h2>

        <asp:GridView ID="GridView3" runat="server">
        </asp:GridView>


    <asp:Button ID="ButtonAnotherOrder" runat="server" Text="Place Another Order" OnClick="ButtonAnotherOrder_Click" />
</asp:Content>
