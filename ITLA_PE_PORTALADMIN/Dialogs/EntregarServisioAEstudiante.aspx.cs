using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN.Dialogs
{
    public partial class EntregarServisioAEstudiante : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int facturaID = Request.QueryString["token"].ToInt();

                var factura = base.ServicesLayer.ServiceRegistro.ServicioRegistroBusqueda(facturaID);

                Nombre.Text = factura.nombre;
                Apellido.Text = factura.apellido;

                Servicio.Text = factura.ServicioNombre;
                Matricula.Text = factura.matricula;

                FechaEntrega.Text = DateTime.Today.ToString("dd/MM/yyyy");




            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            int facturaID = Request.QueryString["token"].ToInt();


            base.ServicesLayer.ServiceRegistro.ServicioRegistroInserta(
                facturaID,
                ITLA_PE_MVC.ENTITY.RUNTIME.RunTimeHelper.UserID.Value,
                FechaEntrega.Text.ToNuleableDateFromddMMyyyy().Value,
                Comentario.Text);


            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Substring(0, 12), "parent.CloseAndUpdate();", true);

        }
    }
}