using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITLA_PE_MVC.ENTITY;

namespace ITLA_PE_MVC.SERVICE
{
    public class ServiceSecurity
    {
        ITLA_PE_MVC.DATA.ORBIPEEntities dbContext = null;

        public ServiceSecurity()
        {
            dbContext = new ITLA_PE_MVC.DATA.ORBIPEEntities();
        }

        public ITLA_PE_MVC.ENTITY.UspGetLoginInfo_Result CheckIfHaveAccess(string userName, string passWord)
        {
            ITLA_PE_MVC.ENTITY.UspGetLoginInfo_Result item = dbContext.UspGetLoginInfo(userName).SingleOrDefault();

            if (item != null)
            {
                if (item.clave != MD5(passWord))
                    item = null;
            }

            return item;
        }

        string MD5(string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }
        }

        public void Dispose()
        {
            if (dbContext != null)
                ((IDisposable)dbContext).Dispose();
        }


    }
}
