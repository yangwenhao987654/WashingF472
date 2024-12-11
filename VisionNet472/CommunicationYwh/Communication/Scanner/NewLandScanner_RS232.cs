using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationUtilYwh.Communication;
using LogTool;

namespace VisionNet472.CommunicationYwh.Device
{
    
    /// <summary>
    /// 新大洲扫码枪通讯
    /// </summary>
    public class NewLandScanner_RS232 :SerialCommunication,IScannerSuppoprt
    {
        public string TriggerCmd { get; set; } = "<SOH> T <EOT>";  //16进制 01 54 04
        public string StopCmd { get; set; } = "<SOH> P <EOT>";    //16进制 01 50 04

        public NewLandScanner_RS232(SerialPort serialPort) : base(serialPort)
        {

        }

        public void Trigger()
        {
            this.CleanInBuffer();
            //

            byte[] data = { 0x01,0x54,0x04};
            this.SendData(data);
        }

        public void Stop()
        {
            this.CleanInBuffer();
            //

            byte[] data = { 0x01, 0x50, 0x04 };
            this.SendData(data);
        }

        public string GetResult()
        {
            string result = ReadStr();
          
            if (result != "")
            {
                result = result.TrimEnd('\r', '\n');
                result = result.Replace("\r", "");
                result = result.Replace("\n", "");
                result = result.Replace(" ", "");
                // LogMgr.Instance.Debug(@$"过滤后长度:{result.Length}");
            }
            return result;
        }
    }
}
