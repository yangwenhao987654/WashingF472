using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace UI.Extend
{
    public static class TbxCheckExtend
    {
        public static bool CheckLength(this TextBox tbx,string name, int length)
        {
            if (tbx.Text=="")
            {
               throw new Exception($"{name} 不能为空");
            }

            if (tbx.Text.Length!=length)
            {
                throw new Exception($"{name} 长度应该为[{length}]");
            }

            return true;
        }

        public static bool CheckLength(this UITextBox tbx, string name, int length)
        {
            if (tbx.Text == "")
            {
                throw new Exception($"{name} 不能为空");
            }

            if (tbx.Text.Length != length)
            {
                throw new Exception($"{name} 长度应该为[{length}]");
            }
            return true;
        }
    }
}
