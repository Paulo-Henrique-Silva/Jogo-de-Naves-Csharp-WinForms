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
using System.Media;

namespace Form_Jogo.P_Filhos
{
    /// <summary>
    /// Separa os tipos existentes de tiros que existem no jogo.
    /// </summary>
    enum TiposTiros { TiroComum = 1, TiroGrande, TiroRapido }

    public partial class F_Jogo : Form
    {
        /// <summary>
        /// Propriedade que armazena o form pai do form atual.
        /// </summary>
        private F_Principal FrmPai { get; }

        private int fundoVelocidade;

        private const int JOG_VELOCIDADE = 12;

        private bool apertouDireita, apertouEsquerda;

        public F_Jogo(F_Principal formPai)
        {
            InitializeComponent();
            FrmPai = formPai;
        }

        private void ComecarJogo(object sender, EventArgs e)
        {
            fundoVelocidade = 2;

            MudaTiros(Pbx_Tiro1);
            Thread.Sleep(50); //sleep para diferenciar as posições inicias
            MudaTiros(Pbx_Tiro2);

            Lbl_FimJogo.Visible = false;
            Btn_ComecarJogo.Visible = false;
            Pbx_Inimigo.Visible = true;

            Pbx_Tiro1.Visible = true;
            Pbx_Tiro2.Visible = true;
            Pbx_Nave.Visible = true;

            Tmr_Jogo.Start();
            Tmr_AmtDif.Start();
        }

        private void FimJogo()
        {
            Lbl_FimJogo.Visible = true;
            Btn_ComecarJogo.Visible = true;
            Pbx_Inimigo.Visible = false;

            Pbx_Tiro1.Visible = false;
            Pbx_Tiro2.Visible = false;
            Pbx_Nave.Visible = false;

            Tmr_Jogo.Stop();
            Tmr_AmtDif.Stop();

            new SoundPlayer(Properties.Resources.somFimJogo).Play();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Tmr_Jogo.Stop();
            Tmr_AmtDif.Stop();
            FrmPai.MudaForm(new F_Menu(FrmPai));
        }

        /// <summary>
        /// Checa se o usuário pressionou as teclas de movimento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_Jogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                apertouDireita = true;
            if (e.KeyCode == Keys.A)
                apertouEsquerda = true;
        }

        private void F_Jogo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                apertouDireita = false;
            if (e.KeyCode == Keys.A)
                apertouEsquerda = false;
        }

        /// <summary>
        /// Volta os tiros para uma das posições iniciais e muda o tipo deles.
        /// </summary>
        /// <param name="tiro"></param>
        private void MudaTiros(PictureBox tiro)
        {
            //Cria dois random para garantir maior aleatoridade.
            Random random = new Random();

            //muda o tipo do tiro, assim como as características.
            switch (random.Next(1, 4))
            {
                case 1:
                    tiro.Tag = TiposTiros.TiroComum;
                    tiro.Size = new Size(15, 68);
                    tiro.BackColor = Color.Yellow;
                    break;

                case 2:
                    tiro.Tag = TiposTiros.TiroGrande;
                    tiro.Size = new Size(30, 68); //o tamanho maior é proposital
                    tiro.BackColor = Color.DarkGreen;
                    break;

                case 3:
                    tiro.Tag = TiposTiros.TiroRapido;
                    tiro.Size = new Size(15, 68);
                    tiro.BackColor = Color.Red;
                    break;
            }

            //Coloca-o em uma nova posição, conforme em um dos canhões.
            switch (random.Next(1, 8))
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

            //como o tiro grande é maior que os outros tiros, ele ajusta a posiçao para ficar conforme o canhão da nave inimiga.
            if ((TiposTiros)tiro.Tag == TiposTiros.TiroGrande)
                tiro.Left -= 8;

            new SoundPlayer(Properties.Resources.tiroSom).Play();
        }

        /// <summary>
        /// Move os tiros conforme o seu respectivo tipo e a velocidade do fundo.
        /// </summary>
        /// <param name="tiro"></param>
        private void MoveTiro(PictureBox tiro)
        {
            if ((TiposTiros)tiro.Tag == TiposTiros.TiroComum)
            {
                tiro.Top += fundoVelocidade;
            }
            else if ((TiposTiros)tiro.Tag == TiposTiros.TiroGrande)
            {
                tiro.Top += fundoVelocidade / 2;
            }
            else
            {
                tiro.Top += fundoVelocidade + fundoVelocidade / 2;
            }
        }

        /// <summary>
        /// Movimenta os componentes do jogo conforme as ações do usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Jogo_Tick(object sender, EventArgs e)
        {
            //Movimenta o background
            Pbx_Fundo1.Top += fundoVelocidade;
            Pbx_Fundo2.Top += fundoVelocidade;

            MoveTiro(Pbx_Tiro1);
            MoveTiro(Pbx_Tiro2);

            //movimenta a nave principal
            if (apertouDireita && Pbx_Nave.Right < Width) Pbx_Nave.Left += JOG_VELOCIDADE;
            if (apertouEsquerda && Pbx_Nave.Left > 0) Pbx_Nave.Left -= JOG_VELOCIDADE;

            if (Pbx_Tiro1.Top > Height) MudaTiros(Pbx_Tiro1);
            if (Pbx_Tiro2.Top > Height) MudaTiros(Pbx_Tiro2);

            ///detecta se a nava principal encosta em um dos tiros.
            if (Pbx_Nave.Bounds.IntersectsWith(Pbx_Tiro1.Bounds) || Pbx_Nave.Bounds.IntersectsWith(Pbx_Tiro2.Bounds))
                FimJogo();

            //troca as fotos de fundo
            if (Pbx_Fundo1.Top > Height) Pbx_Fundo1.Top = -Height;
            if (Pbx_Fundo2.Top > Height) Pbx_Fundo2.Top = -Height;
        }

        /// <summary>
        /// Método responsável por aumentar a velocidade do fundo do jogo e cosequentemente a velocidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_AmtDif_Tick(object sender, EventArgs e)
        {
            fundoVelocidade++;
        }
    }
}
