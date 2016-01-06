<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" EnableEventValidation ="false"
AutoEventWireup="true" CodeFile="MyOrders.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link rel="stylesheet" type="text/css" href="Styles/style.css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="wrapper">
                
                <div class='div-result-box'>
                    <div style="clear:both; width:100%; margin-bottom:5px;">
                        <asp:Label ID="m_lbl" Text="Đặt hàng của tôi" runat="server" CssClass="cssManField"></asp:Label>
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
                            EmptyDataText="Không có đặt hàng nào phù hợp" PageSize="15" 
                            ShowHeader="true" 
                            onpageindexchanging="m_grv_bang_tot_nghiep_PageIndexChanging" >
                            <Columns>
                                <asp:TemplateField ItemStyle-Width="4%">
                                    <HeaderTemplate>STT</HeaderTemplate>
                                    <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="MA_DON_HANG" HeaderText="Mã đơn hàng" 
                                    ItemStyle-Width="10%">
                                </asp:BoundField>
                                <asp:BoundField DataField="USER_NV_DAT_HANG" HeaderText="User NV đặt hàng" 
                                    ItemStyle-Width="6%">
                                </asp:BoundField>
                                <asp:BoundField DataField="DIEN_THOAI" HeaderText="SĐT NV đặt hàng" 
                                    ItemStyle-Width="6%">
                                </asp:BoundField>
                                <asp:BoundField DataField="THOI_GIAN_DAT_HANG" ItemStyle-HorizontalAlign="Center" 
                                    HeaderText="Thời gian đặt hàng" DataFormatString="{0:dd/MM/yyyy HH:mm:ss}" 
                                    ItemStyle-Width="6%" >
                                </asp:BoundField>
                                <asp:BoundField DataField="TEN_LOAI_DICH_VU" 
                                HeaderText="Loại dịch vụ yêu cầu" ItemStyle-Width="8%" >
                                </asp:BoundField>
                                <asp:BoundField DataField="NOI_DUNG_DAT_HANG" HeaderText="Chi tiết đặt hàng" 
                                    ItemStyle-Width="15%">
                                </asp:BoundField>
                                <asp:BoundField DataField="LOAI_THOI_GIAN_CAN_HOAN_THANH" HeaderText="Cần hoàn thành trong" 
                                    ItemStyle-Width="10%">
                                </asp:BoundField>
                                <asp:BoundField DataField="PHAN_HOI_TU_DVMC" HeaderText="Phản hồi từ DVMC"
                                    ItemStyle-Width="10%" >
                                </asp:BoundField>
                                  <asp:BoundField DataField="TRANG_THAI_YC" HeaderText="Trạng thái yêu cầu" 
                                    ItemStyle-Width="10%" >
                                </asp:BoundField>
                                 <asp:BoundField DataField="LICH_SU_TRAO_DOI" HeaderText="Lịch sử trao đổi" 
                                    ItemStyle-Width="15%" >
                                </asp:BoundField>
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
</asp:Content>