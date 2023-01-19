using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mahiro_patter
{
    public partial class MainWindow : Form
    {
        private static Assembly asm = Assembly.GetExecutingAssembly();
        private ResourceManager rm = new ResourceManager("mahiro_patter.Properties.Resources", asm);

        private IKeyboardMouseEvents hook = Hook.GlobalEvents();

        private string mode = Properties.Settings.Default.Mode;

        private int keyCount = 0;
        private const int HEAD_TOT = 8;
        private bool changeHeadSwitcher = true;

        public StringCollection right_pressed = new StringCollection();
        public StringCollection left_pressed = new StringCollection();

        public StringCollection right = new StringCollection();
        public StringCollection left = new StringCollection();

        private Bitmap front = Properties.Resources.handsBG;

        public MainWindow()
        {
            InitializeComponent();

            // 设置监控面板
            pictureBox1.Parent = Hands;
            pictureBox1.BackColor = Color.Transparent;

            // 窗口大小初始化
            PictureSizeChange(Properties.Settings.Default.windowSizeX,Properties.Settings.Default.windowSizeY);

            // 窗口是否置顶
            this.TopMost = Properties.Settings.Default.isTopMost;

            // 当前窗口恒定监控键盘(无焦点即可触发)
            this.KeyPreview = true;
            hook.KeyDown += new KeyEventHandler(HookKeyDown);
            hook.KeyUp += new KeyEventHandler(HookKeyUp);

            SetMode(mode);
            AvatorShower.Controls.Add(Hands);
        }

        public void SetMode(string mode)
        {
            right_pressed.Clear();
            left_pressed.Clear();
            Hands.Image = Impose(front, Properties.Resources.leftHandUp, 320, 0);
            Hands.Image = Impose(front, Properties.Resources.rightHandUp);
            switch (mode)
            {
                case "Default":
                    this.mode = "Default";

                    right.Clear();
                    left.Clear();
                    foreach (string s in Properties.Settings.Default.defaultLeft)
                    {
                        left.Add(s);
                    }
                    foreach (string s in Properties.Settings.Default.defaultRight)
                    {
                        right.Add(s);
                    }
                    break;

            }
        }
        private void LeftHandPress(string Key)
        {
            // 左按键集合内没有对应按键
            if (!left_pressed.Contains(Key))

            {
                left_pressed.Add(Key);
                Hands.Image = Impose(front, Properties.Resources.leftHandDown, 320, 0);
                Task.Run(async () =>
                {
                    await Task.Delay(100);
                    if (left_pressed.Count > 0)
                    {
                        // 如果队列还有按键则继续按下
                        Hands.Image = Impose(front, Properties.Resources.leftHandDown, 320, 0);
                    }
                    else
                    {
                        Hands.Image = Impose(front, Properties.Resources.leftHandUp, 320, 0);
                    }
                });
            }
        }
        private void RightHandPress(string Key)
        {
            // 右按键集合内没有对应按键
            if (!right_pressed.Contains(Key))
            {
                right_pressed.Add(Key);
                Hands.Image = Impose(front, Properties.Resources.rightHandDown);
                Task.Run(async () =>
                {
                    await Task.Delay(100);
                    if (right_pressed.Count > 0)
                    {
                        // 如果队列还有按键则按下
                        Hands.Image = Impose(front, Properties.Resources.rightHandDown);
                    }
                    else
                    {
                        Hands.Image = Impose(front, Properties.Resources.rightHandUp);
                    }
                });
            }
        }

        private void LeftHandUnPoress(string Key)
        {
            left_pressed.Remove(Key);
            if (left_pressed.Count == 0)
            {
                Hands.Image = Impose(front, Properties.Resources.leftHandUp, 320, 0);
            }
        }
        private void RightHandUnPoress(string Key)
        {
            right_pressed.Remove(Key);
            if (right_pressed.Count == 0)
            {
                Hands.Image = Impose(front, Properties.Resources.rightHandUp);
            }
        }
        private void HookKeyDown(object sender, KeyEventArgs e)
        {
            if (left.Contains(e.KeyCode.ToString()))
            {
                changeHead();
                LeftHandPress(e.KeyCode.ToString());
            }
            if (right.Contains(e.KeyCode.ToString()))
            {
                changeHead();
                RightHandPress(e.KeyCode.ToString());
            }
        }
        /// <summary>
        /// 摇头
        /// </summary>
        private void changeHead()
        {
            if (changeHeadSwitcher)
            {
                // 正向
                keyCount++;
                if (keyCount == HEAD_TOT)
                {
                    changeHeadSwitcher = false;
                }
                else
                {
                    AvatorShower.Image = (Image)rm.GetObject("mahiro" + keyCount.ToString());
                }
            }
            if (!changeHeadSwitcher)
            {
                keyCount--;
                if (keyCount == -1)
                {
                    changeHeadSwitcher = true;
                }
                else
                {
                    AvatorShower.Image = (Image)rm.GetObject("mahiro" + keyCount.ToString());
                }
            }
        }
        private void HookKeyUp(object sender, KeyEventArgs e)
        {
            if (left_pressed.Contains(e.KeyCode.ToString()))
            {
                LeftHandUnPoress(e.KeyCode.ToString());
            }
            if (right_pressed.Contains(e.KeyCode.ToString()))
            {
                RightHandUnPoress(e.KeyCode.ToString());
            }
        }

        private Bitmap Impose(Bitmap bottomBmp, Bitmap topBmp, int x = 0, int y = 0)
        {
            Graphics g = Graphics.FromImage(bottomBmp);
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;// 覆盖背景
            g.DrawImageUnscaled(topBmp, new Point(x, y));
            return bottomBmp;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Setting setting= new Setting(this);
            setting.Show();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            int x = ClientSize.Width;
            int y = ClientSize.Height;
            ClientSize= new Size(x, x * 36 / 64);
            y = ClientSize.Height;
            if (this.FormBorderStyle.Equals(FormBorderStyle.Sizable))
            {
                PictureSizeChange(x, y);
                Properties.Settings.Default.windowSizeX = x;
                Properties.Settings.Default.windowSizeY = y;
                Properties.Settings.Default.Save();
            }
        }

        private void PictureSizeChange(int x, int y)
        {
            pictureBox1.Size= new Size(x, y);
            AvatorShower.Size = pictureBox1.Size;
            Hands.Size = pictureBox1.Size;
            ClientSize = pictureBox1.Size;
        }
    }
}
