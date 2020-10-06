using ITLA_PE_MVC.ENTITY.RUNTIME;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class PrevalidacionJuventudDetalle : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var solicitud = base.ServicesLayer.ServicioJuventudADM.GetNextPrevalidacion();

                if (solicitud != null)
                {

                    NoSolicitud.Text = solicitud.CodigoSolicitud;

                    Nombre.Text = solicitud.Apellidos.ToUpper();
                    Apellido.Text = solicitud.Nombres.ToUpper();
                    DOB.Text = solicitud.FechaNacimiento.ToString("dd/MM/yyyy");
                    FechaSolicitud.Text = solicitud.FechaCreacion.ToString("dd/MM/yyyy");
                    Email.Text = solicitud.Email;
                    Telefonos.Text = solicitud.TelCelular + "," + solicitud.TelResidencial;
                    Identificacion.Text = solicitud.IdentificacionCedula;

                    RepeaterFiles.DataSource = solicitud.SolicitudAnexoes;
                    RepeaterFiles.DataBind();

                    base.ViewStateSet("ID", solicitud.SolicitudID.ToString());
                }
                else
                {
                    Response.Redirect("PrevalidacionJuventud.aspx");
                }

            }
        }

        protected void DropDownListRecordDeNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListRecordDeNota.SelectedValue == "SI")
                panelIndice.Visible = true;
            else
                panelIndice.Visible = false;
        }

        protected void ButtonSaveExit_Click(object sender, EventArgs e)
        {
            this.SaveThis();
            Response.Redirect("PrevalidacionJuventud.aspx");
        }

        protected void ButtonSaveNext_Click(object sender, EventArgs e)
        {
            this.SaveThis();
            Response.Redirect("PrevalidacionJuventudDetalle.aspx");
        }

        private void SaveThis()
        {
            var solicitud = base.ServicesLayer.ServicioJuventudADM.SolicitudGet(base.ViewStateGet("ID").ToInt());

            solicitud.Genero = DropDownListGenero.SelectedValue;
            solicitud.PrevalidacionUserId = RunTimeHelper.UserID.Value;
            solicitud.PrevalidacionLastDate = DateTime.Now;
            solicitud.PrevalidacionEstatus = "PREVALIDADO";
            solicitud.PreValidado = true;


            if (DropDownListIdentidad.SelectedValue == "SI")
                solicitud.PrevalidacionIdentificacionValida = true;
            else
                solicitud.PrevalidacionIdentificacionValida = false;

            if (DropDownListRecordDeNota.SelectedValue == "SI")
            {
                solicitud.PrevalidacionRecordValido = true;
                solicitud.PrevalidacionIndice = decimal.Parse(IndiceAcademinco.Text);
            }
            else
                solicitud.PrevalidacionRecordValido = false;

            base.ServicesLayer.ServicioJuventudADM.SolicitudUpdate(solicitud);


        }
    }
}