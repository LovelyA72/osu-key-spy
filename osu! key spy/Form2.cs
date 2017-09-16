using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace osu_key_spy
{
    public partial class Form2 : Form
    {
        int score;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)//检测存档文件是否存在，如果存在就完成第一个成就
        {
            string text = System.IO.File.ReadAllText("Save.rvdata");
            int score = Convert.ToInt32(text);
            if (File.Exists("Save.rvdata")) {
                pictureBox1.Image = Image.FromFile("tick.png");
            }
            if (score >= 1000) {
                pictureBox3.Image = Image.FromFile("tick.png");
           }
            if (score >= 50000)
            {
                pictureBox3.Image = Image.FromFile("tick.png");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我的osu!直播需要帅气一点的显示工具！这个软件蛮不错的~","成就");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不知不觉打了1000下了呢，osu!还挺好玩的嘛", "成就");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这个游戏是要有技巧的~50000下打完才摸索透了一些", "成就");
        }
    }
}
