using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mahiro_patter
{
    public partial class Setting : Form
    {
        private bool left_trigger = false;
        private bool right_trigger = false;

        MainWindow app;
        public Setting(MainWindow app)
        {
            InitializeComponent();
            this.app = app;
            Location= new Point(app.Location.X + 140, app.Location.Y + 50);
            foreach (string s in Properties.Settings.Default.defaultLeft)
            {
                LeftItem.Items.Add(s);
            }
            foreach (string s in Properties.Settings.Default.defaultRight)
            {
                RightItem.Items.Add(s);
            }
            this.topMostCB.CheckState = Properties.Settings.Default.isTopMost ? CheckState.Checked : CheckState.Unchecked;
            this.picSizeChangeCB.CheckState = Properties.Settings.Default.isResizeAble ? CheckState.Checked : CheckState.Unchecked;

            KeyPreview = true;
            KeyDown += new KeyEventHandler(Setting_KeyDown);
        }

        private void Setting_KeyDown(object sender, KeyEventArgs e)
        {
            if (left_trigger)
            {
                if (!app.left.Contains(e.KeyCode.ToString()))
                {
                    Properties.Settings.Default.defaultLeft.Add(e.KeyCode.ToString());
                    app.left.Add(e.KeyCode.ToString());
                    Properties.Settings.Default.Save();
                    LeftItem.Items.Add(e.KeyCode.ToString());
                }
            }
            if (right_trigger)
            {
                if (!app.right.Contains(e.KeyCode.ToString()))
                {
                    Properties.Settings.Default.defaultRight.Add(e.KeyCode.ToString());
                    app.right.Add(e.KeyCode.ToString());
                    Properties.Settings.Default.Save();
                    RightItem.Items.Add(e.KeyCode.ToString());
                }
            }
            DisableTriggers();
        }
        private void DisableTriggers()
        {
            if (left_trigger)
            {
                left_trigger= false;
                AddLeft.Text = "<=添加左键";
            }
            if (right_trigger)
            {
                right_trigger= false;
                AddRight.Text = "添加右键=>";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://daiisuukee.github.io/");
        }

        private void AddLeft_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            left_trigger= true;
            AddLeft.Text = "请点击任意键";
        }

        private void AddRight_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            right_trigger = true;
            AddRight.Text = "请点击任意键";
        }

        private void LeftItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = LeftItem.SelectedIndex;

            if (index != ListBox.NoMatches)
            {
                Properties.Settings.Default.defaultLeft.RemoveAt(index);
                app.left.RemoveAt(index);
                Properties.Settings.Default.Save();
                LeftItem.Items.RemoveAt(index);
            }
        }

        private void RightItem_DoubleClick(object sender, EventArgs e)
        {
            int index = RightItem.SelectedIndex;

            if (index != ListBox.NoMatches)
            {
                Properties.Settings.Default.defaultRight.RemoveAt(index);
                app.right.RemoveAt(index);
                Properties.Settings.Default.Save();
                RightItem.Items.RemoveAt(index);
            }
        }

        // 窗口置顶
        private void topMostCB_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.topMostCB.Checked;
            if (flag)
            {
                app.TopMost = true;
                this.TopMost = true;
                Properties.Settings.Default.isTopMost = true;
                Properties.Settings.Default.Save();
            } else
            {
                app.TopMost = false;
                this.TopMost = false;
                Properties.Settings.Default.isTopMost = false;
                Properties.Settings.Default.Save();
            }
        }

        private void picSizeChangeCB_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.picSizeChangeCB.Checked;
            if (flag)
            {
                app.FormBorderStyle = FormBorderStyle.Sizable;
                Properties.Settings.Default.isResizeAble = true;
                Properties.Settings.Default.Save();
            } else
            {
                app.FormBorderStyle = FormBorderStyle.FixedSingle;
                Properties.Settings.Default.isResizeAble = false;
                Properties.Settings.Default.Save();
            }
        }

        private void picSizeChangeCB_MouseHover(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 100;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 500;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框

            //  设置伴随的对象.
            toolTip1.SetToolTip(this.picSizeChangeCB, "推荐窗口大小修改完毕后关闭'改变尺寸'项");//设置提示按钮和提示内容
        }
        private void topMostCB_MouseClick(object sender, MouseEventArgs e)
        {
            if (topMostCB.Checked)
            {
                MessageBox.Show("当前窗口已置顶！");
            }
        }
    }
}
