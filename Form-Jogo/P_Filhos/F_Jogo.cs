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

        private int fundoVel = 1;

        private bool apertouDir, apertouEsq;

        public F_Jogo(F_Principal formPai)
        {
            InitializeComponent();
            FrmPai = formPai;

            //Bgw_TrocaFundo.RunWorkerAsync();
            //Tmr_AmtVel.Start();
        }

        private void Bgw_TrocaFundo_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Pbx_Fundo1.Top += fundoVel;
                Pbx_Fundo2.Top += fundoVel;

                if (apertouDir) Pbx_Nave.Left += 3;
                if (apertouEsq) Pbx_Nave.Left -= 3;

                if (Pbx_Fundo1.Top > Height) Pbx_Fundo1.Top = -Height;
                if (Pbx_Fundo2.Top > Height) Pbx_Fundo2.Top = -Height;
                Thread.Sleep(1);
            }
        }

        private void Tmr_AmtVel_Tick(object sender, EventArgs e)
        {
            fundoVel += 1;
        }

        private void F_Jogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                apertouDir = true;
            if (e.KeyCode == Keys.Left)
                apertouEsq = true;
        }

        private void F_Jogo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                apertouDir = false;
            if (e.KeyCode == Keys.Left)
                apertouEsq = false;
        }
    }
}
