using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            ITLA_PE_MVC.SERVICE.ServiceSecurity security = new ITLA_PE_MVC.SERVICE.ServiceSecurity();

            ITLA_PE_MVC.ENTITY.UspGetLoginInfo_Result item = security.CheckIfHaveAccess(txtNombreUsuario.Text, txtPassword.Text);

            if (item == null)
            {
                LiteralInfo.Text = "<span class='alert alert-danger'>Nombre de usuario o contraseña invalido</span>";
            }
            else
            {
                Session.Add("UserID", item.UserID);
                Session.Add("UsuarioIDOrbi", item.UsuarioIDOrbi);
                Session.Add("UserTypeCode", item.UserTypeCode);
                Session.Add("FullName", item.FullName + " (" + item.UserTypeCode + ")");

                Response.Redirect("DashboardAdmision.aspx");

            }


                
        }
    }
}