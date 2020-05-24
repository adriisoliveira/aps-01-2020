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
    public partial class CarregarChat : Form
    {
        ConexaoCarregarChat conexao = new ConexaoCarregarChat();
        
        public CarregarChat()
        {
            InitializeComponent();
            
        }


        private void CarregarChat_Load(object sender, EventArgs e)
        {
            
            try
            {
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("select * from Ocorrencias");
                //O campo SelectedValue se refere ao que eu selecionar na ComboBox
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dtvIp.DataSource = dt;

                //dtaInfo.Rows.RemoveAt(dtaInfo.RowCount);

                dtvIp.AllowUserToAddRows = false;

                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS!\n" + exe.Message);
            }
            
        }

        private void btnCarregarChat_Click(object sender, EventArgs e)
        {
            string info = "";
            info = dtvIp.SelectedRows[0].Cells[1].Value.ToString();
            rtxChat.Text = info;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio inicio = new TelaInicio();
            inicio.Show();
            this.Hide();
        }
    }
}
