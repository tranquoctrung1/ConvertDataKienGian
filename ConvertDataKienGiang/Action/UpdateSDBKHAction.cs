using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class UpdateSDBKHAction
    {
        public void UpdateSDBKH()
        {
            var dbDataContext = new EOSKG_WebAppEntities();
            var context = new KG_ClockRecordEntities();

            List<KHACHHANG> list = dbDataContext.KHACHHANGs.Where(k => k.MAKV == "PQ").ToList();

            foreach(var kh in list)
            {
                var k = dbDataContext.TIEUTHUs.Where(t => t.IDKH == kh.IDKH).OrderByDescending(t => t.NAM).FirstOrDefault();
                if(k != null)
                {
                    var result = context.t_Consumers.FirstOrDefault(t => t.ConsumerId == kh.IDKH);
                    if(result != null)
                    {
                        result.Acronym = k.SODB;
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
