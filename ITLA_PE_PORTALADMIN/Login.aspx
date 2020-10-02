<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.Login" %>

<!doctype html>
<html lang="en">


<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="Amaury Mateo">
    <title>Dashboard Itla</title>

    <!-- Bootstrap core CSS -->
    <link rel="stylesheet" href="Content/Login/css/bootstrap.css">
    <link rel="stylesheet" href="Content/Login/css/bootstrap-grid.min.css">
    <!-- <link rel="stylesheet" href="Content/Login/css/bootstrap-extended.min.css"> -->

    <!-- MDB core CSS -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap">

    <!-- fontawesome icons -->
    <link rel="stylesheet" href="Content/Login/css/fontawesome.css">
    <link rel="stylesheet" href="Content/Login/css/brands.css">
    <%--<link rel="stylesheet" href="Content/Login/css/solid.css">--%>
    <!-- <link rel="stylesheet" href="Content/Login/css/simple-line-icons.css"> -->
    <link rel="stylesheet" href="Content/Login/css/simple-line-icons.min.css">
    <link rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/simple-line-icons/2.5.5/css/simple-line-icons.css" />
    <!-- <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/simple-line-icons/2.5.5/css/simple-line-icons.min.css" integrity="sha512-QKC1UZ/ZHNgFzVKSAhV5v5j73eeL9EEN289eKAEFaAjgAiobVAnVv/AGuPbXsKl1dNoel3kNr6PYnSiTzVVBCw==" crossorigin="anonymous" /> -->

    <!-- custom style for this template -->
    <link rel="stylesheet" href="Content/Login/css/itla-dashboard.css">

    <link rel="icon" type="image/png" href="Content/Login/images/icons/favicon.ico" />
    <link rel="stylesheet" type="text/css" href="Content/Login/font/font-awesome.min.css">
    <link rel="stylesheet" type="text/css" href="Content/Login/font/icon-font.min.css">
    <link rel="stylesheet" type="text/css" href="Content/Login/css/select2.min.css">
    <link rel="stylesheet" type="text/css" href="Content/Login/css/util.css">
    <link rel="stylesheet" type="text/css" href="Content/Login/css/main.css">

    <script type="text/javascript" src="Content/Login/js/jquery-3.5.1.min.js"></script>
    <script type="text/javascript" src="Content/Login/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="Content/Login/js/bootstrap.bundle.min.js"></script>
    <script type="text/javascript" src="Content/Login/js/mdb.min.js"></script>
    <script type="text/javascript" src="Content/Login/js/popper.min.js"></script>
    <script type="text/javascript" src="Content/Login/js/fontawesome.js"></script>
    <script type="text/javascript" src="Content/Login/js/app-menu.min.js"></script>
    <script type="text/javascript" src="Content/Login/js/vendors.min.js"></script>
    <script src="Content/Login/js/select2.min.js"></script>
    <script src="Content/Login/js/main.js"></script>
</head>

<body>
    <form id="form2" runat="server">
        <div class="limiter">
            <div class="container-login100" style="background-image: url('Content/Login/images/background.png');">
                <div class="wrap-login100 p-t-80 p-b-30">
                    <div class="login100-form validate-form">
                        <div class="form-group">
                            <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
                        </div>

                        <div class="login100-form-avatar mb-5">
                            <img src="Content/Login/images/Logo-ITLA.png" alt="Logo">
                        </div>

                        <div class="wrap-input100 validate-input mb-3" data-validate="Username is required">
                            <asp:TextBox ID="txtNombreUsuario" CssClass="input100" runat="server" placeholder="Nombre de usuario" required="required" ClientIDMode="Static"></asp:TextBox>
                                                        
                            <span class="focus-input100"></span>
                            <span class="symbol-input100">
                                <i class="fas fa-user"></i>
                            </span>
                        </div>

                        <div class="wrap-input100 validate-input  mb-3" data-validate="Password is required">
                            <%--<input class="" type="password" name="pass" placeholder="Password">--%>
                            <asp:TextBox ID="txtPassword" CssClass="input100" runat="server" placeholder="*****" required="required" TextMode="Password" ClientIDMode="Static"></asp:TextBox>

                            <span class="focus-input100"></span>
                            <span class="symbol-input100">
                                <i class="fas fa-lock"></i>
                            </span>
                        </div>

                        <div class="container-login100-form-btn pt-4">

                            <asp:Button ID="btnEntrar" runat="server" CssClass="login100-form-btn" Text="Entrar" OnClick="btnEntrar_Click" />


                        </div>

                        <div class="text-center w-full p-t-25 p-b-10">
                            <a href="#" class="txt1">Olvidó su Usuario / Contraseña?
                            </a>
                        </div>

                        <div class="text-center w-full">
                            <a class="txt1" href="#">Crear una cuenta nueva
							<i class="fas fa-arrow-right"></i>
                            </a>
                        </div>
                    </div>
                </div>
                <div id="animate-area">
			
			</div>
            </div>
        </div>


     

    </form>
</body>
