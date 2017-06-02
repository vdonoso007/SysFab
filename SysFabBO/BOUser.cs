using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabDAL;

namespace SysFabBO
{
    public class BOUser
    {
        public static bool Login(string user, string password)
        {
            UserDAL objDLUser = new UserDAL();
            bool response = false;
            try
            {
                response = objDLUser.Login(user, password);
            }
            catch (Exception e)
            { }
            finally
            {
                objDLUser = null;
            }
            return response;
        }
    }
}
