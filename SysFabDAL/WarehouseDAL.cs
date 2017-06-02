using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;
using System.Dynamic;

namespace SysFabDAL
{
    public class WarehouseDAL
    {
        public List<DescWarehouse> GetListWarehouse()
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.DescWarehouse.ToList();
            }
        }

        public string GetNameWarehouseById(int Id)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.DescWarehouse.Where(p => p.Id == Id && p.State == "A").Select(s => s.Description).Single<string>();
            }
        }

        public object GetWarehouseStockByMaster(int idWarehouse, int idMaster)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return (from a in db.Warehouse
                        join b in db.DescWarehouse on a.Warehouse1 equals b.Id
                        join c in db.Master on a.Master equals c.Id
                        where a.Warehouse1 == idWarehouse &&
                           a.Master == idMaster
                        select new
                        {
                            Warehouse = a.Warehouse1,
                            Description = b.Description,
                            Name = c.Name,
                            Master = a.Master,
                            Quantity = a.Quantity,
                            QtyOnHand = a.QtyOnHand
                        }).SingleOrDefault();
            }
        }

    }

    

}
