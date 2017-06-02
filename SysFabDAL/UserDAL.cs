using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;

namespace SysFabDAL
{
    public class UserDAL
    {
        public bool Login(string user, string password)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                var response = db.User.Where(s => s.Username == user && s.Password == password && s.Status == "A");
                if (response != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
