<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" EnableEventValidation ="false"
AutoEventWireup="true" CodeFile="DanhGiaDichVu.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link rel="stylesheet" type="text/css" href="Styles/style.css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="wrapper">
    <div class='div-search-box' style="height:450px">
        <div style=" font-size:25px; font-weight:bold; color:RGB(129,12,21);" align ="center">
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
                <ew:CalendarPopup ID="m_dat_ngay_dat_hang" runat="server" 
                    ControlDisplay="TextBoxImage" GoToTodayText="Hôm nay:" 
                ImageUrl="~/Img/cal.gif" Nullable="True" NullableLabelText="" 
                ShowGoToToday="True" Width="50%" SelectedDate="" 
                    Text="" Culture="vi-VN" 
                DisableTextboxEntry="False">
                <weekdaystyle backcolor="White" font-names="Verdana,Helvetica,Tahoma,Arial" 
                    font-size="XX-Small" forecolor="Black" />
                <weekendstyle backcolor="LightGray" font-names="Verdana,Helvetica,Tahoma,Arial" 
                    font-size="XX-Small" forecolor="Black" />
                <offmonthstyle backcolor="AntiqueWhite" 
                    font-names="Verdana,Helvetica,Tahoma,Arial" font-size="XX-Small" 
                    forecolor="Gray" />
                <selecteddatestyle backcolor="Yellow" 
                    font-names="Verdana,Helvetica,Tahoma,Arial" font-size="XX-Small" 
                    forecolor="Black" />
                <monthheaderstyle backcolor="Yellow" 
                    font-names="Verdana,Helvetica,Tahoma,Arial" font-size="XX-Small" 
                    forecolor="Black" />
                <DayHeaderStyle BackColor="Orange" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                    Font-Size="XX-Small" ForeColor="Black" />
                <cleardatestyle backcolor="White" font-names="Verdana,Helvetica,Tahoma,Arial" 
                    font-size="XX-Small" forecolor="Black" />
                <gototodaystyle backcolor="White" font-names="Verdana,Helvetica,Tahoma,Arial" 
                    font-size="XX-Small" forecolor="Black" />
                <TodayDayStyle BackColor="LightGoldenrodYellow" 
                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                    ForeColor="Black" />
                <holidaystyle backcolor="White" font-names="Verdana,Helvetica,Tahoma,Arial" 
                    font-size="XX-Small" forecolor="Black" />
            </ew:CalendarPopup>
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
                        <td style="width:20%"> <img alt="Logo TOPICA" src="Img/Rat_hai_long.JPG" /></td>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="Img/hai_long.JPG" /></td>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="Img/xong_viec.JPG" /></td>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="Img/hoi_duoi.JPG" /></td>
                        <td style="width:20%"> <img alt="Logo TOPICA" src="Img/ko_dat.JPG" /></td>
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
                    Height="24px" onclick="m_cmd_gui_danh_gia_Click" CssClass="input-button-search"
                Text="Gửi đánh giá" Width="110px" />
                <asp:HiddenField ID="hdf_id_don_hang" runat="server"/>
            </div>
    </div>         
</asp:Content>