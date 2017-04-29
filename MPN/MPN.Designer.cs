namespace MPN
{
    partial class MPNCalc
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
            this.txtDIL1 = new System.Windows.Forms.TextBox();
            this.txtPOS1 = new System.Windows.Forms.TextBox();
            this.txtDIL2 = new System.Windows.Forms.TextBox();
            this.txtPOS2 = new System.Windows.Forms.TextBox();
            this.txtDIL3 = new System.Windows.Forms.TextBox();
            this.txtPOS3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMPN = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnLWR = new System.Windows.Forms.Button();
            this.btnHGHR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDIL1
            // 
            this.txtDIL1.Location = new System.Drawing.Point(12, 57);
            this.txtDIL1.Name = "txtDIL1";
            this.txtDIL1.ReadOnly = true;
            this.txtDIL1.Size = new System.Drawing.Size(100, 20);
            this.txtDIL1.TabIndex = 0;
            this.txtDIL1.TabStop = false;
            this.txtDIL1.Text = "0.10";
            // 
            // txtPOS1
            // 
            this.txtPOS1.Location = new System.Drawing.Point(203, 55);
            this.txtPOS1.Name = "txtPOS1";
            this.txtPOS1.Size = new System.Drawing.Size(100, 20);
            this.txtPOS1.TabIndex = 2;
            // 
            // txtDIL2
            // 
            this.txtDIL2.Location = new System.Drawing.Point(12, 83);
            this.txtDIL2.Name = "txtDIL2";
            this.txtDIL2.ReadOnly = true;
            this.txtDIL2.Size = new System.Drawing.Size(100, 20);
            this.txtDIL2.TabIndex = 3;
            this.txtDIL2.TabStop = false;
            this.txtDIL2.Text = "0.01";
            // 
            // txtPOS2
            // 
            this.txtPOS2.Location = new System.Drawing.Point(203, 81);
            this.txtPOS2.Name = "txtPOS2";
            this.txtPOS2.Size = new System.Drawing.Size(100, 20);
            this.txtPOS2.TabIndex = 5;
            // 
            // txtDIL3
            // 
            this.txtDIL3.Location = new System.Drawing.Point(12, 109);
            this.txtDIL3.Name = "txtDIL3";
            this.txtDIL3.ReadOnly = true;
            this.txtDIL3.Size = new System.Drawing.Size(100, 20);
            this.txtDIL3.TabIndex = 6;
            this.txtDIL3.TabStop = false;
            this.txtDIL3.Text = "0.001";
            // 
            // txtPOS3
            // 
            this.txtPOS3.Location = new System.Drawing.Point(203, 109);
            this.txtPOS3.Name = "txtPOS3";
            this.txtPOS3.Size = new System.Drawing.Size(100, 20);
            this.txtPOS3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "g or ml per test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "# (+) Tests";
            // 
            // txtMPN
            // 
            this.txtMPN.Location = new System.Drawing.Point(91, 169);
            this.txtMPN.Name = "txtMPN";
            this.txtMPN.Size = new System.Drawing.Size(100, 20);
            this.txtMPN.TabIndex = 12;
            this.txtMPN.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(220, 148);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(83, 60);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnLWR
            // 
            this.btnLWR.Location = new System.Drawing.Point(118, 55);
            this.btnLWR.Name = "btnLWR";
            this.btnLWR.Size = new System.Drawing.Size(50, 33);
            this.btnLWR.TabIndex = 16;
            this.btnLWR.Text = "▲";
            this.btnLWR.UseVisualStyleBackColor = true;
            this.btnLWR.Click += new System.EventHandler(this.btnLWR_Click);
            // 
            // btnHGHR
            // 
            this.btnHGHR.Location = new System.Drawing.Point(118, 94);
            this.btnHGHR.Name = "btnHGHR";
            this.btnHGHR.Size = new System.Drawing.Size(50, 35);
            this.btnHGHR.TabIndex = 17;
            this.btnHGHR.Text = "▼";
            this.btnHGHR.UseVisualStyleBackColor = true;
            this.btnHGHR.Click += new System.EventHandler(this.btnHGHR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "MPN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MPNCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHGHR);
            this.Controls.Add(this.btnLWR);
            this.Controls.Add(this.txtMPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPOS3);
            this.Controls.Add(this.txtDIL3);
            this.Controls.Add(this.txtPOS2);
            this.Controls.Add(this.txtDIL2);
            this.Controls.Add(this.txtPOS1);
            this.Controls.Add(this.txtDIL1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCalculate);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MPNCalc";
            this.Text = "MPN Calc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDIL1;
        private System.Windows.Forms.TextBox txtPOS1;
        private System.Windows.Forms.TextBox txtDIL2;
        private System.Windows.Forms.TextBox txtPOS2;
        private System.Windows.Forms.TextBox txtDIL3;
        private System.Windows.Forms.TextBox txtPOS3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMPN;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnLWR;
        private System.Windows.Forms.Button btnHGHR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

