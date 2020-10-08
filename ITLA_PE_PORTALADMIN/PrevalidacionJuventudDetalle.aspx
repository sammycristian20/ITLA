<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="PrevalidacionJuventudDetalle.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.PrevalidacionJuventudDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        label {font-weight: bold; color: black}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />
    <div class="content-body">
        <!-- Basic form layout section start -->
        <section id="basic-form-layouts">
            <div class="row match-height">
                <div class="col-md-9">
                    <div class="card" style="min-height: 150.5px;">
                        <div class="card-header">
                            <h4 class="card-title" id="basic-layout-form">Información del Solicitante</h4>
                        </div>
                        <div class="card-content collapse show">
                            <div class="card-body">
                                <div class="form">
                                    <div class="form-body">
                                        <div class="row">
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label for="projectinput1">Solicitud</label>
                                                    <asp:TextBox ID="NoSolicitud" CssClass="form-control border-primary" ReadOnly="true" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label for="projectinput1">Fecha de nacimiento</label>
                                                    <asp:TextBox ID="DOB" CssClass="form-control border-primary" ReadOnly="true" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label for="projectinput1">Fecha de solicitud</label>
                                                    <asp:TextBox ID="FechaSolicitud" CssClass="form-control border-primary" ReadOnly="true" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label for="projectinput1">Identificación</label>
                                                    <asp:TextBox ID="Identificacion" CssClass="form-control border-primary" ReadOnly="true" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label for="projectinput1">Nombre</label>
                                                    <asp:TextBox ID="Nombre" CssClass="form-control border-primary" ReadOnly="true" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label for="projectinput2">Apellido</label>
                                                    <asp:TextBox ID="Apellido" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label for="projectinput1">Email</label>
                                                    <asp:TextBox ID="Email" CssClass="form-control border-primary" ReadOnly="true" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label for="projectinput2">Teléfonos</label>
                                                    <asp:TextBox ID="Telefonos" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <h4 class="form-section"><i class="fa fa-eye"></i>Pre-Validación</h4>
                                        <br />

                                        <div class="row">
                                            <div class="col-md-2">
                                                <div class="form-group">
                                                    <label for="projectinput1">
                                                        Genero
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownListGenero" ErrorMessage="El genero es requerido" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    </label>
                                                    <asp:DropDownList ID="DropDownListGenero" runat="server" CssClass="form-control border-primary">
                                                        <asp:ListItem Value="" Text="Favor seleccionar"></asp:ListItem>
                                                        <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                                                        <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group">
                                                    <label for="projectinput1">
                                                        Documento de Identidad
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownListIdentidad" ErrorMessage="Verificar el documento de Identidad es requerido" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    </label>
                                                    <asp:DropDownList ID="DropDownListIdentidad" runat="server" CssClass="form-control border-primary">
                                                        <asp:ListItem Value="" Text="Favor seleccionar"></asp:ListItem>
                                                        <asp:ListItem Value="SI" Text="SI"></asp:ListItem>
                                                        <asp:ListItem Value="NO" Text="NO"></asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group">
                                                    <label for="projectinput1">
                                                        Record de Nota
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownListRecordDeNota" ErrorMessage="Verificar el record de nota es requerido" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    </label>
                                                    <asp:DropDownList ID="DropDownListRecordDeNota" runat="server" CssClass="form-control border-primary" AutoPostBack="true" OnSelectedIndexChanged="DropDownListRecordDeNota_SelectedIndexChanged">
                                                        <asp:ListItem Value="" Text="Favor seleccionar"></asp:ListItem>
                                                        <asp:ListItem Value="SI" Text="SI"></asp:ListItem>
                                                        <asp:ListItem Value="NO" Text="NO"></asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="col-md-4" id="panelIndice" runat="server" visible="false">
                                                <div class="form-group">
                                                    <label for="projectinput1">
                                                        Indice de Matemática (base a 100)
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="IndiceAcademinco" ErrorMessage="Verificar el Indice de matematica es requerido" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    </label>
                                                    <asp:TextBox ID="IndiceAcademinco" CssClass="form-control border-primary" runat="server"></asp:TextBox>
                                                </div>
                                            </div>

                                        </div>


                                    </div>

                                    <div class="form-actions">
                                        <asp:Button ID="ButtonSaveExit" runat="server" Text="Guardar y Salir" CssClass="btn btn-warning mr-1" OnClick="ButtonSaveExit_Click" />
                                        <asp:Button ID="ButtonSaveNext" runat="server" Text="Guardar y Proximo" CssClass="btn btn-primary" OnClick="ButtonSaveNext_Click" />

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-md-3">
                    <div class="card" style="min-height: 300.5px;">
                        <div class="card-header">
                            <h4 class="card-title" id="basic-layout-colored-form-control">Documentos Cargados</h4>
                        </div>
                        <div class="card-content collapse show">
                            <div class="card-body">
                                <div class="form">
                                    <div class="form-body">


                                        <asp:Repeater ID="RepeaterFiles" runat="server">
                                            <ItemTemplate>
                                                <div class="form-group">
                                                    <a style="color: black" href='<%# Eval("URL") %>' target="_blank"><%# Eval("FileName") %> </a>
                                                </div>

                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>




        </section>
        <!-- // Basic form layout section end -->
    </div>

  

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
