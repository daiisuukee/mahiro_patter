using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Location= new Point(app.Location.X + 140, app.Location.Y + 50);
            foreach (string s in Properties.Settings.Default.defaultLeft)
            {
                LeftItem.Items.Add(s);
            }
            foreach (string s in Properties.Settings.Default.defaultRight)
            {
                RightItem.Items.Add(s);
            }

            KeyPreview = true;
            KeyDown += new KeyEventHandler(Setting_KeyDown);
            this.app = app;
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
    }
}
