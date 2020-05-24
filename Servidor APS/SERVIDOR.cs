using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Servidor_APS
{
    public partial class SERVIDOR : Form
    {

        //Marca d'água
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);


        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }


        //porta da conexão
        int numeroPorta = 8000;
        //escutar o cliente e ficar esperando por novas conexões
        TcpListener tcpListener;
        //cliente
        TcpClient tcpClient;
        //responsavel pela conexão
        NetworkStream networkStream;
        Thread thInteraction;
        public SERVIDOR()
        {
            InitializeComponent();
            List<TextBox> tlist = new List<TextBox>();
            List<string> sList = new List<string>();
            tlist.Add(txtIpClienteMarca);
            sList.Add("Digite o IP do cliente aqui...");
            SetCueBanner(ref tlist, sList);

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIpServidor.Text = address.ToString();
                }
            }

        }

        //Métodos da aplicação 

        //Conexão
        private bool Connect()
        {
            bool retorno = false;
            try
            {
                //instanciar o tcpListener para ele começar a aceitar novas conexões
                tcpListener = new TcpListener(System.Net.IPAddress.Any, numeroPorta);
                //dar o start no tcp listener
                tcpListener.Start();
                retorno = true;
            }
            catch { }
            return retorno;

        }


        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Desconectar
        private void disconnect()
        {
            //verificando se tem algo no thread
            if (thInteraction != null)
            {
                //verificar o estado dele
                if (thInteraction.ThreadState == ThreadState.Running)
                {
                    //se tiver rodando aborta
                    thInteraction.Abort();
                }
                //se tiver um tcpClient
                else { }
                if (tcpClient != null)
                {
                    //então vamos desconectar
                    tcpClient.Client.Disconnect(true);
                }
                tcpListener.Stop();

                //metodo ainda não criado para enviar uma mensagem de ADM
                setMsg("## CONEXÕES PERDIDAS...##", true);
            }
        }

        //Aceita a Conexão
        private void acceptConection()
        {
            try
            {
                tcpClient = tcpListener.AcceptTcpClient();
            }
            catch { }
        }

        //Envia a mensagem para o cliente
        private void enviarMSG(string mensagem)
        {
            //criar um metodo para ver se ele pode escrever
            if (podeEscrever())
            {
                //vamos pegar os bytes da mensagem para enviar através do Network Stream
                //convertendo a ensagem para byte
                byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                //enviar
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
        }

        //Verifica se pode escrever
        private bool podeEscrever()
        {
            //verificar se tem alguma conexão
            if (networkStream == null)
            {
                return false;
            }
            //verificar se o netWorkStream pode escrever e se tem algum cliente ali
            if (networkStream.CanWrite && tcpClient != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Método Mensagem de ADM
        //Delegate para escreve sem dar erro
        delegate void delSetMsg(string mensagem, bool burlar);
        //Quando eu chamar este método, ele vai verificar se esta requerendo uma invocação

        private void setMsg(string mensagem, bool burlar)
        {
            //se for chamada a invocação
            if (this.InvokeRequired)
            {
                //Ele vai começar a incovação chamando este método de novo enviando os dois parametros, verificando se ha um burlar ou não
                this.BeginInvoke(new delSetMsg(setMsg), mensagem, burlar);
            }
            else
            //porem por conta deste else, mesmo que não haja cliente ele vai escrever
            {
                if (burlar == true || podeEscrever() == true)
                {
                    rtbConversa.Text += System.Environment.NewLine + "Eu: " + mensagem;
                }
            }
        }



        delegate void delGetMsg(string menssagem);
        private void getMsg(string menssagem)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delGetMsg(getMsg), menssagem);
            }
            else
            {
                if (podeEscrever() == true)
                {
                    rtbConversa.Text += System.Environment.NewLine + "Cliente: " + menssagem + System.Environment.NewLine;
                }
            }
        }

        //Iniciar - Conectar e chamar o thread
        private void start()
        {
            if (Connect())
            {
                setMsg(" - -  - AGUARDANDO UMA CONEXÃ0 - - - - -" + System.Environment.NewLine, true);
            }
            thInteraction = new Thread(new ThreadStart(interaction));
            thInteraction.IsBackground = true;
            thInteraction.Priority = ThreadPriority.Highest;
            thInteraction.Name = "thInteraction";
            thInteraction.Start();
        }

        //Interação
        private void interaction()
        {
            try
            {
                //aceitar a conexão
                acceptConection();
                //enviar uma menagem que a conexão foi aceita
                setMsg("- - - - CONEXÃO ACEITA - - - -" + System.Environment.NewLine, true);

                do
                {
                    //verificar se tem algo no cliente
                    networkStream = tcpClient.GetStream();

                    //quando ele pegar alguma mensagem
                    if (networkStream.CanRead)
                    {
                        //então ele faz a leitura e a conversão
                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(tcpClient.ReceiveBufferSize));

                        //converter para string e exibir
                        string clientData = Encoding.ASCII.GetString(bytes);
                        //pegou a mensagem que o cliente enviou , troca o \0 por nada, tira todos os espaços (trim)
                        if (clientData.Replace("\0", "").Trim() != "")
                        {
                            getMsg(clientData);
                        }
                        else
                        {
                            tcpClient = null;
                        }
                    }

                } while (tcpClient != null);
                disconnect();
                start();
            }
            catch { }
        }


        private void SERVIDOR_Load(object sender, EventArgs e)
        {
            start();

        }


        private void rtbMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            //verificação
            if (e.KeyCode == Keys.Enter)
            {
                string mensagem = rtbMensagem.Text;
                enviarMSG(mensagem);
                setMsg(mensagem, false);
            }
        }

        private void rtbMensagem_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                    rtbMensagem.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciar o salvar chat
            SalvarChat gravar = new SalvarChat(txtIpClienteMarca.Text, rtbConversa.Text);
            //ele pega esses valores, envia para o construtor de SalvarIP que 
            //faz a conexão e adiciona os valores no banco
            //Mensagem para ser exibida caso seja bem sucedido ou tenha erro
            MessageBox.Show(gravar.mensagem);
        }


    }

}

