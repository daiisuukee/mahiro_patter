namespace mahiro_patter
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftItem = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RightItem = new System.Windows.Forms.ListBox();
            this.AddLeft = new System.Windows.Forms.Button();
            this.AddRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Lable2 = new System.Windows.Forms.Label();
            this.topMostCB = new System.Windows.Forms.CheckBox();
            this.picSizeChangeCB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftItem
            // 
            this.LeftItem.FormattingEnabled = true;
            this.LeftItem.ItemHeight = 12;
            this.LeftItem.Location = new System.Drawing.Point(6, 20);
            this.LeftItem.Name = "LeftItem";
            this.LeftItem.Size = new System.Drawing.Size(81, 136);
            this.LeftItem.TabIndex = 0;
            this.LeftItem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LeftItem_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LeftItem);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "左键";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RightItem);
            this.groupBox2.Location = new System.Drawing.Point(238, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "右键";
            // 
            // RightItem
            // 
            this.RightItem.FormattingEnabled = true;
            this.RightItem.ItemHeight = 12;
            this.RightItem.Location = new System.Drawing.Point(6, 20);
            this.RightItem.Name = "RightItem";
            this.RightItem.Size = new System.Drawing.Size(81, 136);
            this.RightItem.TabIndex = 0;
            this.RightItem.DoubleClick += new System.EventHandler(this.RightItem_DoubleClick);
            // 
            // AddLeft
            // 
            this.AddLeft.Location = new System.Drawing.Point(123, 63);
            this.AddLeft.Name = "AddLeft";
            this.AddLeft.Size = new System.Drawing.Size(99, 23);
            this.AddLeft.TabIndex = 5;
            this.AddLeft.Text = "<=添加左键";
            this.AddLeft.UseVisualStyleBackColor = true;
            this.AddLeft.Click += new System.EventHandler(this.AddLeft_Click);
            // 
            // AddRight
            // 
            this.AddRight.Location = new System.Drawing.Point(123, 106);
            this.AddRight.Name = "AddRight";
            this.AddRight.Size = new System.Drawing.Size(99, 23);
            this.AddRight.TabIndex = 6;
            this.AddRight.Text = "添加右键=>";
            this.AddRight.UseVisualStyleBackColor = true;
            this.AddRight.Click += new System.EventHandler(this.AddRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Version 1.0.1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(236, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Code by 黛苏珂";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lable2.Location = new System.Drawing.Point(104, 204);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(142, 19);
            this.Lable2.TabIndex = 9;
            this.Lable2.Text = "双击键值以删除";
            // 
            // topMostCB
            // 
            this.topMostCB.AutoSize = true;
            this.topMostCB.Location = new System.Drawing.Point(135, 145);
            this.topMostCB.Name = "topMostCB";
            this.topMostCB.Size = new System.Drawing.Size(72, 16);
            this.topMostCB.TabIndex = 10;
            this.topMostCB.Text = "置顶窗口";
            this.topMostCB.UseVisualStyleBackColor = true;
            this.topMostCB.CheckedChanged += new System.EventHandler(this.topMostCB_CheckedChanged);
            this.topMostCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topMostCB_MouseClick);
            // 
            // picSizeChangeCB
            // 
            this.picSizeChangeCB.AutoSize = true;
            this.picSizeChangeCB.Location = new System.Drawing.Point(135, 171);
            this.picSizeChangeCB.Name = "picSizeChangeCB";
            this.picSizeChangeCB.Size = new System.Drawing.Size(72, 16);
            this.picSizeChangeCB.TabIndex = 11;
            this.picSizeChangeCB.Text = "改变尺寸";
            this.picSizeChangeCB.UseVisualStyleBackColor = true;
            this.picSizeChangeCB.CheckedChanged += new System.EventHandler(this.picSizeChangeCB_CheckedChanged);
            this.picSizeChangeCB.MouseHover += new System.EventHandler(this.picSizeChangeCB_MouseHover);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 268);
            this.Controls.Add(this.picSizeChangeCB);
            this.Controls.Add(this.topMostCB);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRight);
            this.Controls.Add(this.AddLeft);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox RightItem;
        private System.Windows.Forms.Button AddLeft;
        private System.Windows.Forms.Button AddRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.CheckBox topMostCB;
        private System.Windows.Forms.CheckBox picSizeChangeCB;
    }
}