<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HellenBookStore.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelShoppingCart" runat="server" Text=""></asp:Label>
    
    
    <asp:Button ID="ButtonViewShoppingCart" runat="server" Height="16px" OnClick="ButtonViewShoppingCart_Click" Text="Veiw Shopping Cart" />
    
    <table width="100%" align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="#EAEAEA" >
        <tr align="left" style="background-color:#004080;color:White;" >
            <td> ISBN </td>                        
            <td> Title </td>            
            <td> Author </td> 
            <td> Price </td>
            <td> Image </td>
            <td> Action </td>
        </tr>
        <%=getBookInfo()%>
    </table>
    
</asp:Content>
