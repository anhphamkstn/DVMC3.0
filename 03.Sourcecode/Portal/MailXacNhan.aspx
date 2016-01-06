<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MailXacNhan.aspx.cs" Inherits="MailXacNhan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<div>Dear thầy/cô!</div>

<p>Cảm ơn thầy/cô đã sử dụng Dịch vụ một cửa 2.0.</p>

<div>DVMC đã hoàn thành đơn hàng MA_DON_HANG</div>

<table style="width:100%;border:1px solid;">
	<tbody>
		<tr>
			<td rowspan="2" style="width:25%"><img alt="DVMC" src="http://dvmc.topica.vn/Img/DVMC.jpg" style="width:100%" /></td>
			<td rowspan="2" style="width:20%"><img alt="DVMC_Infor" src="http://dvmc.topica.vn/Img/DVMC_Infor.jpg" style="width:100%" /></td>
			<td rowspan="2" style="width:20%"><img alt="TheDichVu" src="http://dvmc.topica.vn/Img/TheDichVu.JPG" style="width:100%" /></td>
			<td style="background-color:#808080; width:35%"><span style="color:White; font-family:arial; font-size:12px">M&atilde; đơn h&agrave;ng (DVMC điền)</span></td>
		</tr>
		<tr>
			<td style="width:35%">MA_DON_HANG</td>
		</tr>
	</tbody>
</table>

<table style="width:100%;border:1px solid;">
	<tbody>
		<tr>
			<td style="background-color:#808080; width:45%"><span style="color:White; font-family:arial; font-size:14px">User nh&acirc;n vi&ecirc;n đặt h&agrave;ng</span></td>
			<td style="background-color:#808080; width:15%"><span style="color:White; font-family:arial; font-size:14px">Đơn vị</span></td>
			<td style="background-color:#808080; width:15%"><span style="color:White; font-family:arial; font-size:14px">Điện thoại</span></td>
			<td style="background-color:#808080; width:25%"><span style="color:White; font-family:arial; font-size:14px">Thời gian đặt h&agrave;ng</span></td>
		</tr>
		<tr>
			<td>USER_NHAN_VIEN</td>
			<td>USER_DON_VI</td>
			<td>USER_DIEN_THOAI</td>
			<td>USER_THOI_GIAN_DAT_HANG</td>
		</tr>
		<tr>
			<td colspan="4" style="background-color:#808080"><span style="color:White; font-family:arial; font-size:14px">Bạn muốn hỗ trợ</span></td>
		</tr>
		<tr>
			<td colspan="4"><strong>Y&ecirc;u cầu, t&igrave;m kiếm t&agrave;i liệu</strong><br />
			<p style="font-family:arial; font-size:13px;margin-bottom:10px">LOAI_DICH_VU_HO_TRO</p></td>
		</tr>
		<tr>
			<td colspan="4" style="background-color:#808080"><span style="color:White; font-family:arial; font-size:14px">Y&ecirc;u cầu cụ thể của bạn</span></td>
		</tr>
		<tr>
			<td colspan="4"><p style="font-family:arial; font-size:13px;margin-bottom:10px; margin-top:10px;">YEU_CAU_CU_THE</p></td>
		</tr>
        <tr>
			<td colspan="4" style="background-color:#808080"><span style="color:White; font-family:arial; font-size:14px">Lịch sử trao đổi</span></td>
		</tr>
		<tr>
			<td colspan="4"><p style="font-family:arial; font-size:13px;margin-bottom:10px; margin-top:10px;">LICH_SU_TRAO_DOI</p></td>
		</tr>
		<tr>
			<td colspan="4" style="background-color:#808080"><span style="color:White; font-family:arial; font-size:14px">Bạn muốn đặt h&agrave;ng được giải quyết trong v&ograve;ng </span></td>
		</tr>
		<tr>
			<td colspan="4">
            <p style="font-family:arial; font-size:13px;padding-left:5px;font-weight:bold;margin-top:10px;">THOI_GIAN_MONG_MUON_SUA_XONG</p>
             <br />
                <table style="width: 100%;">
                    <tr>
                        <td style="font-family:arial; font-size:13px;width:60%;">
                            Biệt phái: người của DVMC trực tại chỗ</td>
                        <td style="font-family:arial; font-size:13px;width:40%;">
                            Gọi 1800 6882</td>
                    </tr>
                    <tr>
                        <td style="font-family:arial; font-size:13px;width:60%;">
                            Dân quân: hướng dẫn khách hàng tự thực hiện</td>
                        <td style="font-family:arial; font-size:13px;width:40%;">
                            Gọi 1800 6882</td>
                    </tr>
                </table>
			</td>
		</tr>
		<tr>
			<td colspan="4" style="background-color:#808080"><span style="color:White; font-family:arial; font-size:14px">Phản hồi của DVMC với kh&aacute;ch h&agrave;ng</span></td>
		</tr>
		<tr>
			<td colspan="4"><p style="margin-bottom:10px;margin-top:10px; font-family:arial; font-size:14px">PHAN_HOI_CUA_DVMC</p></td>
		</tr>
	</tbody>
</table>
<p></p>
<table style="width: 100%;border:1px solid;">
        <tr>
            <td style="font-family:arial; font-size:14px;width:33%; text-align:center;">
                Thời gian hoàn thành thực tế</td>
            <td style="font-family:arial; font-size:14px;width:33%;; text-align:center;">
               Người xử lý đơn hàng </td>
            <td style="font-family:arial; font-size:14px;width:33%;; text-align:center;">
               Người nhận đặt hàng </td>
        </tr>
        <tr>
            <td style="font-family:arial; font-size:13px;width:33%;">
                </td>
            <td style="font-family:arial; font-size:13px;width:33%;">
                </td>
            <td style="font-family:arial; font-size:13px;width:33%;">
                </td>
        </tr>
        <tr>
            <td style="font-family:arial; font-size:13px;width:33%;">
                </td>
            <td style="font-family:arial; font-size:13px;width:33%;">
                </td>
            <td style="font-family:arial; font-size:13px;width:33%;">
                </td>
        </tr>
        <tr>
            <td style="font-family:arial; font-size:13px;width:33%;; text-align:center;">
                THOI_GIAN_HOAN_THANH_THUC_TE</td>
            <td style="font-family:arial; font-size:13px;width:33%;; text-align:center;">
                NGUOI_XU_LY_DON_HANG</td>
            <td style="font-family:arial; font-size:13px;width:33%;; text-align:center;">
                NGUOI_NHAN_DAT_HANG</td>
        </tr>
    </table>

<div style="clear:both"></div>

<p>Mời thầy/c&ocirc; đ&aacute;nh gi&aacute; đơn h&agrave;ng MA_DON_HANG&nbsp;<a href="LINK_DANH_GIA_DON_HANG" style="line-height: 20.7999992370605px;">tại đ&acirc;y</a></p>

<div>Cảm ơn thầy c&ocirc;!</div></body>
</html>
