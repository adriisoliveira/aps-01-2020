using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//declarar biblioteca de classes para manipular arquivos de forma mais rápida:
using System.IO;
using System.Runtime.Remoting;
namespace CLIENTE
{
    public partial class TransfArquivo : Form
    {
        public TransfArquivo()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            File.Copy("C:\\TESTE1\\ARQUIVO_TESTE.TXT", "C:\\TESTE1\\PASTA COPIA\\TESTANDO_copiar.TXT", true);
            MessageBox.Show("Arquivo copiado com sucesso!");
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            //nome do arquivo, @diretorio/novo nome
            File.Move("C:\\TESTE1\\ARQUIVO_TESTE.TXT", "C:\\TESTE1\\PASTA MOVER\\TESTANDO_mover.txt");
            MessageBox.Show("Arquivo movido com sucesso!");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //o arquivo se encontra na raiz, por isso apenas um local
            File.Delete("C:\\TESTE1\\ARQUIVO_TESTE.TXT");
            MessageBox.Show("Arquivo removido com sucesso!");
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            TelaCliente cliente = new TelaCliente();
            cliente.Show();
            this.Hide();
        }

        private void TransfArquivo_Load(object sender, EventArgs e)
        {
            cbxArquivo.Items.Add("ARQUIVO_TESTE");
            cbxArquivo.Items.Add("ARQUIVO_TESTE2");

            cbxDestino.Items.Add("C:\\TESTE1\\PASTA COPIAR");
            cbxDestino.Items.Add("C:\\TESTE1\\PASTA MOVER");
        }
    }
}
