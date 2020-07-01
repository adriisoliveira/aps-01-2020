using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class ConexaoVerificacao
    {
        //Criar a conexão com o banco de dados
        SqlConnection con = new SqlConnection();

        //Construtor
        public ConexaoVerificacao()
        {
            //endereço do banco de dados
            con.ConnectionString = "Data Source=LAPTOP-19CP4RFH\\DRIH;Initial Catalog=LoginServidor;Integrated Security=True";
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
