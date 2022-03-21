using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class UpdateRouteIdAction
    {
        public void UpdateRouteId(DateTime time)
        {
            var db = new KG_ClockRecordEntities();
            ((IObjectContextAdapter)db).ObjectContext.CommandTimeout = 180;


            List<tbl_ClockRecord> list = db.tbl_ClockRecord.Where(t => t.Period == time).ToList();

            foreach(tbl_ClockRecord record in list)
            {
                List<tbl_ClockRecord> listUpdate = db.tbl_ClockRecord.Where(t => t.ContractID == record.ContractID && t.Period > time).ToList();
                if(listUpdate.Count > 0)
                {
                    foreach (tbl_ClockRecord el in listUpdate)
                    {
                        el.RouteID = record.RouteID;

                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
