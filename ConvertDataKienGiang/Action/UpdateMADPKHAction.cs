using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class UpdateMADPKHAction
    {
        public void UpdateMADPKH()
        {
            var dbDataContext = new EOSKG_WebAppEntities();
            var context = new KG_ClockRecordEntities();

            List<KHACHHANG> list = dbDataContext.KHACHHANGs.Where(k => k.MAKV == "PQ").ToList();

            int count = 0;

            foreach(var k in list)
            {
                t_Sites site  = context.t_Sites.FirstOrDefault(s => s.ConsumerId == k.IDKH);

                if(site != null)
                {
                    Console.WriteLine(++count);

                    site.PipeSize = k.MADP;
                    context.SaveChanges();
                }
            }
        }
    }
}
