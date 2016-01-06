<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>
<%@ Register Src="Uc/CaptchaUc.ascx" TagName="CaptchaUc" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
  <link href="/Css/login-box.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" charset="utf-8" src="Scripts/jquery-1.4.1.min.js"></script>
    <link rel="stylesheet" type="text/css" href="Styles/style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
 <div id="wrapper">
            <img class="stamp" src="Img/stamp.png" alt="stamp" />
            <img class="top" src="Img/top_border.JPG" alt="border" />
            <img class="bottom" src="Img/Border.JPG" alt="border" />
            <span class="header-top">GỬI PHẢN HỒI, GÓP Ý</span>
            <div class="div-controsl">
            <label for="name"><strong>Họ và tên:&nbsp;
                <asp:RequiredFieldValidator ID="m_rq_" runat="server" ControlToValidate="m_txt_name"
                    ErrorMessage="Bạn hãy nhập họ tên"></asp:RequiredFieldValidator>
                </strong></label>
             <asp:TextBox runat="server" name="name" id="m_txt_name" 
                value="" CssClass="class-textbox input-textbox-search" />
       
            <label for="email"><strong>Email:&nbsp;&nbsp; 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="m_txt_email" ErrorMessage="Bạn hãy nhập email"></asp:RequiredFieldValidator>
                </strong></label>
            <asp:TextBox name="email" id="m_txt_email" value="" 
                runat="server" CssClass="class-textbox input-textbox-search"/>
            <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator1" runat="server" ControlToValidate="m_txt_email"
                    ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"
                    ErrorMessage="Email không đúng định dạng"></asp:RegularExpressionValidator>
            <label for="SDT"><strong>Số điện thoại:&nbsp; </strong>
                <asp:RequiredFieldValidator ID="m_rq_0" runat="server" 
                    ControlToValidate="m_txt_so_dien_thoai" ErrorMessage="Bạn hãy nhập số điện thoại"></asp:RequiredFieldValidator>
                </label>
            <asp:TextBox name="SDT" id="m_txt_so_dien_thoai" value="" 
                runat="server" CssClass="class-textbox input-textbox-search"/>
            <asp:RegularExpressionValidator ID="m_regu_validator" ErrorMessage="Số ĐT không đúng định dạng"
            ControlToValidate="m_txt_so_dien_thoai" ValidationExpression="^[0-9\-\+]{10,12}$" runat="server"/>
            <label for="subject"><strong>Tiêu đề:&nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="m_txt_subject" ErrorMessage="Bạn hãy nhập tiêu đề"></asp:RequiredFieldValidator>
                </strong></label>
            <asp:TextBox name="subject" id="m_txt_subject" value="" 
            runat="server" CssClass="class-textbox input-textbox-search"/>
        
            <label for="message"><strong>Phản hồi, góp ý:&nbsp;
                <asp:RequiredFieldValidator ID="m_rq_2" runat="server" 
                    ControlToValidate="m_txt_message"
                    ErrorMessage="Nội dung không được để trắng"></asp:RequiredFieldValidator>
                </strong></label>
            <asp:TextBox TextMode="MultiLine" 
            Rows="4" runat="server" id="m_txt_message" 
            CssClass="class-textbox required"></asp:TextBox>
                
                <div class="div-captcha">
                <label for="m_txt_security_code"><strong>Nhập các chữ cái ở bên dưới</strong></label>
                <asp:TextBox id="m_txt_security_code" CssClass="class-textbox captcha"
                name="security_code" autocomplete="off" runat="server"/>  
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="m_txt_security_code"
                    ErrorMessage="(*)"></asp:RequiredFieldValidator><br />
                <uc2:CaptchaUc ID="CaptchaUc1" runat="server" />
                <asp:Button ID="m_cmd_gui_phan_hoi" Text="Gửi phản hồi"  CssClass="potition-button" 
                Height="24px" runat="server" Width="98px" onclick="m_cmd_gui_phan_hoi_Click" />
               </div>
            </div>
            <p class="ghi-chu-email">(*) Hãy nhập đúng Email và số điện thoại của bạn. 
            Thông tin đó được dùng để liên hệ với bạn khi có phản hồi sớm nhất.</p>
            <p class="rules">
                Nếu bạn có bất cứ thắc mắc, ý kiến đóng góp hoặc câu hỏi gì về chứng chỉ cũng như việc cấp phát chứng chỉ
                , hãy liên lạc với chúng tôi bằng form dưới đây. Chúng tôi sẽ hồi âm bạn sớm nhất có thể. </p>
    </div>
    <!--End #wrapper-->
</asp:Content>

