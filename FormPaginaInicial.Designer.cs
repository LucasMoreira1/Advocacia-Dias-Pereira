namespace Advocacia_Dias_Pereira
{
    partial class FormPaginaInicial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPesquisarCPF = new System.Windows.Forms.Button();
            this.txtConsultaCPF = new System.Windows.Forms.MaskedTextBox();
            this.panelFormTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panelFormCentral = new System.Windows.Forms.Panel();
            this.btnPaginaInicial = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelEsquerdo.SuspendLayout();
            this.panelFormCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(140, 33);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // btnPesquisarCPF
            // 
            this.btnPesquisarCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCPF.Location = new System.Drawing.Point(1168, 5);
            this.btnPesquisarCPF.Name = "btnPesquisarCPF";
            this.btnPesquisarCPF.Size = new System.Drawing.Size(83, 33);
            this.btnPesquisarCPF.TabIndex = 2;
            this.btnPesquisarCPF.Text = "Pesquisar";
            this.btnPesquisarCPF.UseVisualStyleBackColor = true;
            // 
            // txtConsultaCPF
            // 
            this.txtConsultaCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaCPF.Location = new System.Drawing.Point(1039, 10);
            this.txtConsultaCPF.Mask = "000,000,000-00";
            this.txtConsultaCPF.Name = "txtConsultaCPF";
            this.txtConsultaCPF.Size = new System.Drawing.Size(123, 22);
            this.txtConsultaCPF.TabIndex = 5;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.BackColor = System.Drawing.Color.Khaki;
            this.panelFormTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(1064, 30);
            this.panelFormTitulo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(945, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta CPF";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Silver;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 220);
            this.panelLogo.TabIndex = 0;
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.AutoScroll = true;
            this.panelEsquerdo.BackColor = System.Drawing.Color.White;
            this.panelEsquerdo.Controls.Add(this.btnAjuda);
            this.panelEsquerdo.Controls.Add(this.btnDocumentos);
            this.panelEsquerdo.Controls.Add(this.btnPesquisarCliente);
            this.panelEsquerdo.Controls.Add(this.btnCadastroCliente);
            this.panelEsquerdo.Controls.Add(this.btnPaginaInicial);
            this.panelEsquerdo.Controls.Add(this.panelLogo);
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(200, 681);
            this.panelEsquerdo.TabIndex = 3;
            // 
            // panelFormCentral
            // 
            this.panelFormCentral.BackColor = System.Drawing.Color.White;
            this.panelFormCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormCentral.Controls.Add(this.txtConsultaCPF);
            this.panelFormCentral.Controls.Add(this.dataGridView1);
            this.panelFormCentral.Controls.Add(this.label1);
            this.panelFormCentral.Controls.Add(this.btnPesquisarCPF);
            this.panelFormCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCentral.Location = new System.Drawing.Point(0, 0);
            this.panelFormCentral.Name = "panelFormCentral";
            this.panelFormCentral.Size = new System.Drawing.Size(1264, 681);
            this.panelFormCentral.TabIndex = 5;
            // 
            // btnPaginaInicial
            // 
            this.btnPaginaInicial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaginaInicial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaginaInicial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPaginaInicial.FlatAppearance.BorderSize = 0;
            this.btnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaInicial.ForeColor = System.Drawing.Color.Black;
            this.btnPaginaInicial.Location = new System.Drawing.Point(0, 220);
            this.btnPaginaInicial.Name = "btnPaginaInicial";
            this.btnPaginaInicial.Size = new System.Drawing.Size(200, 45);
            this.btnPaginaInicial.TabIndex = 6;
            this.btnPaginaInicial.Text = "Pagina Inicial";
            this.btnPaginaInicial.UseVisualStyleBackColor = false;
            this.btnPaginaInicial.Click += new System.EventHandler(this.btnPaginaInicial_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.Location = new System.Drawing.Point(0, 265);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(200, 45);
            this.btnCadastroCliente.TabIndex = 7;
            this.btnCadastroCliente.Text = "Cadastro";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(0, 310);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(200, 45);
            this.btnPesquisarCliente.TabIndex = 8;
            this.btnPesquisarCliente.Text = "Pesquisa";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentos.ForeColor = System.Drawing.Color.Black;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 355);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(200, 45);
            this.btnDocumentos.TabIndex = 9;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.Black;
            this.btnAjuda.Location = new System.Drawing.Point(0, 400);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(200, 45);
            this.btnAjuda.TabIndex = 10;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Advocacia_Dias_Pereira.Properties.Resources.logo_advocacia;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelFormTitulo);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelFormCentral);
            this.Name = "FormPaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advocacia Dias Pereira";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelEsquerdo.ResumeLayout(false);
            this.panelFormCentral.ResumeLayout(false);
            this.panelFormCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisarCPF;
        private System.Windows.Forms.MaskedTextBox txtConsultaCPF;
        private System.Windows.Forms.Panel panelFormTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelEsquerdo;
        public System.Windows.Forms.Panel panelFormCentral;
        public System.Windows.Forms.Button btnAjuda;
        public System.Windows.Forms.Button btnDocumentos;
        public System.Windows.Forms.Button btnPesquisarCliente;
        public System.Windows.Forms.Button btnCadastroCliente;
        public System.Windows.Forms.Button btnPaginaInicial;
    }
}