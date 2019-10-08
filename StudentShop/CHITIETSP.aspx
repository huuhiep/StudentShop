<%@ Page Title="CHITIET" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CHITIETSP.aspx.cs" Inherits="StudentShop.CHITIETSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="bookDetail" runat="server"
ItemType="StudentShop.Models.SANPHAM" SelectMethod ="GetDetails"
RenderOuterTable="false">
<ItemTemplate>
<div>
<h1><%#:Item.TENSP %></h1></div>
<br />
<table>
<tr>
<td>
<img src="/Images/<%#:Item.ANH %>"
style="border:solid; height:225px" alt="<%#:Item.TENSP %>"/>
</td>
<td>&nbsp;</td>
<td style="vertical-align: top; text-align:left;">
<b>Thông Tin:</b><br /><%#:Item.THONGTIN %>
<br />
<span><b>Giá:</b>&nbsp;<%#: String.Format("{0:g} đồng",Item.DONGIA)
%></span>
<br />
<span><b>Số Lượng:</b>&nbsp;<%#:Item.MASP *15%></span>
<br />
</td>
</tr>
</table>
</ItemTemplate>
</asp:FormView>
</asp:Content>
