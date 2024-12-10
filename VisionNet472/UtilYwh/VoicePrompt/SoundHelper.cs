using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace UtilYwh.VoicePrompt
{
    public class SoundHelper
    {

        public SoundPlayer player;

        public SoundHelper()
        {
            player = new SoundPlayer("10217.wav");
            player.Load();
        }

        public  void PlayErr()
        {
            try
            {
                player.Play(); // 异步播放
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
         
        }
    }
}
