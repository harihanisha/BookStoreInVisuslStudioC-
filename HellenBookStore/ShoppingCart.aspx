<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="HellenBookStore.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Shopping Cart</h2>
     <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
    <asp:Button ID="ButtonShopping" runat="server" OnClick="Button1_Click" Text="BackToShopping" />
    <table width="100%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="#EAEAEA" >
        <tr align="left" style="background-color:#004080;color:White;" >
            <td> ISBN </td>                        
            <td> Title </td>            
            <td> Price </td> 
            <td> Qty </td>
            <td> Total </td>
            <td> Image </td>
            <td> Action </td>
        </tr>
        <%=getShoppingCart()%>
    </table>
   
    <asp:Button ID="ButtonCheckOut" runat="server" Text="Check Out" OnClick="ButtonCheckOut_Click" />
   
</asp:Content>
