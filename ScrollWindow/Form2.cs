using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollWindow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //将窗体的背景色设置为白色
            this.BackColor = Color.White;
            //当工作区小于300×250像素时显示滚动条
            this.AutoScrollMinSize = new Size(300, 251);
            Size t = this.ClientSize;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            //平移坐标系
            g.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
            //绘制矩形和椭圆
            g.FillRectangle(Brushes.LightPink, 0, 0, 200, 150);
            g.FillRectangle(Brushes.LightGreen, 0, 150, 300, 100);
        }
    }
}
