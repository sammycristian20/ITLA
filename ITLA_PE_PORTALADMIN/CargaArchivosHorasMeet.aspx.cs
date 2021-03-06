﻿using ITLA_PE_MVC.DATA;
using ITLA_PE_MVC.ENTITY;
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
                        //  Lines = Lines.Skip(1).ToArray(); [DECOMENTAR ESTA LINEA CUANDO SE VAYA A SUBIR A PRODUCCION]
                        List<MeetLogDocente> emList = new List<MeetLogDocente>();


                        foreach (var line in Lines)
                        {
                            Fields = line.Split(new char[] { ',' }); //SEPARA LOS CAMPOS
                            emList.Add(
                                new MeetLogDocente
                                {
                                    //IdRegistro = ProcesaFecha(Fields[0].Replace("\"", "")).ToString()+Fields[4].Replace("\"", ""),
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

                        }
                        
                        //Carga la data en la BD
                        using (HorasLogEntities2 db = new HorasLogEntities2())
                        {

                            foreach (var i in emList)
                            {

                                db.MeetLogDocentes.Add(i);


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

    
