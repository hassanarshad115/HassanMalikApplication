namespace HassanMalikApplication
{
    partial class captcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(captcha));
            this.verifybutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refreshbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verifybutton1
            // 
            this.verifybutton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verifybutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifybutton1.Location = new System.Drawing.Point(2, 142);
            this.verifybutton1.Name = "verifybutton1";
            this.verifybutton1.Size = new System.Drawing.Size(221, 116);
            this.verifybutton1.TabIndex = 1;
            this.verifybutton1.Text = "varify";
            this.verifybutton1.UseVisualStyleBackColor = true;
            this.verifybutton1.Click += new System.EventHandler(this.verifybutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 79);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 30);
            this.textBox1.TabIndex = 0;
            // 
            // refreshbutton2
            // 
            this.refreshbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbutton2.Location = new System.Drawing.Point(224, 142);
            this.refreshbutton2.Name = "refreshbutton2";
            this.refreshbutton2.Size = new System.Drawing.Size(90, 116);
            this.refreshbutton2.TabIndex = 2;
            this.refreshbutton2.Text = "Refresh";
            this.refreshbutton2.UseVisualStyleBackColor = true;
            this.refreshbutton2.Click += new System.EventHandler(this.refreshbutton2_Click);
            // 
            // captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BorderThickness = 3;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 35;
            this.CaptionButtonColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionButtonHoverColor = System.Drawing.Color.Aqua;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 270);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshbutton2);
            this.Controls.Add(this.verifybutton1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha ";
            this.Load += new System.EventHandler(this.captcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verifybutton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button refreshbutton2;
    }
}