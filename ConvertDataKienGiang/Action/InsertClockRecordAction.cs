using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class InsertClockRecordAction
    {
        public void InsertClockRecord(int year, int month)
        {
            GetListTieuThuAction action = new GetListTieuThuAction();

            List<TIEUTHU> list = action.GetListTieuThu("PQ", year, month);

            foreach(TIEUTHU tt in list)
            {
                tbl_ClockRecord cr = new tbl_ClockRecord();

                using(var db = new KG_ClockRecordEntities())
                {
                    var contract = (from ct in db.tbl_Contract
                                    where ct.ContractCode == tt.MADB + "_" + tt.IDKH
                                    select new 
                                    {
                                        ContractID = ct.ContractID,
                                    }
                                    ).ToList();

                    cr.ContractID = contract.FirstOrDefault().ContractID;
                }

                cr.Period = new DateTime(year, month, 1, 0, 0, 0);
                if(tt.CHISODAU != null)
                {
                    cr.FirstNumber = long.Parse(tt.CHISODAU.ToString());
                }
                else
                {
                    cr.FirstNumber = null;
                }
                if(tt.CHISOCUOI != null)
                {
                    cr.LastNumber = long.Parse(tt.CHISOCUOI.ToString());
                }
                else
                {
                    cr.LastNumber = null;
                }
                cr.FirstDate = tt.NGAYNHAP_CS;
                cr.User_Input = "";
                cr.UsageNumber = 0;
                cr.InputTime = 1;

                cr.LockedStatus = false;
                cr.BookId = 4;

                using(var db = new KG_ClockRecordEntities())
                {
                    db.tbl_ClockRecord.Add(cr);
                    db.SaveChanges();
                }
            }
        }
    }
}
