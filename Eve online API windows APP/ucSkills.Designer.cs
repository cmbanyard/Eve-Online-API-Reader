namespace WindowsFormsApplication1
{
    partial class ucSkills
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
            this.skillPanel = new StaffDotNet.CollapsiblePanel.CollapsiblePanel();
            this.skillGrid = new System.Windows.Forms.DataGridView();
            this.skillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // skillPanel
            // 
            this.skillPanel.AutoSize = true;
            this.skillPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.skillPanel.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.skillPanel.CausesValidation = false;
            this.skillPanel.Controls.Add(this.skillGrid);
            this.skillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillPanel.ExpandedHeight = 502;
            this.skillPanel.Location = new System.Drawing.Point(0, 0);
            this.skillPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skillPanel.Name = "skillPanel";
            this.skillPanel.NextPanel = null;
            this.skillPanel.PanelTitle = "Panel title";
            this.skillPanel.Size = new System.Drawing.Size(347, 533);
            this.skillPanel.TabIndex = 22;
            this.skillPanel.StateChanged += new StaffDotNet.CollapsiblePanel.CollapsiblePanel.DelegateStateChanged(this.skillPanel_StateChanged);
            // 
            // skillGrid
            // 
            this.skillGrid.AllowUserToAddRows = false;
            this.skillGrid.AllowUserToDeleteRows = false;
            this.skillGrid.AllowUserToResizeColumns = false;
            this.skillGrid.AllowUserToResizeRows = false;
            this.skillGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.skillGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skillGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillGrid.Location = new System.Drawing.Point(0, 19);
            this.skillGrid.Name = "skillGrid";
            this.skillGrid.ReadOnly = true;
            this.skillGrid.RowHeadersVisible = false;
            this.skillGrid.RowTemplate.Height = 28;
            this.skillGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skillGrid.Size = new System.Drawing.Size(347, 517);
            this.skillGrid.TabIndex = 1;
            this.skillGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skillGrid_CellContentClick);
            this.skillGrid.SelectionChanged += new System.EventHandler(this.skillGrid_SelectionChanged);
            // 
            // ucSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skillPanel);
            this.Name = "ucSkills";
            this.Size = new System.Drawing.Size(347, 533);
            this.skillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public StaffDotNet.CollapsiblePanel.CollapsiblePanel skillPanel;
        public System.Windows.Forms.DataGridView skillGrid;
    }
}
