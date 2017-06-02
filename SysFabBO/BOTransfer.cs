using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabDAL;
using SysFabEAL;

namespace SysFabBO
{
    public class BOTransfer
    {
        public static void SaveTransfer(ref Transfer oneTransfer, ref TransferDetail oneDetail)
        {
            TransferDAL objTrnDAL = new TransferDAL();
            try
            {
                if (objTrnDAL.GetTransferHeaderById(oneTransfer.Id))
                    objTrnDAL.InsertTransferDetail(oneDetail);
                else
                    objTrnDAL.SaveTransfer(ref oneTransfer, ref oneDetail);

            }
            catch(Exception e)
            {

            }
            finally
            {

            }
        }

        public static string GetNameWarehouse(int IdWarehouse)
        {
            string result = string.Empty;
            WarehouseDAL objWhDAL = new WarehouseDAL();
            try
            {
                result = objWhDAL.GetNameWarehouseById(IdWarehouse);
            }
            catch(Exception e)
            {

            }
            finally
            {
                objWhDAL = null;
            }
            return result;
        }

        public static string GetNameMaster(int IdMaster)
        {
            string result = string.Empty;
            MasterDALC objMasterDAL = new MasterDALC();
            try
            {
                result = objMasterDAL.GetNameMasterById(IdMaster);
            }
            catch (Exception e)
            {

            }
            finally
            {
                objMasterDAL = null;
            }
            return result;
        }

        public static string GetNameMeasure(int IdMEasure)
        {
            string result = string.Empty;
            CatalogDAL objCatDAL = new CatalogDAL();
            try
            {
                result = objCatDAL.GetNameUntMeasure(IdMEasure);
            }
            catch (Exception e)
            {

            }
            finally
            {
                objCatDAL = null;
            }
            return result;
        }

        public static dynamic GetWarehouseStockByMaster(int idWarehouse, int idMaster)
        {
            WarehouseDAL objWDAL = new WarehouseDAL();
            dynamic resul=null;
            try
            {
                resul = objWDAL.GetWarehouseStockByMaster(idWarehouse, idMaster);
            }
            catch(Exception e)
            {

            }
            finally { objWDAL = null; }
            return resul;
        }

        public static List<dynamic> GetTransfersOnHold(int Src, int Trg)
        {
            TransferDAL objWDAL = new TransferDAL();
            List<dynamic> resul = null;
            try
            {
                resul = objWDAL.GetTransfersOnHold(Src, Trg);
            }
            catch (Exception e)
            {

            }
            finally { objWDAL = null; }
            return resul;
        }

        public static List<Transfer> GetTransfersInTransit()
        {
            TransferDAL objWDAL = new TransferDAL();
            List<Transfer> resul = null;
            try
            {
                resul = objWDAL.GetTransfersIntransit();
            }
            catch (Exception e)
            {

            }
            finally { objWDAL = null; }
            return resul;
        }

        public static List<dynamic> GetTransfersDetailIntransit(int TransferNumber)
        {
            TransferDAL objWDAL = new TransferDAL();
            List<dynamic> resul = null;
            try
            {
                resul = objWDAL.GetTransfersDetailIntransit(TransferNumber);
            }
            catch (Exception e)
            {

            }
            finally { objWDAL = null; }
            return resul;
        }

        public static Transfer GetHeaderById(int Id)
        {
            TransferDAL objTrnDal = new TransferDAL();
            Transfer resul = null;
            try
            {
                resul = objTrnDal.GetHeaderTransferById(Id);
            }
            catch(Exception e)
            { }
            finally
            {
                objTrnDal = null;
            }
            return resul;
        }

        public static List<TransferDetail> GetDetailById(int Id)
        {
            TransferDAL objTrnDal = new TransferDAL();
            List<TransferDetail> resul = null;
            try
            {
                resul = objTrnDal.GetDetailTransferById(Id);
            }
            catch(Exception e)
            { }
            finally
            {
                objTrnDal = null;
            }
            return resul;
        }

        public static void TransferToWarehouse(int TransferNumber)
        {
            TransferDAL objTrnDAL = new TransferDAL();
            try
            {
                objTrnDAL.TransferToWarehouse(TransferNumber);
            }
            catch(Exception e)
            {

            }
            finally { objTrnDAL = null; }
        }

    }
}
