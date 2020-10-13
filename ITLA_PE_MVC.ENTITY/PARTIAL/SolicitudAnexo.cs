using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLA_PE_MVC.ENTITY
{
    public partial class SolicitudAnexo
    {
        public string FileName
        {
            get
            {
                if (this.ArchivoURL == "")
                {
                    return this.LocalFile.Replace(this.LocalFile.Substring(0, 90), "");
                }
                else
                {
                    return this.ArchivoURL;
                }
            }
        }

        public string URL
        {
            get
            {
                if (this.ArchivoURL == "")
                    return "http://puntostecnologicos.com/files/" + this.LocalFile.Replace(this.LocalFile.Substring(0, 54), "");
                else
                    return this.ArchivoURL;
            }
        }
    }
}
