<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f201_kh_danh_gia_dv.aspx.cs" Inherits="WEB_DVMC.chucnang.f201_kh_danh_gia_dv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/style.css" rel="stylesheet" />
</head>
<body>
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
    <form id="form1" runat="server">
        <div id="wrapper">
    <div class='div-search-box' style="height:450px">
        <div style=" font-size:25px; font-weight:bold; color:RGB(129,12,21);" >
            ĐÁNH GIÁ DỊCH VỤ
        </div>
            <div class='div-clear' style="height:20px;">
                <asp:Label runat="server" ID="m_lbl_message"></asp:Label>
            </div>
            <div class='div-left' style="width:100%;text-align:left">
            </div>
            <div class='div-left'>
                <div class='lbl-title'>
                    <span class="cssManField" style="margin-left:10px;" >Mã đơn hàng</span>
                </div>
                <div class="textbox-search">
                    <asp:Label ID="m_lbl_ma_don_hang" CssClass="cssLabel" runat="server" Text="..."></asp:Label>
                </div>
            </div>
            <div class='div-right'>
                <div class="lbl-title">
                    <span class="cssManField" style="margin-left:10px;">Ngày đặt hàng</span>
                </div>
                <div class="textbox-search">
                 
                    <asp:TextBox runat="server" ID="m_dat_ngay_dat_hang" />            
                </div>
            </div>
            
            <div class='div-left'>
                <div class='lbl-title'>
                    <span class="cssManField" style="margin-left:10px;" >Loại dịch vụ yêu cầu</span>
                </div>
                <div class="textbox-search">
                    <asp:Label ID="m_lbl_loai_dat_hang" CssClass="cssLabel" runat="server" Text="..."></asp:Label>
                </div>
            </div>
            
            <div class='div-right'>
                <div class="lbl-title">
                    <span class="cssManField" style="margin-left:10px;">Loại thời hạn</span>
                </div>
                <div class="textbox-search">            
                    <asp:Label ID="m_lbl_loai_thoi_han" CssClass="cssLabel" runat="server" Text="..."></asp:Label>               
                </div>
            </div>
            <div class='div-clear' style="height:20px"></div>
            <div class='div-left' style="width:100%">
                <div class='lbl-title' style="width:15%">
                    <span class="cssManField" style="margin-left:10px;" >Nội dung đặt hàng</span>
                </div>
                <div class="textbox-search" style="width:85%">
                    <asp:TextBox ID="m_txt_noi_dung_dat_hang"  runat="server" Width="95%"></asp:TextBox>
                </div>
            </div>
            <div class='div-clear' style="height:20px"></div>
            <div class='div-left' style="width:100%; text-align:left">
                <span class="cssManField" style="margin-left:10px;">Anh chị đánh giá kết quả đơn hàng theo mức độ nào?</span>
            </div>
            <div class='div-clear'></div>
            <div class='div-left' style="width:100%;">
             <table style="width:100%">
                <thead style='color:White; text-align:center; font-weight:bold;'>
                    <tr style='height:28px;'>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="../Images/Rat_hai_long.JPG" /></td>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="../Images/hai_long.JPG" /></td>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="../Images/xong_viec.JPG" /></td>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="../Images/Hoi_duoi.JPG" /></td>                     
                        <td style="width:20%"> <img alt="Logo TOPICA" src="../Images/ko_dat.JPG" /></td>
                    </tr>
                </thead>
                <tr>
                    <td style="width:20%"><asp:RadioButton ID="m_rdb_rat_hai_long" GroupName="danh_gia" Text="Rất hài lòng" runat="server" /></td>
                    <td style="width:20%"><asp:RadioButton ID="m_rdb_hai_long" Text="Hài lòng" GroupName="danh_gia" runat="server" /></td>
                    <td style="width:20%"><asp:RadioButton ID="m_rdb_xong_viec" Text="Xong việc" GroupName="danh_gia" runat="server" /></td>
                    <td style="width:20%"><asp:RadioButton ID="m_rdb_hoi_duoi" Text="Hơi đuối" GroupName="danh_gia" runat="server" /></td>
                    <td style="width:20%"><asp:RadioButton ID="m_rdb_khong_dat" Text="Không đạt" GroupName="danh_gia" runat="server" /></td>
                </tr>
             </table>
            </div>
            <div class='div-clear' style="height:20px"></div>
             <div class='div-left' style="width:100%">
                <div class='lbl-title' style="width:15%">
                    <span class="cssManField" style="margin-left:10px;" >Ý kiến khác</span>
                </div>
                <div class="textbox-search" style="width:85%">
                    <asp:TextBox ID="m_txt_y_kien_khac"  runat="server" Width="95%"></asp:TextBox>
                </div>
            </div>
            <div class='div-clear' style="height:20px"></div>
            <div class="div-left" style="margin-top:10px; text-align:left">
                <asp:Button ID="m_cmd_gui_danh_gia" runat="server" AccessKey="s" 
                    Height="24px" onclick="m_cmd_gui_danh_gia_Click" CssClass="btn input-button-search"
                Text="Gửi đánh giá" Width="110px" />
                <asp:HiddenField ID="hdf_id_don_hang" runat="server"/>
            </div>
        </div>
    </div>    
        </form>
</body>
</html>
