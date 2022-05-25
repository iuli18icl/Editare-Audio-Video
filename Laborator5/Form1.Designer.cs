namespace Laborator5
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
            this.IncarcareImagini = new System.Windows.Forms.Button();
            this.AlbNegru = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.histogram = new System.Windows.Forms.Button();
            this.Contrast = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Gamma = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.Resize = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.VideoCapture = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BlendingImage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorchange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // IncarcareImagini
            // 
            this.IncarcareImagini.Location = new System.Drawing.Point(24, 18);
            this.IncarcareImagini.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.IncarcareImagini.Name = "IncarcareImagini";
            this.IncarcareImagini.Size = new System.Drawing.Size(216, 54);
            this.IncarcareImagini.TabIndex = 0;
            this.IncarcareImagini.Text = "Incarcare Imagine";
            this.IncarcareImagini.UseVisualStyleBackColor = true;
            this.IncarcareImagini.Click += new System.EventHandler(this.IncarcareImagini_Click);
            // 
            // AlbNegru
            // 
            this.AlbNegru.Location = new System.Drawing.Point(251, 18);
            this.AlbNegru.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AlbNegru.Name = "AlbNegru";
            this.AlbNegru.Size = new System.Drawing.Size(216, 54);
            this.AlbNegru.TabIndex = 3;
            this.AlbNegru.Text = "Alb-negru";
            this.AlbNegru.UseVisualStyleBackColor = true;
            this.AlbNegru.Click += new System.EventHandler(this.AlbNegru_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(477, 454);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(1157, 18);
            this.histogram.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(216, 54);
            this.histogram.TabIndex = 6;
            this.histogram.Text = "Histograms";
            this.histogram.UseMnemonic = false;
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.Histogram_Click_1);
            // 
            // Contrast
            // 
            this.Contrast.Location = new System.Drawing.Point(1384, 18);
            this.Contrast.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(216, 54);
            this.Contrast.TabIndex = 8;
            this.Contrast.Text = "Contrast";
            this.Contrast.UseVisualStyleBackColor = true;
            this.Contrast.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(1384, 84);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(216, 31);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1384, 129);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(216, 31);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Gamma
            // 
            this.Gamma.Location = new System.Drawing.Point(477, 18);
            this.Gamma.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(216, 54);
            this.Gamma.TabIndex = 11;
            this.Gamma.Text = "Gamma";
            this.Gamma.UseVisualStyleBackColor = true;
            this.Gamma.Click += new System.EventHandler(this.Gamma_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(477, 84);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(216, 31);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(931, 18);
            this.Resize.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(216, 54);
            this.Resize.TabIndex = 14;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.resize);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(704, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 54);
            this.button4.TabIndex = 17;
            this.button4.Text = "Rotatie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.rotate);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(704, 84);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(216, 31);
            this.numericUpDown5.TabIndex = 19;
            // 
            // VideoCapture
            // 
            this.VideoCapture.Location = new System.Drawing.Point(1611, 18);
            this.VideoCapture.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.VideoCapture.Name = "VideoCapture";
            this.VideoCapture.Size = new System.Drawing.Size(216, 54);
            this.VideoCapture.TabIndex = 20;
            this.VideoCapture.Text = "Video capture";
            this.VideoCapture.UseVisualStyleBackColor = true;
            this.VideoCapture.Click += new System.EventHandler(this.Video_capture);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(931, 336);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(896, 511);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2637, 742);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // BlendingImage
            // 
            this.BlendingImage.Location = new System.Drawing.Point(25, 186);
            this.BlendingImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlendingImage.Name = "BlendingImage";
            this.BlendingImage.Size = new System.Drawing.Size(215, 51);
            this.BlendingImage.TabIndex = 23;
            this.BlendingImage.Text = "Blending Image";
            this.BlendingImage.UseVisualStyleBackColor = true;
            this.BlendingImage.Click += new System.EventHandler(this.BlendingImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(24, 454);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(443, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // colorchange
            // 
            this.colorchange.Location = new System.Drawing.Point(256, 182);
            this.colorchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorchange.Name = "colorchange";
            this.colorchange.Size = new System.Drawing.Size(211, 55);
            this.colorchange.TabIndex = 25;
            this.colorchange.Text = "Color Change";
            this.colorchange.UseVisualStyleBackColor = true;
            this.colorchange.Click += new System.EventHandler(this.colorchange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2565, 865);
            this.Controls.Add(this.colorchange);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BlendingImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.VideoCapture);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.Gamma);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AlbNegru);
            this.Controls.Add(this.IncarcareImagini);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IncarcareImagini;
        private System.Windows.Forms.Button AlbNegru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button Contrast;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button Gamma;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button Resize;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button VideoCapture;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BlendingImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button colorchange;
    }
}

