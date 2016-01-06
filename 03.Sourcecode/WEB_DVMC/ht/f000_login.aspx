<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f000_login.aspx.cs" Inherits="WEB_DVMC.hethong.f000_login" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta content="IE=edge" http-equiv="X-UA-Compatible">
	<meta content="initial-scale=1.0, width=device-width" name="viewport">
	<title>Login - DVMCv3.0</title>

	<!-- css -->
    <link href="../theme/css/base_2.min.css" rel="stylesheet" />

	<!-- favicon -->
	<!-- ... -->

	<!-- ie -->
		<!--[if lt IE 9]>
			<script src="js/html5shiv.js" type="text/javascript"></script>
			<script src="js/respond.js" type="text/javascript"></script>
		<![endif]-->
</head>
<body>
	<header class="header">
		<div class="clearfix pull-left">
			<span class="header-logo margin-left">DVMCv3.0</span>
		</div>
	</header>
	<div class="content">
		<div class="content-heading">
		</div>
		<div class="content-inner">
			<div class="container">
				<div class="row">
					<div class="col-lg-4 col-lg-push-4 col-sm-6 col-sm-push-3 col-xs-10 col-xs-push-1">
						<div class="card-wrap">
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-inner">
											<h1 class="card-heading">Login</h1>
										</div>
									</div>
									<div class="card-inner">
										<p class="text-center">
											<span class="avatar avatar-inline avatar-lg">
												<img alt="Login" src="../theme/img/users/avatar-001.jpg" />
											</span>
										</p>
										<form class="form" runat="server">
											<div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="login-username">Tên đăng nhập</label>
														<asp:TextBox cssclass="form-control" id="login_username" runat="server" ></asp:TextBox>                                                           
													</div>
												</div>
											</div>
											<div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="login-password">Password</label>
											            <asp:TextBox cssclass="form-control" id="login_password" runat="server" TextMode="Password"></asp:TextBox>  
													</div>
												</div>
											</div>
											<div class="form-group">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<%--<label class="floating-label" for="select_chi_nhanh">Chi nhánh</label>--%>
                                                        <asp:DropDownList runat="server" cssclass="form-control" id="select_chi_nhanh">
                                                            <asp:ListItem Value="1" Text="Hà Nội" />
                                                            <asp:ListItem Value="4" Text="Ðà Nẵng" />
                                                            <asp:ListItem Value="6" Text="TP.Hồ Chí Minh" />
                                                        </asp:DropDownList>														
													</div>
												</div>
                                                <div class="row">
													<div class="col-md-10 col-md-push-1">
														<%--<label class="floating-label" for="select_chi_nhanh">Chi nhánh</label>--%>
                                                       	<asp:Label ID="m_lab_error" runat="server"></asp:Label>										
													</div>
												</div>
											</div>                                       
											<div class="form-group">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
                										<Asp:Button runat="server" ID="v_btn_su" cssclass="btn btn-block waves-attach waves-button" Text="Ðăng nhập" OnClick="Unnamed1_Click"></Asp:Button>
													</div>
												</div>
											</div>
											<%--<div class="form-group">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<div class="checkbox checkbox-adv">
															<label for="login-remember">
																<input class="access-hide" id="login-remember" name="login-remember" type="checkbox">Ghi nh? dang nh?p
																<span class="circle"></span><span class="circle-check"></span><span class="circle-icon icon">done</span>
															</label>
														</div>
													</div>
												</div>
											</div>--%>
										</form>
									</div>
								</div>
							</div>
						</div>						
					</div>
				</div>
			</div>
		</div>
	</div>
	<footer class="footer">
		<div class="container">
			<p>Material</p>
		</div>
	</footer>
    <script src="../Scripts/jquery.min.js"></script>
    <script src="../theme/js/base_2.min.js"></script>
</body>
</html>