using System;
using System.Data.SqlClient;

namespace Servidor_APS
{
    class SalvarChat
    {
        Conexao conexao = new Conexao();
        //Classe para poder escrever em sql 
        SqlCommand cmd = new SqlCommand();
        //Mensagem de erro ou sucesso
        public String mensagem = "";

        //Método construtor
        public SalvarChat(String EnderecoIpCliente, String ChatServidorCliente)
        {

            //passa como parametro as informações que estamos recebendo
            //Comandos SQL para inserir os dados no banco
            //Para escrever os comandos precisa da classe SqlCommand
            cmd.CommandText = "insert into Ocorrencias (ClienteIp,Chat) values (@ClienteIp,@ChatMensagens)";
            //Parametros
            cmd.Parameters.AddWithValue("@ClienteIp", EnderecoIpCliente);
            cmd.Parameters.AddWithValue("@ChatMensagens", ChatServidorCliente);

            //Conectar com o banco
            try
            {
                //o que o programa vai executar dentro do banco de dados
                //cmd.Connection vai receber o endereço do banco de dados
                cmd.Connection = conexao.Conectar();

                //Executar o comando, NonQuery apenas envia os dados
                cmd.ExecuteNonQuery();

                //Desconectar com o banco
                conexao.desconectar();

                //Mensagem de erro ou sucesso
                //para isso que serve a string mensagem
                this.mensagem = "Chat salvo com sucesso!!";

            }
            catch (SqlException e)
            {
                //caso de algum erro ja na conexão o programa ja pula para o cath
                //para tentar resolver
                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados!!!!";
            }
        }
    }
}
