﻿using ITLA_PE_MVC.DATA;
using ITLA_PE_MVC.ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;


namespace ITLA_PE_PORTALADMIN
{
    public partial class CargaArchivosHorasMeet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            if (FileUpload1.HasFile)
            {
                string extension = Path.GetExtension(FileUpload1.FileName);
                extension = extension.ToLower();

                if (extension == ".csv")
                {

                    try
                    {
                        string nombreArchivo = Path.GetFileName(FileUpload1.FileName);
                        string ruta = Path.Combine(Server.MapPath("~/ArchivosMeet"), nombreArchivo);


                        FileUpload1.SaveAs(ruta);

                        string[] Lines = File.ReadAllLines(ruta);
                        string[] Fields;

                        //Quitar la linea encabezado. 
                        Lines = Lines.Skip(1).ToArray();
                        List<MeetLogDocente> registros = new List<MeetLogDocente>();


                        foreach (var line in Lines)
                        {
                            Fields = line.Split(new char[] { ',' }); //SEPARA LOS CAMPOS
                            
                            //VALIDANDO QUE SI HAY UN REGISTRO DUPLICADO EN EL CSV NO SE AGREGUE A LA LISTA (HAY CASOS ASI)
                            if (!registros.Any(x => x.Fecha == ProcesaFecha(Fields[0]).ToString()))
                            {

                                registros.Add(
                                    new MeetLogDocente
                                    {

                                        Fecha = ProcesaFecha(Fields[0]).ToString(),
                                        Codigo_reunion = Fields[3],
                                        Identificador_participante = Fields[4],
                                        Correoelectronico_organizador = Fields[7],
                                        Duracion = Convert.ToInt32(Fields[9]),
                                        Nombre_participante = Fields[11],
                                        Direccion_IP = Fields[12],
                                        Ciudad = Fields[13],
                                        Pais = Fields[14],
                                        ID_evento_calendario = Fields[26],
                                        ID_conferencia = Fields[27],

                                    });

                            //IEnumerable<string> date = registros.Select(x=>x.Fecha);
                            }                     

                         }
                 
                       
                       
                        //Carga la data en la BD
                        using (HorasLogEntities2 db = new HorasLogEntities2())
                        {

                            StringBuilder st = new StringBuilder();
                           //Variables que contienen los resultados de 
                           //una Consulta a los registros existentes en la BD para compararlos con los registros del CSV
                            var fecha = from a in db.MeetLogDocentes
                                        select a.Fecha;
                            var idPart = from a in db.MeetLogDocentes
                                         select a.Identificador_participante;


                           foreach (var i in registros)
                           {
                                if (!fecha.Any(x => x.Equals(i.Fecha)))
                                {
                                    if (!idPart.Any(x => x.Equals(i.Identificador_participante)))
                                    {
                                        db.MeetLogDocentes.Add(i);
                                    }
                                    else
                                    {
                                        db.MeetLogDocentes.Add(i);
                                        //st.AppendLine("Registro duplicado");
                                    }
                                }
                                else if ((!idPart.Any(x => x.Equals(i.Identificador_participante))))
                                {
                                    db.MeetLogDocentes.Add(i);
                                }


                            }
                       
                            db.SaveChanges();
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
                    lblMensaje.Text = "DEBE SER UN ARCHIVO EN FORMATO CSV";
                }
               
            }
            
        }
        //METODO QUE CONVIERTE LA CADENA DE LA FECHA A UNA CADENA FORMATEABLE
        protected DateTime ProcesaFecha(string fecha)
        {

            fecha = fecha.Replace("GMT", "");

            DateTime fechaCompleta = DateTime.Parse(fecha);

            return fechaCompleta;
            
        }
    }
}

    
