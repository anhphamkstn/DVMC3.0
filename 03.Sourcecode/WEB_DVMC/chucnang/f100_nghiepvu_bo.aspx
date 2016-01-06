﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f100_nghiepvu_bo.aspx.cs" Inherits="WEB_DVMC.ht.f100_nghiepvu_bo" %>


<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta content="IE=edge" http-equiv="X-UA-Compatible">
	<meta content="initial-scale=1.0, width=device-width" name="viewport">
	<title>Tables - Material</title>

	<!-- css -->
    <link href="../Styles/css/base.min.css" rel="stylesheet" />
	<!-- css for this project -->
    <link href="../Styles/css/project.min.css" rel="stylesheet" />
	<!-- favicon -->
	<!-- ... -->

	<!-- ie -->
		<!--[if lt IE 9]>
			<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
			<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
</head>
<body class="avoid-fout page-red">
	<div class="avoid-fout-indicator avoid-fout-indicator-fixed">
		<div class="progress-circular progress-circular-center">
			<div class="progress-circular-wrapper">
				<div class="progress-circular-inner">
					<div class="progress-circular-left">
						<div class="progress-circular-spinner"></div>
					</div>
					<div class="progress-circular-gap"></div>
					<div class="progress-circular-right">
						<div class="progress-circular-spinner"></div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<header class="header header-transparent header-waterfall">
		<ul class="nav nav-list pull-left">
			<li>
				<a data-toggle="menu" href="#menu">
					<span class="icon icon-lg">menu</span>
				</a>
			</li>
		</ul>
		<a class="header-logo margin-left-no" href="index.html">Table</a>
		<div class="header-affix pull-left" data-offset-top="108" data-spy="affix">
			<span class="header-text margin-left-no">
				<i class="icon margin-right">chevron_right</i>"DVMC3.0"
			</span>
		</div>
		<ul class="nav nav-list pull-right">
			<li>
				<a data-toggle="menu" href="#profile">
					<span class="access-hide">John Smith</span>
					<span class="avatar"><img alt="alt text for John Smith avatar"  src="../img/users/avatar-001.jpg" /></span>
				</a>
			</li>
		</ul>
	</header>
	<nav aria-hidden="true" class="menu" id="menu" tabindex="-1">
		<div class="menu-scroll">
			<div class="menu-content">
				<a class="menu-logo" href="index.html">DVMC3.0</a>
				<ul class="nav">
					<li>
						<a class="waves-attach" href="ui-card.html">Cards</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-collapse.html">Collapsible Regions</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-dropdown.html">Dropdowns</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-modal.html">Modals &amp; Toasts</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-nav.html">Navs</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-progress.html">Progress Bars</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-tab.html">Tabs</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-tile.html">Tiles</a>
					</li>
				</ul>
				<hr>
				<ul class="nav">
					<li>
						<a class="waves-attach" href="ui-button.html">Buttons</a>
					</li>
					<li>
						<a class="waves-attach" href="ui-form.html">Form Elements</a>
						<span class="menu-collapse-toggle collapsed waves-attach" data-target="#form-elements" data-toggle="collapse"><i class="icon menu-collapse-toggle-close">close</i><i class="icon menu-collapse-toggle-default">add</i></span>
						<ul class="menu-collapse collapse" id="form-elements">
							<li>
								<a class="waves-attach" href="ui-form-adv.html">Form Elements <small>(materialised)</small></a>
							</li>
						</ul>
					</li>
					<li>
						<a class="waves-attach" href="ui-icon.html">Icons</a>
					</li>
					<li class="active">
						<a class="waves-attach" href="ui-table.html">Tables</a>
					</li>
				</ul>
				<hr>
				<ul class="nav">
					<li>
						<a class="waves-attach" href="page-palette.html">Page Palettes</a>
						<span class="menu-collapse-toggle collapsed waves-attach" data-target="#page-palettes" data-toggle="collapse"><i class="icon menu-collapse-toggle-close">close</i><i class="icon menu-collapse-toggle-default">add</i></span>
						<ul class="menu-collapse collapse" id="page-palettes">
							<li>
								<a class="waves-attach" href="page-palette-brand.html">Brand Palette</a>
							</li>
							<li>
								<a class="waves-attach" href="page-palette-brand-accent.html">Accent Palette</a>
							</li>
							<li>
								<a class="waves-attach" href="page-palette-amber.html">Amber Palette</a>
							</li>
							<li>
								<a class="waves-attach" href="page-palette-green.html">Green Palette</a>
							</li>
							<li>
								<a class="waves-attach" href="page-palette-red.html">Red Palette</a>
							</li>
						</ul>
					</li>
				</ul>
			</div>
		</div>
	</nav>
	<nav aria-hidden="true" class="menu menu-right" id="profile" tabindex="-1">
		<div class="menu-scroll">
			<div class="menu-top">
				<div class="menu-top-img">
                    <img  alt="John Smith" src="../img/samples/landscape.jpg" />
				</div>
				<div class="menu-top-info">
					<a class="menu-top-user" href="javascript:void(0)"><span class="avatar pull-left">
                        <img alt="alt text for John Smith avatar"  src="../img/users/avatar-001.jpg" /></span>John Smith</a>
				</div>
				<div class="menu-top-info-sub">
					<small>Some additional information about John Smith</small>
				</div>
			</div>
			<div class="menu-content">
				<ul class="nav">
					<li>
						<a class="waves-attach" href="javascript:void(0)"><span class="icon icon-lg">account_box</span>Profile Settings</a>
					</li>
					<li>
						<a class="waves-attach" href="javascript:void(0)"><span class="icon icon-lg">add_to_photos</span>Upload Photo</a>
					</li>
					<li>
                        <a class="waves-attach" href="f000_login.aspx">f000_login.aspx<span class="icon icon-lg">exit_to_app</span>Đăng xuất</a>
					</li>
				</ul>
			</div>
		</div>
	</nav>
	<div class="content">
		<div class="content-heading">
			<div class="container">
				<h1 id="h1_ten_form" class="heading">Đơn hàng cần tiếp nhận</h1>
			</div>
		</div>
		<div class="container">
			<div class="row">
				<div class="col-lg-8 col-md-10">
					<section class="content-inner">
						<h2 class="content-sub-heading">Đơn hàng cần tiếp nhận</h2>
						<div class="table-responsive">
							<table class="table" title="Đơn hàng cần tiếp nhận">
								<thead>
									<tr>
										<th>User</th>
										<th>Yêu cầu</th>
										<th>Deadline</th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td>Id augue sagittis</td>
										<td>Eleifend metus eget</td>
										<td>Lacinia eros curabitur</td>
									</tr>
									<tr>
										<td>Ac ultrices tortor</td>
										<td>Nunc pellentesque est</td>
										<td>Et velit condimentum</td>
									</tr>
									<tr>
										<td>Convallis etiam sit</td>
										<td>Amet augue eu</td>
										<td>Turpis tempor consectetur</td>
									</tr>
									<tr>
										<td>Suspendisse potenti proin</td>
										<td>Molestie odio volutpat</td>
										<td>Risus tristique euismod</td>
									</tr>
									<tr>
										<td>Vitae eu felis</td>
										<td>Donec ac interdum</td>
										<td>Purus ac vestibulum</td>
									</tr>
									<tr>
										<td>Enim donec venenatis</td>
										<td>Pellentesque ante non</td>
										<td>Faucibus suspendisse potenti</td>
									</tr>
									<tr>
										<td>Cras egestas ac</td>
										<td>Nibh at ornare</td>
										<td>Aliquam quis sapien</td>
									</tr>
									<tr>
										<td>Et est imperdiet</td>
										<td>Tempus proin viverra</td>
										<td>Semper felis iaculis</td>
									</tr>
									<tr>
										<td>Sagittis ex luctus</td>
										<td>A duis mollis</td>
										<td>Nulla non tristique</td>
									</tr>
								</tbody>
							</table>
						</div>
						
					</section>
				</div>
			</div>
		</div>
	</div>
	<footer class="footer">
		<div class="container">
			<p>Material</p>
		</div>
	</footer>
	<div class="fbtn-container">
		<div class="fbtn-inner">
			<a class="fbtn fbtn-brand-accent fbtn-lg" data-toggle="dropdown"><span class="fbtn-text">Links</span><span class="fbtn-ori icon">add</span><span class="fbtn-sub icon">close</span></a>
			<div class="fbtn-dropdown">
				<a class="fbtn" href="https://github.com/Daemonite/material" target="_blank"><span class="fbtn-text">Fork me on GitHub</span><span class="fa fa-github"></span></a>
				<a class="fbtn fbtn-blue" href="https://twitter.com/daemonites" target="_blank"><span class="fbtn-text">Follow Daemon on Twitter</span><span class="fa fa-twitter"></span></a>
				<a class="fbtn fbtn-alt" href="http://www.daemon.com.au/" target="_blank"><span class="fbtn-text">Visit Daemon Website</span><span class="icon">link</span></a>
			</div>
		</div>
	</div>

	<!-- js -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="../Scripts/js/base.min.js"></script>
	<!-- js for this project -->
    <script src="../Scripts/js/project.min.js"></script>
</body>
</html>
