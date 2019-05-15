using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmCadastoUsuario fCadastrarUsuario = new frmCadastoUsuario();
            fCadastrarUsuario.ShowDialog();
        }
    }
}
