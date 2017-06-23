namespace MDI窗体
{
    partial class fatherwin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.窗体操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmmax = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmcloseall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmopen = new System.Windows.Forms.ToolStripMenuItem();
            this.窗体布局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗体列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmduidie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmshuiping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmchuizi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗体操作ToolStripMenuItem,
            this.窗体布局ToolStripMenuItem,
            this.窗体列表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 窗体操作ToolStripMenuItem
            // 
            this.窗体操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmmax,
            this.tsmmin,
            this.tsmcloseall,
            this.tsmopen});
            this.窗体操作ToolStripMenuItem.Name = "窗体操作ToolStripMenuItem";
            this.窗体操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.窗体操作ToolStripMenuItem.Text = "窗体操作";
            // 
            // tsmmax
            // 
            this.tsmmax.Name = "tsmmax";
            this.tsmmax.Size = new System.Drawing.Size(172, 22);
            this.tsmmax.Text = "最大化所有子窗体";
            this.tsmmax.Click += new System.EventHandler(this.tsmmax_Click);
            // 
            // tsmmin
            // 
            this.tsmmin.Name = "tsmmin";
            this.tsmmin.Size = new System.Drawing.Size(172, 22);
            this.tsmmin.Text = "最小化所有子窗体";
            this.tsmmin.Click += new System.EventHandler(this.tsmmin_Click);
            // 
            // tsmcloseall
            // 
            this.tsmcloseall.Name = "tsmcloseall";
            this.tsmcloseall.Size = new System.Drawing.Size(172, 22);
            this.tsmcloseall.Text = "关闭所有子窗体";
            this.tsmcloseall.Click += new System.EventHandler(this.tsmcloseall_Click);
            // 
            // tsmopen
            // 
            this.tsmopen.Name = "tsmopen";
            this.tsmopen.Size = new System.Drawing.Size(172, 22);
            this.tsmopen.Text = "打开子窗体";
            this.tsmopen.Click += new System.EventHandler(this.tsmopen_Click);
            // 
            // 窗体布局ToolStripMenuItem
            // 
            this.窗体布局ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmduidie,
            this.tsmshuiping,
            this.tsmchuizi});
            this.窗体布局ToolStripMenuItem.Name = "窗体布局ToolStripMenuItem";
            this.窗体布局ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.窗体布局ToolStripMenuItem.Text = "窗体布局";
            // 
            // 窗体列表ToolStripMenuItem
            // 
            this.窗体列表ToolStripMenuItem.Name = "窗体列表ToolStripMenuItem";
            this.窗体列表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.窗体列表ToolStripMenuItem.Text = "窗体列表";
            // 
            // tsmduidie
            // 
            this.tsmduidie.Name = "tsmduidie";
            this.tsmduidie.Size = new System.Drawing.Size(160, 22);
            this.tsmduidie.Text = "所有子窗体堆叠";
            this.tsmduidie.Click += new System.EventHandler(this.tsmduidie_Click);
            // 
            // tsmshuiping
            // 
            this.tsmshuiping.Name = "tsmshuiping";
            this.tsmshuiping.Size = new System.Drawing.Size(160, 22);
            this.tsmshuiping.Text = "所有子窗体水平";
            this.tsmshuiping.Click += new System.EventHandler(this.tsmshuiping_Click);
            // 
            // tsmchuizi
            // 
            this.tsmchuizi.Name = "tsmchuizi";
            this.tsmchuizi.Size = new System.Drawing.Size(160, 22);
            this.tsmchuizi.Text = "所有子窗体垂直";
            this.tsmchuizi.Click += new System.EventHandler(this.tsmchuizi_Click);
            // 
            // fatherwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fatherwin";
            this.Text = "父窗体";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 窗体操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmmax;
        private System.Windows.Forms.ToolStripMenuItem tsmmin;
        private System.Windows.Forms.ToolStripMenuItem tsmcloseall;
        private System.Windows.Forms.ToolStripMenuItem tsmopen;
        private System.Windows.Forms.ToolStripMenuItem 窗体布局ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗体列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmduidie;
        private System.Windows.Forms.ToolStripMenuItem tsmshuiping;
        private System.Windows.Forms.ToolStripMenuItem tsmchuizi;
    }
}