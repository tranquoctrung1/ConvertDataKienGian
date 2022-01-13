using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class InsertContractAction
    {
        public void InsertContract()
        {
            GetListKHAction action = new GetListKHAction();

            List<KHACHHANG> list = action.GetListKH("PQ");

            foreach(KHACHHANG kh in list)
            {
                tbl_Contract ct = new tbl_Contract();

                ct.ContractCode = kh.MADB + "_" + kh.IDKH;
                ct.ContractType = 1;
                ct.RegisterID = 1;
                ct.ClockCode = kh.MADH;
                ct.ZoneCode = "PQ";
                ct.Disable = 0;

                using(var db = new KG_ClockRecordEntities())
                {
                    db.tbl_Contract.Add(ct);
                    db.SaveChanges();
                }
            }
        }
    }
}
