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
        //public int counter = 0;
        public Form1()
        {
            InitializeComponent();
          
        }
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int vKey);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*public void timer1_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(67) != 0)
            {
                pictureBox1.BackColor = Color.SkyBlue;
                counter = counter+1;
                label4.Text =Convert.ToString(counter);
            }
            else {
                pictureBox1.BackColor = Color.White;
            }
            if (GetAsyncKeyState(68) != 0)
            {
                pictureBox2.BackColor = Color.SkyBlue;
                counter = counter + 1;
                label4.Text = Convert.ToString(counter);
            }
            else
            {
                pictureBox2.BackColor = Color.White;
            }
        }*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (init_AB == false)
            {
                last_v67 = GetAsyncKeyState(67);
                last_v68 = GetAsyncKeyState(68);
                init_AB = true;
            }


            if (GetAsyncKeyState(67) != 0)
            {
                pictureBox1.BackColor = Color.SkyBlue;
                if (GetAsyncKeyState(67) != last_v67)
                {
                    counter++;
                    label4.Text = counter.ToString();
                    last_v67 = GetAsyncKeyState(67);
                }


            }
            else
            {
                pictureBox1.BackColor = Color.White;
                last_v67 = GetAsyncKeyState(67);
            }
            if (GetAsyncKeyState(68) != 0)
            {
                pictureBox2.BackColor = Color.SkyBlue;
                if (GetAsyncKeyState(68) != last_v68)
                {
                    counter++;
                    label4.Text = counter.ToString();
                    last_v68 = GetAsyncKeyState(68);
                }

            }
            else
            {
                pictureBox2.BackColor = Color.White;
                last_v68 = GetAsyncKeyState(68);
            }

        }
    }

}
