using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;
using SysFabDAL;

namespace SysFabBO
{
    public class BOWarehouse
    {
        public static List<DescWarehouse> GetListWarehouse()
        {
            WarehouseDAL objDLWh = new WarehouseDAL();
            return objDLWh.GetListWarehouse();
        }

        public static Response CreateMovement(Movements movement)
        {
            MovementsDAL objDLMv = new MovementsDAL();
            return objDLMv.InsertMovement(movement);
        }

    }
}
