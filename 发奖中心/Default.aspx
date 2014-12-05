<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="发奖中心.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>发奖中心-锐捷网络</title>
    <style type="text/css">
<!--
div,form,ul,ol,li,span,p,img{margin:0;padding:0;border:0;}
h1,h2,h3,h4,h5,h6,h7{margin:0;padding:0;}
html,body{font-size:12px;font-weight: normal;color:#000000;text-decoration:none;font-family:Arial, '宋体';margin:0; padding:0px;background:#571b00 url(img/bj.jpg) repeat-x left top;}
html{SCROLLBAR-FACE-COLOR: #e8e7e7;SCROLLBAR-FACE-COLOR: #eaeaea;SCROLLBAR-HIGHLIGHT-COLOR: #ffffff;SCROLLBAR-SHADOW-COLOR: #999999;SCROLLBAR-3DLIGHT-COLOR: #999999;SCROLLBAR-ARROW-COLOR: #999999;SCROLLBAR-DARKSHADOW-COLOR: #ffffff;}
.zhu{ width:968px; height:100%; overflow:hidden; margin:0px auto auto auto; background:url(img/bj_3.jpg) repeat-y 3px top;}
.zhu .top{ width:968px; height:138px;overflow:hidden; margin:0px auto auto auto; clear:both;}
.zhu .top img{float:left}
.zhu .daohang{ width:968px; height:100%; overflow:hidden; background:url(img/bj_1.jpg) no-repeat left top;clear:both;}
.zhu .wbk{ height:21px; line-height:21px; border:1px #cb9c96 solid; background:#ffffff url(img/bj_2.jpg) repeat-x left top; padding-left:5px; color:#61322d;}
.a1{line-height:21px;color:#61322d;}
.zhu .an_cx{ width:66px; height:40px; overflow:hidden; border:0px; margin:0px; padding:0px; background:url(img/an_1.jpg) no-repeat left top; cursor:pointer;}
.zhu .an_cx_1{ width:66px; height:40px; overflow:hidden; border:0px; margin:0px; padding:0px; background:url(img/an_2.jpg) no-repeat left top;cursor:pointer;}
.zhu .s1{ width:968px; height:16px; overflow:hidden; margin:0px; padding:0px; clear:both; background:url(img/04.jpg) no-repeat left top;}
.bt{}
.bt table{height:33px;overflow:hidden; background:url(img/bj_4.jpg) repeat-x left top; font-weight:bold; color:#FFF; text-indent:5px;}
.table3{color:#343434;}
.table3 table{border-collapse:collapse; margin:0px auto auto auto; border:1px #dedcdf solid; background:url(img/01.gif) left top;}
.table3 td{text-indent:5px; height:29px;height:28px\9;*height:28px;_height:28px;border-bottom:1px #dedcdf solid;}
.an_1{ width:70px; height:23px; overflow:hidden; line-height:23px; color:#000; font-size:12px; text-align:center; border:0px; margin:0px; padding:0px; background:url(img/02.gif) no-repeat left top; cursor:pointer;}
.an_1s{ width:70px; height:23px; overflow:hidden; line-height:23px; color:#000; font-size:12px; text-align:center; border:0px; margin:0px; padding:0px; background:url(img/03.gif) no-repeat left top; cursor:pointer;}
.hr28{ height:28px; overflow:hidden; margin:0px; padding:0px; clear:both;}
.hr35{height:35px; overflow:hidden; margin:0px; padding:0px; clear:both;}
.a1{ color:#dc0100;}

-->
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="zhu">
        <div class="top">
            <img src="img/01.jpg" width="337" height="138" /><img src="img/02.jpg" width="336"
                height="138" /><img src="img/03.jpg" width="295" height="138" /></div>
        <div class="daohang">
            <table width="900" border="0" cellspacing="0" cellpadding="0" height="41" style="margin: 8px auto auto auto;">
                <tr>
                    <td width="55">
                        &nbsp;
                    </td>
                    <td align="right">
                        姓名：
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txt姓名" runat="server" Width="60px" CssClass="wbk"></asp:TextBox>
                    </td>
                    <td align="right">
                        部门：
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txt部门" runat="server" Width="60px" CssClass="wbk"></asp:TextBox>
                    </td>
                    <td align="right">
                        工号：
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txt工号" runat="server" Width="60px" CssClass="wbk"></asp:TextBox>
                    </td>
                    <td align="right">
                        奖品类型：
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="drop奖品类型" CssClass="a1" AutoPostBack="true" runat="server"
                            OnSelectedIndexChanged="drop奖品类型_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td align="right">
                        奖品：
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="drop奖品" runat="server" CssClass="a1">
                        </asp:DropDownList>
                    </td>
                    <td width="81" align="center" valign="top">
                        <asp:Button ID="btnSearch" CssClass="an_cx" runat="server" OnClick="btnSearch_Click" />
                    </td>
                </tr>
            </table>
            <div class="hr28">
            </div>
            <!--表格标题浮动开始-->
            <div class="bt">
                <table width="886" border="0" cellspacing="0" cellpadding="0" style="margin: 0px auto auto auto;">
                    <tr>
                        <td width="107" height="28">
                            姓名
                        </td>
                        <td width="195">
                            部门
                        </td>
                        <td width="75">
                            工号
                        </td>
                        <td width="152">
                            奖品类型
                        </td>
                        <td width="236">
                            奖品
                        </td>
                        <td width="121">
                            申领情况
                        </td>
                    </tr>
                </table>
            </div>
            <!--表格标题浮动结束-->
            <!--表格开始-->
            <div class="table3">
                <table width="886" border="0" cellspacing="0" cellpadding="0" style="margin: 0px auto auto auto;">
                    <asp:Repeater ID="rptDatalist" runat="server" OnItemCommand="rptDatalist_ItemCommand"
                        OnItemDataBound="rptDatalist_ItemDataBound">
                        <ItemTemplate>
                            <tr>
                                <td width="107">
                                    <%# Eval("姓名") %>
                                </td>
                                <td width="195">
                                    <%# Eval("部门") %>
                                </td>
                                <td width="75">
                                    <%# Eval("工号") %>
                                </td>
                                <td width="152">
                                    <%# Eval("类型名称")%>
                                </td>
                                <td width="236">
                                    <%# Eval("奖品名称")%>
                                </td>
                                <td width="121">
                                    <asp:Label ID="lblL" class="a1" runat="server">已领取</asp:Label>
                                    <asp:Button ID="btnL" CommandName="LQ" CommandArgument='<%# Eval("ID") %>' runat="server"
                                        Text="领取" CssClass="an_1" OnClientClick="return confirm('确认领取吗？')" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr>
                                <td width="107">
                                    <%# Eval("姓名") %>
                                </td>
                                <td width="195">
                                    <%# Eval("部门") %>
                                </td>
                                <td width="75">
                                    <%# Eval("工号") %>
                                </td>
                                <td width="152">
                                    <%# Eval("类型名称")%>
                                </td>
                                <td width="236">
                                    <%# Eval("奖品名称")%>
                                </td>
                                <td width="121">
                                    <asp:Label ID="lblL" class="a1" runat="server">已领取</asp:Label>
                                    <asp:Button ID="btnL" CommandName="LQ" CommandArgument='<%# Eval("ID") %>' runat="server"
                                        Text="领取" CssClass="an_1" OnClientClick="return confirm('确认领取吗？')" />
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
            <!--表格结束-->
        </div>
        <div class="s1">
        </div>
    </div>
    <div class="hr35">
    </div>
    </form>
</body>
</html>
