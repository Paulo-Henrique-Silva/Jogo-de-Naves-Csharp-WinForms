namespace Form_Jogo.P_Filhos
{
    partial class F_Instruções
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Instruções));
            this.Btn_Entendi = new System.Windows.Forms.Button();
            this.Lbl_Instruções2 = new System.Windows.Forms.Label();
            this.Lbl_Instruções1 = new System.Windows.Forms.Label();
            this.Lbl_TituloInstruções = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Entendi
            // 
            this.Btn_Entendi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.Btn_Entendi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Entendi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entendi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Btn_Entendi.Location = new System.Drawing.Point(93, 395);
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
            this.Lbl_Instruções2.Location = new System.Drawing.Point(193, 274);
            this.Lbl_Instruções2.Name = "Lbl_Instruções2";
            this.Lbl_Instruções2.Size = new System.Drawing.Size(191, 90);
            this.Lbl_Instruções2.TabIndex = 4;
            this.Lbl_Instruções2.Text = "Utlize as teclas \"A\" e \"D\" do teclado para mover a nave horizontalmente. ";
            this.Lbl_Instruções2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Instruções1
            // 
            this.Lbl_Instruções1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Instruções1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instruções1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Lbl_Instruções1.Location = new System.Drawing.Point(0, 145);
            this.Lbl_Instruções1.Name = "Lbl_Instruções1";
            this.Lbl_Instruções1.Size = new System.Drawing.Size(384, 119);
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
            this.Lbl_TituloInstruções.Size = new System.Drawing.Size(384, 145);
            this.Lbl_TituloInstruções.TabIndex = 2;
            this.Lbl_TituloInstruções.Text = "Instruções do Jogo";
            this.Lbl_TituloInstruções.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // F_Instruções
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Instruções1);
            this.Controls.Add(this.Lbl_Instruções2);
            this.Controls.Add(this.Btn_Entendi);
            this.Controls.Add(this.Lbl_TituloInstruções);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Instruções";
            this.Text = "F_Instruções";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Entendi;
        private System.Windows.Forms.Label Lbl_Instruções2;
        private System.Windows.Forms.Label Lbl_Instruções1;
        private System.Windows.Forms.Label Lbl_TituloInstruções;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}