namespace HassanMalikApplication
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.label1 = new System.Windows.Forms.Label();
            this.fromcomboBox = new System.Windows.Forms.ComboBox();
            this.yearchart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.tocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearchart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // fromcomboBox
            // 
            this.fromcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromcomboBox.FormattingEnabled = true;
            this.fromcomboBox.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.fromcomboBox.Location = new System.Drawing.Point(51, 12);
            this.fromcomboBox.Name = "fromcomboBox";
            this.fromcomboBox.Size = new System.Drawing.Size(121, 24);
            this.fromcomboBox.TabIndex = 1;
            // 
            // yearchart1
            // 
            this.yearchart1.BorderlineColor = System.Drawing.Color.Black;
            this.yearchart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.yearchart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.yearchart1.Legends.Add(legend1);
            this.yearchart1.Location = new System.Drawing.Point(12, 46);
            this.yearchart1.Name = "yearchart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.yearchart1.Series.Add(series1);
            this.yearchart1.Size = new System.Drawing.Size(759, 337);
            this.yearchart1.TabIndex = 2;
            this.yearchart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.DarkRed;
            title1.Name = "No of Student By Year";
            title1.Text = "No of Students By Year";
            this.yearchart1.Titles.Add(title1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // tocomboBox
            // 
            this.tocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tocomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocomboBox.FormattingEnabled = true;
            this.tocomboBox.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.tocomboBox.Location = new System.Drawing.Point(221, 12);
            this.tocomboBox.Name = "tocomboBox";
            this.tocomboBox.Size = new System.Drawing.Size(121, 24);
            this.tocomboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Students";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HassanMalikApplication.Properties.Resources.EXITEXIT;
            this.pictureBox1.Location = new System.Drawing.Point(725, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gobutton
            // 
            this.gobutton.BackColor = System.Drawing.Color.Transparent;
            this.gobutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gobutton.BackgroundImage")));
            this.gobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gobutton.Location = new System.Drawing.Point(399, 9);
            this.gobutton.Name = "gobutton";
            this.gobutton.Size = new System.Drawing.Size(36, 28);
            this.gobutton.TabIndex = 3;
            this.gobutton.UseVisualStyleBackColor = false;
            this.gobutton.Click += new System.EventHandler(this.gobutton_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gobutton);
            this.Controls.Add(this.yearchart1);
            this.Controls.Add(this.tocomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromcomboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearchart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fromcomboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearchart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tocomboBox;
        private System.Windows.Forms.Button gobutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}