namespace Form_Jogo
{
    partial class F_Menu
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Jogar = new System.Windows.Forms.Button();
            this.Pnl_Butoes = new System.Windows.Forms.Panel();
            this.Btn_Instruções = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Criador = new System.Windows.Forms.Label();
            this.Pnl_Butoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(384, 134);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Jogo de Naves";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Jogar
            // 
            this.Btn_Jogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Jogar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Jogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Jogar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Jogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Jogar.Location = new System.Drawing.Point(0, 0);
            this.Btn_Jogar.Name = "Btn_Jogar";
            this.Btn_Jogar.Size = new System.Drawing.Size(200, 54);
            this.Btn_Jogar.TabIndex = 1;
            this.Btn_Jogar.Text = "Jogar";
            this.Btn_Jogar.UseVisualStyleBackColor = false;
            // 
            // Pnl_Butoes
            // 
            this.Pnl_Butoes.Controls.Add(this.Btn_Sair);
            this.Pnl_Butoes.Controls.Add(this.Btn_Instruções);
            this.Pnl_Butoes.Controls.Add(this.Btn_Jogar);
            this.Pnl_Butoes.Location = new System.Drawing.Point(86, 188);
            this.Pnl_Butoes.Name = "Pnl_Butoes";
            this.Pnl_Butoes.Size = new System.Drawing.Size(200, 163);
            this.Pnl_Butoes.TabIndex = 2;
            // 
            // Btn_Instruções
            // 
            this.Btn_Instruções.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Instruções.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Instruções.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Instruções.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Instruções.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Instruções.Location = new System.Drawing.Point(0, 54);
            this.Btn_Instruções.Name = "Btn_Instruções";
            this.Btn_Instruções.Size = new System.Drawing.Size(200, 54);
            this.Btn_Instruções.TabIndex = 2;
            this.Btn_Instruções.Text = "Instruções";
            this.Btn_Instruções.UseVisualStyleBackColor = false;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Sair.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Sair.Location = new System.Drawing.Point(0, 108);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(200, 54);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Lbl_Criador
            // 
            this.Lbl_Criador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_Criador.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Criador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Criador.Location = new System.Drawing.Point(0, 424);
            this.Lbl_Criador.Name = "Lbl_Criador";
            this.Lbl_Criador.Size = new System.Drawing.Size(384, 37);
            this.Lbl_Criador.TabIndex = 3;
            this.Lbl_Criador.Text = "Criado por: Paulo-Henrique-Silva";
            this.Lbl_Criador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Lbl_Criador);
            this.Controls.Add(this.Pnl_Butoes);
            this.Controls.Add(this.Lbl_Titulo);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Naves";
            this.Pnl_Butoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Jogar;
        private System.Windows.Forms.Panel Pnl_Butoes;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Instruções;
        private System.Windows.Forms.Label Lbl_Criador;
    }
}

