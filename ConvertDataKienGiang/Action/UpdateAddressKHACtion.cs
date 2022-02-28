using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang.Action
{
    public class UpdateAddressKHACtion
    {
        public void UpdateAddressKH()
        {
            var dbDataContext = new EOSKG_WebAppEntities();
            var context = new KG_ClockRecordEntities();

            var entities = (from kh in dbDataContext.KHACHHANGs
                            join dp in dbDataContext.DUONGPHOes on kh.MADP equals dp.MADP
                            join p in dbDataContext.PHUONGs on kh.MAPHUONG equals p.MAPHUONG
                            join kv in dbDataContext.KHUVUCs on kh.MAKV equals kv.MAKV
                            where kh.MAKV == "PQ"
                            select new
                            {
                                kh.IDKH,
                                kh.TENKH,
                                kh.SONHA,
                                dp.TENDP,
                                p.TENPHUONG,
                                kv.TENKV
                            });

            if(entities.Any())
            {
                
                foreach(var entity in entities)
                {
                    var result = context.t_Consumers.SingleOrDefault(c => c.ConsumerId == entity.IDKH);
                    if(result != null)
                    {
                        result.Address = $"{entity.SONHA}, {entity.TENDP}, {entity.TENPHUONG}, {entity.TENKV}";
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
