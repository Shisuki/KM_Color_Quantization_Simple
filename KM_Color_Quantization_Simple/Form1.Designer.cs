namespace KM_Color_Quantization_Simple
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenImage_btn = new System.Windows.Forms.Button();
            this.ModifyImage_btn = new System.Windows.Forms.Button();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.LockBit_btn = new System.Windows.Forms.Button();
            this.resLabel = new System.Windows.Forms.Label();
            this.pixelsLabel = new System.Windows.Forms.Label();
            this.resLabel_val = new System.Windows.Forms.Label();
            this.pixelsLabel_val = new System.Windows.Forms.Label();
            this.kMeansSimple_btn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLabel_val = new System.Windows.Forms.Label();
            this.kMeansSimpleLockbits_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.K_Value = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(313, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 338);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Image";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(797, 247);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(55, 10);
            this.separatorControl1.TabIndex = 2;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl2.Location = new System.Drawing.Point(699, -3);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(46, 466);
            this.separatorControl2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(751, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 338);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modified Image";
            // 
            // OpenImage_btn
            // 
            this.OpenImage_btn.Location = new System.Drawing.Point(12, 16);
            this.OpenImage_btn.Name = "OpenImage_btn";
            this.OpenImage_btn.Size = new System.Drawing.Size(75, 23);
            this.OpenImage_btn.TabIndex = 6;
            this.OpenImage_btn.Text = "Open Image";
            this.OpenImage_btn.UseVisualStyleBackColor = true;
            this.OpenImage_btn.Click += new System.EventHandler(this.OpenImage_btn_Click);
            // 
            // ModifyImage_btn
            // 
            this.ModifyImage_btn.Location = new System.Drawing.Point(12, 82);
            this.ModifyImage_btn.Name = "ModifyImage_btn";
            this.ModifyImage_btn.Size = new System.Drawing.Size(131, 23);
            this.ModifyImage_btn.TabIndex = 7;
            this.ModifyImage_btn.Text = "Remove Blue Color";
            this.ModifyImage_btn.UseVisualStyleBackColor = true;
            this.ModifyImage_btn.Click += new System.EventHandler(this.ModifyImage_btn_Click);
            // 
            // separatorControl3
            // 
            this.separatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl3.Location = new System.Drawing.Point(261, -3);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(46, 466);
            this.separatorControl3.TabIndex = 8;
            // 
            // LockBit_btn
            // 
            this.LockBit_btn.Location = new System.Drawing.Point(12, 111);
            this.LockBit_btn.Name = "LockBit_btn";
            this.LockBit_btn.Size = new System.Drawing.Size(164, 23);
            this.LockBit_btn.TabIndex = 9;
            this.LockBit_btn.Text = "Remove Blue Color (LockBits)";
            this.LockBit_btn.UseVisualStyleBackColor = true;
            this.LockBit_btn.Click += new System.EventHandler(this.LockBit_btn_Click);
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(313, 400);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(60, 13);
            this.resLabel.TabIndex = 10;
            this.resLabel.Text = "Resolution:";
            // 
            // pixelsLabel
            // 
            this.pixelsLabel.AutoSize = true;
            this.pixelsLabel.Location = new System.Drawing.Point(313, 430);
            this.pixelsLabel.Name = "pixelsLabel";
            this.pixelsLabel.Size = new System.Drawing.Size(77, 13);
            this.pixelsLabel.TabIndex = 11;
            this.pixelsLabel.Text = "Pixel\'s number:";
            // 
            // resLabel_val
            // 
            this.resLabel_val.AutoSize = true;
            this.resLabel_val.Location = new System.Drawing.Point(427, 400);
            this.resLabel_val.Name = "resLabel_val";
            this.resLabel_val.Size = new System.Drawing.Size(0, 13);
            this.resLabel_val.TabIndex = 12;
            // 
            // pixelsLabel_val
            // 
            this.pixelsLabel_val.AutoSize = true;
            this.pixelsLabel_val.Location = new System.Drawing.Point(427, 430);
            this.pixelsLabel_val.Name = "pixelsLabel_val";
            this.pixelsLabel_val.Size = new System.Drawing.Size(0, 13);
            this.pixelsLabel_val.TabIndex = 13;
            // 
            // kMeansSimple_btn
            // 
            this.kMeansSimple_btn.Location = new System.Drawing.Point(12, 218);
            this.kMeansSimple_btn.Name = "kMeansSimple_btn";
            this.kMeansSimple_btn.Size = new System.Drawing.Size(75, 23);
            this.kMeansSimple_btn.TabIndex = 14;
            this.kMeansSimple_btn.Text = "K-Means";
            this.kMeansSimple_btn.UseVisualStyleBackColor = true;
            this.kMeansSimple_btn.Click += new System.EventHandler(this.kMeansSimple_btn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(751, 400);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(74, 13);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "Elapsed Time:";
            // 
            // timeLabel_val
            // 
            this.timeLabel_val.AutoSize = true;
            this.timeLabel_val.Location = new System.Drawing.Point(892, 400);
            this.timeLabel_val.Name = "timeLabel_val";
            this.timeLabel_val.Size = new System.Drawing.Size(0, 13);
            this.timeLabel_val.TabIndex = 16;
            // 
            // kMeansSimpleLockbits_btn
            // 
            this.kMeansSimpleLockbits_btn.Location = new System.Drawing.Point(12, 247);
            this.kMeansSimpleLockbits_btn.Name = "kMeansSimpleLockbits_btn";
            this.kMeansSimpleLockbits_btn.Size = new System.Drawing.Size(131, 23);
            this.kMeansSimpleLockbits_btn.TabIndex = 17;
            this.kMeansSimpleLockbits_btn.Text = "K-Means (Lockbits)";
            this.kMeansSimpleLockbits_btn.UseVisualStyleBackColor = true;
            this.kMeansSimpleLockbits_btn.Click += new System.EventHandler(this.kMeansSimpleLockbits_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Enter your K number:";
            // 
            // K_Value
            // 
            this.K_Value.Location = new System.Drawing.Point(124, 192);
            this.K_Value.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.K_Value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.K_Value.Name = "K_Value";
            this.K_Value.Size = new System.Drawing.Size(52, 20);
            this.K_Value.TabIndex = 20;
            this.K_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.K_Value.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "(Use small images to get fast results)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.K_Value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kMeansSimpleLockbits_btn);
            this.Controls.Add(this.timeLabel_val);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.kMeansSimple_btn);
            this.Controls.Add(this.pixelsLabel_val);
            this.Controls.Add(this.resLabel_val);
            this.Controls.Add(this.pixelsLabel);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.LockBit_btn);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.ModifyImage_btn);
            this.Controls.Add(this.OpenImage_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenImage_btn;
        private System.Windows.Forms.Button ModifyImage_btn;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private System.Windows.Forms.Button LockBit_btn;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label pixelsLabel;
        private System.Windows.Forms.Label resLabel_val;
        private System.Windows.Forms.Label pixelsLabel_val;
        private System.Windows.Forms.Button kMeansSimple_btn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLabel_val;
        private System.Windows.Forms.Button kMeansSimpleLockbits_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown K_Value;
        private System.Windows.Forms.Label label4;
    }
}

