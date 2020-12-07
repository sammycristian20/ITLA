<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="ReporteServiciosEntregados.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.ReporteServiciosEntregados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/FullLibraries/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.css" rel="stylesheet" />
    <link href="../Content/FullLibraries/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker.min.css" rel="stylesheet" />

    
    <link href="../Content/FullLibraries/tables/css/datatable/jquery.dataTables.min.css" rel="stylesheet" />
    <link href="../Content/FullLibraries/tables/css/datatable/dataTables.bootstrap4.min.css" rel="stylesheet" />
    
    <link href="../Content/FullLibraries/tables/css/extensions/buttons.dataTables.min.css" rel="stylesheet" />
    <link href="../Content/FullLibraries/tables/css/datatable/buttons.bootstrap4.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="card" style="min-height: 943px; background-color: #fff !important">
        <div class="card-body" style="background-color: #fff !important">
            <div class="card-block" style="background-color: #fff !important">
                <div class="form">
                    <div class="form-body">
                        <h4 class="form-section"><i class="icon-info"></i>Reporte de solicitudes de servicios PENDIENTES</h4>                        
                        <div style="margin-top: 5px; margin-bottom: 5px;">
                            <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
                        </div>
                  
                        <h4 class="form-section"><i class="icon-list"></i>Resultados</h4>
                        <div style="background-color: #fff !important">
                            <table class="table table-hover dataTable table-striped width-full" id="tablaEntregados">
                                <thead>
                                    <tr>
                                        <th>IDUsuario</th>
                                        <th>Nombre</th>
                                        <th>Corre</th>
                                        <th>IDfactura</th>
                                        <th>Fecha Solicitud</th>                                        
                                        <th>Fecha Entrega</th>
                                        
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RepeaterEntregados" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("IDUsuario") %></td>
                                                <td><%# Eval("Nombre") %></td>
                                                <td><%# Eval("correo_personal") %></td>
                                                <td><%# Eval("IDfactura") %></td>
                                                <td><%# Eval("Fecha_Solicitud", "{0:yyyy-MM-dd}") %></td>
                                                <td><%# Eval("Fecha_Entrega", "{0:yyyy-MM-dd}") %></td>
                                               >
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                </tbody>
                            </table>
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
        $(function () {

            var table = $('.table').DataTable({
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

    </script>
</asp:Content>
