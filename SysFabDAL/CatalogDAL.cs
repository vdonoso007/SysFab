using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;

namespace SysFabDAL
{
    public class CatalogDAL
    {

        public List<Catalog> GetListCatalog(int table)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Catalog.Where(s => s.Table == table).ToList();
            }
        }

        public string GetNameUntMeasure(int IdUndMeasure)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Catalog.Where(s => s.Table == 5 && s.Id == IdUndMeasure).Select(s => s.Description).Single<string>();
            }
        }
    }
}
