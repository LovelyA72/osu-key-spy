using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Your_Name
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int vKey);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool hitA = false;
            bool hitB = false;
            if (GetAsyncKeyState(67) != 0)
            {
                pictureBox1.BackColor = Color.SkyBlue;

            }
            else {
                pictureBox1.BackColor = Color.White;
            }
            if (GetAsyncKeyState(68) != 0)
            {
                pictureBox2.BackColor = Color.SkyBlue;
            }
            else
            {
                pictureBox2.BackColor = Color.White;
            }
        }

    }
}
