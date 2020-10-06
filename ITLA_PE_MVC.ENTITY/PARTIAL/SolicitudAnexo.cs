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
                return this.LocalFile.Replace(this.LocalFile.Substring(0, 90), "");
            }
        }

        public string URL
        {
            get
            {
                return "http://puntostecnologicos.com/files/" + this.LocalFile.Replace(this.LocalFile.Substring(0, 54), "");
            }
        }
    }
}
