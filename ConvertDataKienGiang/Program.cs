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

            //// insert clock record
            //InsertClockRecordAction insertClockRecordAction = new InsertClockRecordAction();

            //insertClockRecordAction.InsertClockRecord(2022, 01);
            //insertClockRecordAction.InsertClockRecord(2022, 02);

            //// update address for consumer
            //UpdateAddressKHACtion updateAddressKHACtion = new UpdateAddressKHACtion();
            //updateAddressKHACtion.UpdateAddressKH();

            //// update sdb for consumer
            //UpdateSDBKHAction updateSDBKHAction = new UpdateSDBKHAction();
            //updateSDBKHAction.UpdateSDBKH();

            // update madp for site 
            //UpdateMADPKHAction updateMADPKHAction = new UpdateMADPKHAction();
            //updateMADPKHAction.UpdateMADPKH();

            // update route id
            UpdateRouteIdAction updateRouteIdAction = new UpdateRouteIdAction();

            DateTime time = new DateTime(2021, 12, 01, 00, 00, 00);

            updateRouteIdAction.UpdateRouteId(time);

        }
    }
}
