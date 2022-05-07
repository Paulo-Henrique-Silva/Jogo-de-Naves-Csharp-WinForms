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
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Pnl_Instruções = new System.Windows.Forms.Panel();
            this.Btn_Entendi = new System.Windows.Forms.Button();
            this.Lbl_Instruções2 = new System.Windows.Forms.Label();
            this.Lbl_Instruções1 = new System.Windows.Forms.Label();
            this.Lbl_TituloInstruções = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Pnl_Botoes = new System.Windows.Forms.Panel();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Instruções = new System.Windows.Forms.Button();
            this.Btn_Jogar = new System.Windows.Forms.Button();
            this.Lbl_Criador = new System.Windows.Forms.Label();
            this.Pnl_Menu.SuspendLayout();
            this.Pnl_Instruções.SuspendLayout();
            this.Pnl_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Menu.Controls.Add(this.Pnl_Botoes);
            this.Pnl_Menu.Controls.Add(this.Lbl_Criador);
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 1);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(384, 459);
            this.Pnl_Menu.TabIndex = 4;
            // 
            // Pnl_Instruções
            // 
            this.Pnl_Instruções.Controls.Add(this.Btn_Entendi);
            this.Pnl_Instruções.Controls.Add(this.Lbl_Instruções2);
            this.Pnl_Instruções.Controls.Add(this.Lbl_Instruções1);
            this.Pnl_Instruções.Controls.Add(this.Lbl_TituloInstruções);
            this.Pnl_Instruções.Location = new System.Drawing.Point(0, 1);
            this.Pnl_Instruções.Name = "Pnl_Instruções";
            this.Pnl_Instruções.Size = new System.Drawing.Size(387, 464);
            this.Pnl_Instruções.TabIndex = 6;
            this.Pnl_Instruções.Visible = false;
            // 
            // Btn_Entendi
            // 
            this.Btn_Entendi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Entendi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Entendi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entendi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Entendi.Location = new System.Drawing.Point(90, 394);
            this.Btn_Entendi.Name = "Btn_Entendi";
            this.Btn_Entendi.Size = new System.Drawing.Size(200, 54);
            this.Btn_Entendi.TabIndex = 5;
            this.Btn_Entendi.Text = "Entendi";
            this.Btn_Entendi.UseVisualStyleBackColor = false;
            this.Btn_Entendi.Click += new System.EventHandler(this.Btn_Entendi_Click);
            // 
            // Lbl_Instruções2
            // 
            this.Lbl_Instruções2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instruções2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Instruções2.Location = new System.Drawing.Point(181, 286);
            this.Lbl_Instruções2.Name = "Lbl_Instruções2";
            this.Lbl_Instruções2.Size = new System.Drawing.Size(191, 90);
            this.Lbl_Instruções2.TabIndex = 4;
            this.Lbl_Instruções2.Text = "Utlize as setas do teclado para mover a nave horizontalmente. ";
            this.Lbl_Instruções2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Instruções1
            // 
            this.Lbl_Instruções1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instruções1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Instruções1.Location = new System.Drawing.Point(12, 164);
            this.Lbl_Instruções1.Name = "Lbl_Instruções1";
            this.Lbl_Instruções1.Size = new System.Drawing.Size(360, 119);
            this.Lbl_Instruções1.TabIndex = 3;
            this.Lbl_Instruções1.Text = "No jogo, você é um aventureiro espacial que acabou de econtrar uma nave alienígen" +
    "a inimiga.\r\nO seu principal objetivo é desviar dos ataques e projéteis do advers" +
    "ário pelo máximo de tempo possível.";
            this.Lbl_Instruções1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TituloInstruções
            // 
            this.Lbl_TituloInstruções.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_TituloInstruções.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloInstruções.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_TituloInstruções.Location = new System.Drawing.Point(0, 0);
            this.Lbl_TituloInstruções.Name = "Lbl_TituloInstruções";
            this.Lbl_TituloInstruções.Size = new System.Drawing.Size(387, 134);
            this.Lbl_TituloInstruções.TabIndex = 2;
            this.Lbl_TituloInstruções.Text = "Instruções do Jogo";
            this.Lbl_TituloInstruções.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(384, 134);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Jogo de Naves";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Botoes
            // 
            this.Pnl_Botoes.Controls.Add(this.Btn_Sair);
            this.Pnl_Botoes.Controls.Add(this.Btn_Instruções);
            this.Pnl_Botoes.Controls.Add(this.Btn_Jogar);
            this.Pnl_Botoes.Location = new System.Drawing.Point(90, 193);
            this.Pnl_Botoes.Name = "Pnl_Botoes";
            this.Pnl_Botoes.Size = new System.Drawing.Size(200, 163);
            this.Pnl_Botoes.TabIndex = 5;
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
            this.Btn_Instruções.Click += new System.EventHandler(this.Btn_Instruções_Click);
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
            this.Btn_Jogar.Click += new System.EventHandler(this.Btn_Jogar_Click);
            // 
            // Lbl_Criador
            // 
            this.Lbl_Criador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_Criador.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Criador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Criador.Location = new System.Drawing.Point(0, 422);
            this.Lbl_Criador.Name = "Lbl_Criador";
            this.Lbl_Criador.Size = new System.Drawing.Size(384, 37);
            this.Lbl_Criador.TabIndex = 4;
            this.Lbl_Criador.Text = "Criado por: Paulo-Henrique-Silva";
            this.Lbl_Criador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Pnl_Menu);
            this.Controls.Add(this.Pnl_Instruções);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Naves";
            this.Pnl_Menu.ResumeLayout(false);
            this.Pnl_Instruções.ResumeLayout(false);
            this.Pnl_Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Menu;
        private System.Windows.Forms.Label Lbl_Criador;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Panel Pnl_Botoes;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Instruções;
        private System.Windows.Forms.Button Btn_Jogar;
        private System.Windows.Forms.Panel Pnl_Instruções;
        private System.Windows.Forms.Label Lbl_TituloInstruções;
        private System.Windows.Forms.Label Lbl_Instruções1;
        private System.Windows.Forms.Label Lbl_Instruções2;
        private System.Windows.Forms.Button Btn_Entendi;
    }
}

