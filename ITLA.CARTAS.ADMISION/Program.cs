using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.OfficeChart;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;



namespace ITLA.CARTAS.ADMISION
{
    class Program
    {
        static void Main(string[] args)
        {

            ITLA_PE_MVC.DATA.ORBIPEEntities db = new ITLA_PE_MVC.DATA.ORBIPEEntities();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk2MjIxQDMxMzgyZTMyMmUzMEg0V3UzZWxVcmhtSFZxZjNHMm01cGc2ajdwSmlTY2prYzJ3VGtLUTdINVk9");


            var cartas = db.UspRegistroParaEnviarCarta();

            foreach (var carta in cartas.Take(5))
            {
                WordDocument doc = new WordDocument(@"C:\Users\luism\Documents\GitHub\ITLA\ModificadaDIC2020CartadeAdmitidos.docx");


                
                doc.Replace("{ESTUDIANTE}", carta.ESTUDIANTE, false, false);
                doc.Replace("{MATRICULA}", carta.MATRICULA, false, false);
                doc.Replace("{CARRERA}", carta.CARRERA, false, false);
                doc.Replace("{FECHACONVOCATORIA}", carta.FECHACONVOCATORIA, false, false);                
                doc.Replace("{FECHANUEGOINGRESO}", carta.FECHANUEGOINGRESO, false, false);
                doc.Replace("{FECHAAMBIENTACION}", carta.FECHAAMBIENTACION, false, false);
                doc.Replace("{FECHAINICIODOCENCIA}", carta.FECHAINICIODOCENCIA, false, false);
                doc.Replace("{FECHAPERIODO}", carta.FECHAPERIODO, false, false);
                doc.Replace("{FECHA}", carta.FECHA, false, false);


                DocToPDFConverter converter = new DocToPDFConverter();
                //Converts Word document into PDF documents
                PdfDocument pdfDocument = converter.ConvertToPDF(doc);

                //string originalURL = "~/ContratosGenerados/" + Guid.NewGuid().ToString() + ".pdf";
                string fileName = @"C:\Users\luism\Documents\GitHub\ITLA\SALIDA\" + carta.MATRICULA + ".pdf";
                

                pdfDocument.Save(fileName);
                //Closes the instance of document objects
                pdfDocument.Close(true);
                doc.Close();

                doc.Close();


                Console.WriteLine(carta.ESTUDIANTE);
            }

            Console.ReadLine();

            
        }
    }
}
