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

namespace LoginCliente
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginClienteTela cliente = new LoginClienteTela();
            cliente.Show();
            this.Hide();
        }


        public void limpaCampos()
        {
            txtCpf.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtTelefone.Text = "";
            txtUsuario.Text = "";
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            ConexaoLoginCliente conexao = new ConexaoLoginCliente();
            SqlCommand cmd = new SqlCommand();


            try
            {
                //Abrir a conexão com o banco de dados
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = "insert into Cadastro (cpf,usuario, nomeCompleto,telefone,senha) values ('" +txtCpf+"','"+ txtUsuario.Text + "','" + txtNome.Text + "','" + txtTelefone.Text + "','" + txtSenha.Text + "')";
                cmd.CommandText = "insert into ClientesUsuarios (Usuario, Senha) values ('" + txtUsuario.Text + "','" + txtSenha.Text + "')";
                cmd.ExecuteNonQuery();
                conexao.desconectar();

                MessageBox.Show("Cadastro concluido com sucesso!");


                limpaCampos();

                LoginClienteTela login = new LoginClienteTela();
                login.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                string mensagem = "";
                MessageBox.Show("ERRO AO CONECTAR-SE AO BANCO! TENTE NOVAMENTE...");
            }
        }
    }
}
