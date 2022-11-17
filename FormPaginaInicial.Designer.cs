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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaginaInicial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFormTitulo = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.btnVisualizarLogs = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnPaginaInicial = new System.Windows.Forms.Button();
            this.panelFormCentral = new System.Windows.Forms.Panel();
            this.txtPermissaoLogin = new System.Windows.Forms.TextBox();
            this.txtNomeLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEsquerdo.SuspendLayout();
            this.panelFormCentral.SuspendLayout();
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
            // panelFormTitulo
            // 
            this.panelFormTitulo.BackColor = System.Drawing.Color.Khaki;
            this.panelFormTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(1064, 30);
            this.panelFormTitulo.TabIndex = 4;
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
            // panelEsquerdo
            // 
            this.panelEsquerdo.AutoScroll = true;
            this.panelEsquerdo.BackColor = System.Drawing.Color.White;
            this.panelEsquerdo.Controls.Add(this.btnVisualizarLogs);
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
            // btnVisualizarLogs
            // 
            this.btnVisualizarLogs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVisualizarLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisualizarLogs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVisualizarLogs.FlatAppearance.BorderSize = 0;
            this.btnVisualizarLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarLogs.ForeColor = System.Drawing.Color.Black;
            this.btnVisualizarLogs.Location = new System.Drawing.Point(0, 400);
            this.btnVisualizarLogs.Name = "btnVisualizarLogs";
            this.btnVisualizarLogs.Size = new System.Drawing.Size(200, 45);
            this.btnVisualizarLogs.TabIndex = 10;
            this.btnVisualizarLogs.Text = "Visualizar Logs";
            this.btnVisualizarLogs.UseVisualStyleBackColor = false;
            this.btnVisualizarLogs.Click += new System.EventHandler(this.btnAjuda_Click);
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
            // 
            // panelFormCentral
            // 
            this.panelFormCentral.BackColor = System.Drawing.Color.White;
            this.panelFormCentral.BackgroundImage = global::Advocacia_Dias_Pereira.Properties.Resources.pngwing_com__1_;
            this.panelFormCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFormCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormCentral.Controls.Add(this.txtPermissaoLogin);
            this.panelFormCentral.Controls.Add(this.txtNomeLogin);
            this.panelFormCentral.Controls.Add(this.dataGridView1);
            this.panelFormCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCentral.Location = new System.Drawing.Point(0, 0);
            this.panelFormCentral.Name = "panelFormCentral";
            this.panelFormCentral.Size = new System.Drawing.Size(1264, 681);
            this.panelFormCentral.TabIndex = 5;
            // 
            // txtPermissaoLogin
            // 
            this.txtPermissaoLogin.Location = new System.Drawing.Point(1108, 70);
            this.txtPermissaoLogin.Name = "txtPermissaoLogin";
            this.txtPermissaoLogin.Size = new System.Drawing.Size(100, 20);
            this.txtPermissaoLogin.TabIndex = 5;
            this.txtPermissaoLogin.Visible = false;
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.Location = new System.Drawing.Point(1108, 44);
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(100, 20);
            this.txtNomeLogin.TabIndex = 5;
            this.txtNomeLogin.Visible = false;
            // 
            // FormPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelFormTitulo);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelFormCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advocacia Dias Pereira";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPaginaInicial_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEsquerdo.ResumeLayout(false);
            this.panelFormCentral.ResumeLayout(false);
            this.panelFormCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelFormTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelEsquerdo;
        public System.Windows.Forms.Panel panelFormCentral;
        public System.Windows.Forms.Button btnVisualizarLogs;
        public System.Windows.Forms.Button btnDocumentos;
        public System.Windows.Forms.Button btnPesquisarCliente;
        public System.Windows.Forms.Button btnCadastroCliente;
        public System.Windows.Forms.Button btnPaginaInicial;
        public System.Windows.Forms.TextBox txtNomeLogin;
        public System.Windows.Forms.TextBox txtPermissaoLogin;
    }
}