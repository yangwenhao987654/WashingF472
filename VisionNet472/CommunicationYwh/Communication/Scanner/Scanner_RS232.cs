using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationUtilYwh.Communication;
using LogTool;
using VisionNet472.CommunicationYwh.Device;

namespace CommunicationUtilYwh.Device
{
    public class Scanner_RS232: SerialCommunication, IScannerSuppoprt
    {
        public string TriggerCmd { get; set; } ="LON";
        public string StopCmd { get; set; } = "LOFF";


        public Scanner_RS232(SerialPort serialPort) :base(serialPort)
        {
            
        }

        public void Trigger()
        {
            this.CleanInBuffer();
            //
            this.SendData(TriggerCmd);
        }

        public string GetResult()
        {
            string result = ReadStr();
            LogMgr.Instance.Debug(@$"扫码结果:{result}");
            LogMgr.Instance.Debug(@$"扫码长度:{result.Length}");
            if (result !="")
            {
                result =result.TrimEnd('\r', '\n');
                result =result.Replace("\r", "");
                result = result.Replace("\n", "");
                result  =result.Replace(" ", "");
                //result.ReplaceLineEndings("\r");
                LogMgr.Instance.Debug(@$"过滤后长度:{result.Length}");
            }
            return result;
        }


    }
}
