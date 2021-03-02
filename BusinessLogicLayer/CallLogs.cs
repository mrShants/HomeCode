using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
   public class CallLogs
    {
        private int callID;
        private string customerName;
        private string customerSurname;
        private string callDuration;

        public CallLogs()
        {

        }

        public CallLogs(int callID, string customerName, string customerSurname, string callDuration)
        {
            this.callID = callID;
            this.customerName = customerName;
            this.customerSurname = customerSurname;
            this.callDuration = callDuration;

        }

        public int CallID { get => callID; set => callID = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerSurname { get => customerSurname; set => customerSurname = value; }
        public string CallDuration { get => callDuration; set => callDuration = value; }

        public List<CallLogs> getBLCall()
        {
            DataSet callData = new DataSet();
            List<CallLogs> readCallData = new List<CallLogs>();
            CallLogDatahandler cl = new CallLogDatahandler();
            callData = cl.GetCall("tblCallLog");

            foreach(DataRow item in callData.Tables["tblCallLog"].Rows)
            {
                readCallData.Add(new CallLogs(
                    int.Parse(item["CallID"].ToString()),
                    item["CustomerName"].ToString(),
                    item["CustomerSurname"].ToString(),
                    item["CallDuration"].ToString()));
            }
            return readCallData;
        }

        public void InsertBLCall(string name, string surname, string callduration)
        {
            CallLogDatahandler cl = new CallLogDatahandler();
            cl.InsertCall( name,  surname,  callduration);
        }
    }
}
