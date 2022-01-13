using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class InsertDataKGRecordAction
    {
        public void InsertDataKGRecord()
        {
            GetListKHAction action = new GetListKHAction();

            List<KHACHHANG> list = action.GetListKH("PQ").ToList();

            foreach (KHACHHANG kh in list)
            {
                var site = new t_Sites();

                site.SiteId = kh.MADB + "_" + kh.IDKH;
                site.SiteAliasName = kh.MADB + "_" + kh.IDKH;
                site.Location = kh.SONHA + kh.MAPHUONG;
                site.Latitude = 0;
                site.Longitude = 0;
                site.DisplayGroup = kh.MAKV;
                site.Zoom = 16;
                site.ConsumerId = kh.IDKH;
                site.LoggerId = null;
                site.StartDay = null;
                site.Description = kh.TTHD_TENKH;
                site.MeterSerial = kh.MADH;
                site.TransmitterSerial = null;
                site.LoggerSerial = null;
                site.MeterDateChanged = kh.NGAYHETHANDH;
                site.TransmitterDateChanged = null;
                site.LoggerDateChanged = null;
                site.Availability = "HD";
                site.Status = "DSD";
                site.Using = "Feed";
                site.CurrencyCode = "VND";
                site.BookId = 4;
                if (kh.CHISODAU != null)
                {
                    site.FirstIndex = long.Parse(kh.CHISODAU.ToString());
                }
                else
                {
                    site.FirstIndex = null;
                }
                site.Disable = 0;

                using (var db = new KG_ClockRecordEntities())
                {
                    db.t_Sites.Add(site);
                    db.SaveChanges();
                }
            }
        }
    }
}
