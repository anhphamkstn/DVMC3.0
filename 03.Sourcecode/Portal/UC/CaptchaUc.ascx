<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CaptchaUc.ascx.cs" Inherits="UC_CaptchaUc" %>
<img id="captcha_img" src="/Css/Login-Box/loading.gif" alt="" />
<a id="refresh_captcha" style="position:absolute; top:420px; text-decoration:underline; color:Blue; font-size:17px;">Dùng hình ảnh khác</a>
<script type="text/javascript">
    $(document).ready(function () {
        captcha_url = '/UC/ReloadCaptcha.aspx?mcid=' + new Date().getTime();
        $('img#captcha_img').attr('src', captcha_url);
        $('a#refresh_captcha')
        .css('cursor', 'pointer')
        .click(function () {
            captcha_url = '/UC/ReloadCaptcha.aspx?mcid=' + new Date().getTime(); // Math.random();
            $('#captcha_img').attr('src', captcha_url);
        });
    });
</script>