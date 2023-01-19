namespace mahiro_patter
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AvatorShower = new System.Windows.Forms.PictureBox();
            this.Hands = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatorShower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AvatorShower
            // 
            this.AvatorShower.Image = global::mahiro_patter.Properties.Resources.mahiro0;
            this.AvatorShower.Location = new System.Drawing.Point(0, 0);
            this.AvatorShower.Name = "AvatorShower";
            this.AvatorShower.Size = new System.Drawing.Size(640, 360);
            this.AvatorShower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatorShower.TabIndex = 0;
            this.AvatorShower.TabStop = false;
            // 
            // Hands
            // 
            this.Hands.BackColor = System.Drawing.Color.Transparent;
            this.Hands.Location = new System.Drawing.Point(0, 0);
            this.Hands.Name = "Hands";
            this.Hands.Size = new System.Drawing.Size(640, 360);
            this.Hands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hands.TabIndex = 1;
            this.Hands.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AvatorShower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "真寻拍拍          双击图片进入设置≡ω≡";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.AvatorShower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox AvatorShower;
        public System.Windows.Forms.PictureBox Hands;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

