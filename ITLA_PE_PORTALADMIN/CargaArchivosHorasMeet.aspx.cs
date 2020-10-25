using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLA_PE_PORTALADMIN
{
    public partial class CargaArchivosHorasMeet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            if (archivo.HasFile)
            {
                string extension = System.IO.Path.GetExtension(archivo.FileName);
                extension = extension.ToLower();

                if (extension == ".csv" || extension == ".xls" || extension == ".xlsx")
                {
                    archivo.SaveAs(Server.MapPath("~/ArchivosMeet/" + archivo.FileName));
                    Response.Write("ARCHIVO CARGADO CON EXITO");
                }
                else
                {
                    Response.Write("DEBE SER UN ARCHIVOS CSV O XLS/XLSX");
                }
            }
            else
            {
                Response.Write("SELECCIONE ARCHIVO A SUBIR");
            }
        }
    }
}