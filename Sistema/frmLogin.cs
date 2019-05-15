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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string endereco = "server=Paulo-Not\\SQLEXPRESS;database=SUCOS_VENDAS_GUTO;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM USUARIOS WHERE LOGIN = @login AND SENHA = @senha";
            comando.Parameters.AddWithValue("@login", txtUsuario.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);
            conexao.Open();
            //amazenamento o que foi execultado no banco de dados
            SqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
            //se for verdadeiro a coneão sera permitida
            if (consulta.Read() == true)
            {
                MessageBox.Show("Pode entrar");
                conexao.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha Invalido");
                conexao.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
