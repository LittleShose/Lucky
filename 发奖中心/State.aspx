<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="State.aspx.cs" Inherits="发奖中心.State" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>跳转</title>
    <asp:Literal ID="litScript" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
    操作成功
    <br />
    还有&nbsp;<span id="Times" class="ColorA"></span>&nbsp;秒将跳转到指定页面，如页面没有自动跳转，请选择“<asp:HyperLink
        ID="hlReturnPage" runat="server" Text="手动跳转"></asp:HyperLink>”
    </form>
</body>
</html>
