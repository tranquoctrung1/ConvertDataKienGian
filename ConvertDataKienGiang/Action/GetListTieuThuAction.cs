using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class GetListTieuThuAction
    {
        public List<TIEUTHU> GetListTieuThu(string kv, int year, int month)
        {
            var db = new EOSKG_WebAppEntities();
            ((IObjectContextAdapter)db).ObjectContext.CommandTimeout = 180;

            var query = (from tt in db.TIEUTHUs
                         where tt.MAKV == kv && tt.NAM == year && tt.THANG == month
                         select new  { 
                                IDKH = tt.IDKH,
                                THANG = tt.THANG,
                                NAM = tt.NAM,
                                MADB = tt.MADB,
                                CHISODAU = tt.CHISODAU,
                                CHISOCUOI  = tt.CHISOCUOI,
                                NGAYNHAP_CS = tt.NGAYNHAP_CS,
                                MANVN_CS = tt.MANVN_CS
                            
                         }).ToList();

            var list = query.Select(tt => new TIEUTHU()
            {
                IDKH = tt.IDKH,
                THANG = tt.THANG,
                NAM = tt.NAM,
                MADB = tt.MADB,
                CHISODAU = tt.CHISODAU,
                CHISOCUOI = tt.CHISOCUOI,
                NGAYNHAP_CS = tt.NGAYNHAP_CS,
                MANVN_CS = tt.MANVN_CS
            });

            return list.ToList();
        }
    }
}
