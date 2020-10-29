<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="CargaArchivosHorasMeet.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.CargaArchivosHorasMeet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<<<<<<< HEAD
     
    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
    <asp:Button ID="btnSubir" runat="server" Text="Cargar Archivo" OnClick="btnSubir_Click"/><br />
    <asp:Label ID="lblMensaje" runat="server" Text="Label" ForeColor="Red"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  
=======
 <div id="containerFileUpload" class="active">
    <asp:FileUpload ID="archivo" runat="server" /><br />
    <asp:Button ID="btnSubir" runat="server" Text="Cargar Archivo" OnClick="btnSubir_Click" />
 </div>   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   
>>>>>>> 209fad149b9fe00b88d8c421bdd4f1868a31d14d
</asp:Content>

