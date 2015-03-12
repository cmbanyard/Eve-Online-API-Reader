namespace WindowsFormsApplication1
{
    partial class CharSelectForm
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
            this.Cbox1 = new System.Windows.Forms.CheckBox();
            this.Cbox2 = new System.Windows.Forms.CheckBox();
            this.Cbox3 = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbox1
            // 
            this.Cbox1.AutoSize = true;
            this.Cbox1.Checked = true;
            this.Cbox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cbox1.Location = new System.Drawing.Point(64, 88);
            this.Cbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbox1.Name = "Cbox1";
            this.Cbox1.Size = new System.Drawing.Size(113, 24);
            this.Cbox1.TabIndex = 0;
            this.Cbox1.Text = "checkBox1";
            this.Cbox1.UseVisualStyleBackColor = true;
            this.Cbox1.Visible = false;
            // 
            // Cbox2
            // 
            this.Cbox2.AutoSize = true;
            this.Cbox2.Checked = true;
            this.Cbox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cbox2.Location = new System.Drawing.Point(64, 137);
            this.Cbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbox2.Name = "Cbox2";
            this.Cbox2.Size = new System.Drawing.Size(113, 24);
            this.Cbox2.TabIndex = 1;
            this.Cbox2.Text = "checkBox2";
            this.Cbox2.UseVisualStyleBackColor = true;
            this.Cbox2.Visible = false;
            // 
            // Cbox3
            // 
            this.Cbox3.AutoSize = true;
            this.Cbox3.Checked = true;
            this.Cbox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cbox3.Location = new System.Drawing.Point(64, 188);
            this.Cbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbox3.Name = "Cbox3";
            this.Cbox3.Size = new System.Drawing.Size(113, 24);
            this.Cbox3.TabIndex = 2;
            this.Cbox3.Text = "checkBox3";
            this.Cbox3.UseVisualStyleBackColor = true;
            this.Cbox3.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(64, 261);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(179, 64);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please deselect the characters you do not wish to view.";
            // 
            // CharSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.Cbox3);
            this.Controls.Add(this.Cbox2);
            this.Controls.Add(this.Cbox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 399);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(636, 399);
            this.Name = "CharSelectForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EveAPI2_FormClosed);
            this.Load += new System.EventHandler(this.EveAPI2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cbox1;
        private System.Windows.Forms.CheckBox Cbox2;
        private System.Windows.Forms.CheckBox Cbox3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
    }
}