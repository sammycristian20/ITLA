<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="CargaArchivosHorasMeet.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.CargaArchivosHorasMeet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="containerFileUpload" class="active">
    <asp:FileUpload ID="archivo" runat="server" /><br />
    <asp:Button ID="btnSubir" runat="server" Text="Cargar Archivo" OnClick="btnSubir_Click" />
 </div>   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   
</asp:Content>
