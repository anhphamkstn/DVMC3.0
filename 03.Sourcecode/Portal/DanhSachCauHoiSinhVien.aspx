<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" EnableEventValidation ="false"
AutoEventWireup="true" CodeFile="DanhSachCauHoiSinhVien.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link rel="stylesheet" type="text/css" href="Styles/style.css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="wrapper">
            <div class='div-search-box'>
                <div style=" font-size:25px; font-weight:bold; color:RGB(129,12,21);" align ="center">
                    Tra cứu cuộc gọi theo thời gian
                </div>
                <div class="div-header-box">Thông tin tổng hợp báo cáo</div>
                    <div class='div-clear'></div>
                    <div class='div-left'>
                    <div class='lbl-title'><span class="cssManField" style="margin-left:10px;">Điện thoại</span></div>
                        <div class="textbox-search">
                            <asp:TextBox ID="m_txt_dien_thoai" ToolTip="Điện thoại" runat="server" Width="70%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="div-right">
                        <div class="lbl-title">
                            <span class="cssManField" style="margin-left:10px;">Họ tên</span></div>
                        <div class="textbox-search">
                            <asp:TextBox ID="m_txt_ho_ten" runat="server" Width="70%"></asp:TextBox>
                        </div>
                    </div>
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
                    <div class='div-left'>
                         <div class='lbl-title'><span class="cssManField" style="margin-left:10px;">Thời điểm gọi</span></div>
                        <div class="textbox-search">
                            <asp:DropDownList ID="m_ddl_thoi_diem_goi" runat="server" Width="40%" 
                                AutoPostBack="True" 
                                onselectedindexchanged="m_ddl_thoi_diem_goi_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>
                    
                    <div class="div-right" style="margin-top:10px;">
                         <asp:Button ID="m_cmd_tim_kiem" runat="server" AccessKey="s" style= "margin-left:10px;float:left;"
                         Height="24px" onclick="m_cmd_tim_kiem_Click" CssClass="input-button-search"
                        Text="Tìm kiếm" Width="110px" />

                        <asp:Button ID="Button1" runat="server" AccessKey="t" Visible="false"
                            CssClass="input-button-search" Height="24px" onclick="m_cmd_export_excel_Click" 
                            Text="Xuất Excel" Width="110px" />
                    </div>
            </div>
                <div class='div-result-box'>
                    <div style="clear:both; width:100%; margin-bottom:5px;">
                        <asp:Label ID="m_lbl_error" runat="server" CssClass="cssManField"></asp:Label>
                    </div>
                    <tr>
                    <td align="center" colspan="3" style="height: 450px;" valign="top">
                        <asp:GridView ID="m_grv_tong_hop_so_lieu" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            Width="100%" DataKeyNames="ID" CellPadding="0" ForeColor="#333333" AllowSorting="True"
                            CssClass="cssGrid" EmptyDataText="Không có dữ liệu phù hợp" PageSize="15" 
                            ShowHeader="true" 
                            onpageindexchanging="m_grv_tong_hop_so_lieu_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="5%">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Số điện thoại" ItemStyle-HorizontalAlign="Center"
                                DataField="SO_DIEN_THOAI" HeaderStyle-Width ="11%" HeaderStyle-HorizontalAlign = "Center"/>
                                <asp:BoundField HeaderText="Họ tên sinh viên" DataField="HO_TEN_SINH_VIEN" 
                                HeaderStyle-Width ="17%" HeaderStyle-HorizontalAlign = "Center" />
                                <asp:BoundField HeaderText="Thời gian gọi" DataField="START_TIME" DataFormatString="{0:dd/MM/yyyy hh:mm}"
                                    HeaderStyle-Width ="15%" HeaderStyle-HorizontalAlign = "Center" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Độ dài cuộc gọi (giây)" DataField="DURATION" ItemStyle-HorizontalAlign="Center"
                                    HeaderStyle-Width ="15%" HeaderStyle-HorizontalAlign = "Center" />
                                <asp:TemplateField HeaderText="Nghe lại"  ItemStyle-Width="37%"
                                HeaderStyle-HorizontalAlign = "Center" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                    <audio id="player3" controls="controls" src='<%# get_file_record(Eval("VOICE_CALL_LINK")) %>' type="audio/x-wav">
                                    </audio>
                                    </ItemTemplate>
                            </asp:TemplateField>
                            </Columns>
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#810c15" Font-Bold="True" ForeColor="White" />
                            <PagerSettings Position="TopAndBottom" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle CssClass="cssSelectedRow" BackColor="#C5BBAF" Font-Bold="True"
                                ForeColor="#333333"></SelectedRowStyle>
                        </asp:GridView>
                    </td>
                </tr>
                </div>
            </div> 
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            <div class="cssLoadWapper">
                <div class="cssLoadContent" style="visibility:visible">
                    <img src="Img/loadingBar.gif" alt="" />
                    <p>
                        Đang tải dữ liệu, xin hãy đợi ...</p>
                </div>
            </div>
        </ProgressTemplate>
      </asp:UpdateProgress>
</asp:Content>