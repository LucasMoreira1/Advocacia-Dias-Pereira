namespace Advocacia_Dias_Pereira
{
    partial class FormPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisa));
            this.txtFiltroMatricula = new System.Windows.Forms.TextBox();
            this.txtRegistroSelecionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFiltro3 = new System.Windows.Forms.Label();
            this.txtFiltro3 = new System.Windows.Forms.TextBox();
            this.lblFiltro1 = new System.Windows.Forms.Label();
            this.lblFiltro2 = new System.Windows.Forms.Label();
            this.cboxFiltro3 = new System.Windows.Forms.ComboBox();
            this.txtFiltro1 = new System.Windows.Forms.TextBox();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.cboxFiltro2 = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnPesquisaID = new System.Windows.Forms.Button();
            this.btnPesquisaFiltro = new System.Windows.Forms.Button();
            this.txtNomeLogin = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltroMatricula
            // 
            this.txtFiltroMatricula.Enabled = false;
            this.txtFiltroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroMatricula.Location = new System.Drawing.Point(10, 48);
            this.txtFiltroMatricula.Name = "txtFiltroMatricula";
            this.txtFiltroMatricula.Size = new System.Drawing.Size(121, 22);
            this.txtFiltroMatricula.TabIndex = 24;
            this.txtFiltroMatricula.Text = "ID";
            // 
            // txtRegistroSelecionado
            // 
            this.txtRegistroSelecionado.Location = new System.Drawing.Point(515, 52);
            this.txtRegistroSelecionado.Name = "txtRegistroSelecionado";
            this.txtRegistroSelecionado.Size = new System.Drawing.Size(18, 20);
            this.txtRegistroSelecionado.TabIndex = 23;
            this.txtRegistroSelecionado.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Reg. Selecionado";
            this.label3.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "Número de linha(s): ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(10, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 437);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblFiltro3
            // 
            this.lblFiltro3.AutoSize = true;
            this.lblFiltro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro3.Location = new System.Drawing.Point(260, 24);
            this.lblFiltro3.Name = "lblFiltro3";
            this.lblFiltro3.Size = new System.Drawing.Size(57, 20);
            this.lblFiltro3.TabIndex = 17;
            this.lblFiltro3.Text = "Filtro 3";
            this.lblFiltro3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFiltro3
            // 
            this.txtFiltro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro3.Location = new System.Drawing.Point(264, 80);
            this.txtFiltro3.Name = "txtFiltro3";
            this.txtFiltro3.Size = new System.Drawing.Size(121, 22);
            this.txtFiltro3.TabIndex = 14;
            this.txtFiltro3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblFiltro1
            // 
            this.lblFiltro1.AutoSize = true;
            this.lblFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro1.Location = new System.Drawing.Point(10, 24);
            this.lblFiltro1.Name = "lblFiltro1";
            this.lblFiltro1.Size = new System.Drawing.Size(57, 20);
            this.lblFiltro1.TabIndex = 18;
            this.lblFiltro1.Text = "Filtro 1";
            this.lblFiltro1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFiltro2
            // 
            this.lblFiltro2.AutoSize = true;
            this.lblFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro2.Location = new System.Drawing.Point(133, 24);
            this.lblFiltro2.Name = "lblFiltro2";
            this.lblFiltro2.Size = new System.Drawing.Size(57, 20);
            this.lblFiltro2.TabIndex = 19;
            this.lblFiltro2.Text = "Filtro 2";
            this.lblFiltro2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxFiltro3
            // 
            this.cboxFiltro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFiltro3.FormattingEnabled = true;
            this.cboxFiltro3.Items.AddRange(new object[] {
            "Autor",
            "Nacionalidade",
            "EstadoCivil",
            "Profissao",
            "RG",
            "CPF",
            "DataNascimento",
            "Email",
            "Telefone1",
            "Telefone2",
            "CEP",
            "Logradouro",
            "Numero",
            "Complemento",
            "Bairro",
            "Cidade",
            "Estado",
            "Reu",
            "CNPJCPF",
            "TelefoneReu",
            "CEPReu",
            "LogradouroReu",
            "NumeroReu",
            "ComplementoReu",
            "BairroReu",
            "CidadeReu",
            "EstadoReu",
            "Processo",
            "TipoProcesso",
            "IDProcesso",
            "StatusProcesso",
            "NatProcesso",
            "Assunto1",
            "Assunto2",
            "Assunto3",
            "DataPericia",
            "TipoAudiencia",
            "DataAudiencia",
            "Observacao"});
            this.cboxFiltro3.Location = new System.Drawing.Point(264, 47);
            this.cboxFiltro3.Name = "cboxFiltro3";
            this.cboxFiltro3.Size = new System.Drawing.Size(121, 24);
            this.cboxFiltro3.TabIndex = 12;
            this.cboxFiltro3.Text = "Reu";
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro1.Location = new System.Drawing.Point(10, 80);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(121, 22);
            this.txtFiltro1.TabIndex = 15;
            this.txtFiltro1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro1_KeyDown);
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro2.Location = new System.Drawing.Point(137, 80);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(121, 22);
            this.txtFiltro2.TabIndex = 16;
            this.txtFiltro2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // cboxFiltro2
            // 
            this.cboxFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFiltro2.FormattingEnabled = true;
            this.cboxFiltro2.Items.AddRange(new object[] {
            "Autor",
            "Nacionalidade",
            "EstadoCivil",
            "Profissao",
            "RG",
            "CPF",
            "DataNascimento",
            "Email",
            "Telefone1",
            "Telefone2",
            "CEP",
            "Logradouro",
            "Numero",
            "Complemento",
            "Bairro",
            "Cidade",
            "Estado",
            "Reu",
            "CNPJCPF",
            "TelefoneReu",
            "CEPReu",
            "LogradouroReu",
            "NumeroReu",
            "ComplementoReu",
            "BairroReu",
            "CidadeReu",
            "EstadoReu",
            "Processo",
            "TipoProcesso",
            "IDProcesso",
            "StatusProcesso",
            "NatProcesso",
            "Assunto1",
            "Assunto2",
            "Assunto3",
            "DataPericia",
            "TipoAudiencia",
            "DataAudiencia",
            "Observacao"});
            this.cboxFiltro2.Location = new System.Drawing.Point(137, 47);
            this.cboxFiltro2.Name = "cboxFiltro2";
            this.cboxFiltro2.Size = new System.Drawing.Size(121, 24);
            this.cboxFiltro2.TabIndex = 13;
            this.cboxFiltro2.Text = "Autor";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(723, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(146, 47);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.Location = new System.Drawing.Point(723, 65);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(146, 47);
            this.btnMostrarTodos.TabIndex = 25;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Visible = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(875, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(146, 47);
            this.btnAtualizar.TabIndex = 25;
            this.btnAtualizar.Text = "Atualizar ( )";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(875, 65);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(146, 47);
            this.btnDeletar.TabIndex = 25;
            this.btnDeletar.Text = "Deletar ( )";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnPesquisaID
            // 
            this.btnPesquisaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaID.Location = new System.Drawing.Point(10, 109);
            this.btnPesquisaID.Name = "btnPesquisaID";
            this.btnPesquisaID.Size = new System.Drawing.Size(120, 36);
            this.btnPesquisaID.TabIndex = 26;
            this.btnPesquisaID.Text = "Pesquisar ID";
            this.btnPesquisaID.UseVisualStyleBackColor = true;
            this.btnPesquisaID.Click += new System.EventHandler(this.btnPesquisaID_Click);
            // 
            // btnPesquisaFiltro
            // 
            this.btnPesquisaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaFiltro.Location = new System.Drawing.Point(137, 109);
            this.btnPesquisaFiltro.Name = "btnPesquisaFiltro";
            this.btnPesquisaFiltro.Size = new System.Drawing.Size(248, 36);
            this.btnPesquisaFiltro.TabIndex = 26;
            this.btnPesquisaFiltro.Text = "Pesquisar Filtro";
            this.btnPesquisaFiltro.UseVisualStyleBackColor = true;
            this.btnPesquisaFiltro.Click += new System.EventHandler(this.btnPesquisaFiltro_Click);
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.Location = new System.Drawing.Point(420, 24);
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(100, 20);
            this.txtNomeLogin.TabIndex = 27;
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 612);
            this.Controls.Add(this.txtNomeLogin);
            this.Controls.Add(this.btnPesquisaFiltro);
            this.Controls.Add(this.btnPesquisaID);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtFiltroMatricula);
            this.Controls.Add(this.txtRegistroSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFiltro3);
            this.Controls.Add(this.txtFiltro3);
            this.Controls.Add(this.lblFiltro1);
            this.Controls.Add(this.lblFiltro2);
            this.Controls.Add(this.cboxFiltro3);
            this.Controls.Add(this.txtFiltro1);
            this.Controls.Add(this.txtFiltro2);
            this.Controls.Add(this.cboxFiltro2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtFiltroMatricula;
        private System.Windows.Forms.TextBox txtRegistroSelecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFiltro3;
        public System.Windows.Forms.TextBox txtFiltro3;
        private System.Windows.Forms.Label lblFiltro1;
        private System.Windows.Forms.Label lblFiltro2;
        private System.Windows.Forms.ComboBox cboxFiltro3;
        public System.Windows.Forms.TextBox txtFiltro1;
        public System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.ComboBox cboxFiltro2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnPesquisaID;
        private System.Windows.Forms.Button btnPesquisaFiltro;
        public System.Windows.Forms.TextBox txtNomeLogin;
    }
}