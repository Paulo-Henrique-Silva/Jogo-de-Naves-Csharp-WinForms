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
            this.Btn_Comecar = new System.Windows.Forms.Button();
            this.Tmr_AmtDif = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fundo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fundo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Nave)).BeginInit();
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
            this.Tmr_Jogo.Interval = 1;
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
            this.Pbx_Nave.Location = new System.Drawing.Point(157, 363);
            this.Pbx_Nave.Name = "Pbx_Nave";
            this.Pbx_Nave.Size = new System.Drawing.Size(70, 80);
            this.Pbx_Nave.TabIndex = 7;
            this.Pbx_Nave.TabStop = false;
            // 
            // Btn_Comecar
            // 
            this.Btn_Comecar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Comecar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Comecar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Comecar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Comecar.Location = new System.Drawing.Point(91, 151);
            this.Btn_Comecar.Name = "Btn_Comecar";
            this.Btn_Comecar.Size = new System.Drawing.Size(206, 95);
            this.Btn_Comecar.TabIndex = 8;
            this.Btn_Comecar.Text = "Começar";
            this.Btn_Comecar.UseVisualStyleBackColor = false;
            this.Btn_Comecar.Click += new System.EventHandler(this.Btn_Comecar_Click);
            // 
            // Tmr_AmtDif
            // 
            this.Tmr_AmtDif.Interval = 8000;
            this.Tmr_AmtDif.Tick += new System.EventHandler(this.Tmr_AmtDif_Tick);
            // 
            // F_Jogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Btn_Comecar);
            this.Controls.Add(this.Pbx_Nave);
            this.Controls.Add(this.Btn_Sair);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbx_Fundo1;
        private System.Windows.Forms.PictureBox Pbx_Fundo2;
        private System.Windows.Forms.Timer Tmr_Jogo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.PictureBox Pbx_Nave;
        private System.Windows.Forms.Button Btn_Comecar;
        private System.Windows.Forms.Timer Tmr_AmtDif;
    }
}