using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public  class WorkshopBusiness
    {
        public bool InsertWorkshop(tbl_Workshop Wp)
        {
            //Workshopdate should be greater than current date
            if (Wp.WorkShopDate > DateTime.Now)
            {
                WorkShopDb WD = new WorkShopDb();
                WD.InsertWorkshop(Wp);
                return true;
            }
            else
            {
                return false;
            }
        }

public List<tbl_Workshop> GetWorkshops()
        {
            WorkShopDb WD = new WorkShopDb();
            return WD.GetWorkshops();
        }

public tbl_Workshop GetWorkshopById(int WorkShopId)
{
    WorkShopDb WD = new WorkShopDb();
    tbl_Workshop Wp=WD.GetWorkshopById(WorkShopId);
    return Wp;
}

public bool UpdateWorkshopById(tbl_Workshop Wp, int WorkShopId)
{
    WorkShopDb WD = new WorkShopDb();
    if (Wp.WorkShopDate > DateTime.Now)
    {
        WD.UpdateWorkshopById(Wp, WorkShopId);
        return true;
    }
    else
    {
        return false;
    }
}
public bool DeleteWorkshopById(int WorkShopId)
{
    WorkShopDb WD = new WorkShopDb();
    WD.DeleteWorkshopById(WorkShopId);
    return true;
}

    }
}
