namespace Launcher_Radianta_Novo
{
    partial class winLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.bntVerSenha = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntrar.CausesValidation = false;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.ImageKey = "(nenhum/a)";
            this.btnEntrar.Location = new System.Drawing.Point(53, 315);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(60, 42);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.TabStop = false;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(9, 191);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.WordWrap = false;
            this.txtEmail.ReadOnlyChanged += new System.EventHandler(this.txtEmail_ReadOnlyChanged);
            this.txtEmail.ClientSizeChanged += new System.EventHandler(this.txtEmail_ClientSizeChanged);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress_1);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário ou Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.Location = new System.Drawing.Point(8, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "<---";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lnkRegistro
            // 
            this.lnkRegistro.AutoSize = true;
            this.lnkRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lnkRegistro.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnkRegistro.Location = new System.Drawing.Point(38, 390);
            this.lnkRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(100, 13);
            this.lnkRegistro.TabIndex = 5;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = "Não tem um conta?";
            this.lnkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistro_LinkClicked);
            // 
            // bntVerSenha
            // 
            this.bntVerSenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.bntVerSenha.Image = global::Launcher_Radianta_Novo.Properties.Resources.OlhoCorreto;
            this.bntVerSenha.Location = new System.Drawing.Point(149, 225);
            this.bntVerSenha.Name = "bntVerSenha";
            this.bntVerSenha.Size = new System.Drawing.Size(32, 33);
            this.bntVerSenha.TabIndex = 2;
            this.bntVerSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntVerSenha.UseVisualStyleBackColor = true;
            this.bntVerSenha.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(9, 231);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(136, 20);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WordWrap = false;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // winLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher_Radianta_Novo.Properties.Resources.loginRegister;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 421);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.bntVerSenha);
            this.Controls.Add(this.lnkRegistro);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "winLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.winLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lnkRegistro;
        private System.Windows.Forms.Button bntVerSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
    }
}

