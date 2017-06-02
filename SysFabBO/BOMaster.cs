using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFabEAL;
using SysFabDAL;

namespace SysFabBO
{
    public class BOMaster
    {
        public static List<Master> GetListMasterByFilter(string filter)
        {
            MasterDALC objDLMaster = new MasterDALC();
            List<Master> oneMaster = null;
            try
            {
                oneMaster = objDLMaster.GetListMasterByFilter(filter);
            }
            catch (Exception e)
            { }
            finally
            {
                objDLMaster = null;
            }
            return oneMaster;
        }

        public static Master GetMasterByBarCode(string BarCode)
        {
            MasterDALC objDLMaster = new MasterDALC();
            Master oneMaster = null;
            try
            {
                oneMaster = objDLMaster.GetMasterByBarCode(BarCode);
            }
            catch(Exception e)
            {}
            finally
            {
                objDLMaster = null;
            }
            return oneMaster;
        }

        public static Pharmacology GetPharmaByMaster(int master)
        {
            MasterDALC objDLMaster = new MasterDALC();
            Pharmacology onePharma = null;
            try
            {
                onePharma = objDLMaster.GetPharmaByMaster(master);
            }
            catch (Exception e)
            { }
            finally
            {
                objDLMaster = null;
            }
            return onePharma;
        }

        public static List<Master> GetListMaster()
        {
            MasterDALC objDLMaster = new MasterDALC();
            return objDLMaster.GetListMaster(); 
        }

        public static List<Catalog> GetListCatalog(int table)
        {
            CatalogDAL objDLCatalog = new CatalogDAL();
            return objDLCatalog.GetListCatalog(table);
        }

        public static bool SaveMaster(Master oneMaster, Pharmacology onePharma)
        {
            MasterDALC objDLMaster = new MasterDALC();
            bool result = false;
            try
            {
                //Master tmp = GetMasterByBarCode(oneMaster.CodeBar);
                if (oneMaster.Id == 0)
                    objDLMaster.CreateMaster(oneMaster, onePharma);
                else if(oneMaster.Id > 0)
                    objDLMaster.UpdateMaster(oneMaster, onePharma);
                result = true;
            }
            catch (Exception e)
            { }
            finally
            {
                objDLMaster = null;
            }
            return result;
        }

        public static bool DeleteMaster(int delMaster)
        {
            MasterDALC objDLMaster = new MasterDALC();
            bool result = false;
            try
            {
                objDLMaster.DeleteMaster(delMaster);
                result = true;
            }
            catch (Exception e)
            { }
            finally
            {
                objDLMaster = null;
            }
            return result;
        }

        public static string GetNameMasterById(int IdMaster)
        {
            string resul = string.Empty;
            MasterDALC objMD = new MasterDALC();
            try
            {
                resul = objMD.GetNameMasterById(IdMaster);
            }
            catch(Exception e)
            {

            }
            finally
            {
                objMD = null;
            }
            return resul;
        }

        public static string GetNameMeasuredById(int IdMeasure)
        {
            string resul = string.Empty;
            CatalogDAL objMD = new CatalogDAL();
            try
            {
                resul = objMD.GetNameUntMeasure(IdMeasure);
            }
            catch (Exception e)
            {

            }
            finally
            {
                objMD = null;
            }
            return resul;
        }

    }
}
