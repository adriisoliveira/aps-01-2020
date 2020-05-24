namespace Menu
{
    partial class CarregarChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarregarChat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxChat = new System.Windows.Forms.RichTextBox();
            this.dtvIp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarregarChat = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvIp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECUPERAR CHAT COM CLIENTE";
            // 
            // rtxChat
            // 
            this.rtxChat.Location = new System.Drawing.Point(308, 176);
            this.rtxChat.Name = "rtxChat";
            this.rtxChat.Size = new System.Drawing.Size(464, 150);
            this.rtxChat.TabIndex = 2;
            this.rtxChat.Text = "";
            // 
            // dtvIp
            // 
            this.dtvIp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvIp.Location = new System.Drawing.Point(36, 176);
            this.dtvIp.Name = "dtvIp";
            this.dtvIp.Size = new System.Drawing.Size(243, 150);
            this.dtvIp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o IP para abrir o chat...";
            // 
            // btnCarregarChat
            // 
            this.btnCarregarChat.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarChat.Location = new System.Drawing.Point(308, 140);
            this.btnCarregarChat.Name = "btnCarregarChat";
            this.btnCarregarChat.Size = new System.Drawing.Size(208, 29);
            this.btnCarregarChat.TabIndex = 5;
            this.btnCarregarChat.Text = "Carregar chat";
            this.btnCarregarChat.UseVisualStyleBackColor = true;
            this.btnCarregarChat.Click += new System.EventHandler(this.btnCarregarChat_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(601, 352);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(159, 33);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar para o Inicio";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CarregarChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 411);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCarregarChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtvIp);
            this.Controls.Add(this.rtxChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CarregarChat";
            this.Text = "Recuperar Chats";
            this.Load += new System.EventHandler(this.CarregarChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvIp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxChat;
        private System.Windows.Forms.DataGridView dtvIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarregarChat;
        private System.Windows.Forms.Button btnVoltar;
    }
}