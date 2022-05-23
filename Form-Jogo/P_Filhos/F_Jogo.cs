using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Form_Jogo.P_Filhos
{
    enum TiposTiros { TiroComum = 1, TiroGrande, TiroRapido }

    public partial class F_Jogo : Form
    {
        /// <summary>
        /// Propriedade que armazena o form pai do form atual.
        /// </summary>
        private F_Principal FrmPai { get; }

        private int fundoVel;
        private const int JOG_VEL = 12;
        private bool apertouDir, apertouEsq;

        public F_Jogo(F_Principal formPai)
        {
            InitializeComponent();
            FrmPai = formPai;
        }

        private void Btn_Comecar_Click(object sender, EventArgs e)
        {
            fundoVel = 2;

            MudaTiros(Pbx_Tiro1);
            Thread.Sleep(30); //sleep de 20 miliseegundos para diferenciar as posições inicias
            MudaTiros(Pbx_Tiro2);

            Btn_Comecar.Visible = false;
            Pbx_Inimigo.Visible = true;

            Tmr_Jogo.Start();
            Tmr_AmtDif.Start();
        }

        private void Btn_Sair_Click(object sender, EventArgs e) => FrmPai.MudaForm(new F_Menu(FrmPai));

        /// <summary>
        /// Checa se o usuário pressionou as teclas de movimento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_Jogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                apertouDir = true;
            if (e.KeyCode == Keys.A)
                apertouEsq = true;
        }

        private void F_Jogo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                apertouDir = false;
            if (e.KeyCode == Keys.A)
                apertouEsq = false;
        }

        /// <summary>
        /// Volta os tiros para uma das posições iniciais e muda o tipo deles.
        /// </summary>
        /// <param name="tiro"></param>
        private void MudaTiros(PictureBox tiro)
        {
            Random rand = new Random();

            //muda o tipo do tiro, assim como as características.
            switch (rand.Next(1, 4))
            {
                case 1:
                    tiro.Tag = TiposTiros.TiroComum;
                    tiro.Size = new Size(15, 68);
                    tiro.BackColor = Color.Yellow;
                    break;

                case 2:
                    tiro.Tag = TiposTiros.TiroGrande;
                    tiro.Size = new Size(30, 68);
                    tiro.BackColor = Color.DarkOliveGreen;
                    break;

                case 3:
                    tiro.Tag = TiposTiros.TiroRapido;
                    tiro.Size = new Size(15, 68);
                    tiro.BackColor = Color.Red;
                    break;
            }

            //Coloca-o em uma nova posição.
            switch (rand.Next(1, 8))
            {
                case 1:
                    tiro.Location = new Point(20, 43);
                    break;

                case 2:
                    tiro.Location = new Point(75, 43);
                    break;

                case 3:
                    tiro.Location = new Point(130, 43);
                    break;

                case 4:
                    tiro.Location = new Point(185, 43);
                    break;

                case 5:
                    tiro.Location = new Point(240, 43);
                    break;

                case 6:
                    tiro.Location = new Point(295, 43);
                    break;

                case 7:
                    tiro.Location = new Point(350, 43);
                    break;
            }

            if ((TiposTiros)tiro.Tag == TiposTiros.TiroGrande)
                tiro.Left -= 8;
        }

        /// <summary>
        /// Move os tiros conforme o seu respectivo tipo e a velocidade do fundo.
        /// </summary>
        /// <param name="tiro"></param>
        private void MoveTiro(PictureBox tiro)
        {
            if ((TiposTiros)tiro.Tag == TiposTiros.TiroComum) tiro.Top += fundoVel;
            else if ((TiposTiros)tiro.Tag == TiposTiros.TiroGrande) tiro.Top += fundoVel / 2;
            else tiro.Top += (int)Math.Ceiling(1.5 * fundoVel);
        }

        /// <summary>
        /// Movimenta os componentes do jogo a cada 1 milissegundo e conforme as ações do usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Jogo_Tick(object sender, EventArgs e)
        {
            //Movimenta o background
            Pbx_Fundo1.Top += fundoVel;
            Pbx_Fundo2.Top += fundoVel;

            MoveTiro(Pbx_Tiro1);
            MoveTiro(Pbx_Tiro2);

            //movimenta a nave principal
            if (apertouDir && Pbx_Nave.Right < Width) Pbx_Nave.Left += JOG_VEL;
            if (apertouEsq && Pbx_Nave.Left > 0) Pbx_Nave.Left -= JOG_VEL;

            if (Pbx_Tiro1.Top > Height) MudaTiros(Pbx_Tiro1);
            if (Pbx_Tiro2.Top > Height) MudaTiros(Pbx_Tiro2);

            //troca as fotos de fundo
            if (Pbx_Fundo1.Top > Height) Pbx_Fundo1.Top = -Height;
            if (Pbx_Fundo2.Top > Height) Pbx_Fundo2.Top = -Height;
        }

        /// <summary>
        /// Método responsável por aumentar a dificuldade do jogo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_AmtDif_Tick(object sender, EventArgs e)
        {
            fundoVel++;
        }
    }
}
