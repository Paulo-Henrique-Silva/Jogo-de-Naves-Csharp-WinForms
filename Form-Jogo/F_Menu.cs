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

        private void Btn_Sair_Click(object sender, EventArgs e) => Close();
    }
}
