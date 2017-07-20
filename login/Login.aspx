<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Job Portal Admin Panel</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Minion Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Bootstrap Core CSS -->
<link href="css/bootstrap.min.css" rel='stylesheet' type='text/css' />
<!-- Custom CSS -->
<link href="css/style1.css" rel='stylesheet' type='text/css' />
<!-- Graph CSS -->
<link href="css/font-awesome.css" rel="stylesheet"> 
<!-- jQuery -->
<link href='http://localhost:17662/fonts.googleapis.com/css?family=Roboto:700,500,300,100italic,100,400' rel='stylesheet' type='text/css'/>
<link href='http://localhost:17662/fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
<!-- lined-icons -->
<link rel="stylesheet" href="css/icon-font.min.css" type='text/css' />
<script src="js/amcharts.js"></script>	
<script src="js/serial.js"></script>	
<script src="js/light.js"></script>	
<!-- //lined-icons -->
<script src="js/jquery-1.10.2.min.js"></script>
   <!--pie-chart--->
<script src="js/pie-chart.js" type="text/javascript"></script>
 <script type="text/javascript">

     $(document).ready(function () {
         $('#demo-pie-1').pieChart({
             barColor: '#3bb2d0',
             trackColor: '#eee',
             lineCap: 'round',
             lineWidth: 8,
             onStep: function (from, to, percent) {
                 $(this.element).find('.pie-value').text(Math.round(percent) + '%');
             }
         });

         $('#demo-pie-2').pieChart({
             barColor: '#fbb03b',
             trackColor: '#eee',
             lineCap: 'butt',
             lineWidth: 8,
             onStep: function (from, to, percent) {
                 $(this.element).find('.pie-value').text(Math.round(percent) + '%');
             }
         });

         $('#demo-pie-3').pieChart({
             barColor: '#ed6498',
             trackColor: '#eee',
             lineCap: 'square',
             lineWidth: 8,
             onStep: function (from, to, percent) {
                 $(this.element).find('.pie-value').text(Math.round(percent) + '%');
             }
         });


     });

    </script>
</head>
<body>
    
    <form id="form1" runat="server">
    
    
	<div class="registration_left">
		<h2>Admin Login</h2>
		 <div class="registration_form">
          
				
					<label>
                        <asp:TextBox ID="txtemail" placeholder="email:" runat="server" required=""></asp:TextBox>
						
					</label>
				
				<div>
					<label>
                        <asp:TextBox ID="txtpassword"  placeholder="password" runat="server"  required="" TextMode="Password" ></asp:TextBox>
						
					</label>
				</div>						
				<div>
                    <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click1"  />
					
				</div>
				<div class="forget">
					<a href="forget.aspx">forgot your password</a>
				</div>
             <div>
                 <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
             </div>
			
			<!-- /Form -->
		
	<div class="clearfix"></div>
	</div>

   
    </form>
</body>
</html>
