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
    public partial class ListagemUsuarios : Form
    {
        public ListagemUsuarios()
        {
            InitializeComponent();
        }

        private void ListagemUsuarios_Load(object sender, EventArgs e)
        {
            string endereco = "server=Paulo-Not\\SQLEXPRESS;database=SUCOS_VENDAS_GUTO;UID=sa;password=123456";
            SqlDataAdapter da = new SqlDataAdapter("SELECT CODIGO, LOGIN FROM USUARIOS", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "USUARIOS");
            dataGridUsuario.DataSource = ds.Tables["USUARIOS"].DefaultView;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String endereco = "server=Paulo-Not\\SQLEXPRESS;database=SUCOS_VENDAS_GUTO;UID=sa;password=123456";
            SqlDataAdapter da = new SqlDataAdapter("SELECT CODIGO, LOGIN FROM USUARIOS WHERE LOGIN LIKE '%" + txtPesquisar.Text + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "USUARIOS");
            dataGridUsuario.DataSource = ds.Tables["USUARIOS"].DefaultView;
        }
    }
}
