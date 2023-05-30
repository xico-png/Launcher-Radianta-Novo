namespace Launcher_Radianta_Novo
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.AbaVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.AbaVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // AbaVideo
            // 
            this.AbaVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbaVideo.Enabled = true;
            this.AbaVideo.Location = new System.Drawing.Point(0, 0);
            this.AbaVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AbaVideo.Name = "AbaVideo";
            this.AbaVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AbaVideo.OcxState")));
            this.AbaVideo.Size = new System.Drawing.Size(946, 547);
            this.AbaVideo.TabIndex = 0;
            this.AbaVideo.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.AbaVideo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Video";
            this.Text = "Video";
            ((System.ComponentModel.ISupportInitialize)(this.AbaVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer AbaVideo;
    }
}