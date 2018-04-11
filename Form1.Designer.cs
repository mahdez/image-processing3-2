namespace image_processing3_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HistogramRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Negative = new System.Windows.Forms.Button();
            this.btn_Brightness = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(310, 13);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(105, 36);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open file";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(421, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 202);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Intensity Correction";
            // 
            // HistogramRed
            // 
            chartArea16.Name = "ChartArea1";
            this.HistogramRed.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.HistogramRed.Legends.Add(legend16);
            this.HistogramRed.Location = new System.Drawing.Point(13, 244);
            this.HistogramRed.Name = "HistogramRed";
            series16.ChartArea = "ChartArea1";
            series16.Color = System.Drawing.Color.Red;
            series16.Legend = "Legend1";
            series16.Name = "Color";
            series16.ShadowColor = System.Drawing.Color.Red;
            this.HistogramRed.Series.Add(series16);
            this.HistogramRed.Size = new System.Drawing.Size(283, 131);
            this.HistogramRed.TabIndex = 19;
            this.HistogramRed.Text = "HistogramRed";
            // 
            // HistogramBlue
            // 
            chartArea17.Name = "ChartArea1";
            this.HistogramBlue.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.HistogramBlue.Legends.Add(legend17);
            this.HistogramBlue.Location = new System.Drawing.Point(606, 244);
            this.HistogramBlue.Name = "HistogramBlue";
            series17.ChartArea = "ChartArea1";
            series17.Color = System.Drawing.Color.Blue;
            series17.Legend = "Legend1";
            series17.Name = "Color";
            this.HistogramBlue.Series.Add(series17);
            this.HistogramBlue.Size = new System.Drawing.Size(283, 131);
            this.HistogramBlue.TabIndex = 22;
            this.HistogramBlue.Text = "HistogramBlue";
            // 
            // HistogramGreen
            // 
            chartArea18.Name = "ChartArea1";
            this.HistogramGreen.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.HistogramGreen.Legends.Add(legend18);
            this.HistogramGreen.Location = new System.Drawing.Point(310, 244);
            this.HistogramGreen.Name = "HistogramGreen";
            series18.ChartArea = "ChartArea1";
            series18.Color = System.Drawing.Color.Lime;
            series18.Legend = "Legend1";
            series18.Name = "Color";
            series18.ShadowColor = System.Drawing.Color.Red;
            this.HistogramGreen.Series.Add(series18);
            this.HistogramGreen.Size = new System.Drawing.Size(283, 131);
            this.HistogramGreen.TabIndex = 21;
            this.HistogramGreen.Text = "HistogramGreen";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(13, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 185);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(310, 395);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(283, 185);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(606, 395);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(283, 185);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Red Component";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Green Conponent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Blue Commonent";
            // 
            // Percentage
            // 
            this.Percentage.Location = new System.Drawing.Point(761, 52);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(107, 20);
            this.Percentage.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(874, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Percentage (+/-)";
            // 
            // btn_Negative
            // 
            this.btn_Negative.Location = new System.Drawing.Point(837, 90);
            this.btn_Negative.Name = "btn_Negative";
            this.btn_Negative.Size = new System.Drawing.Size(75, 23);
            this.btn_Negative.TabIndex = 30;
            this.btn_Negative.Text = "Negative";
            this.btn_Negative.UseVisualStyleBackColor = true;
            this.btn_Negative.Click += new System.EventHandler(this.btn_Negative_Click);
            // 
            // btn_Brightness
            // 
            this.btn_Brightness.Location = new System.Drawing.Point(761, 90);
            this.btn_Brightness.Name = "btn_Brightness";
            this.btn_Brightness.Size = new System.Drawing.Size(70, 23);
            this.btn_Brightness.TabIndex = 29;
            this.btn_Brightness.Text = "Brigtness";
            this.btn_Brightness.UseVisualStyleBackColor = true;
            this.btn_Brightness.Click += new System.EventHandler(this.btn_Brightness_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 605);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Negative);
            this.Controls.Add(this.btn_Brightness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.HistogramBlue);
            this.Controls.Add(this.HistogramGreen);
            this.Controls.Add(this.HistogramRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramBlue;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramGreen;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Percentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Negative;
        private System.Windows.Forms.Button btn_Brightness;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

