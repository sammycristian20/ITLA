<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="DashboardServiciosRegistro.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.DashboardServiciosRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/export-data.js"></script>
    <script src="https://code.highcharts.com/modules/accessibility.js"></script>
    <script src="https://code.highcharts.com/modules/data.js"></script>
    <link href="Content/css/colors.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- Content here -->
    <!-- Content here -->
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
                                <h3 class="section-heading mb-1 h1 mt-4 text-left">Dashboard Servicios Registro
                                    
                                </h3>
                                <div class="row">

                                    <div class="col-lg-12">
                                        <div class="row">
                                            <div class="col-12">
                                                <div class="card">
                                                    <div class="card-content">
                                                        <div class="card-body">
                                                           <%-- <div class="row">

                                                                <div class="col-lg-4 col-sm-12 border-right-blue-grey border-right-lighten-5">
                                                                    <div class="card border-left-primary bg-itla-4 h-100 py-2 text-left border-0">
                                                                        <div class="card-body">
                                                                            <div class="row no-gutters align-items-center">
                                                                                <div class="col mr-2">
                                                                                    <div class="text-xs text-white text-uppercase mb-1">Nuevo ingreso</div>
                                                                                    <div class="h3 mb-0 font-weight-bold text-white">
                                                                                        <asp:Literal ID="literalNuevoIngreso" runat="server" Text="0"></asp:Literal><br />
                                                                                        <asp:Literal ID="literalNuevos" runat="server" Text=""></asp:Literal>%   
                                                                                    </div>
                                                                                </div>
                                                                                <div class="col-auto">
                                                                                    <i class="fas fa-check-double fa-2x text-white"></i>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-4 col-sm-12 border-right-blue-grey border-right-lighten-5">
                                                                    <div class="card border-left-primary bg-itla-4 h-100 py-2 text-left border-0">
                                                                        <div class="card-body">
                                                                            <div class="row no-gutters align-items-center">
                                                                                <div class="col mr-2">
                                                                                    <div class="text-xs text-white text-uppercase mb-1">Reinscritos</div>
                                                                                    <div class="h3 mb-0 font-weight-bold text-white">
                                                                                        <asp:Literal ID="literalReinscritos" runat="server" Text="0"></asp:Literal><br />
                                                                                        <asp:Literal ID="literalPorcientoReinscritos" runat="server" Text=""></asp:Literal>%
                                                                                    </div>
                                                                                </div>
                                                                                <div class="col-auto">
                                                                                    <i class="fas fa-check-double fa-2x text-white"></i>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                                <div class="col-lg-4 col-sm-12 border-right-blue-grey border-right-lighten-5">
                                                                    <div class="card border-left-primary bg-itla-4 h-100 py-2 text-left border-0">
                                                                        <div class="card-body">
                                                                            <div class="row no-gutters align-items-center">
                                                                                <div class="col mr-2">
                                                                                    <div class="text-xs text-white text-uppercase mb-1">Total Inscritos</div>
                                                                                    <div class="h3 mb-0 font-weight-bold text-white">
                                                                                        <asp:Literal ID="literalTotalInscritos" runat="server" Text="0"></asp:Literal><br />
                                                                                        100%   
                                                                                    </div>
                                                                                </div>
                                                                                <div class="col-auto">
                                                                                    <i class="fas fa-check-double fa-2x text-white"></i>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>



                                                            </div>--%>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-lg-8">
                                        <div id="containerCondicionAcademica">
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <div id="containerInscritos"></div>
                                    </div>
                                </div>
                               


                            </section>
                        </div>
                    </div>

                </div>
            </div>
            <!-- Column -->
        </div>

        <!-- Column -->

    </div>


    <table id="datatableCondicionAcademica" style="display: normal">
        <thead>
            <tr>
                <th>Cantidad</th>
                <th>ID Condicion Academica</th>
                <th>Nombre</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterCondicionAcademica" runat="server">
                <ItemTemplate>
                    <itemtemplate>
                        <tr>
                            <td><%# Eval("Cantidad") %></td>
                            <td><%# Eval("IDcondicion_academica") %></td>
                   -        <td><%# Eval("nombre") %></td>
                           
                        </tr>
                    </itemtemplate>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>

   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <script>
         Highcharts.chart('containerCondicionAcademica', {
             data: {
                 table: 'datatableCondicionAcademica'
             },
             chart: {
                 plotBackgroundColor: null,
                 plotBorderWidth: null,
                 plotShadow: false,
                 type: 'pie'
             },
             title: {
                 text: 'Inscritos por Genero'
             },
             yAxis: {
                 min: 0,
                 title: {
                     text: 'Cantidad',
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
                         enabled: false
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

         //Highcharts.chart('containerCondicionAcademica', {
         //    data: {
         //        table: 'datatableCondicionAcademica'
         //    },
         //    chart: {
         //        plotBackgroundColor: null,
         //        plotBorderWidth: null,
         //        plotShadow: false,
         //        type: 'pie'
         //    },
         //    title: {
         //        text: 'Inscritos por Edad'
         //    },
         //    yAxis: {
         //        min: 0,
         //        title: {
         //            text: 'Cantidad',
         //            align: 'high'
         //        },
         //        labels: {
         //            overflow: 'justify'
         //        }
         //    },
         //    tooltip: {
         //        valueSuffix: ' '
         //    },
         //    plotOptions: {
         //        column: {
         //            dataLabels: {
         //                enabled: true
         //            }
         //        }
         //    },
         //    legend: {
         //        layout: 'vertical',
         //        align: 'right',
         //        verticalAlign: 'top',
         //        x: -40,
         //        y: 80,
         //        floating: true,
         //        borderWidth: 1,
         //        backgroundColor:
         //            Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF',
         //        shadow: true
         //    },
         //    tooltip: {
         //        formatter: function () {
         //            return '<b>' + this.series.name + '</b><br/>' +
         //                this.point.y + ' ' + this.point.name.toLowerCase();
         //        }
         //    }
         //});

         //Highcharts.chart('containerCondicionAcademica', {
         //    data: {
         //        table: 'datatableCondicionAcademica'
         //    },
         //    chart: {
         //        plotBackgroundColor: null,
         //        plotBorderWidth: null,
         //        plotShadow: false,
         //        type: 'pie'
         //    },
         //    title: {
         //        text: 'Grafico Condicion Academica'
         //    },
         //    yAxis: {
         //        min: 0,
         //        title: {
         //            text: 'Cantidad',
         //            align: 'high'
         //        },
         //        labels: {
         //            overflow: 'justify'
         //        }
         //    },
         //    tooltip: {
         //        valueSuffix: ' '
         //    },
         //    plotOptions: {
         //        column: {
         //            dataLabels: {
         //                enabled: true
         //            }
         //        }
         //    },
         //    legend: {
         //        layout: 'vertical',
         //        align: 'right',
         //        verticalAlign: 'top',
         //        x: -40,
         //        y: 80,
         //        floating: true,
         //        borderWidth: 1,
         //        backgroundColor:
         //            Highcharts.defaultOptions.legend.backgroundColor || '#FFFFFF',
         //        shadow: true
         //    },
         //    tooltip: {
         //        formatter: function () {
         //            return '<b>' + this.series.name + '</b><br/>' +
         //                this.point.y + ' ' + this.point.name.toLowerCase();
         //        }
         //    }
         //});


         //Highcharts.chart('containerCondicionAcademica', {
         //    data
         //    chart: {
         //        plotBackgroundColor: null,
         //        plotBorderWidth: null,
         //        plotShadow: false,
         //        type: 'pie'
         //    },
         //    title: {
         //        text: 'Nuevos ingresos / Reinscritos'
         //    },
         //    tooltip: {
         //        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
         //    },
         //    accessibility: {
         //        point: {
         //            valueSuffix: '%'
         //        }
         //    },
         //    plotOptions: {
         //        pie: {
         //            allowPointSelect: true,
         //            cursor: 'pointer',
         //            dataLabels: {
         //                enabled: true,
         //                format: '<b>{point.name}</b>: {point.percentage:.1f} %'
         //            }
         //        }
         //    },
         //    series: [{
         //        name: 'Brands',
         //        colorByPoint: true,
         //        data: [{
         //            name: 'Reinscritos',
         //            y: viejos,
         //            sliced: true,
         //            selected: true
         //        }, {
         //            name: 'Nuevos',
         //            y: nuevos
         //        }]
         //    }]
         //});
     </script>
</asp:Content>
