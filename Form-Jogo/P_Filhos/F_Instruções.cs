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
    public partial class F_Instruções : Form
    {
        /// <summary>
        /// Formulário pai atual do projeto.
        /// </summary>
        private F_Principal FormPai { get; }

        public F_Instruções(F_Principal formPai)
        {
            InitializeComponent();
            FormPai = formPai;
        }

        private void Btn_Entendi_Click(object sender, EventArgs e) => FormPai.MudaForm(new F_Menu(FormPai));
    }
}
