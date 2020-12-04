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
    <asp:ValidationSummary ID="ValidationSummary1" runat="server"  ShowMessageBox="true" ShowSummary="false"  />
    <div class="card" style="min-height: 943px; background-color: #fff !important">
        <div class="card-body" style="background-color: #fff !important">
            <div class="card-block" style="background-color: #fff !important">
                <div class="form">
                    <div class="form-body">
                        <h4 class="form-section"><i class="icon-info"></i>Reporte de Servicios Entregados</h4>
                        <div style="margin-top: 5px; margin-bottom: 5px;">
                            <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-4">
                                    <label for="userinput1">Fecha desde<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fecha desde es Requerida" Text="*" ForeColor="Red" ControlToValidate="FechaDesde">
                                    </asp:RequiredFieldValidator></label>
                                    <asp:TextBox ID="FechaDesde" runat="server" CssClass="form-control date"></asp:TextBox>
                                </div>
                                <div class="form-group col-md-4">
                                    <label for="userinput2">Fecha hasta<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fecha hasta es Requerida" Text="*" ForeColor="Red" ControlToValidate="FechaHasta">
                                    </asp:RequiredFieldValidator></label>
                                    <asp:TextBox ID="FechaHasta" runat="server" CssClass="form-control date"></asp:TextBox>
                                </div>
                            
                                <div class="form-group col-md-4">
                                    <label for="exampleInputPassword1">
                                        &nbsp;
                                        

                                    </label>
                                    <br />
                                    <asp:Button ID="btmBuscar" runat="server" Text="Buscar" CssClass="btn btn-sm btn-success btn-block" CausesValidation="true" OnClick="btmBuscar_Click" />

                                </div>

<%--                            <div class="row">
                                <div class="col-md-12">
                                    <label for="exampleInputPassword1">
                                        Fecha Desde
                                    
                                    </label>
                                    

                                </div>

                                <div class="col-md-12">
                                    <label for="exampleInputPassword1">
                                        Fecha Hasta
                                    
                                    </label>
                                    

                                </div>


                            </div>--%>

                        </div>

                        <h4 class="form-section"><i class="icon-list"></i>Resultados</h4>
                        <div style="background-color: #fff !important">
                            <table class="table table-hover dataTable table-striped width-full" id="tablaEntregados">
                                <thead>
                                    <tr>

                                        <th>Realizado por</th>
                                        <th>Fecha Entrega</th>
                                        <th>IDfactura</th>
                                        <th>Matricula</th>
                                        <th>Estudiante</th>
                                        <th>Correo</th>
                                        

                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RepeaterEntregados" runat="server">
                                        <ItemTemplate>
                                            <tr>

                                                <td><%# Eval("Usuario") %></td>
                                                <td><%# Eval("FechaEntrega", "{0:yyyy-MM-dd}") %></td>
                                                <td><%# Eval("IDfactura") %></td>
                                                <td><%# Eval("Matricula") %></td>
                                                <td><%# Eval("estudiante") %></td>
                                                <td><%# Eval("correo_institucional") %></td>
                                               
                                                
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

            $('.date').datepicker({
                clearBtn: true,
                autoclose: true,
                format: "dd/mm/yyyy",
                todayHighlight: true
            });


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
