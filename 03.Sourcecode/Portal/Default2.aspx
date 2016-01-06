<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" EnableEventValidation ="false"
AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" Runat="Server">
    <link rel="stylesheet" type="text/css" href="Styles/style.css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="width: 100%; height: 100px;">
            <tr>
                <td style="margin-left:10px; font-size:25px; font-weight:bold;" align ="center">
                   </td>
            </tr>
            <tr>
                    <td>
                        <table style="  width: 100%; height: 100px;">
                            <tr>
                                <td style="text-align: left; padding-left:40px">
                                    <img alt='Excel_Document_Icon' src="Img/SoLuongCuocGoi.png" width="40px" />
                                    &nbsp; <a href="TongHopSoLuongCuocGoi.aspx" 
                                        style="font-size: x-large">Báo cáo số lượng cuộc gọi theo thời gian</a></td>
                                
                           
                            </tr>
                            <tr>
                                <td style="text-align: left; padding-left:40px">
                                    <img alt='Excel_Document_Icon' src="Img/list_call.png" width="40px" />
                                    &nbsp; <a href="DanhSachCauHoiSinhVien.aspx" 
                                        style="font-size: x-large">Danh sách các cuộc gọi sinh viên gọi đến</a></td>
                                
                           
                            </tr>
                            <tr>
                                <td style="text-align: left; padding-left:40px">
                                    <img alt='Excel_Document_Icon' src="Img/ChamCong.png" width="40px" />
                                    &nbsp; <a href="BaoCaoChamCong.aspx" 
                                        style="font-size: x-large">Báo cáo chấm công</a></td>
                                
                           
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>   
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            <div class="cssLoadWapper">
            </div>
        </ProgressTemplate>
      </asp:UpdateProgress>
</asp:Content>