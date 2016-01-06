<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" EnableEventValidation ="false"
AutoEventWireup="true" CodeFile="BaoCaoChamCong.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link rel="stylesheet" type="text/css" href="Styles/style.css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="wrapper">
    <div class='div-search-box' style="height:200px">
        <div style=" font-size:25px; font-weight:bold; color:RGB(129,12,21);" align ="center">
            Báo cáo thống kê thời gian làm việc của Điện thoại viên
        </div>
        <div class="div-header-box">Thông tin tổng hợp báo cáo</div>
            <div class='div-clear'></div>
            <div class='div-left'>
                <div class='lbl-title'>
                    <span class="cssManField" style="margin-left:10px;" >Từ ngày</span>
                </div>
                <div class="textbox-search">
                <ew:CalendarPopup ID="m_dat_tu_ngay" runat="server" 
                ControlDisplay="TextBoxImage" GoToTodayText="Hôm nay:" 
                ImageUrl="~/Img/cal.gif" Nullable="True" NullableLabelText="" 
                ShowGoToToday="True" Width="50%" SelectedDate="" Text="" Culture="vi-VN" 
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
            <div class='div-right'>
                <div class="lbl-title">
                    <span class="cssManField" style="margin-left:10px;">Đến ngày</span>
                </div>
                <div class="textbox-search">
                <ew:CalendarPopup ID="m_dat_den_ngay" runat="server" 
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
                <div class='lbl-title'><span class="cssManField" style="margin-left:10px;">Điện thoại viên</span></div>
                <div class="textbox-search">
                    <asp:DropDownList ID="m_ddl_dien_thoai_vien" runat="server" Width="70%" 
                        AutoPostBack="True" 
                        onselectedindexchanged="m_ddl_dien_thoai_vien_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
                    
            <div class="div-right" style="margin-top:10px; text-align:left">
                <asp:Button ID="m_cmd_tim_kiem" runat="server" AccessKey="s" 
                    Height="24px" onclick="m_cmd_tim_kiem_Click" CssClass="input-button-search"
                Text="Thống kê" Width="110px" />

                <asp:Button ID="m_cmd_export_excel" runat="server" AccessKey="t"
                    CssClass="input-button-search" Height="24px" onclick="m_cmd_export_excel_Click" 
                    Text="Xuất Excel" Width="110px" />
            </div>
    </div>
        <div class='div-result-box'>
            <div style="clear:both; width:100%; margin-bottom:5px;">
                <asp:Label ID="m_lbl_error" runat="server" CssClass="cssManField"></asp:Label>
            </div>
            
            <div align="center">
            <% 
                Response.Write(m_str_table_cham_cong); 
            %>
            </div>
    </div> 
</asp:Content>