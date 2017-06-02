using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;

namespace SysFabDAL
{
    public class TransferDAL
    {

        public void SaveTransfer(ref Transfer headerTransfer, ref TransferDetail detailTransfer)
        {
            int idtrn = 0;
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                try
                {
                    idtrn = db.Transfer.Max(s => s.Id)+1;
                }
                catch (InvalidOperationException e)
                {
                    idtrn += 1;
                }
                headerTransfer.Id = idtrn;
                db.Transfer.Add(headerTransfer);
                detailTransfer.Transfer = headerTransfer.Id;
                db.TransferDetail.Add(detailTransfer);
                db.SaveChanges();
            }
        }

        public void TransferToWarehouse(int TransferNro)
        {
            //For now i wanna update state of the transfer to T
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                var trnToUpd = db.Transfer.Where(x => x.Id == TransferNro).SingleOrDefault();
                if (trnToUpd != null)
                {
                    trnToUpd.Status = "T";
                }

                using (var dbCtx = new DB_SYSFABEntities())
                {
                    dbCtx.Entry(trnToUpd).State = System.Data.Entity.EntityState.Modified;
                    dbCtx.SaveChanges();
                }

            }
        }

        public bool GetTransferHeaderById(int Id)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                var trn = db.Transfer.Where(s => s.Id == Id).SingleOrDefault();
                if (trn != null)
                {
                    if (trn.Id == Id)
                        return true;
                    else return false;
                }
                else
                    return false;
            }
        }

        public Transfer GetHeaderTransferById(int Id)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Transfer.Where(x => x.Id == Id).SingleOrDefault();
            }
        }

        public List<TransferDetail> GetDetailTransferById(int Id)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.TransferDetail.Where(x => x.Transfer == Id).ToList();
            }
        }

        public void InsertTransferHeader(Transfer header)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                db.Transfer.Add(header);
                db.SaveChanges();
            }
        }

        public void InsertTransferDetail(TransferDetail detail)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                db.TransferDetail.Add(detail);
                db.SaveChanges();
            }
        }


        public void UpdateTransferDetail(TransferDetail detail)
        {
            TransferDetail transferdetailToUpd;
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {

                transferdetailToUpd = db.TransferDetail.Where(s => s.Transfer == detail.Transfer && s.Line == detail.Line).FirstOrDefault<TransferDetail>();
                if (transferdetailToUpd!=null)
                {
                    transferdetailToUpd.SrcWarehouse = detail.SrcWarehouse;
                    transferdetailToUpd.TrgWarehouse = detail.TrgWarehouse;
                    transferdetailToUpd.Master = detail.Master;
                    transferdetailToUpd.Quantity = detail.Quantity;
                    transferdetailToUpd.UntMeasure = detail.UntMeasure;
                }

                using (var dbCtx = new DB_SYSFABEntities())
                {
                    dbCtx.Entry(transferdetailToUpd).State = System.Data.Entity.EntityState.Modified;
                    dbCtx.SaveChanges();
                }

            }

        }

        public void DeleteTransferDetail(int NroTransfer, int Line)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                var trnToDelete = db.TransferDetail.Where(s => s.Transfer == NroTransfer && s.Line == Line).FirstOrDefault<TransferDetail>();
                db.Entry(trnToDelete).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<dynamic> GetTransfersOnHold(int Src, int Trg)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return
                (from a in db.Transfer
                 join b in db.TransferDetail on a.Id equals b.Transfer
                 join c in db.Master on b.Master equals c.Id
                 join d in db.DescWarehouse on b.SrcWarehouse equals d.Id
                 join e in db.DescWarehouse on b.TrgWarehouse equals e.Id
                 join f in db.Catalog on b.UntMeasure equals f.Id
                 where b.SrcWarehouse == Src && b.TrgWarehouse == Trg
                     && a.Status == "I" && f.Table == 5
                group b by new { Src = d.Description , Trg = e.Description, c.Name, b.Transfer, UndMed = f.Description } into g
                select new { Source = g.Key.Src, Target = g.Key.Trg, Master = g.Key.Name, UndMed = g.Key.UndMed , Qty = g.Sum(x => x.Quantity), TransferNr = g.Key.Transfer }).ToList<dynamic>();
            }
        }

        public List<Transfer> GetTransfersIntransit()
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                return db.Transfer.Where(s => s.Id > 0 && s.Status == "T").ToList();
            }
        }

        public List<dynamic> GetTransfersDetailIntransit(int TransferNumber)
        {
            using (DB_SYSFABEntities db = new DB_SYSFABEntities())
            {
                var result = (from a in db.Transfer
                             join b in db.TransferDetail on a.Id equals b.Transfer
                             join c in db.DescWarehouse on b.SrcWarehouse equals c.Id
                             join d in db.DescWarehouse on b.TrgWarehouse equals d.Id
                             join e in db.Master on b.Master equals e.Id
                             join f in db.Catalog on b.UntMeasure equals f.Id 
                             where a.Id == TransferNumber
                                && a.Status == "T"
                                && f.Table == 5
                             select new { Line = b.Line, Src = c.Description, Target = d.Description, Master = e.Name, UntMeasure = f.Description, Qty = b.Quantity, Seleccionar = false, Observación = "" }).ToList<dynamic>();
                                
                return result;
            }
        }

        //public void UpdateTransfer(Transfer headerTransfer, List<TransferDetail> detailTransfer)
        //{
        //    Transfer transferToUpd;
        //    List<TransferDetail> detailtrnToUpd;
        //    using (DB_SYSFABEntities db = new DB_SYSFABEntities())
        //    {
        //        transferToUpd = db.Transfer.Where(s => s.Id == headerTransfer.Id).FirstOrDefault<Transfer>();
        //        detailtrnToUpd = db.TransferDetail.Where(s => s.Transfer == headerTransfer.Id).ToList();
        //    }

        //    if (transferToUpd != null)
        //    {
        //        transferToUpd.Description = headerTransfer.Description;
        //    }

        //    if (detailtrnToUpd != null && detailtrnToUpd.Count > 0)
        //    {

        //        pharmaToUpd.ActionPharmacology = pharma.ActionPharmacology;
        //        pharmaToUpd.Composition = pharma.Composition;
        //        pharmaToUpd.Dose = pharma.Dose;
        //        pharmaToUpd.Lab = pharma.Lab;
        //        pharmaToUpd.Prescription = pharma.Prescription;
        //        pharmaToUpd.Treatment = pharma.Treatment;
        //    }

        //    using (var dbCtx = new DB_SYSFABEntities())
        //    {
        //        dbCtx.Entry(masterToUpd).State = System.Data.Entity.EntityState.Modified;
        //        dbCtx.Entry(pharmaToUpd).State = System.Data.Entity.EntityState.Modified;
        //        dbCtx.SaveChanges();
        //    }

        //}

    }
}
