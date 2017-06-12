using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;

namespace SysFabDAL
{
    public class TransferReturnDAL
    {

        public Response InsertBatchTransferReturn(List<TransferReturn> transferreturn)
        {
            Response response = new Response();
            try
            {
                using (DB_SYSFABEntities db = new DB_SYSFABEntities())
                {
                    db.TransferReturn.AddRange(transferreturn);
                    db.SaveChanges();
                    response.Error = false;
                    response.Message = "ok";
                    response.Object = null;
                }
            }
            catch (Exception e)
            {
                response.Error = true;
                response.Message = e.Message;
                response.Object = e;
            }
            return response;
        }

        public Response InsertTransferReturn(TransferReturn transferreturn)
        {
            Response response = new Response();
            try
            {
                using (DB_SYSFABEntities db = new DB_SYSFABEntities())
                {
                    db.TransferReturn.Add(transferreturn);
                    db.SaveChanges();
                    response.Error = false;
                    response.Message = "ok";
                    response.Object = null;
                }
            }
            catch(Exception e)
            {
                response.Error = true;
                response.Message = e.Message;
                response.Object = e;
            }
            return response;
        }
        
    }
}
