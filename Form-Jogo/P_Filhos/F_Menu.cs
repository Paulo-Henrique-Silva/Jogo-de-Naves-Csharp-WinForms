using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Jogo.P_Filhos
{
    public partial class F_Menu : Form
    {
        /// <summary>
        /// Formulário pai atual do projeto.
        /// </summary>
        private F_Principal FrmPai { get; }

        public F_Menu(F_Principal formPai)
        {
            InitializeComponent();
            FrmPai = formPai;
        }

        private void Btn_Jogar_Click(object sender, EventArgs e) => FrmPai.MudaForm(new F_Jogo(FrmPai));

        private void Btn_Instruções_Click(object sender, EventArgs e) => FrmPai.MudaForm(new F_Instruções(FrmPai));

        private void Btn_Sair_Click(object sender, EventArgs e) => FrmPai.Close();

    }
}
