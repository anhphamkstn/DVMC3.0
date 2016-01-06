<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="Confirm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
     <link rel="stylesheet" type="text/css" href="Styles/style.css" />
     <meta http-equiv="refresh" content="5; url=Default.aspx" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
     <div class="div-confirm-phan-hoi">
        Thắc mắc, góp ý của bạn đã được gửi đi. <br /> Chúng tôi sẽ phản hồi lại bạn sớm nhất có thể. Xin cảm ơn!
    </div>
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Timer ID="m_timer" runat="server" OnTick="m_timer_Tick" Interval="1000"></asp:Timer>

    <div class="div-back-homepage">
                 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="m_timer" />
                    </Triggers>
                    <ContentTemplate>
                         Hệ thống sẽ tự động chuyển về trang tra cứu sau <asp:Label ID="m_lbl_time" runat="server"></asp:Label> s hoặc bấm vào 
                         <a href="Default.aspx" style="cursor:pointer;">đây</a> để quay lại trang chủ
                    </ContentTemplate>
                </asp:UpdatePanel>
    </div>
</asp:Content>

