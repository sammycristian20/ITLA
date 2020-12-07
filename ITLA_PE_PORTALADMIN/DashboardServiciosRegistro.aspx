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
                                <h3 class="section-heading mb-1 h1 mt-4 text-left">Dashboard Registro
                                    
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
                                    <div class="col-lg-4">
                                        <div id="containerC22020">
                                        </div>
                                        
                                    </div>
                                    <div class="col-lg-4">
                                        <div id="containerC12020"></div>
                                    </div>
                                    <div class="col-lg-4">
                                        <div id="containerC32019"></div>
                                    </div>
                                </div>
                                
                                <div class="row">

                                </div>
                                <div class="row">

                                </div>
                                <div class="row">
                                    <div class="col-lg-12">
                                        <div id="containerEntregadosFecha"></div>
                                    </div>
                                </div>
                                 <div class="row">

                                </div>
                                <div class="row">

                                </div>
                                <div class="row">
                                    <div class="col-lg-6">
                                        <div id="containerEntregadosUsuario">
                                        </div>
                                        
                                    </div>
                                    <div class="col-lg-6">
                                        <div id="containerEntregadosTipo"></div>
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


    <table id="datatableC22020" style="display: none">
        <thead>
            <tr>
                <th>Cantidad</th>
                <th>ID Condicion Academica</th>
                <th>Nombre</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterC22020" runat="server">
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

    <table id="datatableC12020" style="display: none">
        <thead>
            <tr>
                <th>Cantidad</th>
                <th>ID Condicion Academica</th>
                <th>Nombre</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterC12020" runat="server">
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

    <table id="datatableC32019" style="display: none">
        <thead>
            <tr>
                <th>Cantidad</th>
                <th>ID Condicion Academica</th>
                <th>Nombre</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterC32019" runat="server">
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

    

    <table id="datatableEntregadosFecha" style="display: none">
        <thead>
            <tr>
                <th>Fecha Entrega</th>
                <th>Cantidad</th>
                
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterEntregadosFecha" runat="server">
                <ItemTemplate>
                    <itemtemplate>
                        <tr>
                            <td><%# Eval("FechaEntrega") %></td>
                            <td><%# Eval("Cantidad") %></td>
                   
                           
                        </tr>
                    </itemtemplate>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>

     <table id="datatableEntregadosUsuario" style="display: none">
        <thead>
            <tr>
                <th>Usuario</th>
                <th>Cantidad</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterEntregadosUsuario" runat="server">
                <ItemTemplate>
                    <itemtemplate>
                        <tr>
                           <td><%# Eval("NombreUsuario") %></td>
                            <td><%# Eval("Cantidad") %></td>
                           
                        </tr>
                    </itemtemplate>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>

      <table id="datatableEntregadosTipo" style="display: none">
        <thead>
            <tr>
                <th>Servicio </th>
                <th>Cantidad</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterEntregadosTipo" runat="server">
                <ItemTemplate>
                    <itemtemplate>
                        <tr>
                           <td><%# Eval("TipoServicio") %></td>
                            <td><%# Eval("Cantidad") %></td>
                           
                        </tr>
                    </itemtemplate>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>


  

  

   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <script>


         let normalC2 = parseInt(<%=this.C22020Normal%>);
         let pruebaC2 = parseInt(<%=this.C22020Prueba%>);
         let separadoC2 = parseInt(<%=this.C22020Separado%>);

         let normalC1 = parseInt(<%=this.C12020Normal%>);
         let pruebaC1 = parseInt(<%=this.C12020Prueba%>);
         let separadoC1 = parseInt(<%=this.C12020Separado%>);

         let normalC3 = parseInt(<%=this.C32019Normal%>);
         let pruebaC3 = parseInt(<%=this.C32019Prueba%>);
         let separadoC3 = parseInt(<%=this.C32019Separado%>);

         let record = parseInt(<%=this.Record%>);
         let certificacion = parseInt(<%=this.Certificacion%>);
       
         // Create the chart

         
         Highcharts.chart('containerC22020', {
             chart: {
                 type: 'column'
             },
             title: {
<<<<<<< HEAD
                 text: 'Condición Academica C2-2020'
=======
                 text: 'Condicion Academica C2-2020'
>>>>>>> 15630a5ecae458bf1260f092200e9a4afce8a7e2
             },
             /* subtitle: {
                  text: 'Click the columns to view versions. Source: <a href="http://statcounter.com" target="_blank">statcounter.com</a>'
              },*/
             accessibility: {
                 announceNewData: {
                     enabled: true
                 }
             },
             xAxis: {
                 type: 'category'
             },
             yAxis: {
                 title: {
                     text: 'Cantidad'
                 }

             },
             legend: {
                 enabled: false
             },
             plotOptions: {
                 series: {
                     borderWidth: 0,
                     dataLabels: {
                         enabled: true,
                         // format: '{point.y}%'
                     }
                 }
             },

             tooltip: {
                 headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
                 // pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}%</b> of total<br/>'
             },

             series: [
                 {
                     name: "Cantidad",
                     colorByPoint: true,
                     data: [
                         {
                             name: "Normal",
                             y: normalC2,

                         },
                         {
                             name: "Prueba Academica",
                             y: pruebaC2,

                         },
                         {
                             name: "Separado de la Carrera",
                             y: separadoC2,

                         }
                     ]
                 }]





         });



         Highcharts.chart('containerC12020', {
             chart: {
                 type: 'column'
             },
             title: {
<<<<<<< HEAD
                 text: 'Condición Academica C1-2020'
=======
                 text: 'Condicion Academica C1-2020'
>>>>>>> 15630a5ecae458bf1260f092200e9a4afce8a7e2
             },
             /* subtitle: {
                  text: 'Click the columns to view versions. Source: <a href="http://statcounter.com" target="_blank">statcounter.com</a>'
              },*/
             accessibility: {
                 announceNewData: {
                     enabled: true
                 }
             },
             xAxis: {
                 type: 'category'
             },
             yAxis: {
                 title: {
                     text: 'Cantidad'
                 }

             },
             legend: {
                 enabled: false
             },
             plotOptions: {
                 series: {
                     borderWidth: 0,
                     dataLabels: {
                         enabled: true,
                         // format: '{point.y}%'
                     }
                 }
             },

             tooltip: {
                 headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
                 // pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}%</b> of total<br/>'
             },

             series: [
                 {
                     name: "Cantidad",
                     colorByPoint: true,
                     data: [
                         {
                             name: "Normal",
                             y: normalC1,

                         },
                         {
                             name: "Prueba Academica",
                             y: pruebaC1,

                         },
                         {
                             name: "Separado de la Carrera",
                             y: separadoC1,

                         }
                     ]
                 }]





         });

         Highcharts.chart('containerC32019', {
             chart: {
                 type: 'column'
             },
             title: {
<<<<<<< HEAD
                 text: 'Condición Academica C3-2019'
=======
                 text: 'Condicion Academica C3-2019'
>>>>>>> 15630a5ecae458bf1260f092200e9a4afce8a7e2
             },
             /* subtitle: {
                  text: 'Click the columns to view versions. Source: <a href="http://statcounter.com" target="_blank">statcounter.com</a>'
              },*/
             accessibility: {
                 announceNewData: {
                     enabled: true
                 }
             },
             xAxis: {
                 type: 'category'
             },
             yAxis: {
                 title: {
                     text: 'Cantidad'
                 }

             },
             legend: {
                 enabled: false
             },
             plotOptions: {
                 series: {
                     borderWidth: 0,
                     dataLabels: {
                         enabled: true,
                         // format: '{point.y}%'
                     }
                 }
             },

             tooltip: {
                 headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
                 // pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}%</b> of total<br/>'
             },

             series: [
                 {
                     name: "Cantidad",
                     colorByPoint: true,
                     data: [
                         {
                             name: "Normal",
                             y: normalC3,

                         },
                         {
                             name: "Prueba Academica",
                             y: pruebaC3,

                         },
                         {
                             name: "Separado de la Carrera",
                             y: separadoC3,

                         }
                     ]
                 }]





         });


         Highcharts.chart('containerEntregadosFecha', {
             data: {
                 table: 'datatableEntregadosFecha'
             },
             chart: {
                 type: 'line'
             },
             title: {
                 text: 'Servicios Entregados por Fecha'
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
             legend: {
                 enabled: false
             },
             tooltip: {
                 headerFormat: '<b>{series.name}</b><br/>',
                 pointFormat: '{point.y}'
             },
             plotOptions: {
                 line: {
                     dataLabels: {
                         enabled: true
                     },
                     enableMouseTracking: true
                 }
             }
         });

         Highcharts.chart('containerEntregadosUsuario', {
             data: {
                 table: 'datatableEntregadosUsuario'
             },
             chart: {
                 plotBackgroundColor: null,
                 plotBorderWidth: null,
                 plotShadow: false,
                 type: 'pie'
             },
             title: {
                 text: 'Servicios Entregados Por Usuario'
             },
             tooltip: {
                 //pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
             },
             accessibility: {
                 point: {
                     valueSuffix: '%'
                 }
             },
             plotOptions: {
                 pie: {
                     allowPointSelect: true,
                     cursor: 'pointer',
                     dataLabels: {
                         enabled: true,
                         format: '<b>{point.name}</b>: {point.percentage:.1f} %'
                     }
                 }
             },
             series: [{
                 name: 'Cantidad',
                 colorByPoint: true,
                 data: [{
                     name: 'Carta de Certificacion',
                     y: certificacion,
                     sliced: true,
                     selected: true
                 }, {
                     name: 'Record de Notas',
                     y: record
                 }]
             }]
         });


         Highcharts.chart('containerEntregadosTipo', {
             chart: {
                 plotBackgroundColor: null,
                 plotBorderWidth: null,
                 plotShadow: false,
                 type: 'pie'
             },
             title: {
<<<<<<< HEAD
                 text: 'Relación Tipo de Servicios'
=======
                 text: 'Relacion Tipo de Servicios'
>>>>>>> 15630a5ecae458bf1260f092200e9a4afce8a7e2
             },
             tooltip: {
                 //pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
             },
             accessibility: {
                 point: {
                     valueSuffix: '%'
                 }
             },
             plotOptions: {
                 pie: {
                     allowPointSelect: true,
                     cursor: 'pointer',
                     dataLabels: {
                         enabled: true,
                         format: '<b>{point.name}</b>: {point.percentage:.1f} %'
                     }
                 }
             },
             series: [{
                 name: 'Cantidad',
                 colorByPoint: true,
                 data: [{
                     name: 'Carta de Certificacion',
                     y: certificacion,
                     sliced: true,
                     selected: true
                 }, {
                         name: 'Record de Notas',
                         y: record
                 }]
             }]
         });
        

     </script>
</asp:Content>
