using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;

namespace SysFabDAL
{
    public class MasterDALC
    {

        public Master GetMasterByBarCode(string BarCode)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Master.Where(s => s.CodeBar == BarCode).SingleOrDefault();
            }
        }

        public Pharmacology GetPharmaByMaster(int master)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Pharmacology.Where(s => s.Master == master).SingleOrDefault();
            }
        }

        public List<Master> GetListMaster()
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Master.ToList();
            }
        }

        public List<Master> GetListMasterByFilter(string filter)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Master.Where(s => s.Name.Contains(filter) || s.Description.Contains(filter) || s.ShortDescription.Contains(filter)).ToList();
            }
        }

        public void CreateMaster(Master OneMaster, Pharmacology pharma)
        {
            int idmaster = 0;
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                try
                {
                    idmaster = db.Master.Max(p => p.Id)+1;
                }
                catch(InvalidOperationException e)
                {
                    idmaster += 1;
                }
                OneMaster.Id = idmaster;
                db.Master.Add(OneMaster);
                pharma.Master = OneMaster.Id;
                db.Pharmacology.Add(pharma);
                db.SaveChanges();
            }
        }

        public void UpdateMaster(Master OneMaster, Pharmacology pharma)
        {
            Master masterToUpd;
            Pharmacology pharmaToUpd;
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                masterToUpd = db.Master.Where(s => s.Id == OneMaster.Id).FirstOrDefault<Master>();
                pharmaToUpd = db.Pharmacology.Where(s => s.Master == OneMaster.Id).FirstOrDefault<Pharmacology>();
            }

            if (masterToUpd!=null)
            {
                masterToUpd.CodeBar = OneMaster.CodeBar;
                masterToUpd.Name = OneMaster.Name;
                masterToUpd.Description = OneMaster.Description;
                masterToUpd.ShortDescription = OneMaster.ShortDescription;
                masterToUpd.Type = OneMaster.Type;
                masterToUpd.Line = OneMaster.Line;
                masterToUpd.Category = OneMaster.Category;
                masterToUpd.Presentation = OneMaster.Presentation;
                masterToUpd.UntMeasure = OneMaster.UntMeasure;
                masterToUpd.Minimum = OneMaster.Minimum;
                masterToUpd.Maximum = OneMaster.Maximum;
            }

            if (pharmaToUpd!=null)
            {
                pharmaToUpd.ActionPharmacology = pharma.ActionPharmacology;
                pharmaToUpd.Composition = pharma.Composition;
                pharmaToUpd.Dose = pharma.Dose;
                pharmaToUpd.Lab = pharma.Lab;
                pharmaToUpd.Prescription = pharma.Prescription;
                pharmaToUpd.Treatment = pharma.Treatment;
            }

            using (var dbCtx = new DB_SYSFABEntities())
            {
                dbCtx.Entry(masterToUpd).State = System.Data.Entity.EntityState.Modified;
                dbCtx.Entry(pharmaToUpd).State = System.Data.Entity.EntityState.Modified;
                dbCtx.SaveChanges();
            }

        }

        public void DeleteMaster(int Id)
        {
            Master masterToDelete;
            Pharmacology pharmaToDelete;
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                masterToDelete = db.Master.Where(s => s.Id == Id).FirstOrDefault<Master>();
                pharmaToDelete = db.Pharmacology.Where(s => s.Master == Id).FirstOrDefault<Pharmacology>();
                db.Entry(masterToDelete).State = System.Data.Entity.EntityState.Deleted;
                db.Entry(pharmaToDelete).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public string GetNameMasterById(int Id)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Master.Where(p => p.Id == Id && p.State == "A").Select(s => s.Name).Single<string>();
            }
        }

    }
}
