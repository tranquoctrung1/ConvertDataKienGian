using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class InsertConsumerAction
    {
        public void InsertConsumer()
        {
            GetListKHAction action = new GetListKHAction();

            List<KHACHHANG> list = action.GetListKH("PQ").ToList();

            foreach(KHACHHANG kh in list)
            {
                var consumer = new t_Consumers()
                {
                    ConsumerId = kh.IDKH,
                    Zoom = null,
                    Description = kh.TENKH,
                    SetDefault = null,
                    Acronym = "",
                    Address = kh.SONHA,
                    Email = "",
                    Fax = "",
                    Phone = kh.SDT,
                    Contact = "",
                    Career = "",
                    DMA = kh.MAKV,


                };

                using (var db = new KG_ClockRecordEntities())
                {
                    db.t_Consumers.Add(consumer);
                    db.SaveChanges();

                }
            }
        }
    }
}
