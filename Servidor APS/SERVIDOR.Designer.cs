namespace Servidor_APS
{
    partial class SERVIDOR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SERVIDOR));
            this.label1 = new System.Windows.Forms.Label();
            this.rtbConversa = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMensagem = new System.Windows.Forms.TextBox();
            this.txtIpClienteMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtIpClientePrint = new System.Windows.Forms.TextBox();
            this.txtIpServidor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHAT";
            // 
            // rtbConversa
            // 
            this.rtbConversa.Location = new System.Drawing.Point(16, 86);
            this.rtbConversa.Multiline = true;
            this.rtbConversa.Name = "rtbConversa";
            this.rtbConversa.ReadOnly = true;
            this.rtbConversa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbConversa.Size = new System.Drawing.Size(504, 129);
            this.rtbConversa.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite o IP do cliente para salvar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite sua mensagem";
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Location = new System.Drawing.Point(15, 301);
            this.rtbMensagem.Multiline = true;
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbMensagem.Size = new System.Drawing.Size(504, 161);
            this.rtbMensagem.TabIndex = 6;
            this.rtbMensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMensagem_KeyDown);
            this.rtbMensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbMensagem_KeyUp);
            // 
            // txtIpClienteMarca
            // 
            this.txtIpClienteMarca.Location = new System.Drawing.Point(185, 225);
            this.txtIpClienteMarca.Name = "txtIpClienteMarca";
            this.txtIpClienteMarca.Size = new System.Drawing.Size(260, 20);
            this.txtIpClienteMarca.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Porta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IP Cliente:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(424, 8);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.ReadOnly = true;
            this.txtPorta.Size = new System.Drawing.Size(83, 20);
            this.txtPorta.TabIndex = 14;
            this.txtPorta.Text = "8000";
            this.txtPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIpClientePrint
            // 
            this.txtIpClientePrint.Location = new System.Drawing.Point(142, 39);
            this.txtIpClientePrint.Name = "txtIpClientePrint";
            this.txtIpClientePrint.Size = new System.Drawing.Size(229, 20);
            this.txtIpClientePrint.TabIndex = 13;
            // 
            // txtIpServidor
            // 
            this.txtIpServidor.Location = new System.Drawing.Point(142, 8);
            this.txtIpServidor.Name = "txtIpServidor";
            this.txtIpServidor.ReadOnly = true;
            this.txtIpServidor.Size = new System.Drawing.Size(229, 20);
            this.txtIpServidor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seu IP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Deseja salvar o chat com o cliente?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Gravar Chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(386, 36);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(121, 23);
            this.btnDesconectar.TabIndex = 20;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // SERVIDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(538, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIpClientePrint);
            this.Controls.Add(this.txtIpServidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIpClienteMarca);
            this.Controls.Add(this.rtbMensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbConversa);
            this.Controls.Add(this.label1);
            this.Name = "SERVIDOR";
            this.Text = "SERVIDOR";
            this.Load += new System.EventHandler(this.SERVIDOR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rtbConversa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rtbMensagem;
        private System.Windows.Forms.TextBox txtIpClienteMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtIpClientePrint;
        private System.Windows.Forms.TextBox txtIpServidor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

