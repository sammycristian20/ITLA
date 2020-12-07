<%@ Page Title="" Language="C#" MasterPageFile="~/Dialogs/SiteDialog.Master" AutoEventWireup="true" CodeBehind="EntregarServisioAEstudiante.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.Dialogs.EntregarServisioAEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        label{ 
            font-weight:bold;
        }
    </style>
    <link href="../Content/FullLibraries/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker.css" rel="stylesheet" />
    <script src="../Content/FullLibraries/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <asp:ValidationSummary ID="ValidationSummary1" runat="server"  ShowMessageBox="true" ShowSummary="false"  />

        <div class="form-group">
            <label for="exampleInputEmail1">Nombre</label>            
            <asp:TextBox ID="Nombre" runat="server" CssClass="form-control"  ReadOnly="true"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Apellido</label>
            <asp:TextBox ID="Apellido" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleInputPassword1">Matricula</label>
            <asp:TextBox ID="Matricula" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleInputPassword1">Servicio</label>
            <asp:TextBox ID="Servicio" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleInputPassword1">Fecha de Entrega
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fecha de Entrega es Requerida" Text="*" ForeColor="Red" ControlToValidate="FechaEntrega">
                </asp:RequiredFieldValidator>
            </label>
            <asp:TextBox ID="FechaEntrega" runat="server" CssClass="form-control date" ></asp:TextBox>
        </div>

             <div class="form-group">
            <label for="exampleInputPassword1">Comentario
               
            </label>
            <asp:TextBox ID="Comentario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>


        <asp:Button ID="btnSave" runat="server" Text="Guardar" CssClass="btn btn-primary"  OnClick="btnSave_Click"/>

        
    </div>

    <script>
        $(document).ready(function () {

            
            $('.date').datepicker({
                clearBtn: true,
                autoclose: true,
                format: "dd/mm/yyyy",
                todayHighlight: true
            });

        });
    </script>
</asp:Content>
