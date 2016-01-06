<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
    <head>
		<title>Đăng nhập Cổng tra cứu danh sách câu hỏi học viên cho QLHT</title>
        <link href="../Styles/Login.css" rel="stylesheet" type="text/css" />
	    <style type="text/css">
            .style1
            {
                color: #810c15;
            }
        </style>
	</head>
	<body style="margin:0px 0px 0px 0px;background-color:#808080;" onload="ShowTable();">
		<form id="Form2" method="post" runat="server">
			<table id="tbView" cellspacing="0" cellpadding="0" align="center" style="width:1003px;height:550px;" border="0">
				<tr>
					<td valign="middle" align="center" style="width:100%;height:100%;">
					    <table style="width:358px;height:35px;" cellpadding="0" cellspacing="0" border="0" > 
	                        <tr>
		                        <td style="width:9px;height:35px;background-image:url(../Img/Dialog/top-left.png);"></td>
		                        <td align="center" 
                                    style="background-image:url('../Img/Dialog/top-mid.png'); height:35px !important;width:340;" 
                                    valign="middle" >
			                        <asp:label id="lblPageTitle" Runat="server" CssClass="cssTitleLogin" Text="ĐĂNG NHẬP CHO QLHT" />
		                        </td>
		                        <td valign="top" style="width:7px;height:35px;background-image:url(../Img/Dialog/top-right.png);background-position:right;"></td>
	                        </tr>
	                        <tr>
		                        <td style="background-image:url(../Img/Dialog/left.png);width:7px;"></td>
		                        <td style="background-color:white;width:340;height:35px;">
		                            <table cellspacing="0" cellpadding="1" align="center" border="0" style="width:340px;">
	                                    <tr>
		                                    <td colspan="4" valign="top" style="height:3px;"></td>
	                                    </tr>
	                                    <tr>
		                                    <td colspan="4" valign="top" align="left" style="height:6px;">
		                                        <asp:validationsummary id="ValidationSummary1" CssClass="cssManField" runat="server" />
		                                    </td>
	                                    </tr>
	                                    <tr>
		                                    <td align="right" style="width:145px;">
		                                        <asp:label id="lbl_username" CssClass="cssManField" runat="server" Text="<U>T</U>ên đăng nhập:" />
		                                    </td>
		                                    <td style="width:5px;"></td>
		                                    <td style="width:175px;" align="left">
		                                        <asp:textbox id="txtUserName" AccessKey="t"    runat="server" MaxLength="40" Width="96%"/>
		                                    </td>
		                                    <td align="center" style="width:15px;">
		                                        <asp:requiredfieldvalidator id="rqfUserName" runat="server" ErrorMessage="Tên đăng nhập không được rỗng" ControlToValidate="txtUserName">*</asp:requiredfieldvalidator>
		                                        <asp:CustomValidator ID="ctvLogin" runat="server" ErrorMessage="Cặp tên/mật khẩu đăng nhập không hợp lệ!">*</asp:CustomValidator>
		                                    </td>
	                                    </tr>
	                                    <tr>
		                                    <td align="right" style="width:145px;">
		                                        <asp:label id="lbl_password" Runat="server" CssClass="cssManField" Text="<U>M</U>ật khẩu:" />
		                                    </td>
		                                    <td style="width:5px;"></td>
		                                    <td style="width:175px;" align="left">
		                                        <asp:textbox id="txtPassWord" AccessKey="m"   runat="server" MaxLength="40" Width="96%" TextMode="Password" />
				                            </td>
		                                    <td align="center" style="width:15px;">
		                                         <asp:requiredfieldvalidator id="rqfPassWord" runat="server" ErrorMessage="Mật khẩu không được rỗng" ControlToValidate="txtPassWord">*</asp:requiredfieldvalidator>				                                 
				                            </td>
	                                    </tr>
	                                    <tr>
		                                    <td align="right">
		                                        <asp:label id="lbl_password0" Runat="server" CssClass="cssManField" 
                                                    Text="Trường:" />
		                                    </td>
                                            <td style="width:5px;"></td>
		                                        <td>
		                                            <asp:DropDownList id="m_cbo_truong" runat="server" Width="96%" />
                                                </td>
		                                    <td align="center">&nbsp;</td>
		                                </tr>
	                                    <tr>
		                                    <td align="right">
		                                        <asp:label id="Label1" Runat="server" CssClass="cssManField" Text="<U>G</U>hi nhớ mật khẩu:" />
		                                    </td>
		                                    <td colspan="2" style="padding-left:4px;" align="left">
		                                        <asp:checkbox id="cbxRememberPassword" AccessKey="g" CssClass="cssCheckbox" runat="server" />
		                                    </td>
		                                    <td align="center"></td>
		                                </tr>
		                                <tr>		                                   
		                                    <td align="right" colspan="4" style="padding-right:5px; text-align: center;">
		                                        <asp:button id="btnLogin" accessKey="l" Width="98px" runat="server" 
                                                    Text="Đăng nhập(L)" CssClass="cssButton" onclick="btnLogin_Click" />&nbsp;
		                                        </td>
	                                    </tr>
	                                    <tr>
		                                    <td colspan="4" valign="top" style="height:3px;"></td>
	                                    </tr>
	                                    <tr>
		                                    <td colspan="4" align="center" valign="middle" 
                                                style="height:34px;background-color:#dddddd;" class="style1">
		                                        Copyright © 2014 - Designed by TIS
		                                    </td>
	                                    </tr>
                                    </table>
		                        </td>
		                        <td style="background-image:url(../Img/Dialog/right.png);background-position:right;width:7px;"></td>
	                        </tr>
	                        <tr>
	                            <td style="width:9px;height:7px;background-image:url(../Img/Dialog/bottom-left.png);"></td>
		                        <td style="background-image:url(../Img/Dialog/bottom-mid.png);width:340;"></td>
		                        <td style="width:9px;height:7px;background-image:url(../Img/Dialog/bottom-right.png);"></td>
	                        </tr>
                        </table>
                    </td>
				</tr>
			</table>
		</form>
	</body>
</html>