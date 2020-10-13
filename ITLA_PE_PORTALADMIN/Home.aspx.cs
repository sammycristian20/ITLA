﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class Home :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlPeriodo.DataSource = base.ServicesLayer.ServicesDashboard.GetUspGetPeriodo();
                ddlPeriodo.DataTextField = "Periodo";
                ddlPeriodo.DataValueField = "IDPeriodo";
                ddlPeriodo.DataBind();

            }
        }

        protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}