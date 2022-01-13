using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class InsertMeterAction
    {
        public void InsertMeter()
        {
            GetListKHAction action = new GetListKHAction();

            List<KHACHHANG> list = action.GetListKH("PQ").ToList();

            foreach(KHACHHANG kh  in list)
            {
                try
                {
                    t_Meters meter = new t_Meters();

                    meter.Serial = kh.MADH;

                    if (meter.Serial != null)
                    {
                        using (var db = new KG_ClockRecordEntities())
                        {
                            db.t_Meters.Add(meter);
                            db.SaveChanges();
                        }
                    }

                }
                catch (Exception ex)
                {

                }
                
            }
        }
    }
}
