using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Jogo
{
    public partial class F_Principal : Form
    {
        /// <summary>
        /// Propriedade que armazena o form filho que está na tela.
        /// </summary>
        private Form FrmFilho { get; set; }

        public F_Principal()
        {
            InitializeComponent();
            MudaForm(new P_Filhos.F_Menu(this));
        }

        /// <summary>
        /// Método responsável por retirar o form filho atual da tela e colocar outro form no lugar.
        /// </summary>
        /// <param name="form">Form filho que substituirá o atual.</param>
        public void MudaForm(Form form)
        {
            Pnl_Principal.Controls.Remove(FrmFilho);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            Pnl_Principal.Controls.Add(form);
            form.Show();

            FrmFilho = form;
            Pnl_Principal.Focus();
        }
    }
}
