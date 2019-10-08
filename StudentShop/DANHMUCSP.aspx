<%@ Page Title="Danh Mục" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DANHMUCSP.aspx.cs" Inherits="StudentShop.DANHMUCSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
    <div>
<hgroup>
<h2><%: Page.Title %></h2>
</hgroup>
<asp:ListView ID="bookList" runat="server" DataKeyNames="MASP"
GroupItemCount="4"
ItemType="StudentShop.Models.SANPHAM" SelectMethod="GetSANPHAMs">
<EmptyDataTemplate>
<table >
<tr>
<td>No data was returned.</td>
</tr>
</table>
</EmptyDataTemplate>
<EmptyItemTemplate>
<td/>
</EmptyItemTemplate>
<GroupTemplate>
<tr id="itemPlaceholderContainer" runat="server">
<td id="itemPlaceholder" runat="server"></td>
</tr>
</GroupTemplate>
<ItemTemplate>
<td runat="server">
<table>
<tr>
<td>
<a href="CHITIETSP.aspx?bookID=<%#:Item.MASP%>">
<img src ="/Images/<%#:Item.ANH%>"
width="150" height="225" style="border:solid" /></a>
</td>
</tr>
<tr>
<td>
<a href="CHITIETSP.aspx?bookID=<%#:Item.MASP%>">
<span>
<%#:Item.TENSP%>
</span>
</a>
<br />
<span>
<b>Giá: </b><%#:String.Format("{0:g} đồng",Item.DONGIA)%>
</span>
    <br />
    <a href="AddToCart.aspx?bookID=<%#:Item.MASP%>">
<span>
    <b> + Thêm vào giỏ hàng<b>
</span>
</a>
</td>
</tr>
<tr>
<td>&nbsp;</td>
</tr>
</table>
</p>
</td>
</ItemTemplate>
<LayoutTemplate>
<table style="width:100%;">
<tbody>
<tr>
<td>
<table id="groupPlaceholderContainer" runat="server"
style="width:100%">
<tr id="groupPlaceholder"></tr>
</table>
</td>
</tr>
<tr>
<td></td>
</tr>
<tr></tr>
</tbody>
</table>
</LayoutTemplate>
</asp:ListView>
</div>
</section>
</asp:Content>
