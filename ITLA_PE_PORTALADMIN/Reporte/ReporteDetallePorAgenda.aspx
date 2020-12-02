<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="ReporteDetallePorAgenda.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.Reporte.ReporteDetallePorAgenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../Content/FullLibraries/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.css" rel="stylesheet" />
    <link href="../Content/FullLibraries/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker.min.css" rel="stylesheet" />

    
    <link href="../Content/FullLibraries/tables/css/datatable/jquery.dataTables.min.css" rel="stylesheet" />
    <link href="../Content/FullLibraries/tables/css/datatable/dataTables.bootstrap4.min.css" rel="stylesheet" />
    
    <link href="../Content/FullLibraries/tables/css/extensions/buttons.dataTables.min.css" rel="stylesheet" />
    <link href="../Content/FullLibraries/tables/css/datatable/buttons.bootstrap4.min.css" rel="stylesheet" />


    <%--<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/bs/dt-1.10.22/datatables.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/buttons/1.6.4/css/buttons.dataTables.min.css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="min-height: 943px; background-color: #fff !important">
        <div class="card-body" style="background-color: #fff !important">
            <div class="card-block" style="background-color: #fff !important">
                <div class="form">
                    <div class="form-body">
                        <h4 class="form-section"><i class="icon-info"></i>Agendatos para la fecha: </h4>
                        <asp:TextBox ID="txtFileID" runat="server" ClientIDMode="Static" Style="display: none"></asp:TextBox>
                        <div style="margin-top: 5px; margin-bottom: 5px;">
                            <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
                        </div>
                       
                        <h4 class="form-section"><i class="icon-list"></i>Resultados</h4>
                        <div style="background-color: #fff !important">
                            <asp:Literal ID="LiteralTable" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <script src="../Content/FullLibraries/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>

    
    <script src="../Content/FullLibraries/tables/js/jquery.dataTables.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/datatable/dataTables.bootstrap4.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/datatable/dataTables.buttons.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/jszip.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/pdfmake.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/buttons.html5.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/buttons.flash.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/buttons.print.min.js"></script>
    <script src="../Content/FullLibraries/tables/js/vfs_fonts.js"></script>


    <script>
        $(document).ready(function () {


            

            $('.date').datepicker({
                clearBtn: true,
                autoclose: true,
                format: 'dd/mm/yyyy'
            });

            $(function () {

                var table = $('#basicTable').DataTable({
                    dom: 'Bfrtip',
                    "iDisplayLength": 20,
                    buttons: [
                        'copyHtml5',
                        'excelHtml5',
                        'csvHtml5',
                        'pdfHtml5'
                    ]
                });
            });

        });
    </script>
</asp:Content>
