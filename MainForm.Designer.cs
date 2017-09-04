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
            this.Container = new System.Windows.Forms.TableLayoutPanel();
            this.AppPanel = new System.Windows.Forms.Panel();
            this.AppList = new System.Windows.Forms.ListView();
            this.TabImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DeploymentPanel = new System.Windows.Forms.Panel();
            this.DeploymentList = new System.Windows.Forms.ListBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ReleasePanel = new System.Windows.Forms.Panel();
            this.ReleaseList = new System.Windows.Forms.ListBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Container.SuspendLayout();
            this.AppPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.DeploymentPanel.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.ReleasePanel.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolbar24
            // 
            this.MainToolbar24.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolbar24.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MainToolbar24.Location = new System.Drawing.Point(0, 0);
            this.MainToolbar24.Name = "MainToolbar24";
            this.MainToolbar24.Size = new System.Drawing.Size(1006, 25);
            this.MainToolbar24.TabIndex = 0;
            this.MainToolbar24.Text = "toolStrip1";
            // 
            // Container
            // 
            this.Container.ColumnCount = 3;
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.2766F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.7234F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 493F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.Container.Controls.Add(this.AppPanel, 0, 0);
            this.Container.Controls.Add(this.DeploymentPanel, 1, 0);
            this.Container.Controls.Add(this.ReleasePanel, 2, 0);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 25);
            this.Container.Margin = new System.Windows.Forms.Padding(4);
            this.Container.Name = "Container";
            this.Container.RowCount = 1;
            this.Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Container.Size = new System.Drawing.Size(1006, 525);
            this.Container.TabIndex = 0;
            // 
            // AppPanel
            // 
            this.AppPanel.Controls.Add(this.AppList);
            this.AppPanel.Controls.Add(this.toolStrip1);
            this.AppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppPanel.Location = new System.Drawing.Point(4, 4);
            this.AppPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AppPanel.Name = "AppPanel";
            this.AppPanel.Size = new System.Drawing.Size(229, 517);
            this.AppPanel.TabIndex = 3;
            // 
            // AppList
            // 
            this.AppList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppList.Location = new System.Drawing.Point(0, 48);
            this.AppList.Margin = new System.Windows.Forms.Padding(4);
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(229, 469);
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
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(229, 48);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 45);
            this.toolStripLabel1.Text = "Apps";
            // 
            // DeploymentPanel
            // 
            this.DeploymentPanel.Controls.Add(this.DeploymentList);
            this.DeploymentPanel.Controls.Add(this.toolStrip4);
            this.DeploymentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeploymentPanel.Location = new System.Drawing.Point(241, 4);
            this.DeploymentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DeploymentPanel.Name = "DeploymentPanel";
            this.DeploymentPanel.Size = new System.Drawing.Size(267, 517);
            this.DeploymentPanel.TabIndex = 4;
            // 
            // DeploymentList
            // 
            this.DeploymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeploymentList.FormattingEnabled = true;
            this.DeploymentList.ItemHeight = 45;
            this.DeploymentList.Location = new System.Drawing.Point(0, 48);
            this.DeploymentList.Margin = new System.Windows.Forms.Padding(4);
            this.DeploymentList.Name = "DeploymentList";
            this.DeploymentList.Size = new System.Drawing.Size(267, 469);
            this.DeploymentList.TabIndex = 4;
            this.DeploymentList.SelectedIndexChanged += new System.EventHandler(this.DeploymentList_SelectedIndexChanged);
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(267, 48);
            this.toolStrip4.TabIndex = 5;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.IsLink = true;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(208, 45);
            this.toolStripLabel2.Text = "Deployments";
            // 
            // ReleasePanel
            // 
            this.ReleasePanel.Controls.Add(this.ReleaseList);
            this.ReleasePanel.Controls.Add(this.toolStrip3);
            this.ReleasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleasePanel.Location = new System.Drawing.Point(516, 4);
            this.ReleasePanel.Margin = new System.Windows.Forms.Padding(4);
            this.ReleasePanel.Name = "ReleasePanel";
            this.ReleasePanel.Size = new System.Drawing.Size(486, 517);
            this.ReleasePanel.TabIndex = 5;
            // 
            // ReleaseList
            // 
            this.ReleaseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleaseList.FormattingEnabled = true;
            this.ReleaseList.ItemHeight = 45;
            this.ReleaseList.Location = new System.Drawing.Point(0, 48);
            this.ReleaseList.Margin = new System.Windows.Forms.Padding(4);
            this.ReleaseList.Name = "ReleaseList";
            this.ReleaseList.Size = new System.Drawing.Size(486, 469);
            this.ReleaseList.TabIndex = 4;
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
            this.toolStrip3.Size = new System.Drawing.Size(486, 48);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.IsLink = true;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(141, 45);
            this.toolStripLabel3.Text = "Releases";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLabel,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1006, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UserLabel
            // 
            this.UserLabel.Image = ((System.Drawing.Image)(resources.GetObject("UserLabel.Image")));
            this.UserLabel.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(94, 33);
            this.UserLabel.Text = "User";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("StatusLabel.Image")));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(111, 33);
            this.StatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.MainToolbar24);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "CodePush Deployment Admin Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Container.ResumeLayout(false);
            this.AppPanel.ResumeLayout(false);
            this.AppPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DeploymentPanel.ResumeLayout(false);
            this.DeploymentPanel.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ReleasePanel.ResumeLayout(false);
            this.ReleasePanel.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolbar24;
        private System.Windows.Forms.ImageList TabImageList;
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
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ListView AppList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel UserLabel;
    }
}

