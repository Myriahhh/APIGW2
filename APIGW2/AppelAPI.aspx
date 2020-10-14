<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppelAPI.aspx.cs" Inherits="APIGW2.AppelAPI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
<div class="section z-depth-2 blue-grey lighten-5">
    <asp:Repeater ID="rptResults1" runat="server">
        <HeaderTemplate><table style="width: 25%" align="center"></HeaderTemplate>
        <ItemTemplate>
        <tr>
            <td><strong>Question <%# Container.ItemIndex + 1 %>:</strong></td>
            <td><%# Container.DataItem %></td>
        </tr>
        </ItemTemplate>
        <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
</div>
</div>
    </form>
</body>
</html>
