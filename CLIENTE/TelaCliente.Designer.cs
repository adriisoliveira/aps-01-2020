namespace CLIENTE
{
    partial class TelaCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIpCliente = new System.Windows.Forms.TextBox();
            this.rtbMensagem = new System.Windows.Forms.TextBox();
            this.rtbConversa = new System.Windows.Forms.TextBox();
            this.txtIpServidor = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seu IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite sua mensagem...";
            // 
            // txtIpCliente
            // 
            this.txtIpCliente.Location = new System.Drawing.Point(184, 10);
            this.txtIpCliente.Name = "txtIpCliente";
            this.txtIpCliente.Size = new System.Drawing.Size(320, 20);
            this.txtIpCliente.TabIndex = 3;
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Location = new System.Drawing.Point(17, 313);
            this.rtbMensagem.Multiline = true;
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbMensagem.Size = new System.Drawing.Size(508, 157);
            this.rtbMensagem.TabIndex = 5;
            this.rtbMensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMensagem_KeyDown);
            this.rtbMensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbMensagem_KeyUp);
            // 
            // rtbConversa
            // 
            this.rtbConversa.Location = new System.Drawing.Point(17, 105);
            this.rtbConversa.Multiline = true;
            this.rtbConversa.Name = "rtbConversa";
            this.rtbConversa.ReadOnly = true;
            this.rtbConversa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbConversa.Size = new System.Drawing.Size(508, 125);
            this.rtbConversa.TabIndex = 6;
            // 
            // txtIpServidor
            // 
            this.txtIpServidor.Location = new System.Drawing.Point(184, 36);
            this.txtIpServidor.Name = "txtIpServidor";
            this.txtIpServidor.ReadOnly = true;
            this.txtIpServidor.Size = new System.Drawing.Size(136, 20);
            this.txtIpServidor.TabIndex = 7;
            this.txtIpServidor.Text = "192.168.0.3";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(367, 36);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.ReadOnly = true;
            this.txtPorta.Size = new System.Drawing.Size(137, 20);
            this.txtPorta.TabIndex = 8;
            this.txtPorta.Text = "8000";
            this.txtPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP Servidor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Porta:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(367, 62);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(137, 23);
            this.btnDesconectar.TabIndex = 11;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Deseja enviar um arquivo?";
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Location = new System.Drawing.Point(205, 253);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(320, 23);
            this.btnEnviarArquivo.TabIndex = 14;
            this.btnEnviarArquivo.Text = "Enviar Arquivo";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 482);
            this.Controls.Add(this.btnEnviarArquivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIpServidor);
            this.Controls.Add(this.rtbConversa);
            this.Controls.Add(this.rtbMensagem);
            this.Controls.Add(this.txtIpCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CLIENTE";
            this.Text = "CLIENTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CLIENTE_FormClosing_1);
            this.Load += new System.EventHandler(this.CLIENTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIpCliente;
        private System.Windows.Forms.TextBox rtbMensagem;
        private System.Windows.Forms.TextBox rtbConversa;
        private System.Windows.Forms.TextBox txtIpServidor;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviarArquivo;
    }
}

