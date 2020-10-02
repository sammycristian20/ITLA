<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="DashboardJueventud.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.DashboardJueventud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/modules/data.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/accessibility.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row mt-3">
        <!-- Column -->
        <div class="col col-lg-12 col-xlg-12 col-md-12">
            <!-- Column -->
            <div class="card">
                <div class="container-fluid">

                    <div class="row">
                        <div class="col col-lg-12">
                            <section id="inputs" class="text-center">
                                <!--Section heading-->
                                <h3 class="section-heading mb-1 h1 mt-4 text-left">Dashboard Solicitudes Proyecto ITLA - Juventud 2020
                                </h3>

                                <br />
                                <div></div>
                                <div class="row">


                                    <div class="col-xl-3 col-md-6 mb-4">
                                        <div class="card border-left-primary bg-itla-1 h-100 py-2 text-left border-0">
                                            <div class="card-body">
                                                <div class="row no-gutters align-items-center">
                                                    <div class="col mr-2">
                                                        <div class="text-xs text-white text-uppercase mb-1">Total de Solicitudes</div>
                                                        <div class="h3 mb-0 font-weight-bold text-white">
                                                            <asp:Literal ID="literalTotalSolicitudes" runat="server"></asp:Literal>
                                                        </div>
                                                    </div>
                                                    <div class="col-auto">
                                                        <i class="fas fa-users fa-2x text-white"></i>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-md-6 mb-4">
                                        <div class="card border-left-primary bg-itla-2 h-100 py-2 text-left border-0">
                                            <div class="card-body">
                                                <div class="row no-gutters align-items-center">
                                                    <div class="col mr-2">
                                                        <div class="text-xs text-white text-uppercase mb-1">Total Gran Santo Domingo</div>
                                                        <div class="h3 mb-0 font-weight-bold text-white"><asp:Literal ID="literalTotalSolicitudesGS" runat="server"></asp:Literal></div>
                                                    </div>
                                                    <div class="col-auto">
                                                        <i class="fas fa-inbox fa-2x text-white"></i>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-md-6 mb-4">
                                        <div class="card border-left-primary bg-itla-3 h-100 py-2 text-left border-0">
                                            <div class="card-body">
                                                <div class="row no-gutters align-items-center">
                                                    <div class="col mr-2">
                                                        <div class="text-xs text-white text-uppercase mb-1">Total El Interior</div>
                                                        <div class="h3 mb-0 font-weight-bold text-white"><asp:Literal ID="literalNOGS" runat="server"></asp:Literal></div>
                                                    </div>
                                                    <div class="col-auto">
                                                        <i class="fas fa-sign-out-alt fa-2x text-white"></i>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-xl-3 col-md-6 mb-4">
                                        <div class="card border-left-primary bg-itla-4 h-100 py-2 text-left border-0">
                                            <div class="card-body">
                                                <div class="row no-gutters align-items-center">
                                                    <div class="col mr-2">
                                                        <div class="text-xs text-white text-uppercase mb-1">Total Aprobadas</div>
                                                        <div class="h3 mb-0 font-weight-bold text-white"><asp:Literal ID="literalAprobadas" runat="server" Text="0"></asp:Literal></div>
                                                    </div>
                                                    <div class="col-auto">
                                                        <i class="fas fa-check-double fa-2x text-white"></i>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-8">
                                        <div class="row">
                                            <div class="col-12">
                                                <div id="containerProvincia"></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <div class="row">
                                            <div class="col-12">
                                                <div id="containerProvincia2"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-lg-8">
                                        <div class="row">
                                            <div class="col-12">
                                                <div id="container"></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <div class="row">
                                            <div class="col-12">
                                                <div id="containerDIA"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                 

                            </section>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>






    <table id="datatable" style="display: none">
        <thead>
            <tr>
                <th>Materia</th>
                <th>Solicitudes</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterMaterias" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%# Eval("Materia") %></th>
                        <td><%# Eval("Cantidad") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

    <table id="datatableProvincia" style="display: none">
        <thead>
            <tr>
                <th>Provincia</th>
                <th>Solicitudes</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterProvincias" runat="server">
                <ItemTemplate>
                    <itemtemplate>
                    <tr>
                        <th><%# Eval("Provincia") %></th>
                        <td><%# Eval("Cantidad") %></td>
                    </tr>
                </itemtemplate>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

    
    <table id="datatableDia" style="display: none">
        <thead>
            <tr>
                <th>Dia</th>
                <th>Solicitudes</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterDia" runat="server">
                <ItemTemplate>
                    <itemtemplate>
                    <tr>
                        <th><%# Eval("Fecha") %></th>
                        <td><%# Eval("Cantidad") %></td>
                    </tr>
                </itemtemplate>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <script language="javascript">
        setInterval(function () {
            window.location.reload(1);
        }, 60000);
    </script>

    <script>


        Highcharts.chart('containerDIA', {
            data: {
                table: 'datatableDia'
            },
            chart: {
                type: 'column'
            },
            title: {
                text: 'Solicitudes por Dia'
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Solicitudes',
                    align: 'high'
                },
                labels: {
                    overflow: 'justify'
                }
            },
            tooltip: {
                valueSuffix: ' '
            },
            plotOptions: {
                column: {
                    dataLabels: {
                        enabled: true
                    }
                }
            },
            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'top',
                x: -40,
                y: 80,
                floating: true,
                borderWidth: 1,
                backgroundColor:
                    Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF',
                shadow: true
            },
            tooltip: {
                formatter: function () {
                    return '<b>' + this.series.name + '</b><br/>' +
                        this.point.y + ' ' + this.point.name.toLowerCase();
                }
            }
        });


        Highcharts.chart('container', {
            data: {
                table: 'datatable'
            },
            chart: {
                type: 'column'
            },
            title: {
                text: 'Solicitudes por Materia'
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Solicitudes',
                    align: 'high'
                },
                labels: {
                    overflow: 'justify'
                }
            },
            tooltip: {
                valueSuffix: ' '
            },
            plotOptions: {
                column: {
                    dataLabels: {
                        enabled: true
                    }
                }
            },
            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'top',
                x: -40,
                y: 80,
                floating: true,
                borderWidth: 1,
                backgroundColor:
                    Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF',
                shadow: true
            },
            tooltip: {
                formatter: function () {
                    return '<b>' + this.series.name + '</b><br/>' +
                        this.point.y + ' ' + this.point.name.toLowerCase();
                }
            }
        });

        Highcharts.chart('containerProvincia', {
            data: {
                table: 'datatableProvincia'
            },
            chart: {
                type: 'column'
            },
            title: {
                text: 'Solicitudes por Provincia'
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Solicitudes',
                    align: 'high'
                },
                labels: {
                    overflow: 'justify'
                }
            },
            tooltip: {
                valueSuffix: ' '
            },
            plotOptions: {
                column: {
                    dataLabels: {
                        enabled: true
                    }
                }
            },
            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'top',
                x: -40,
                y: 80,
                floating: true,
                borderWidth: 1,
                backgroundColor:
                    Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF',
                shadow: true
            },
            tooltip: {
                formatter: function () {
                    return '<b>' + this.series.name + '</b><br/>' +
                        this.point.y + ' ' + this.point.name.toLowerCase();
                }
            }
        });


        Highcharts.chart('containerProvincia2', {
            data: {
                table: 'datatableProvincia'
            },
            chart: {
                type: 'pie'
            },
            title: {
                text: 'Solicitudes por Provincia'
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Solicitudes',
                    align: 'high'
                },
                labels: {
                    overflow: 'justify'
                }
            },
            tooltip: {
                valueSuffix: ' '
            },
            plotOptions: {
                pie: {
                    dataLabels: {
                        enabled: true
                    }
                }
            },
            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'top',
                x: -40,
                y: 80,
                floating: true,
                borderWidth: 1,
                backgroundColor:
                    Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF',
                shadow: true
            },
            tooltip: {
                formatter: function () {
                    return '<b>' + this.series.name + '</b><br/>' +
                        this.point.y + ' ' + this.point.name.toLowerCase();
                }
            }
        });

    </script>
</asp:Content>
