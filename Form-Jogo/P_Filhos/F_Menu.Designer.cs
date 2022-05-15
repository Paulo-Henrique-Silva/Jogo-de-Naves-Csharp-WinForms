namespace Form_Jogo.P_Filhos
{
    partial class F_Menu
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
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Instruções = new System.Windows.Forms.Button();
            this.Btn_Jogar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Pnl_Botoes = new System.Windows.Forms.Panel();
            this.Lbl_Criador = new System.Windows.Forms.Label();
            this.Pnl_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Sair.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Sair.Location = new System.Drawing.Point(93, 165);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(200, 53);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Instruções
            // 
            this.Btn_Instruções.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Instruções.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Instruções.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Instruções.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Instruções.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Instruções.Location = new System.Drawing.Point(93, 103);
            this.Btn_Instruções.Name = "Btn_Instruções";
            this.Btn_Instruções.Size = new System.Drawing.Size(200, 53);
            this.Btn_Instruções.TabIndex = 2;
            this.Btn_Instruções.Text = "Instruções";
            this.Btn_Instruções.UseVisualStyleBackColor = false;
            this.Btn_Instruções.Click += new System.EventHandler(this.Btn_Instruções_Click);
            // 
            // Btn_Jogar
            // 
            this.Btn_Jogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Jogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Jogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Jogar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Jogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Jogar.Location = new System.Drawing.Point(93, 41);
            this.Btn_Jogar.Name = "Btn_Jogar";
            this.Btn_Jogar.Size = new System.Drawing.Size(200, 53);
            this.Btn_Jogar.TabIndex = 1;
            this.Btn_Jogar.Text = "Jogar";
            this.Btn_Jogar.UseVisualStyleBackColor = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(384, 160);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Jogo de Naves";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Botoes
            // 
            this.Pnl_Botoes.Controls.Add(this.Btn_Sair);
            this.Pnl_Botoes.Controls.Add(this.Btn_Instruções);
            this.Pnl_Botoes.Controls.Add(this.Btn_Jogar);
            this.Pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Botoes.Location = new System.Drawing.Point(0, 160);
            this.Pnl_Botoes.Name = "Pnl_Botoes";
            this.Pnl_Botoes.Size = new System.Drawing.Size(384, 247);
            this.Pnl_Botoes.TabIndex = 5;
            // 
            // Lbl_Criador
            // 
            this.Lbl_Criador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Criador.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Criador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Criador.Location = new System.Drawing.Point(0, 407);
            this.Lbl_Criador.Name = "Lbl_Criador";
            this.Lbl_Criador.Size = new System.Drawing.Size(384, 54);
            this.Lbl_Criador.TabIndex = 6;
            this.Lbl_Criador.Text = "Criador por: Paulo-Henrique-Silva";
            this.Lbl_Criador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Lbl_Criador);
            this.Controls.Add(this.Pnl_Botoes);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Menu";
            this.Text = "F_Menu";
            this.Pnl_Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Instruções;
        private System.Windows.Forms.Button Btn_Jogar;
        private System.Windows.Forms.Panel Pnl_Botoes;
        private System.Windows.Forms.Label Lbl_Criador;
    }
}