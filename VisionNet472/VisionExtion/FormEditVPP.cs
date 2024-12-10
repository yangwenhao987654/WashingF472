using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PaddleOCRSharp_Vpro
{
    public partial class FormEditVPP : Form
    {
        private string path;
        private CogToolBlock toolblock;
        public FormEditVPP()
        {
            InitializeComponent();
        }
        public FormEditVPP(CogToolBlock cogtool,string vpppath)
        {
            InitializeComponent();
            path = vpppath;
            toolblock = cogtool;
            this.txtVppPath.Text = path;
        }

        private void FormEditVPP_Load(object sender, EventArgs e)
        {
            this.cogToolBlockEditV21.Subject = toolblock;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                CogSerializer.SaveObjectToFile(this.cogToolBlockEditV21.Subject, path, typeof( BinaryFormatter),CogSerializationOptionsConstants.Minimum);
                //CogSerializer.SaveObjectToFile(this.cogToolBlockEditV21.Subject, path, typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), CogSerializationOptionsConstants.Minimum);
                MessageBox.Show("保存成功！");
            }
            catch (Exception exception)
            {
                MessageBox.Show("保存失败:" + exception.Message);
            }
        }
    }
}
