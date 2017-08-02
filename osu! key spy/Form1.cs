using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Your_Name
{

    public partial class Form1 : Form
    {
        //public int countercache = 0;
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        //[DllImport("kernel32.dll")]

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
                label2.BackColor = Color.SkyBlue;
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
                label2.BackColor = Color.White;
                last_v67 = GetAsyncKeyState(67);
            }
            if (GetAsyncKeyState(68) != 0)
            {
                pictureBox2.BackColor = Color.SkyBlue;
                label3.BackColor = Color.SkyBlue;
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
                label3.BackColor = Color.White;
                last_v68 = GetAsyncKeyState(68);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            label4.Text = counter.ToString();
        }
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }
        
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "THANKS";
            // Thread.Sleep(1000);
            Delay(1000);
            label4.Text = "4 USING";
            // Thread.Sleep(1000);
            Delay(1000);
            label4.Text = "THE SOF";
            // Thread.Sleep(1000);
            Delay(1000);
            label4.Text = "WARE";
            // Thread.Sleep(1000);
            Delay(1000);
            label4.Text = "FROM";
            // Thread.Sleep(1000);
            Delay(1000);
            label4.Text = "TEAM.";
            // Thread.Sleep(500);
            Delay(500);
            label4.Text = "TEAM..";
            // Thread.Sleep(500);
            Delay(500);
            label4.Text = "TEAM...";
            // Thread.Sleep(500);
            Delay(500);
            label4.Text = "A72";
            // Thread.Sleep(2000);
            Delay(2000);
            label4.Text = counter.ToString();
            MessageBox.Show("osu! key spy\n2017 TEAM A72\nvisit our website at https://www.yzwiki.com \nProject GitHub: https://github.com/LovelyA72/osu-key-spy \n\nHeXiaoling I love you!", "About");
        }

        private void 主站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yzwiki.com/blog/");
        }

        private void 主站ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yzwiki.com/item/Main_Page");
        }

        private void 何小绫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yzwiki.com/item/%E4%BD%95%E5%B0%8F%E7%BB%AB");
        }
    }
    }
