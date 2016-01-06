<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" EnableEventValidation ="false"
AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
                <div class="div-header-box">Thông tin tra cứu câu hỏi</div>
                    <div class='div-left'>
                        <div class='lbl-title'><span class="cssManField" style="margin-left:10px;">Họ tên học viên</span></div>
                        <div class='textbox-search'>
                            <asp:TextBox ID="m_txt_ho_ten_hoc_vien" runat="server" 
                                CssClass="input-textbox-search" ToolTip="Họ tên học viên" Width="90%"></asp:TextBox>
                        </div>
                    </div>
                    <div class='div-right'>
                        <div class="lbl-title">
                            <span class="cssManField" style="margin-left:15px;">Trạng thái</span></div>
                        <div class="combobox-search">
                            <asp:DropDownList ID="m_cbo_trang_thai" runat="server" Width="92%"></asp:DropDownList>
                        </div>
                    </div>
                    <div class='div-clear'></div>
                    <div class='div-left'>
                        <div class="lbl-title">
                            <span class="cssManField" style="margin-left:10px;">Số điện thoại</span></div>
                        <div class="textbox-search">
                            <asp:TextBox ID="m_txt_dien_thoai_hoc_vien" runat="server" 
                                CssClass="input-textbox-search" ToolTip="Số chứng chỉ được cấp" 
                                Width="90%"></asp:TextBox>
                        </div>
                    </div>
                    <div class='div-right' style="text-align:left;">
                        <div class="lbl-title">
                            <span class="cssManField" style="margin-left:15px;">Lớp</span></div>
                        <div class="textbox-search">
                            <asp:TextBox ID="m_txt_lop_hoc_vien" runat="server" 
                                CssClass="input-textbox-search" ToolTip="Số điện thoại" 
                                Width="90%"></asp:TextBox>
                        </div>
                    </div>
                    <div class='div-clear'></div>
                    <div class="div-left">
                        <asp:Button ID="m_cmd_export_excel" runat="server" AccessKey="t" 
                            CssClass="input-button-search" Height="24px" onclick="m_cmd_export_excel_Click" 
                            Text="Xuất Excel" Width="110px" />
                    </div>
                    <div class="div-right" style="text-align:right; margin-right:15px;">
                       <asp:Button ID="m_cmd_tim_kiem" runat="server" AccessKey="s" 
                        CssClass="input-button-search" Height="24px" onclick="m_cmd_tim_kiem_Click" 
                        Text="Tìm kiếm" Width="110px" />
                    </div>
                </div>
                
                <div class='div-result-box'>
                    <div style="clear:both; width:100%; margin-bottom:5px;">
                        <asp:Label ID="m_lbl_error" runat="server" CssClass="cssManField"></asp:Label>
                    </div>
                   <!-- <div style="float:left; width:50%; margin-bottom:5px;">
                        <asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="lbl-thong-bao"></asp:Label>
                    </div>  -->
                    <div class='div-result-message'>
                    Tổng số 
                    <asp:Label runat="server" CssClass="lbl-result-chung-chi"
                    ID="m_lbl_result_message" Text="0">
                    </asp:Label> câu hỏi</div>
                    <asp:GridView ID="m_grv_cau_hoi_hoc_vien" runat="server" 
                            AllowPaging="True" AutoGenerateColumns="False"
                            Width="100%" DataKeyNames="ID" CellPadding="4" ForeColor="#333333" AllowSorting="True"
                            EmptyDataText="Không có câu hỏi, yêu cầu phù hợp" PageSize="15" 
                            ShowHeader="true" 
                            onpageindexchanging="m_grv_bang_tot_nghiep_PageIndexChanging" 
                        onrowupdating="m_grv_cau_hoi_hoc_vien_RowUpdating" >
                            <Columns>
                                <asp:TemplateField ItemStyle-Width="4%">
                                    <HeaderTemplate>STT</HeaderTemplate>
                                    <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="NOI_DUNG_CAU_HOI" HeaderText="Nội dung câu hỏi" 
                                    ItemStyle-Width="20%">
                                </asp:BoundField>
                                <asp:BoundField DataField="HO_TEN_SINH_VIEN" 
                                HeaderText="Sinh viên" ItemStyle-Width="10%" >
                                </asp:BoundField>
                                <asp:BoundField DataField="MA_SINH_VIEN" HeaderText="Mã sinh viên" ItemStyle-Width="10%">
                                </asp:BoundField>
                                <asp:BoundField DataField="LOP" HeaderText="Lớp" 
                                    ItemStyle-Width="8%">
                                </asp:BoundField>
                                <asp:BoundField DataField="SO_DIEN_THOAI" HeaderText="Điện thoại gọi" 
                                    ItemStyle-Width="8%" >
                                </asp:BoundField>
                                <asp:BoundField DataField="THOI_GIAN_HV_HOI" ItemStyle-HorizontalAlign="Center" 
                                    HeaderText="Thời gian hỏi" DataFormatString="{0:dd/MM/yyyy}" 
                                    ItemStyle-Width="8%" >
                                </asp:BoundField>
                                 <asp:BoundField DataField="NOI_DUNG_TRAO_DOI" HeaderText="Ghi chú của điện thoại viên" 
                                    ItemStyle-Width="18%" >
                                </asp:BoundField>
                                  <asp:BoundField DataField="TRANG_THAI_CAU_HOI" HeaderText="Trạng thái câu hỏi" 
                                    ItemStyle-Width="8%" >
                                </asp:BoundField>
                                <asp:BoundField DataField="ID_TRANG_THAI_CAU_HOI" HeaderText="Id trạng thái câu hỏi" Visible="false">
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Cập nhật đã trả lời" 
                                        ItemStyle-Width="6%" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate> 
                                        <asp:LinkButton ToolTip="Cập nhật trạng thái đã trả lời" ID = "lbt_UpdateTrangThai" runat="server"
                                            CommandName="Update" OnClientClick="return confirm ('Câu hỏi này đã được QLHT trả lời sinh viên?')">
                                        <img src="Img/notification_done.png" width="30px" alt="Cập nhật trạng thái đã trả lời" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#810c15" Font-Bold="True" ForeColor="White" />
                            <PagerSettings Position="Bottom" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle CssClass="cssSelectedRow" BackColor="#C5BBAF" Font-Bold="True"
                                ForeColor="#333333"></SelectedRowStyle>
                        </asp:GridView>
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