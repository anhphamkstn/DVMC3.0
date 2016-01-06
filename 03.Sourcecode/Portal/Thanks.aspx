<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" AutoEventWireup="true" CodeFile="Thanks.aspx.cs" Inherits="Confirm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
     <link rel="stylesheet" type="text/css" href="Styles/style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
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
</asp:Content>

