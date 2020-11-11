<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="ReporteDetalleIntencion.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.Reporte.ReporteDetalleIntencion" %>

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
                        <h4 class="form-section"><i class="icon-info"></i>Reporte de solicitudes de Intención</h4>
                        <asp:TextBox ID="txtFileID" runat="server" ClientIDMode="Static" Style="display: none"></asp:TextBox>
                        <div style="margin-top: 5px; margin-bottom: 5px;">
                            <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
                        </div>
                        <div class="row">

                            <div class="col-md-1">
                                <div class="form-group">
                                    <label for="projectinput2">Desde:</label>
                                </div>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="txtDateFrom" runat="server" CssClass="form-control date" ClientIDMode="Static"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <div class="form-group">
                                    <label for="projectinput2">Hasta:</label>
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <asp:TextBox ID="txtDateTo" runat="server" CssClass="form-control date" ClientIDMode="Static"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="form-group">
                                    <asp:Button ID="ButtonSearch" runat="server" Text="BUSCAR" CssClass="btn btn-success btn-block" ClientIDMode="Static" OnClick="ButtonSearch_Click" />
                                </div>
                            </div>
                        </div>
                        <h4 class="form-section"><i class="icon-list"></i>Resultados</h4>
                        <div style="background-color: #fff !important">
                            <table class="table table-hover dataTable table-striped width-full" id="users-contacts">
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Provincia</th>
                                        <th>Fecha</th>
                                        <th>Email</th>
                                        <th>Nombre</th>
                                        <th>Apellido</th>
                                        <th>Tel. Residencial</th>
                                        <th>Tel. Celular</th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RepeaterDates" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("CodigoIntencion") %></td>
                                                <td><%# Eval("Provincia") %></td>
                                                <td><%# Eval("FechaCreacion") %></td>
                                                <td><%# Eval("Email") %></td>
                                                <td><%# Eval("NOMBRE") %></td>
                                                <td><%# Eval("APELLIDO") %></td>
                                                <td><%# Eval("TelResidencial") %></td>
                                                <td><%# Eval("TelCelular") %></td>
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
        $(document).ready(function () {


            

            $('.date').datepicker({
                clearBtn: true,
                autoclose: true,
                format: 'dd/mm/yyyy'
            });

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

        });
    </script>
</asp:Content>
