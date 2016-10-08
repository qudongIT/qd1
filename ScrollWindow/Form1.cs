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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Cursor = new Cursor(Application.StartupPath + "\\Cursor1.cur");
            this.Cursor = new Cursor(@"C:\Users\qd\Documents\Visual Studio 2015\Projects\ScrollWindow\ScrollWindow\Cursor1.cur");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //1
            //2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
