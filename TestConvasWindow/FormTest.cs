using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisionNet472
{
    public partial class FormTest : UIForm
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private int count = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            //ctrlOCV1.Init

            //设置面板拖动
            this.uiPanel1.DragEnter += FormTest_DragEnter;
            this.uiPanel1.DragDrop += FormTest_DragDrop;
           
        }

        private void FormTest_DragDrop(object sender, DragEventArgs e)
        {
            // 获取拖拽的数据
            if (e.Data.GetDataPresent(typeof(UIButton)))
            {
                //相对位移坐标
                Point dropLocation = this.PointToClient(new Point(e.X - uiPanel1.Location.X, e.Y - uiPanel1.Location.Y));
                #region 拖动原来的按钮
                var button = (UIButton)e.Data.GetData(typeof(UIButton));

                // 将按钮移动到鼠标释放的位置
                button.Location = dropLocation;
                #endregion

                #region 生成新的按钮
             /*   //拖放完毕之后，自动生成新控件
                UIButton btn = new UIButton();
                btn.Size = btn.Size;
                btn.Location = dropLocation;
                //用这个方法计算出客户端容器界面的X，Y坐标。否则直接使用X，Y是屏幕坐标
                uiPanel1.Controls.Add(btn);
                btn.Text = "按钮" + count.ToString();
                count = count + 1;*/
                #endregion

            }
        }

        private void FormTest_DragEnter(object sender, DragEventArgs e)
        {
            // 如果拖拽的数据是 Button 类型，则允许拖拽
            if (e.Data.GetDataPresent(typeof(UIButton)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void uiButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 开始拖拽操作
                DoDragDrop(sender, DragDropEffects.Move|DragDropEffects.Copy);
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            UIButton btn = new UIButton();
            btn.Size = btn.Size;
            btn.Location = new Point(10,10);
            //用这个方法计算出客户端容器界面的X，Y坐标。否则直接使用X，Y是屏幕坐标
            uiPanel1.Controls.Add(btn);
            btn.Text = "按钮" + count.ToString();
            count = count + 1;
            btn.AllowDrop =true;
            btn.MouseDown += uiButton2_MouseDown;
        }
    }
}
