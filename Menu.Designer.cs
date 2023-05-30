namespace Launcher_Radianta_Novo
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCapa = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::Launcher_Radianta_Novo.Properties.Resources.Design_sem_nome__1_;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCapa
            // 
            this.btnCapa.BackColor = System.Drawing.Color.White;
            this.btnCapa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCapa.Image = global::Launcher_Radianta_Novo.Properties.Resources.Trailer__3_;
            this.btnCapa.Location = new System.Drawing.Point(794, 447);
            this.btnCapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapa.Name = "btnCapa";
            this.btnCapa.Size = new System.Drawing.Size(110, 40);
            this.btnCapa.TabIndex = 0;
            this.btnCapa.UseVisualStyleBackColor = false;
            this.btnCapa.Click += new System.EventHandler(this.btnCapa_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnVideo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVideo.Image = global::Launcher_Radianta_Novo.Properties.Resources.Trailer__4_;
            this.btnVideo.Location = new System.Drawing.Point(348, 447);
            this.btnVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(110, 40);
            this.btnVideo.TabIndex = 1;
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Launcher_Radianta_Novo.Properties.Resources.JanelaLauncher1;
            this.pictureBox2.Location = new System.Drawing.Point(326, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 335);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Launcher_Radianta_Novo.Properties.Resources.BackiGroun;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1260, 670);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCapa);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapa;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}