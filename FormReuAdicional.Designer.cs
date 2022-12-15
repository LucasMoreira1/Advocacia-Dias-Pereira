namespace Advocacia_Dias_Pereira
{
    partial class FormReuAdicional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReuAdicional));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCEPReu = new System.Windows.Forms.Button();
            this.txtCEPReu = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtComplementoReu = new System.Windows.Forms.TextBox();
            this.txtEstadoReu = new System.Windows.Forms.TextBox();
            this.txtCidadeReu = new System.Windows.Forms.TextBox();
            this.txtBairroReu = new System.Windows.Forms.TextBox();
            this.txtNumeroReu = new System.Windows.Forms.TextBox();
            this.txtLogradouroReu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCadNumero = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTelefoneReu = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReu = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnLimpar);
            this.groupBox4.Controls.Add(this.txtObservacao);
            this.groupBox4.Controls.Add(this.btnAtualizar);
            this.groupBox4.Controls.Add(this.btnSalvar);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1028, 152);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observação";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(819, 68);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 35);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(6, 22);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacao.Size = new System.Drawing.Size(427, 122);
            this.txtObservacao.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(645, 68);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 35);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(732, 68);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 35);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.btnBuscarCEPReu);
            this.groupBox5.Controls.Add(this.txtCEPReu);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.txtComplementoReu);
            this.groupBox5.Controls.Add(this.txtEstadoReu);
            this.groupBox5.Controls.Add(this.txtCidadeReu);
            this.groupBox5.Controls.Add(this.txtBairroReu);
            this.groupBox5.Controls.Add(this.txtNumeroReu);
            this.groupBox5.Controls.Add(this.txtLogradouroReu);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1028, 152);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Endereço Réu";
            // 
            // btnBuscarCEPReu
            // 
            this.btnBuscarCEPReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCEPReu.Location = new System.Drawing.Point(239, 15);
            this.btnBuscarCEPReu.Name = "btnBuscarCEPReu";
            this.btnBuscarCEPReu.Size = new System.Drawing.Size(98, 26);
            this.btnBuscarCEPReu.TabIndex = 2;
            this.btnBuscarCEPReu.Text = "Buscar";
            this.btnBuscarCEPReu.UseVisualStyleBackColor = true;
            this.btnBuscarCEPReu.Click += new System.EventHandler(this.btnBuscarCEPReu_Click);
            // 
            // txtCEPReu
            // 
            this.txtCEPReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEPReu.Location = new System.Drawing.Point(102, 19);
            this.txtCEPReu.Mask = "00,000-000";
            this.txtCEPReu.Name = "txtCEPReu";
            this.txtCEPReu.Size = new System.Drawing.Size(89, 22);
            this.txtCEPReu.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(617, 54);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "Complemento";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(7, 118);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 16);
            this.label33.TabIndex = 0;
            this.label33.Text = "Estado";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(439, 86);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(51, 16);
            this.label34.TabIndex = 0;
            this.label34.Text = "Cidade";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(7, 86);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(43, 16);
            this.label35.TabIndex = 0;
            this.label35.Text = "Bairro";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(439, 54);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 16);
            this.label36.TabIndex = 0;
            this.label36.Text = "Número";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(7, 54);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 16);
            this.label37.TabIndex = 1;
            this.label37.Text = "Logradouro";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(6, 22);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(34, 16);
            this.label38.TabIndex = 0;
            this.label38.Text = "CEP";
            // 
            // txtComplementoReu
            // 
            this.txtComplementoReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplementoReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoReu.Location = new System.Drawing.Point(755, 51);
            this.txtComplementoReu.Name = "txtComplementoReu";
            this.txtComplementoReu.Size = new System.Drawing.Size(114, 22);
            this.txtComplementoReu.TabIndex = 5;
            // 
            // txtEstadoReu
            // 
            this.txtEstadoReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadoReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoReu.Location = new System.Drawing.Point(102, 115);
            this.txtEstadoReu.Name = "txtEstadoReu";
            this.txtEstadoReu.Size = new System.Drawing.Size(88, 22);
            this.txtEstadoReu.TabIndex = 8;
            // 
            // txtCidadeReu
            // 
            this.txtCidadeReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeReu.Location = new System.Drawing.Point(522, 83);
            this.txtCidadeReu.Name = "txtCidadeReu";
            this.txtCidadeReu.Size = new System.Drawing.Size(347, 22);
            this.txtCidadeReu.TabIndex = 7;
            // 
            // txtBairroReu
            // 
            this.txtBairroReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroReu.Location = new System.Drawing.Point(102, 83);
            this.txtBairroReu.Name = "txtBairroReu";
            this.txtBairroReu.Size = new System.Drawing.Size(331, 22);
            this.txtBairroReu.TabIndex = 6;
            // 
            // txtNumeroReu
            // 
            this.txtNumeroReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroReu.Location = new System.Drawing.Point(522, 51);
            this.txtNumeroReu.Name = "txtNumeroReu";
            this.txtNumeroReu.Size = new System.Drawing.Size(89, 22);
            this.txtNumeroReu.TabIndex = 4;
            // 
            // txtLogradouroReu
            // 
            this.txtLogradouroReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouroReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouroReu.Location = new System.Drawing.Point(102, 51);
            this.txtLogradouroReu.Name = "txtLogradouroReu";
            this.txtLogradouroReu.Size = new System.Drawing.Size(331, 22);
            this.txtLogradouroReu.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.txtDataCadastro);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCadNumero);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtTelefoneReu);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtReu);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.txtCNPJ);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1028, 109);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Identificação Réu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(594, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(79, 42);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.Location = new System.Drawing.Point(442, 13);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(124, 22);
            this.txtDataCadastro.TabIndex = 10;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(339, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Data Cadastro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Número Registro";
            // 
            // txtCadNumero
            // 
            this.txtCadNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNumero.Location = new System.Drawing.Point(146, 13);
            this.txtCadNumero.Name = "txtCadNumero";
            this.txtCadNumero.ReadOnly = true;
            this.txtCadNumero.Size = new System.Drawing.Size(150, 22);
            this.txtCadNumero.TabIndex = 9;
            this.txtCadNumero.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1118, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // txtTelefoneReu
            // 
            this.txtTelefoneReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneReu.Location = new System.Drawing.Point(443, 73);
            this.txtTelefoneReu.Mask = "(99)00000-0000";
            this.txtTelefoneReu.Name = "txtTelefoneReu";
            this.txtTelefoneReu.Size = new System.Drawing.Size(123, 22);
            this.txtTelefoneReu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réu";
            // 
            // txtReu
            // 
            this.txtReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReu.Location = new System.Drawing.Point(146, 45);
            this.txtReu.Name = "txtReu";
            this.txtReu.Size = new System.Drawing.Size(420, 22);
            this.txtReu.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(7, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 16);
            this.label27.TabIndex = 0;
            this.label27.Text = "CNPJ/CPF";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(304, 76);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 16);
            this.label31.TabIndex = 0;
            this.label31.Text = "Telefone Réu";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(146, 76);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(152, 22);
            this.txtCNPJ.TabIndex = 1;
            this.txtCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisarCNPJ);
            // 
            // FormReuAdicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 417);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReuAdicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reu Adicional";
            this.Load += new System.EventHandler(this.FormReuAdicional_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.TextBox txtObservacao;
        public System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuscarCEPReu;
        public System.Windows.Forms.MaskedTextBox txtCEPReu;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        public System.Windows.Forms.TextBox txtComplementoReu;
        public System.Windows.Forms.TextBox txtEstadoReu;
        public System.Windows.Forms.TextBox txtCidadeReu;
        public System.Windows.Forms.TextBox txtBairroReu;
        public System.Windows.Forms.TextBox txtNumeroReu;
        public System.Windows.Forms.TextBox txtLogradouroReu;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.MaskedTextBox txtTelefoneReu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtReu;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        public System.Windows.Forms.TextBox txtCNPJ;
        public System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCadNumero;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}