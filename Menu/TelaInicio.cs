using Login;
using Servidor_APS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class TelaInicio : Form
    {

        TelaLogin login = new TelaLogin();
        CarregarChat carregar = new CarregarChat();

        public TelaInicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void btnEcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            carregar.Show();
            this.Hide();
        }

        private void TelaInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
