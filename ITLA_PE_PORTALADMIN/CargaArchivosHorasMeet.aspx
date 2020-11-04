<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMain.Master" AutoEventWireup="true" CodeBehind="CargaArchivosHorasMeet.aspx.cs" Inherits="ITLA_PE_PORTALADMIN.CargaArchivosHorasMeet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"  UpdateMode="Conditional">
       <ContentTemplate>
           <asp:FileUpload ID="FileUpload1" runat="server" /><br />
          
          
          
            
       </ContentTemplate>

        <Triggers>
            <asp:PostBackTrigger ControlID="btnSubir"/>
        </Triggers>
    </asp:UpdatePanel>
          <asp:Button ID="btnSubir" runat="server" Text="CARGAR ARCHIVO" OnClick="btnSubir_Click" /><br />
            <asp:Label ID="lblMensaje" runat="server" Text="Label" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblPrueba" runat="server" Text="Label" ForeColor="Red"></asp:Label>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
       <ProgressTemplate>
            <img src="Content/images/loading.gif" height="500" width="500"/>
       </ProgressTemplate>
    </asp:UpdateProgress>
        
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

  
</asp:Content>

