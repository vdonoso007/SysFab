using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;

namespace SysFabDAL
{
    public class MovementsDAL
    {

        public Response InsertMovement(Movements movement)
        {
            Response response = new Response();
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                try
                {
                    db.Movements.Add(movement);
                    db.SaveChanges();
                    response.Error = false;
                    response.Message = "ok";
                    response.Object = movement;
                }
                catch(Exception e)
                {
                    response.Error = true;
                    response.Message = e.Message;
                    response.Object = null;
                }
            }
            return response;
        }

    }
}
