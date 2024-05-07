namespace GestorDeEstudantes_Natan
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelAcessar = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelDados = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanelAcessar = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.tableLayoutPanelDados.SuspendLayout();
            this.tableLayoutPanelBotoes.SuspendLayout();
            this.tableLayoutPanelAcessar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAcessar
            // 
            this.labelAcessar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAcessar.AutoSize = true;
            this.labelAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcessar.Location = new System.Drawing.Point(14, 6);
            this.labelAcessar.Name = "labelAcessar";
            this.labelAcessar.Size = new System.Drawing.Size(172, 46);
            this.labelAcessar.TabIndex = 0;
            this.labelAcessar.Text = "Acessar";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(3, 76);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(194, 165);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 1;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // tableLayoutPanelDados
            // 
            this.tableLayoutPanelDados.ColumnCount = 2;
            this.tableLayoutPanelDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.90604F));
            this.tableLayoutPanelDados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.09396F));
            this.tableLayoutPanelDados.Controls.Add(this.textBoxSenha, 1, 1);
            this.tableLayoutPanelDados.Controls.Add(this.labelUser, 0, 0);
            this.tableLayoutPanelDados.Controls.Add(this.labelSenha, 0, 1);
            this.tableLayoutPanelDados.Controls.Add(this.textBoxUsuario, 1, 0);
            this.tableLayoutPanelDados.Location = new System.Drawing.Point(12, 276);
            this.tableLayoutPanelDados.Name = "tableLayoutPanelDados";
            this.tableLayoutPanelDados.RowCount = 2;
            this.tableLayoutPanelDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDados.Size = new System.Drawing.Size(338, 105);
            this.tableLayoutPanelDados.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(124, 63);
            this.textBoxSenha.Multiline = true;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(211, 31);
            this.textBoxSenha.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(6, 10);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(108, 31);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Usuário";
            this.labelUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(14, 63);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(92, 31);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(124, 10);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(211, 31);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // tableLayoutPanelBotoes
            // 
            this.tableLayoutPanelBotoes.ColumnCount = 2;
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonCancelar, 1, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonLogin, 0, 0);
            this.tableLayoutPanelBotoes.Location = new System.Drawing.Point(12, 408);
            this.tableLayoutPanelBotoes.Name = "tableLayoutPanelBotoes";
            this.tableLayoutPanelBotoes.RowCount = 1;
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanelBotoes.Size = new System.Drawing.Size(338, 73);
            this.tableLayoutPanelBotoes.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(182, 12);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(143, 48);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(13, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(143, 48);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelAcessar
            // 
            this.tableLayoutPanelAcessar.ColumnCount = 1;
            this.tableLayoutPanelAcessar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAcessar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAcessar.Controls.Add(this.labelAcessar, 0, 0);
            this.tableLayoutPanelAcessar.Controls.Add(this.pictureBoxUsuario, 0, 1);
            this.tableLayoutPanelAcessar.Location = new System.Drawing.Point(86, 12);
            this.tableLayoutPanelAcessar.Name = "tableLayoutPanelAcessar";
            this.tableLayoutPanelAcessar.RowCount = 2;
            this.tableLayoutPanelAcessar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.20675F));
            this.tableLayoutPanelAcessar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.79325F));
            this.tableLayoutPanelAcessar.Size = new System.Drawing.Size(200, 258);
            this.tableLayoutPanelAcessar.TabIndex = 4;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 493);
            this.Controls.Add(this.tableLayoutPanelAcessar);
            this.Controls.Add(this.tableLayoutPanelBotoes);
            this.Controls.Add(this.tableLayoutPanelDados);
            this.Name = "FormLogin";
            this.Text = "SGA - Acessar";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.tableLayoutPanelDados.ResumeLayout(false);
            this.tableLayoutPanelDados.PerformLayout();
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            this.tableLayoutPanelAcessar.ResumeLayout(false);
            this.tableLayoutPanelAcessar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAcessar;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDados;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAcessar;
    }
}

