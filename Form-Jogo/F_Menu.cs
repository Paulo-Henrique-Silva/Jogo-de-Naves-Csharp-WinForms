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
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Jogar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Instruções_Click(object sender, EventArgs e)
        {
            Pnl_Instruções.Visible = true;
            Pnl_Instruções.BringToFront();
        }

        private void Btn_Sair_Click(object sender, EventArgs e) => Close();

        private void Btn_Entendi_Click(object sender, EventArgs e)
        {
            Pnl_Instruções.Visible = false;
            Pnl_Instruções.SendToBack();
        }
    }
}
