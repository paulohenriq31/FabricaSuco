using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmCadastoUsuario : Form
    {
        public frmCadastoUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String endereco = "server=Paulo-Not\\SQLEXPRESS;database=SUCOS_VENDAS_GUTO;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO USUARIOS(LOGIN, SENHA, CODIGO) VALUES(@login, @senha, @codigo)";
            comando.Parameters.AddWithValue("@login", txtNomeUsuario.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);
            comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
            conexao.Open();
            int linhaAfetadas = comando.ExecuteNonQuery();
            if (linhaAfetadas > 0)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu algum problema no cadastro.");
            }
            conexao.Close();
        }
    }
}
