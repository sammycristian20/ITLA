<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/export-data.js"></script>
    <script src="https://code.highcharts.com/modules/accessibility.js"></script>
    <link href="Content/css/colors.css" rel="stylesheet" />    
    <link href="Content/css/bootstrap-extended.min.css" rel="stylesheet" />
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
                                <h3 class="section-heading mb-1 h1 mt-4 text-left">Dashboard Educación Superior
                                    <asp:DropDownList ID="ddlPeriodo" runat="server" DataValueField="Periodo" DataTextField="Periodo" AutoPostBack="true" OnSelectedIndexChanged="ddlPeriodo_SelectedIndexChanged">

                                    </asp:DropDownList>

                                    
                                </h3>
                                <div class="row">
                                 
                                    <div class="col-lg-12">
                                        <div class="row">
                                            <div class="col-12">
                                                <div class="card">
                                                    <div class="card-content">
                                                        <div class="card-body">
                                                            <div class="row">
                                                                <div class="col-lg-4 col-sm-12 border-right-blue-grey border-right-lighten-5">
                                                                    <div class="pb-1">
                                                                        <div class="clearfix mb-1">
                                                                            <i class="icon-bag font-large-1 blue-grey float-left mt-1" style="background-color: #fff!important"></i>
                                                                            <span class="font-large-2 text-bold-300 info float-right">689</span>
                                                                        </div>
                                                                        <div class="clearfix">
                                                                            <span class="text-muted">Nuevo Ingreso</span>
                                                                            <span class="info float-right">
                                                                                <i class="ft-arrow-up info" ></i>20.53%</span>
                                                                        </div>
                                                                    </div>
                                                                    <div class="progress mb-0" style="height: 7px;">
                                                                        <div class="progress-bar bg-info" role="progressbar" style="width: 20.53%" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100"></div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-4 col-sm-12 border-right-blue-grey border-right-lighten-5">
                                                                    <div class="pb-1">
                                                                        <div class="clearfix mb-1">
                                                                            <i class="icon-user font-large-1 blue-grey float-left mt-1" style="background-color: #fff!important"></i>
                                                                            <span class="font-large-2 text-bold-300 danger float-right">2,667</span>
                                                                        </div>
                                                                        <div class="clearfix">
                                                                            <span class="text-muted">Re-Inscripciones</span>
                                                                            <span class="danger float-right"><i class="ft-arrow-up danger"></i>79.46%</span>
                                                                        </div>
                                                                    </div>
                                                                    <div class="progress mb-0" style="height: 7px;">
                                                                        <div class="progress-bar bg-danger" role="progressbar" style="width: 79.46%" aria-valuenow="45" aria-valuemin="0" aria-valuemax="100"></div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-4 col-sm-12 border-right-blue-grey border-right-lighten-5">
                                                                    <div class="pb-1">
                                                                        <div class="clearfix mb-1">
                                                                            <i class="icon-shuffle font-large-1 blue-grey float-left mt-1" style="background-color: #fff!important"></i>
                                                                            <span class="font-large-2 text-bold-300 success float-right">3,356</span>
                                                                        </div>
                                                                        <div class="clearfix">
                                                                            <span class="text-muted">Total Inscritos</span>
                                                                            <span class="success float-right"><i class="ft-arrow-down success"></i>100%</span>
                                                                        </div>
                                                                    </div>
                                                                    <div class="progress mb-0" style="height: 7px;">
                                                                        <div class="progress-bar bg-success" role="progressbar" style="width: 100%" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"></div>
                                                                    </div>
                                                                </div>
                                                                <%--<div class="col-lg-3 col-sm-12">
                                                                    <div class="pb-1">
                                                                        <div class="clearfix mb-1">
                                                                            <i class="icon-globe font-large-1 blue-grey float-left mt-1" style="background-color: #fff!important"></i>
                                                                            <span class="font-large-2 text-bold-300 warning float-right">3,356/4000</span>
                                                                        </div>
                                                                        <div class="clearfix">
                                                                            <span class="text-muted">Meta</span>
                                                                            <span class="warning float-right"><i class="ft-arrow-up warning"></i>83.90%</span>
                                                                        </div>
                                                                    </div>
                                                                    <div class="progress mb-0" style="height: 7px;">
                                                                        <div class="progress-bar bg-warning" role="progressbar" style="width: 83.90%" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100"></div>
                                                                    </div>
                                                                </div>--%>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-lg-8">
                                        <div id="container"></div>
                                    </div>
                                       <div class="col-lg-4">
                                        <div id="containerIngresos"></div>
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

    <table id="datatableCarreras" style="display: none">
        <thead>
            <tr>
                <th>Provincia</th>
                <th>Solicitudes</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterCarreras" runat="server">
                <ItemTemplate>
                    <itemtemplate>
                    <tr>
                        <th><%# Eval("Carrera") %></th>
                        <td><%# Eval("NuevoIngreso") %></td>
                        <td><%# Eval("Viejos") %></td>
                        <td><%# Eval("Total") %></td>
                    </tr>
                </itemtemplate>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script>
        $(document).ready(function () {

            Highcharts.chart('containerIngresos', {
                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: 0,
                    plotShadow: false
                },
                title: {
                    text: '% de Nuevo <br/>vs Existentes',
                    align: 'center',
                    verticalAlign: 'middle',
                    y: 60
                },
                tooltip: {
                    pointFormat: '{series.name}: <b>{point.percentage:.1f}% + {point.x:.1f}</b>'
                },
                accessibility: {
                    point: {
                        valueSuffix: '%'
                    }
                },
                plotOptions: {
                    pie: {
                        dataLabels: {
                            enabled: true,
                            distance: -50,
                            style: {
                                fontWeight: 'bold',
                                color: 'white'
                            }
                        },
                        startAngle: -90,
                        endAngle: 90,
                        center: ['50%', '75%'],
                        size: '110%'
                    }
                },
                series: [{
                    type: 'pie',
                    name: 'Browser share',
                    innerSize: '50%',
                    data: [
                        ['Nuevo Ingreso', 689],
                        ['Re-Inscripciones', 2667]

                    ]
                }]
            });

            Highcharts.chart('container', {
                data: {
                    table: 'datatableCarreras'
                },
                chart: {
                    type: 'pie'
                },
                title: {
                    text: 'Inscritos por carreras'
                },
                yAxis: {
                    min: 0,
                    title: {
                        text: 'Inscritos',
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

            //Highcharts.chart('container', {
            //    chart: {
            //        type: 'column'
            //    },
            //    title: {
            //        text: 'Inscripciones por Carrera'
            //    },
            //    xAxis: {
            //        categories: ['Tecnología en Desarrollo de Software',
            //            'Tecnología en Seguridad Informática',
            //            'Tecnología en Multimedia',
            //            'Tecnología en Mecatrónica',
            //            'Tecnología de Redes de Información',
            //            'Tecnología en Sonido',
            //            'Tecnología en Manufactura Automatizada',
            //            'Tecnólogo en Analítica y Ciencia de los Datos',
            //            'Tecnología en Diseño Industrial',
            //            'Tecnólogo en Manufactura de Dispositivos Médicos']
            //    },
            //    yAxis: {
            //        min: 0,
            //        title: {
            //            text: 'Total de Inscripciones'
            //        },
            //        stackLabels: {
            //            enabled: true,
            //            style: {
            //                fontWeight: 'bold',
            //                color: ( // theme
            //                    Highcharts.defaultOptions.title.style &&
            //                    Highcharts.defaultOptions.title.style.color
            //                ) || 'gray'
            //            }
            //        }
            //    },
            //    legend: {
            //        align: 'right',
            //        x: -30,
            //        verticalAlign: 'top',
            //        y: 25,
            //        floating: true,
            //        backgroundColor:
            //            Highcharts.defaultOptions.legend.backgroundColor || 'white',
            //        borderColor: '#CCC',
            //        borderWidth: 1,
            //        shadow: false
            //    },
            //    tooltip: {
            //        headerFormat: '<b>{point.x}</b><br/>',
            //        pointFormat: '{series.name}: {point.y}<br/>Total: {point.stackTotal}'
            //    },
            //    plotOptions: {
            //        column: {
            //            stacking: 'normal',
            //            dataLabels: {
            //                enabled: true
            //            }
            //        }
            //    },
            //    series: [{
            //        name: 'Nuevo Ingreso',
            //        data: [263, 125, 118, 67, 41, 20, 5, 21, 15, 14]
            //    }, {
            //        name: 'Re-Inscripciones',
            //        data: [1017, 461, 463, 335, 223, 67, 40, 20, 25, 16]
            //    }]
            //});

        });

    </script>
</asp:Content>
