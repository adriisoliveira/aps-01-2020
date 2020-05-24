using Servidor_APS;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CLIENTE
{
    public partial class TelaCliente : Form
    {


        //Variáveis
        TcpClient tcpClient;
        NetworkStream networkStream;
        Thread thInteraction;

        SERVIDOR servidor = new SERVIDOR();
        public TelaCliente()
        {
            InitializeComponent();
        }

        //Conexão
        private void connect()
        {
            tcpClient = new TcpClient();
            //ele serve para enviar as mensagens para nós mesmo
            setMsg("- - - - ESTABELECENDO CONEXÃO - - - - " + System.Environment.NewLine);
            //ip do proprio pc
            tcpClient.Connect(txtIpCliente.Text, 8000);
        }

        //Desconectar
        private void disconnect()
        {
            //verificar se tem algum thread
            if (thInteraction != null)
            {
                if (thInteraction.ThreadState == ThreadState.Running)
                {
                    thInteraction.Abort();
                }
            }
            tcpClient.Close();
        }

        //Enviar a mensagem
        private void enviarMsg(string mensagem)
        {
            //verificar se o networkStream pode enviar a mensage
            if (networkStream.CanWrite)
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }


        }

        delegate void delSetMsg(string mensagem);
        private void setMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {
                //iniciar a invocação
                this.BeginInvoke(new delSetMsg(setMsg), mensagem);
            }
            else
            {
                rtbConversa.Text += System.Environment.NewLine + "Eu: " + mensagem;
            }

        }

        delegate void delGetMsg(string mensagem);
        private void getMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {
                //iniciar a invocação
                this.BeginInvoke(new delGetMsg(getMsg), mensagem);
            }
            else
            {
                rtbConversa.Text += System.Environment.NewLine + "Server: " + mensagem + System.Environment.NewLine;
            }

        }


        //Interação
        private void interaction()
        {
            try
            {
                do
                {
                    //verificando se tem algo para ler
                    networkStream = tcpClient.GetStream();
                    if (networkStream.CanRead)
                    {

                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(tcpClient.ReceiveBufferSize));

                        string returnData = Encoding.ASCII.GetString(bytes);
                        getMsg(returnData);

                    }
                    else
                    {
                        setMsg("- - - -NÃO É POSSÍVEL LER DADOS PARA ESTE STREAM - - - - -" + System.Environment.NewLine);
                        disconnect();
                    }

                } while (tcpClient.Connected);
            }
            catch { }
        }


        private void CLIENTE_Load(object sender, EventArgs e)
        {
            connect();

            //inicializar o cliente
            thInteraction = new Thread(new ThreadStart(interaction));
            thInteraction.IsBackground = true;
            thInteraction.Priority = ThreadPriority.Highest;
            thInteraction.Name = "thInteraction";
            thInteraction.Start();
        }


        private void rtbMensagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbMensagem.Clear();
            }
            else { }
        }

        private void rtbMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (networkStream.CanWrite)
                {
                    string mensagem = rtbMensagem.Text;
                    enviarMsg(mensagem);
                    setMsg(mensagem);
                }
                else
                {
                    setMsg("- - - - NÃO É POSSÍVEL ENVIDAR DADOS DESTE STREAM - - - - " + System.Environment.NewLine);
                    disconnect();
                }
            }
        }

        private void CLIENTE_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            disconnect();
        }


        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviarArquivo_Click(object sender, EventArgs e)
        {
            TransfArquivo arquivo = new TransfArquivo();
            arquivo.Show();
            this.Hide();
        }
    }
}