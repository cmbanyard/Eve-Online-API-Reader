namespace WindowsFormsApplication1
{
    partial class ApiKeyForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtKeyID = new System.Windows.Forms.TextBox();
            this.txtVcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(339, 155);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKeyID
            // 
            this.txtKeyID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyID.Location = new System.Drawing.Point(339, 20);
            this.txtKeyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeyID.Name = "txtKeyID";
            this.txtKeyID.Size = new System.Drawing.Size(631, 26);
            this.txtKeyID.TabIndex = 1;
            this.txtKeyID.Text = "4039251";
            this.txtKeyID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVcode
            // 
            this.txtVcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVcode.Location = new System.Drawing.Point(339, 58);
            this.txtVcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVcode.Name = "txtVcode";
            this.txtVcode.Size = new System.Drawing.Size(631, 26);
            this.txtVcode.TabIndex = 2;
            this.txtVcode.Text = "0EJyVzZQBWwYFHHD44deRb35BxmDZtL9gYQbP0eOHmNaZI2ZS6hYLUBzyoJ9IlOk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "KeyID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verification Code:";
            // 
            // ApiKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVcode);
            this.Controls.Add(this.txtKeyID);
            this.Controls.Add(this.btnSubmit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1011, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1011, 281);
            this.Name = "ApiKeyForm";
            this.Text = "Uni Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtKeyID;
        private System.Windows.Forms.TextBox txtVcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

