using Servidor_APS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Login
{
    public partial class TelaLogin : Form
    {
        //Criar a nossa thread para chamar o form do servidor
        Thread nt;
        public TelaLogin()
        {
            InitializeComponent();
        }

        string mensagem = "";
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
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
                        SERVIDOR servidor = new SERVIDOR();
                        //TelaInicio inicio = new TelaInicio();
                        this.Hide();
                        servidor.Show();
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


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
