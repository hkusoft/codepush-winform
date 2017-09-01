namespace codepush_winform
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainToolbar24 = new System.Windows.Forms.ToolStrip();
            this.Login = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.Container = new System.Windows.Forms.TableLayoutPanel();
            this.AppPanel = new System.Windows.Forms.Panel();
            this.AppList = new System.Windows.Forms.ListView();
            this.TabImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DeploymentPanel = new System.Windows.Forms.Panel();
            this.DeploymentList = new System.Windows.Forms.ListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ReleasePanel = new System.Windows.Forms.Panel();
            this.ReleaseList = new System.Windows.Forms.ListBox();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ReleaseDetailPanel = new System.Windows.Forms.Panel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.MainToolbar24.SuspendLayout();
            this.Container.SuspendLayout();
            this.AppPanel.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.DeploymentPanel.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.ReleasePanel.SuspendLayout();
            this.toolStrip6.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.ReleaseDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolbar24
            // 
            this.MainToolbar24.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MainToolbar24.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.MainToolbar24.Location = new System.Drawing.Point(0, 0);
            this.MainToolbar24.Name = "MainToolbar24";
            this.MainToolbar24.Size = new System.Drawing.Size(760, 35);
            this.MainToolbar24.TabIndex = 0;
            this.MainToolbar24.Text = "toolStrip1";
            // 
            // Login
            // 
            this.Login.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(32, 32);
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // Container
            // 
            this.Container.ColumnCount = 4;
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.15825F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.84175F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.Container.Controls.Add(this.AppPanel, 0, 0);
            this.Container.Controls.Add(this.DeploymentPanel, 1, 0);
            this.Container.Controls.Add(this.ReleasePanel, 2, 0);
            this.Container.Controls.Add(this.ReleaseDetailPanel, 3, 0);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 35);
            this.Container.Name = "Container";
            this.Container.RowCount = 1;
            this.Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Container.Size = new System.Drawing.Size(760, 417);
            this.Container.TabIndex = 0;
            // 
            // AppPanel
            // 
            this.AppPanel.Controls.Add(this.AppList);
            this.AppPanel.Controls.Add(this.toolStrip5);
            this.AppPanel.Controls.Add(this.toolStrip1);
            this.AppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppPanel.Location = new System.Drawing.Point(3, 3);
            this.AppPanel.Name = "AppPanel";
            this.AppPanel.Size = new System.Drawing.Size(140, 411);
            this.AppPanel.TabIndex = 3;
            // 
            // AppList
            // 
            this.AppList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppList.Location = new System.Drawing.Point(0, 50);
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(140, 361);
            this.AppList.SmallImageList = this.TabImageList;
            this.AppList.TabIndex = 5;
            this.AppList.UseCompatibleStateImageBehavior = false;
            this.AppList.View = System.Windows.Forms.View.List;
            this.AppList.SelectedIndexChanged += new System.EventHandler(this.AppList_SelectedIndexChanged);
            // 
            // TabImageList
            // 
            this.TabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabImageList.ImageStream")));
            this.TabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TabImageList.Images.SetKeyName(0, "android16.png");
            this.TabImageList.Images.SetKeyName(1, "ios16.png");
            // 
            // toolStrip5
            // 
            this.toolStrip5.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton13});
            this.toolStrip5.Location = new System.Drawing.Point(0, 25);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(140, 25);
            this.toolStrip5.TabIndex = 4;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "toolStripButton8";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(140, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "App";
            // 
            // DeploymentPanel
            // 
            this.DeploymentPanel.Controls.Add(this.DeploymentList);
            this.DeploymentPanel.Controls.Add(this.toolStrip2);
            this.DeploymentPanel.Controls.Add(this.toolStrip4);
            this.DeploymentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeploymentPanel.Location = new System.Drawing.Point(149, 3);
            this.DeploymentPanel.Name = "DeploymentPanel";
            this.DeploymentPanel.Size = new System.Drawing.Size(145, 411);
            this.DeploymentPanel.TabIndex = 4;
            // 
            // DeploymentList
            // 
            this.DeploymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeploymentList.FormattingEnabled = true;
            this.DeploymentList.ItemHeight = 17;
            this.DeploymentList.Location = new System.Drawing.Point(0, 50);
            this.DeploymentList.Name = "DeploymentList";
            this.DeploymentList.Size = new System.Drawing.Size(145, 361);
            this.DeploymentList.TabIndex = 4;
            this.DeploymentList.SelectedIndexChanged += new System.EventHandler(this.DeploymentList_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(145, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton8";
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(145, 25);
            this.toolStrip4.TabIndex = 5;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.IsLink = true;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel2.Text = "Deployment";
            // 
            // ReleasePanel
            // 
            this.ReleasePanel.Controls.Add(this.ReleaseList);
            this.ReleasePanel.Controls.Add(this.toolStrip6);
            this.ReleasePanel.Controls.Add(this.toolStrip3);
            this.ReleasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleasePanel.Location = new System.Drawing.Point(300, 3);
            this.ReleasePanel.Name = "ReleasePanel";
            this.ReleasePanel.Size = new System.Drawing.Size(145, 411);
            this.ReleasePanel.TabIndex = 5;
            // 
            // ReleaseList
            // 
            this.ReleaseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleaseList.FormattingEnabled = true;
            this.ReleaseList.ItemHeight = 17;
            this.ReleaseList.Location = new System.Drawing.Point(0, 50);
            this.ReleaseList.Name = "ReleaseList";
            this.ReleaseList.Size = new System.Drawing.Size(145, 361);
            this.ReleaseList.TabIndex = 4;
            // 
            // toolStrip6
            // 
            this.toolStrip6.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10});
            this.toolStrip6.Location = new System.Drawing.Point(0, 25);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Size = new System.Drawing.Size(145, 25);
            this.toolStrip6.TabIndex = 5;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "toolStripButton10";
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(145, 25);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.IsLink = true;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel3.Text = "Release";
            // 
            // ReleaseDetailPanel
            // 
            this.ReleaseDetailPanel.Controls.Add(this.listBox4);
            this.ReleaseDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleaseDetailPanel.Location = new System.Drawing.Point(451, 3);
            this.ReleaseDetailPanel.Name = "ReleaseDetailPanel";
            this.ReleaseDetailPanel.Size = new System.Drawing.Size(306, 411);
            this.ReleaseDetailPanel.TabIndex = 6;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 17;
            this.listBox4.Location = new System.Drawing.Point(0, 0);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(306, 411);
            this.listBox4.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 452);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.MainToolbar24);
            this.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "CodePush Winform Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainToolbar24.ResumeLayout(false);
            this.MainToolbar24.PerformLayout();
            this.Container.ResumeLayout(false);
            this.AppPanel.ResumeLayout(false);
            this.AppPanel.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DeploymentPanel.ResumeLayout(false);
            this.DeploymentPanel.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ReleasePanel.ResumeLayout(false);
            this.ReleasePanel.PerformLayout();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ReleaseDetailPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolbar24;
        private System.Windows.Forms.ToolStripButton Login;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ImageList TabImageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel Container;
        private System.Windows.Forms.Panel AppPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel DeploymentPanel;
        private System.Windows.Forms.ListBox DeploymentList;
        private System.Windows.Forms.Panel ReleasePanel;
        private System.Windows.Forms.ListBox ReleaseList;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Panel ReleaseDetailPanel;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ListView AppList;
    }
}

