namespace Form_Jogo.P_Filhos
{
    partial class F_Jogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Jogo));
            this.Pbx_Fundo1 = new System.Windows.Forms.PictureBox();
            this.Pbx_Fundo2 = new System.Windows.Forms.PictureBox();
            this.Tmr_Jogo = new System.Windows.Forms.Timer(this.components);
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Pbx_Nave = new System.Windows.Forms.PictureBox();
            this.Btn_ComecarJogo = new System.Windows.Forms.Button();
            this.Tmr_AmtDif = new System.Windows.Forms.Timer(this.components);
            this.Pbx_Inimigo = new System.Windows.Forms.PictureBox();
            this.Pbx_Tiro1 = new System.Windows.Forms.PictureBox();
            this.Pbx_Tiro2 = new System.Windows.Forms.PictureBox();
            this.Lbl_FimJogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fundo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fundo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Nave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Inimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Tiro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Tiro2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbx_Fundo1
            // 
            this.Pbx_Fundo1.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Fundo1.Image")));
            this.Pbx_Fundo1.Location = new System.Drawing.Point(0, 0);
            this.Pbx_Fundo1.Name = "Pbx_Fundo1";
            this.Pbx_Fundo1.Size = new System.Drawing.Size(384, 461);
            this.Pbx_Fundo1.TabIndex = 0;
            this.Pbx_Fundo1.TabStop = false;
            // 
            // Pbx_Fundo2
            // 
            this.Pbx_Fundo2.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Fundo2.Image")));
            this.Pbx_Fundo2.Location = new System.Drawing.Point(0, 461);
            this.Pbx_Fundo2.Name = "Pbx_Fundo2";
            this.Pbx_Fundo2.Size = new System.Drawing.Size(384, 461);
            this.Pbx_Fundo2.TabIndex = 1;
            this.Pbx_Fundo2.TabStop = false;
            // 
            // Tmr_Jogo
            // 
            this.Tmr_Jogo.Interval = 20;
            this.Tmr_Jogo.Tick += new System.EventHandler(this.Tmr_Jogo_Tick);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Sair.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Sair.Location = new System.Drawing.Point(12, 12);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(50, 25);
            this.Btn_Sair.TabIndex = 6;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Pbx_Nave
            // 
            this.Pbx_Nave.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Nave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pbx_Nave.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Nave.Image")));
            this.Pbx_Nave.Location = new System.Drawing.Point(166, 369);
            this.Pbx_Nave.Name = "Pbx_Nave";
            this.Pbx_Nave.Size = new System.Drawing.Size(55, 80);
            this.Pbx_Nave.TabIndex = 7;
            this.Pbx_Nave.TabStop = false;
            this.Pbx_Nave.Visible = false;
            // 
            // Btn_ComecarJogo
            // 
            this.Btn_ComecarJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_ComecarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ComecarJogo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ComecarJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_ComecarJogo.Location = new System.Drawing.Point(90, 268);
            this.Btn_ComecarJogo.Name = "Btn_ComecarJogo";
            this.Btn_ComecarJogo.Size = new System.Drawing.Size(206, 95);
            this.Btn_ComecarJogo.TabIndex = 8;
            this.Btn_ComecarJogo.Text = "Começar";
            this.Btn_ComecarJogo.UseVisualStyleBackColor = false;
            this.Btn_ComecarJogo.Click += new System.EventHandler(this.ComecarJogo);
            // 
            // Tmr_AmtDif
            // 
            this.Tmr_AmtDif.Interval = 10000;
            this.Tmr_AmtDif.Tick += new System.EventHandler(this.Tmr_AmtDif_Tick);
            // 
            // Pbx_Inimigo
            // 
            this.Pbx_Inimigo.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Inimigo.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Inimigo.Image")));
            this.Pbx_Inimigo.Location = new System.Drawing.Point(12, 43);
            this.Pbx_Inimigo.Name = "Pbx_Inimigo";
            this.Pbx_Inimigo.Size = new System.Drawing.Size(360, 68);
            this.Pbx_Inimigo.TabIndex = 9;
            this.Pbx_Inimigo.TabStop = false;
            this.Pbx_Inimigo.Visible = false;
            // 
            // Pbx_Tiro1
            // 
            this.Pbx_Tiro1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Pbx_Tiro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pbx_Tiro1.Location = new System.Drawing.Point(130, 43);
            this.Pbx_Tiro1.Name = "Pbx_Tiro1";
            this.Pbx_Tiro1.Size = new System.Drawing.Size(15, 68);
            this.Pbx_Tiro1.TabIndex = 19;
            this.Pbx_Tiro1.TabStop = false;
            this.Pbx_Tiro1.Visible = false;
            // 
            // Pbx_Tiro2
            // 
            this.Pbx_Tiro2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Pbx_Tiro2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pbx_Tiro2.Location = new System.Drawing.Point(240, 43);
            this.Pbx_Tiro2.Name = "Pbx_Tiro2";
            this.Pbx_Tiro2.Size = new System.Drawing.Size(15, 68);
            this.Pbx_Tiro2.TabIndex = 21;
            this.Pbx_Tiro2.TabStop = false;
            this.Pbx_Tiro2.Visible = false;
            // 
            // Lbl_FimJogo
            // 
            this.Lbl_FimJogo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_FimJogo.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FimJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_FimJogo.Location = new System.Drawing.Point(71, 114);
            this.Lbl_FimJogo.Name = "Lbl_FimJogo";
            this.Lbl_FimJogo.Size = new System.Drawing.Size(250, 107);
            this.Lbl_FimJogo.TabIndex = 22;
            this.Lbl_FimJogo.Text = "Fim de Jogo!";
            this.Lbl_FimJogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_FimJogo.Visible = false;
            // 
            // F_Jogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Lbl_FimJogo);
            this.Controls.Add(this.Pbx_Inimigo);
            this.Controls.Add(this.Btn_ComecarJogo);
            this.Controls.Add(this.Pbx_Nave);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Pbx_Tiro1);
            this.Controls.Add(this.Pbx_Tiro2);
            this.Controls.Add(this.Pbx_Fundo1);
            this.Controls.Add(this.Pbx_Fundo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "F_Jogo";
            this.Text = "F_Jogo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Jogo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F_Jogo_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fundo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fundo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Nave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Inimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Tiro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Tiro2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbx_Fundo1;
        private System.Windows.Forms.PictureBox Pbx_Fundo2;
        private System.Windows.Forms.Timer Tmr_Jogo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.PictureBox Pbx_Nave;
        private System.Windows.Forms.Button Btn_ComecarJogo;
        private System.Windows.Forms.Timer Tmr_AmtDif;
        private System.Windows.Forms.PictureBox Pbx_Inimigo;
        private System.Windows.Forms.PictureBox Pbx_Tiro1;
        private System.Windows.Forms.PictureBox Pbx_Tiro2;
        private System.Windows.Forms.Label Lbl_FimJogo;
    }
}