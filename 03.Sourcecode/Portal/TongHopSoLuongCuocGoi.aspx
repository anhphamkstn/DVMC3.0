<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" EnableEventValidation ="false"
AutoEventWireup="true" CodeFile="TongHopSoLuongCuocGoi.aspx.cs" Inherits="_Default" %>
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
              <div style=" font-size:25px; font-weight:bold; color:RGB(129,12,21);" align ="center">
                    Báo cáo số lượng cuộc gọi theo thời gian
            </div>
                <div class="div-header-box">Thông tin tổng hợp báo cáo</div>
                    <div class='div-left'>
                        <div class='lbl-title' align= "left">
                        <span class="cssManField" style="margin-left:10px;" >Từ ngày </span></div>
                        <div class="textbox-search">
                     <ew:CalendarPopup ID="m_dat_tu_ngay" runat="server" 
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
                
                   <div class='div-right'>
                    <div class="lbl-title">
                        <span class="cssManField" style="margin-left:15px;">Đến ngày</span></div>
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
                    
                 <div class='div-clear'></div>
                <div class="div-left">
             </div>
                <div class="div-right" style="text-align:left; margin-right:15px;">
                      <asp:Button ID="m_cmd_tim_kiem" runat="server" AccessKey="s" 
                CssClass="input-button-search" Height="24px" onclick="m_cmd_tim_kiem_Click" 
                Text="Tìm kiếm" Width="110px" />
                    <asp:Button ID="m_cmd_xuat_excel" runat="server" AccessKey="t" 
                        CssClass="input-button-search" Height="24px" onclick="m_cmd_export_excel_Click" 
                        Text="Xuất Excel" Width="110px" />
              </div>
               
                <div class='div-result-box'>
             <div style="clear:both; width:100%; margin-bottom:15px;">
                <asp:Label ID="m_lbl_error" runat="server" CssClass="cssManField"></asp:Label>
            </div>
             <asp:GridView ID="m_grv_tong_hop_so_lieu" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            Width="100%" CellPadding="0" ForeColor="#333333" AllowSorting="True" GridLines="Both"
            CssClass="cssGrid" EmptyDataText="Không có dữ liệu phù hợp" PageSize="15" ShowHeader="true">
            <Columns>
                <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="center" HeaderStyle-Width="3%">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Ngày gọi"  DataFormatString="{0:dd/MM/yyyy}" ItemStyle-HorizontalAlign="Center"
                DataField="NGAY_GOI" HeaderStyle-Width ="10%" HeaderStyle-HorizontalAlign="Center" />
                <asp:BoundField HeaderText="Tổng cuộc gọi vào" ItemStyle-HorizontalAlign="Center"
                DataField="TONG_CUOC_GOI_VAO" HeaderStyle-Width ="5%" />
                
                <asp:BoundField HeaderText="Tổng số câu hỏi" ItemStyle-HorizontalAlign="Center"
                DataField="TONG_SO_CAU_HOI" HeaderStyle-Width ="5%" HeaderStyle-HorizontalAlign="Center" />

                <asp:TemplateField HeaderStyle-Width="40%" HeaderStyle-Height="110px">
                    <HeaderTemplate>
                        <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;
                            color: White">
                            <tr>
                                <td colspan="6" style="height: 30px; text-align: center">
                                    Câu hỏi TĐV trả lời
                                    <br />
                                                    
                                </td>
                            </tr>
                            <tr>
                                <td rowspan="2" style="width: 17%; text-align: center; height: 80px;">
                                    Số câu hỏi
                                </td>
                                <td rowspan="2" style="width: 17%; height: 80px; text-align: center">
                                    Đang chờ trả lời
                                </td>
                                <td rowspan="2" style="width: 17%; height: 80px; text-align: center">
                                    Đã trả lời
                                </td>
                                <td colspan="3";style=" text-align: center">
                                    Đánh giá
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 17%; text-align: center">
                                    Hài lòng
                                </td>
                                <td style="width: 16%; text-align: center">
                                    Tạm được
                                </td>
                                <td style="width: 16%; text-align: center">
                                    Bình thường
                                </td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table border="0" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;
                            text-align: right">
                            <td style="width: 17%; height: 60px; border-right: 1px solid gray; text-align:center;">
                                <%# Eval("SO_CUOC_GOI_TDV", "{0:#,##0}")%>
                            </td>
                            <td style="width: 17%; height: 60px; border-right: 1px solid gray;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_TDV_DANG_CHO", "{0:#,##0}")%>
                            </td>
                            <td style="width: 17%; height: 60px; border-right: 1px solid gray;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_TDV_TRA_LOI", "{0:#,##0}")%>
                            </td>
                            <td style="width: 17%; height: 50px; border-right: 1px solid gray;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_HAI_LONG", "{0:#,##0}")%>
                            </td>
                            <td style="width: 16%; height: 50px; border-right: 1px solid gray;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_TAM_DUOC", "{0:#,##0}")%>
                            </td>
                            <td style="width: 16%; height: 50px;  border-right: 1px solid gray;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_BINH_THUONG", "{0:#,##0}")%>
                            </td>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderStyle-Width="30%" HeaderStyle-Height="110px">
                    <HeaderTemplate>
                        <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;
                            color: White">
                            <tr>
                                <td colspan="3" style="height: 50px; text-align: center">
                                    Cuộc gọi TĐV chuyển cho QLHT
                                    <br />
                                                    
                                </td>
                            </tr>
                            <tr>
                                <td rowspan="2" style="text-align: center">
                                    Số cuộc gọi
                                </td>
                                <td rowspan="2" style="width: 33.33%; height: 60px; text-align: center">
                                    Đã trả lời
                                </td>
                                <td rowspan="2" style=" text-align: center">
                                    Chưa trả lời
                                </td>
                            </tr>
                                           
                        </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table border="0" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;
                            text-align: right">
                            <td style="width: 20%; height: 60px; border-right: 1px solid gray;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_QLHT", "{0:#,##0}")%>
                            </td>
                            <td style="width: 20%; height: 60px; border-right: 1px solid gray;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_QLHT_TRA_LOI", "{0:#,##0}")%>
                            </td>
                            <td style="width: 20%; height: 50px;text-align:center;">
                                <%# Eval("SO_CUOC_GOI_QLHT_CHUA_TRA_LOI", "{0:#,##0}")%>
                            </td>

                        </table>
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
            </div>
        </div>
        </ContentTemplate>
        <Triggers>
               <asp:PostBackTrigger ControlID="m_cmd_xuat_excel" />
           </Triggers>
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