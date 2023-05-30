namespace Launcher_Radianta_Novo
{
    partial class winRegistro
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Usuário = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblTeste = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(9, 168);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(114, 26);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 223);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "seuemail@email.com";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Location = new System.Drawing.Point(11, 153);
            this.Usuário.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(43, 13);
            this.Usuário.TabIndex = 2;
            this.Usuário.Text = "Usuário";
            this.Usuário.Click += new System.EventHandler(this.Usuário_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(7, 208);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(87, 332);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(117, 19);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Enviar Email";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnEnviarEmail);
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(149, 171);
            this.lblTeste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(0, 13);
            this.lblTeste.TabIndex = 6;
            this.lblTeste.Click += new System.EventHandler(this.btn_INFO_Email);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(14, 332);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 19);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // winRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher_Radianta_Novo.Properties.Resources.loginRegister;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 401);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Usuário);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "winRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.winRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Usuário;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Button btnCancelar;
    }
}