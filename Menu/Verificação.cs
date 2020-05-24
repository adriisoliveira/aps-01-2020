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

namespace Menu
{
    public partial class Verificação : Form
    {
        public Verificação()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConexaoVerificacao conexao = new ConexaoVerificacao();
            //Classe para poder escrever em sql 
            string adminId = txtLogin.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT Usuario, Senha FROM Usuarios WHERE Usuario=@adminId and Senha = @password";
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
                    CarregarChat chats = new CarregarChat();
                    chats.Show();
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
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados!!!!");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaInicio inicio = new TelaInicio();
            inicio.Show();
            this.Hide();
        }
    }
}
