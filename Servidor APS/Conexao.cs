using System.Data.SqlClient;

namespace Servidor_APS
{
    class Conexao
    {
        //Criar a conexão com o banco de dados
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            //endereço do banco de dados
            con.ConnectionString = "Data Source=LAPTOP-19CP4RFH\\DRIH;Initial Catalog=APS_IPs;Integrated Security=True";
        }

        //Método para conectar com o banco de dados

        public SqlConnection Conectar()
        {
            //Verificar se há conexão

            //Se a conexão estiver fechada
            if (con.State == System.Data.ConnectionState.Closed)
            {
                //conecta
                con.Open();
            }
            //caso contrario não é necessário conectar

            //retorna a conexão
            return con;
        }

        //Método para desconectar

        public void desconectar()
        {
            //Verificar se ja não está desconectado

            //Se a conexão ja estar fechada
            if (con.State == System.Data.ConnectionState.Open)
            {
                //desconecta
                con.Close();
            }
            //caso contrario não é necessário desconectar
        }

    }
}
