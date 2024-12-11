using LogTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationUtilYwh.Communication;
using CommunicationUtilYwh.Communication.ModbusRTU;

namespace VisionNet472.CommunicationYwh.Device
{
    public class WeightController232: IDisposable
    {
        private ModbusRTU client;

        public bool IsConnect
        {
            get
            {
                return client != null && client.IsConnect;
            }
        }
        public WeightController232()
        {
            client = new ModbusRTU();
        }

        public bool Open(string portName)
        {
            return client.Open(portName);
        }

        public void Close()
        {
            client.Dispose();
        }

        private bool SendCmd()
        {

            //client.Read()
            return true;
        }

        /// <summary>
        /// 读取温度
        /// </summary>
        public int ReadWeight()
        {
            string address = "80";
            bool f = client.ReadInt32(address, out int value);
            if (!f)
            {
                LogMgr.Instance.Error("读取温度失败");
            }
            return value;
        }

        public void Dispose()
        {
            client?.Dispose();
        }
    }
}
