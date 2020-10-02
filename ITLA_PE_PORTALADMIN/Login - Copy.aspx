<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.Login" %>

<!doctype html>
<html class="no-js" lang="">

<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>ITLA - ORBI ADMINISTRATIVO 2020</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Favicon -->
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.png">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="xmee-main/css/bootstrap.min.css">
    <!-- Fontawesome CSS -->
    <link rel="stylesheet" href="xmee-main/css/fontawesome-all.min.css">
    <!-- Flaticon CSS -->
    <link rel="stylesheet" href="xmee-main/font/flaticon.css">
    <!-- Google Web Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" rel="stylesheet">
    <!-- Custom CSS -->
    <link rel="stylesheet" href="xmee-main/style.css">

    <link href="Content/css/colors.css" rel="stylesheet" />

    <style>
        label {
            font-weight: bold;
            color: black;
        }
    </style>
</head>

<body>
    <!--[if lt IE 8]>
        <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->
    <section class="fxt-template-animation fxt-template-layout4">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-6 col-12 fxt-bg-wrap">
                    <div class="fxt-bg-img" data-bg-image="xmee-main/img/figure/bg4-l.jpg">
                        <div class="fxt-header">
                            <div class="fxt-transformY-50 fxt-transition-delay-1">
                                <a href="login-4.html" class="fxt-logo">
                                    <img src="xmee-main/img/logo-4.png" alt="Logo"></a>
                            </div>
                            <div class="fxt-transformY-50 fxt-transition-delay-2">
                                <h1>Welcome To Our xmee</h1>
                            </div>
                            <div class="fxt-transformY-50 fxt-transition-delay-3">
                                <p>Grursus mal suada faci lisis Lorem ipsum dolarorit more ametion consectetur elit. Vesti at bulum nec odio aea the dumm ipsumm ipsum that dolocons rsus mal suada and fadolorit to the dummy consectetur elit the Lorem Ipsum genera.</p>
                            </div>
                        </div>
                        <ul class="fxt-socials">
                            <li class="fxt-facebook fxt-transformY-50 fxt-transition-delay-4"><a href="#"
                                title="Facebook"><i class="fab fa-facebook-f"></i></a></li>
                            <li class="fxt-twitter fxt-transformY-50 fxt-transition-delay-5"><a href="#" title="twitter"><i
                                class="fab fa-twitter"></i></a></li>
                            <li class="fxt-google fxt-transformY-50 fxt-transition-delay-6"><a href="#" title="google"><i
                                class="fab fa-google-plus-g"></i></a></li>
                            <li class="fxt-linkedin fxt-transformY-50 fxt-transition-delay-7"><a href="#"
                                title="linkedin"><i class="fab fa-linkedin-in"></i></a></li>
                            <li class="fxt-youtube fxt-transformY-50 fxt-transition-delay-8"><a href="#" title="youtube"><i class="fab fa-youtube"></i></a></li>
                        </ul>
                    </div>
                </div>
                <div class="col-md-6 col-12 fxt-bg-color">
                    <div class="fxt-content">
                        <div class="fxt-form">
                            <form id="form1" runat="server">
                                <div class="form-group">
                                    <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
                                    </div>
                                <div class="form-group">
                                    <label for="email" class="input-label">Nombre de Usuario</label>
                                    <asp:TextBox ID="txtNombreUsuario" CssClass="form-control" runat="server" placeholder="demo@gmail.com" required="required"  ClientIDMode="Static"></asp:TextBox>                                    
                                    
                                </div>
                                <div class="form-group">
                                    <label for="password" class="input-label">Password</label>
                                    <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" placeholder="*****" required="required" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                                    
                                </div>
                              <%--  <div class="form-group">
                                    <div class="fxt-checkbox-area">
                                        <div class="checkbox">
                                            <input id="checkbox1" type="checkbox">
                                            <label for="checkbox1">Keep me logged in</label>
                                        </div>
                                        <a href="forgot-password-4.html" class="switcher-text">Forgot Password</a>
                                    </div>
                                </div>--%>
                                <div class="form-group">
                                    <asp:Button ID="btnEntrar" runat="server" CssClass="fxt-btn-fill" Text="Entrar" style="background-color: #023877" OnClick="btnEntrar_Click"/>
                                </div>
                            </form>
                        </div>
                        <div class="fxt-footer">
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- jquery-->
    <script src="xmee-main/js/jquery-3.5.0.min.js"></script>
    <!-- Popper js -->
    <script src="xmee-main/js/popper.min.js"></script>
    <!-- Bootstrap js -->
    <script src="xmee-main/js/bootstrap.min.js"></script>
    <!-- Imagesloaded js -->
    <script src="xmee-main/js/imagesloaded.pkgd.min.js"></script>
    <!-- Validator js -->
    <script src="xmee-main/js/validator.min.js"></script>
    <!-- Custom Js -->
    <script src="xmee-main/js/main.js"></script>

</body>

</html>

<!DOCTYPE html>

<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>--%>
