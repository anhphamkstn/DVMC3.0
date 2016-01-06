<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f202_thanks.aspx.cs" Inherits="WEB_DVMC.chucnang.f202_thanks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="~/Styles/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div id="header">
         <img alt="Logo TOPICA" runat="server" src="~/Images/DVMC.JPG" />
        <img alt="Logo TOPICA" runat="server" src="~/Images/DVMC_Infor.JPG" />
        <p style="text-align: right; padding-top: 20px; color: #810C15; font-size: 18px; font-weight: normal;">
            <span style="font-weight:bold;">
                        <asp:Label runat="server" ID="m_lbl_username"></asp:Label>
                      </span>
            &nbsp;&nbsp;&nbsp;
        </p>
    </div>
   
    <div id="banner">
        <div class="div-home-page">
            <div class="div-home-page">
            
        </div>
        </div>
        <div class="div-header">
            DỊCH VỤ MỘT CỬA 3.0
        </div>
    </div>
    
    <div id="container">
        <div class="div-confirm-phan-hoi">
        Cảm ơn thầy / cô đã đánh giá cho đơn hàng <asp:Label runat="server" ID="m_lbl_don_hang"></asp:Label>. 
        <br /> Chúc thầy / cô một ngày làm việc thật hiệu quả!
        <br /> -- DVMC --
        <br />
        <br />
        <br />
        <div style="text-align:left">
        </div>
    </div>
    </div>
    
    </div>
    </form>
</body>
</html>
