namespace WindowsFormsApplication1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skillTable = new System.Windows.Forms.TableLayoutPanel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.allianceLabel = new System.Windows.Forms.Label();
            this.corpLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.spLabel = new System.Windows.Forms.Label();
            this.skillTableLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.skillGridContainer = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            this.skillGridContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // skillTable
            // 
            this.skillTable.AutoSize = true;
            this.skillTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.skillTable.ColumnCount = 3;
            this.skillTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 527F));
            this.skillTable.Location = new System.Drawing.Point(13, 182);
            this.skillTable.Name = "skillTable";
            this.skillTable.RowCount = 2;
            this.skillTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillTable.Size = new System.Drawing.Size(527, 0);
            this.skillTable.TabIndex = 19;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(148, 87);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(75, 20);
            this.balanceLabel.TabIndex = 17;
            this.balanceLabel.Text = "Balance: ";
            // 
            // allianceLabel
            // 
            this.allianceLabel.AutoSize = true;
            this.allianceLabel.Location = new System.Drawing.Point(148, 67);
            this.allianceLabel.Name = "allianceLabel";
            this.allianceLabel.Size = new System.Drawing.Size(72, 20);
            this.allianceLabel.TabIndex = 16;
            this.allianceLabel.Text = "Alliance: ";
            // 
            // corpLabel
            // 
            this.corpLabel.AutoSize = true;
            this.corpLabel.Location = new System.Drawing.Point(148, 47);
            this.corpLabel.Name = "corpLabel";
            this.corpLabel.Size = new System.Drawing.Size(100, 20);
            this.corpLabel.TabIndex = 15;
            this.corpLabel.Text = "Corporation: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(149, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name: ";
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.characterPictureBox.Location = new System.Drawing.Point(15, 22);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(128, 128);
            this.characterPictureBox.TabIndex = 20;
            this.characterPictureBox.TabStop = false;
            // 
            // spLabel
            // 
            this.spLabel.AutoSize = true;
            this.spLabel.Location = new System.Drawing.Point(147, 105);
            this.spLabel.Name = "spLabel";
            this.spLabel.Size = new System.Drawing.Size(140, 20);
            this.spLabel.TabIndex = 23;
            this.spLabel.Text = "Currently Training: ";
            // 
            // skillTableLayout
            // 
            this.skillTableLayout.AutoSize = true;
            this.skillTableLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.skillTableLayout.Location = new System.Drawing.Point(3, 3);
            this.skillTableLayout.MinimumSize = new System.Drawing.Size(100, 100);
            this.skillTableLayout.Name = "skillTableLayout";
            this.skillTableLayout.Size = new System.Drawing.Size(100, 100);
            this.skillTableLayout.TabIndex = 24;
            this.skillTableLayout.WrapContents = false;
            // 
            // skillGridContainer
            // 
            this.skillGridContainer.AutoScroll = true;
            this.skillGridContainer.Controls.Add(this.skillTableLayout);
            this.skillGridContainer.Location = new System.Drawing.Point(15, 169);
            this.skillGridContainer.Name = "skillGridContainer";
            this.skillGridContainer.Size = new System.Drawing.Size(578, 648);
            this.skillGridContainer.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(513, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 64);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh API";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.skillGridContainer);
            this.Controls.Add(this.spLabel);
            this.Controls.Add(this.characterPictureBox);
            this.Controls.Add(this.skillTable);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.allianceLabel);
            this.Controls.Add(this.corpLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(615, 845);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            this.skillGridContainer.ResumeLayout(false);
            this.skillGridContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel skillTable;
        public System.Windows.Forms.Label balanceLabel;
        public System.Windows.Forms.Label allianceLabel;
        public System.Windows.Forms.Label corpLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.PictureBox characterPictureBox;
        public System.Windows.Forms.Label spLabel;
        public System.Windows.Forms.FlowLayoutPanel skillTableLayout;
        public System.Windows.Forms.Panel skillGridContainer;
        public System.Windows.Forms.Button btnRefresh;

    }
}
