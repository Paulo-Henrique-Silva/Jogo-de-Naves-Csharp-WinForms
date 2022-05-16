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
    public partial class F_Jogo : Form
    {
        /// <summary>
        /// Propriedade que armazena o form pai do form atual.
        /// </summary>
        private F_Principal FrmPai { get; }

        private int fundoVel;
        private const int JOG_VEL = 5;
        private bool apertouDir, apertouEsq;

        public F_Jogo(F_Principal formPai)
        {
            InitializeComponent();
            FrmPai = formPai;
        }

        private void Btn_Comecar_Click(object sender, EventArgs e)
        {
            fundoVel = 1;

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
        /// Movimenta os componentes do jogo a cada 1 milissegundo e conforme as ações do usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Jogo_Tick(object sender, EventArgs e)
        {
            //Movimenta o background
            Pbx_Fundo1.Top += fundoVel;
            Pbx_Fundo2.Top += fundoVel;

            //movimenta a nave principal
            if (apertouDir && Pbx_Nave.Right < Width) Pbx_Nave.Left += JOG_VEL;
            if (apertouEsq && Pbx_Nave.Left > 0) Pbx_Nave.Left -= JOG_VEL;

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
