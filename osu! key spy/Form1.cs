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
using System.IO;
using osu_key_spy;

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
        public void amountChk(int amount) {
            //检查计数器是否超标
            if (amount > 99999999) {
                //MessageBox.Show("你输入的数值超过了这个程序可以承受的数值了哦~");
                counter = 0;//如果超标，清零
            }
        }
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
                    amountChk(counter);
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
                    amountChk(counter);
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
            label4.Text = "TEAM A72";
            MessageBox.Show("osu! key spy\n2017 TEAM A72\nvisit our website at https://www.yzwiki.com \nProject GitHub: https://github.com/LovelyA72/osu-key-spy \n\nHeXiaoling I love you!", "About");
            label4.Text = counter.ToString();
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

        private void 项目Github页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LovelyA72/osu-key-spy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                MessageBox.Show("你什么也没输入欸？");
                return;
            }
            int inputlenth = 0;
            string cache = "";
            cache = textBox1.Text;
            inputlenth = cache.Length;
            for (int i = 0;i<inputlenth;i++) {
                if (cache[i] >= '0'&& cache[i] <= '9')
                {
                }
                else {
                    MessageBox.Show("不要输入奇怪的东西哦！");
                    return;
                }
            }
            if (Convert.ToInt32(cache) >= 99999999) {
                MessageBox.Show("你输入的数值超过了这个程序可以承受的数值了哦~");
                return;
            }
            counter = Convert.ToInt32(cache);
            label4.Text = counter.ToString();
        }


        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //点击时保存存档
            save();
        }
        public void save(string path = "Save.rvdata") {
            if (!File.Exists(path))
            {//若没有文件，报错
                MessageBox.Show("Error:801 Save.rvdata - No such file or directory");
            }
            else
            {
                //保存存档
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                fs.SetLength(0);
                fs.Close();
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(counter);
                sw.Close();
            }
        }
        private void 成就ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化窗体2并弹出
            Form2 chengjiu = new Form2();
            chengjiu.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //启动自检
            if (!File.Exists("tick.png")) {//检查图片资源是否存在，如果不存在，报错并退出
                MessageBox.Show("tick.png: No such file or directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            if (!File.Exists("Save.rvdata")){ //检查存档文件，不存在就新建一个文本文件并写入0
                StreamWriter sw;
                sw = File.CreateText("Save.rvdata");
                sw.Write("0");
                sw.Close();
            }
            //检查完成，导入存档
            string text = System.IO.File.ReadAllText("Save.rvdata");
            counter = Convert.ToInt32(text);
            label4.Text = counter.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //退出时保存存档
            save();
        }
    }
}
