namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.userControl11 = new WindowsFormsApplication1.UserControl1();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.userControl12 = new WindowsFormsApplication1.UserControl1();
            this.serverLabel2 = new System.Windows.Forms.Label();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.userControl13 = new WindowsFormsApplication1.UserControl1();
            this.serverStatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.serverStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imgMainLoad = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.serverStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMainLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.userControl11);
            this.tab1.Location = new System.Drawing.Point(4, 29);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(613, 820);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "tabPage1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(607, 814);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.userControl12);
            this.tab2.Controls.Add(this.serverLabel2);
            this.tab2.Location = new System.Drawing.Point(4, 29);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(613, 820);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "tabPage2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // userControl12
            // 
            this.userControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl12.Location = new System.Drawing.Point(3, 3);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(607, 814);
            this.userControl12.TabIndex = 12;
            // 
            // serverLabel2
            // 
            this.serverLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serverLabel2.AutoSize = true;
            this.serverLabel2.Location = new System.Drawing.Point(3, 1134);
            this.serverLabel2.Name = "serverLabel2";
            this.serverLabel2.Size = new System.Drawing.Size(0, 20);
            this.serverLabel2.TabIndex = 11;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.userControl13);
            this.tab3.Location = new System.Drawing.Point(4, 29);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(613, 820);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "tabPage3";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // userControl13
            // 
            this.userControl13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl13.Location = new System.Drawing.Point(3, 3);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(607, 814);
            this.userControl13.TabIndex = 0;
            // 
            // serverStatusStrip1
            // 
            this.serverStatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.serverStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverStripStatusLabel1});
            this.serverStatusStrip1.Location = new System.Drawing.Point(0, 853);
            this.serverStatusStrip1.Name = "serverStatusStrip1";
            this.serverStatusStrip1.Size = new System.Drawing.Size(621, 42);
            this.serverStatusStrip1.TabIndex = 12;
            this.serverStatusStrip1.Text = "statusStrip1";
            // 
            // serverStripStatusLabel1
            // 
            this.serverStripStatusLabel1.Name = "serverStripStatusLabel1";
            this.serverStripStatusLabel1.Size = new System.Drawing.Size(179, 37);
            this.serverStripStatusLabel1.Text = "Server status: ";
            // 
            // imgMainLoad
            // 
            this.imgMainLoad.BackColor = System.Drawing.Color.White;
            this.imgMainLoad.Image = ((System.Drawing.Image)(resources.GetObject("imgMainLoad.Image")));
            this.imgMainLoad.Location = new System.Drawing.Point(0, -3);
            this.imgMainLoad.Name = "imgMainLoad";
            this.imgMainLoad.Size = new System.Drawing.Size(637, 865);
            this.imgMainLoad.TabIndex = 13;
            this.imgMainLoad.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 895);
            this.Controls.Add(this.imgMainLoad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.serverStatusStrip1);
            this.MinimumSize = new System.Drawing.Size(643, 957);
            this.Name = "MainForm";
            this.Text = "Uni Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.serverStatusStrip1.ResumeLayout(false);
            this.serverStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMainLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Label serverLabel2;
        private System.Windows.Forms.StatusStrip serverStatusStrip1;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        public System.Windows.Forms.ToolStripStatusLabel serverStripStatusLabel1;
        private System.Windows.Forms.PictureBox imgMainLoad;

    }
}