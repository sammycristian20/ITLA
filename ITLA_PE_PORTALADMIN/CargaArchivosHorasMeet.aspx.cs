using ITLA_PE_MVC.DATA;
//using ITLA_PE_MVC.ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (FileUpload1.HasFile)
            {
                string extension = Path.GetExtension(FileUpload1.FileName);
                extension = extension.ToLower();

                if (extension == ".csv" || extension == ".xlsx")
                {

                    try
                    {
                        string nombreArchivo = Path.GetFileName(FileUpload1.FileName);
                        string ruta = Path.Combine(Server.MapPath("~/ArchivosMeet"), nombreArchivo);

                      
                        FileUpload1.SaveAs(ruta);
                        
                        string[] Lines = File.ReadAllLines(ruta);
                        string[] Fields;

                        //Quitar la linea encabezado
                        //  Lines = Lines.Skip(1).ToArray();
                        List<MEETLOGDOCENTE> emList = new List<MEETLOGDOCENTE>();


                        foreach (var line in Lines)
                        {
                            Fields = line.Split(new char[] { ',' });
                            emList.Add(
                                new MEETLOGDOCENTE
                                {

                                    Fecha = ProcesaFecha(Fields[0].Replace("\"", "")),
                                    Codigo_reunion = Fields[3].Replace("\"", ""),
                                    Identificador_participante = Fields[4].Replace("\"", ""),
                                    Correoelectronico_organizador = Fields[7].Replace("\"", ""),
                                    Duracion = Convert.ToInt32((Fields[9].Replace("\"", ""))),
                                    Nombre_participante = Fields[11].Replace("\"", ""),
                                    Direccion_IP = Fields[12].Replace("\"", ""),
                                    Ciudad = Fields[13].Replace("\"", ""),
                                    Pais = Fields[14].Replace("\"", ""),
                                    ID_evento_calendario = Fields[26].Replace("\"", ""),
                                    ID_conferencia = Fields[27].Replace("\"", ""),

                                });

                        }

                        //Carga la data en la BD
                        using (HorasLogEntities db = new HorasLogEntities())
                        {

                            foreach (var i in emList)
                            {
                                var v = db.MEETLOGDOCENTEs.Where(a => a.IdRegistro.Equals(i.IdRegistro)).FirstOrDefault();
                                if (v != null)
                                {
                                    // v.IdRegistro = i.IdRegistro;
                                    v.Fecha = i.Fecha;
                                    v.Nombre_evento = i.Nombre_evento;

                                }
                                else
                                {
                                    db.MEETLOGDOCENTEs.Add(i);
                                }

                            }

                            db.SaveChanges();

                            // populate updated data 
                            // populateDatabaseData();
                            lblMensaje.Text = "ARCHIVO SUBIDO CON EXITO";
                           
                            
                        }
                    }
                    catch (Exception error)
                    {
                        lblMensaje.Text = error.Message;
                    }
                }
                else
                {
                    lblMensaje.Text= "DEBE SER UN ARCHIVO CSV O XLSX";
                }
            }
            else
            {
                lblMensaje.Text = "SELECCIONE ARCHIVO A SUBIR";
            }
        }

       
        //METODO QUE CONVIERTE LA CADENA DE LA FECHA A UNA CADENA FORMATEABLE
        protected string ProcesaFecha(string fecha)
        {
                          
            string day = fecha.Substring(0, 2);
            string mes = fecha.Substring(3, 3);
            string year = fecha.Substring(8, 4);

            int month = 0;
            
            switch (mes)
            {
                case "ene": month = 01; break;
                case "feb": month = 02; break;
                case "mar": month = 03; break;
                case "abr": month = 04; break;
                case "may": month = 05; break;
                case "jun": month = 06; break;
                case "jul": month = 07; break;
                case "ago": month = 08; break;
                case "sep": month = 09; break;
                case "oct": month = 10; break;
                case "nov": month = 11; break;
                case "dic": month = 12; break;
            }

            fecha = month + "/" + day + "/" + year;
            return fecha;
        }

       
    }
}