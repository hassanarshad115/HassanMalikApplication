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
            this.verifybutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refreshbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verifybutton1
            // 
            this.verifybutton1.Location = new System.Drawing.Point(108, 251);
            this.verifybutton1.Name = "verifybutton1";
            this.verifybutton1.Size = new System.Drawing.Size(75, 23);
            this.verifybutton1.TabIndex = 1;
            this.verifybutton1.Text = "varify";
            this.verifybutton1.UseVisualStyleBackColor = true;
            this.verifybutton1.Click += new System.EventHandler(this.verifybutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 88);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 0;
            // 
            // refreshbutton2
            // 
            this.refreshbutton2.Location = new System.Drawing.Point(325, 127);
            this.refreshbutton2.Name = "refreshbutton2";
            this.refreshbutton2.Size = new System.Drawing.Size(75, 23);
            this.refreshbutton2.TabIndex = 2;
            this.refreshbutton2.Text = "Refresh";
            this.refreshbutton2.UseVisualStyleBackColor = true;
            this.refreshbutton2.Click += new System.EventHandler(this.refreshbutton2_Click);
            // 
            // captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 328);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshbutton2);
            this.Controls.Add(this.verifybutton1);
            this.Name = "captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "captcha";
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