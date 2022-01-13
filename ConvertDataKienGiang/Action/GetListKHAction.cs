using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class GetListKHAction
    {
        public List<KHACHHANG> GetListKH(string kv)
        {
            var db = new EOSKG_WebAppEntities();

            var query = (from kh in db.KHACHHANGs
                         where kh.MAKV == kv
                         select new
                         {
                             IDKH = kh.IDKH,
                             MADP = kh.MADP,
                             DUONGPHU = kh.DUONGPHU,
                             MADBCU = kh.MADBCU,
                             STT = kh.STT,
                             MAMDSD = kh.MAMDSD,
                             NHOMKV = kh.NHOMKV,
                             CMND = kh.CMND,
                             NOICAPCM = kh.NOICAPCM,
                             MADDK = kh.MADDK,
                             MST = kh.MST,
                             STK = kh.STK,
                             MALKH = kh.MALKH,
                             MAHTTT = kh.MATT,
                             ISDINHMUC = kh.ISDINHMUC,
                             SONK = kh.SONK,
                             M3KHOAN = kh.M3KHOAN,
                             THUEBAO = kh.THUEBAO,
                             MALDH = kh.MALDH,
                             THUYLK = kh.THUYLK,
                             NGAYHT = kh.NGAYHT,
                             NGAYCUP = kh.NGAYCUP,
                             SLANTHAYDH = kh.SLANTHAYDH,
                             TTSD = kh.TTSD,
                             KOPHINT = kh.KOPHINT,
                             KOVAT = kh.KOVAT,
                             TTHD = kh.TTHD,
                             TTHD_DIACHI = kh.TTHD_DIACHI,
                             MATT = kh.MATT,
                             KYKHAITHAC = kh.KYKHAITHAC,
                             CHISOCUOI = kh.CHISOCUOI,
                             CHANLE = kh.CHANLE,
                             SODU = kh.SODU,
                             ISXOABO = kh.ISXOABO,
                             NGAYXOA = kh.NGAYXOA,
                             MANVXOA = kh.MANVXOA,
                             ISNUOCTHO = kh.ISNUOCTHO,
                             GIAHD = kh.GIAHD,
                             ISKHDB = kh.ISKHDB,
                             SORT = kh.SORT,
                             NGAYHETHANDH = kh.NGAYHETHANDH,
                             MAVUNG = kh.MAVUNG,
                             TENKH = kh.TENKH,
                             MAKV = kh.MAKV,
                             SONHA = kh.SONHA,
                             MAPHUONG = kh.MAPHUONG,
                             SDT = kh.SDT,
                             MADB = kh.MADB,
                             NGAYTHAYDH = kh.NGAYTHAYDH,
                             MADH = kh.MADH,
                             TTHD_TENKH = kh.TTHD_TENKH,
                             CHISODAU = kh.CHISODAU,
                         }).ToList();


            var list = query.Select(kh => new KHACHHANG()
            {
                IDKH = kh.IDKH,
                MADP = kh.MADP,
                DUONGPHU = kh.DUONGPHU,
                MADBCU = kh.MADBCU,
                STT = kh.STT,
                MAMDSD = kh.MAMDSD,
                NHOMKV = kh.NHOMKV,
                CMND = kh.CMND,
                NOICAPCM = kh.NOICAPCM,
                MADDK = kh.MADDK,
                MST = kh.MST,
                STK = kh.STK,
                MALKH = kh.MALKH,
                MAHTTT = kh.MATT,
                ISDINHMUC = kh.ISDINHMUC,
                SONK = kh.SONK,
                M3KHOAN = kh.M3KHOAN,
                THUEBAO = kh.THUEBAO,
                MALDH = kh.MALDH,
                THUYLK = kh.THUYLK,
                NGAYHT = kh.NGAYHT,
                NGAYCUP = kh.NGAYCUP,
                SLANTHAYDH = kh.SLANTHAYDH,
                TTSD = kh.TTSD,
                KOPHINT = kh.KOPHINT,
                KOVAT = kh.KOVAT,
                TTHD = kh.TTHD,
                TTHD_DIACHI = kh.TTHD_DIACHI,
                MATT = kh.MATT,
                KYKHAITHAC = kh.KYKHAITHAC,
                CHISOCUOI = kh.CHISOCUOI,
                CHANLE = kh.CHANLE,
                SODU = kh.SODU,
                ISXOABO = kh.ISXOABO,
                NGAYXOA = kh.NGAYXOA,
                MANVXOA = kh.MANVXOA,
                ISNUOCTHO = kh.ISNUOCTHO,
                GIAHD = kh.GIAHD,
                ISKHDB = kh.ISKHDB,
                SORT = kh.SORT,
                NGAYHETHANDH = kh.NGAYHETHANDH,
                MAVUNG = kh.MAVUNG,
                TENKH = kh.TENKH,
                MAKV = kh.MAKV,
                SONHA = kh.SONHA,
                MAPHUONG = kh.MAPHUONG,
                SDT = kh.SDT,
                MADB = kh.MADB,
                NGAYTHAYDH = kh.NGAYTHAYDH,
                MADH = kh.MADH,
                TTHD_TENKH = kh.TTHD_TENKH,
                CHISODAU = kh.CHISODAU,
            });

            return list.ToList();
        }
    }
}
