using ConvertDataKienGiang.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataKienGiang
{
    class Program
    {
        static void Main(string[] args)
        {
            //// fill meter

            //InsertMeterAction insertMeterAction = new InsertMeterAction();

            //insertMeterAction.InsertMeter();


            //// fill site 
            //InsertDataKGRecordAction insertDataKGRecordAction = new InsertDataKGRecordAction();

            //insertDataKGRecordAction.InsertDataKGRecord();

            //// fill consumers 
            //InsertConsumerAction insertConsumerAction = new InsertConsumerAction();

            //insertConsumerAction.InsertConsumer();

            //// insert contract 
            //InsertContractAction insertContractAction = new InsertContractAction();

            //insertContractAction.InsertContract();

            // insert clock record
            InsertClockRecordAction insertClockRecordAction = new InsertClockRecordAction();

            insertClockRecordAction.InsertClockRecord(2021, 12);
            insertClockRecordAction.InsertClockRecord(2021, 11);
            insertClockRecordAction.InsertClockRecord(2021, 10);
        }
    }
}
