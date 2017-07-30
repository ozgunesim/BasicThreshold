namespace ProcessVideo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOpenDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOpenVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.seçeneklerToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpenDevice,
            this.toolOpenVideo,
            this.toolOpenImage});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // toolOpenDevice
            // 
            this.toolOpenDevice.Name = "toolOpenDevice";
            this.toolOpenDevice.Size = new System.Drawing.Size(165, 22);
            this.toolOpenDevice.Text = "Video Aygıtı Aç";
            this.toolOpenDevice.Click += new System.EventHandler(this.toolOpenDevice_Click);
            // 
            // toolOpenVideo
            // 
            this.toolOpenVideo.Name = "toolOpenVideo";
            this.toolOpenVideo.Size = new System.Drawing.Size(165, 22);
            this.toolOpenVideo.Text = "Video Dosyası Aç";
            // 
            // toolOpenImage
            // 
            this.toolOpenImage.Name = "toolOpenImage";
            this.toolOpenImage.Size = new System.Drawing.Size(165, 22);
            this.toolOpenImage.Text = "Resim Aç";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // picVideo
            // 
            this.picVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVideo.Location = new System.Drawing.Point(12, 27);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(320, 240);
            this.picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picVideo.TabIndex = 1;
            this.picVideo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 335);
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolOpenDevice;
        private System.Windows.Forms.ToolStripMenuItem toolOpenVideo;
        private System.Windows.Forms.ToolStripMenuItem toolOpenImage;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.PictureBox picVideo;
    }
}

