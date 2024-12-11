using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionNet472.CommunicationYwh.Device
{
    public interface IScannerSuppoprt
    {
         void Trigger();

         string GetResult();


         string TriggerCmd { get; set; }

         string StopCmd  { get; set; }
}
}
