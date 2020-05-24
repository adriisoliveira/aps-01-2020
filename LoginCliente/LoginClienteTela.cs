using CLIENTE;
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
    public partial class LoginClienteTela : Form
    {
        public LoginClienteTela()
        {
            InitializeComponent();
        }

        string mensagem = "";

        private void LoginClienteTela_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConexaoLoginCliente conexao = new ConexaoLoginCliente();
            //Classe para poder escrever em sql 
            string adminId = txtLogin.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT Usuario, Senha FROM ClientesUsuarios WHERE Usuario=@adminId and Senha = @password";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.Parameters.AddWithValue("@password", password);

            //Conectar com o banco
            try
            {
                //o que o programa vai executar dentro do banco de dados
                //cmd.Connection vai receber o endereço do banco de dados
                cmd.Connection = conexao.Conectar();

                //Ler os dados no banco e comparar
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    adminId = reader["Usuario"].ToString();
                    password = reader["Senha"].ToString();
                    TelaCliente cliente = new TelaCliente();
                    cliente.Show();
                    this.Hide();
                    
                }



                else
                {
                    MessageBox.Show("Login ou senha incorretos!");
                }
                reader.Close();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }

            catch (SqlException ex)
            {
                //caso de algum erro ja na conexão o programa ja pula para o cath
                //para tentar resolver
                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados!!!!";
            }
        }
    }
}
