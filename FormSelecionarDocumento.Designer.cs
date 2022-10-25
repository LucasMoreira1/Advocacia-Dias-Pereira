namespace Advocacia_Dias_Pereira
{
    partial class FormSelecionarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelecionarDocumento));
            this.cboxDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerarDocumento = new System.Windows.Forms.Button();
            this.txtIDAutor = new System.Windows.Forms.TextBox();
            this.txtCEPReu = new System.Windows.Forms.MaskedTextBox();
            this.txtDataPericia = new System.Windows.Forms.MaskedTextBox();
            this.cboxStatusProcesso = new System.Windows.Forms.ComboBox();
            this.cboxTipoProcesso = new System.Windows.Forms.ComboBox();
            this.txtTipoAudiencia = new System.Windows.Forms.TextBox();
            this.txtAssunto1 = new System.Windows.Forms.TextBox();
            this.txtAssunto3 = new System.Windows.Forms.TextBox();
            this.txtAssunto2 = new System.Windows.Forms.TextBox();
            this.txtEstadoReu = new System.Windows.Forms.TextBox();
            this.txtBairroReu = new System.Windows.Forms.TextBox();
            this.txtProcesso = new System.Windows.Forms.TextBox();
            this.txtNumeroReu = new System.Windows.Forms.TextBox();
            this.txtNatProcesso = new System.Windows.Forms.TextBox();
            this.txtComplementoReu = new System.Windows.Forms.TextBox();
            this.txtIdProcesso = new System.Windows.Forms.TextBox();
            this.txtCidadeReu = new System.Windows.Forms.TextBox();
            this.txtLogradouroReu = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtTelefoneReu = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.cboxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtDataAudiencia = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtReu = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboxDocumento
            // 
            this.cboxDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDocumento.FormattingEnabled = true;
            this.cboxDocumento.Items.AddRange(new object[] {
            "1 - CONTRATO DE HONORARIOS ADVOCATÍCIOS",
            "2 - DECLARAÇÃO DE HIPOSSUFICIÊNCIA",
            "3 - MANIFESTAÇÃO",
            "4 - PROCURAÇÃO"});
            this.cboxDocumento.Location = new System.Drawing.Point(133, 137);
            this.cboxDocumento.Name = "cboxDocumento";
            this.cboxDocumento.Size = new System.Drawing.Size(477, 24);
            this.cboxDocumento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirme o Autor e selecione o tipo de documento que deseja criar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(133, 88);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(477, 23);
            this.txtAutor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Documento";
            // 
            // btnGerarDocumento
            // 
            this.btnGerarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDocumento.Location = new System.Drawing.Point(261, 193);
            this.btnGerarDocumento.Name = "btnGerarDocumento";
            this.btnGerarDocumento.Size = new System.Drawing.Size(133, 47);
            this.btnGerarDocumento.TabIndex = 3;
            this.btnGerarDocumento.Text = "Gerar";
            this.btnGerarDocumento.UseVisualStyleBackColor = true;
            this.btnGerarDocumento.Click += new System.EventHandler(this.btnGerarDocumento_Click);
            // 
            // txtIDAutor
            // 
            this.txtIDAutor.Location = new System.Drawing.Point(39, 220);
            this.txtIDAutor.Name = "txtIDAutor";
            this.txtIDAutor.Size = new System.Drawing.Size(100, 20);
            this.txtIDAutor.TabIndex = 4;
            this.txtIDAutor.Visible = false;
            // 
            // txtCEPReu
            // 
            this.txtCEPReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEPReu.Location = new System.Drawing.Point(470, 190);
            this.txtCEPReu.Mask = "00,000-000";
            this.txtCEPReu.Name = "txtCEPReu";
            this.txtCEPReu.Size = new System.Drawing.Size(10, 22);
            this.txtCEPReu.TabIndex = 11;
            this.txtCEPReu.Visible = false;
            // 
            // txtDataPericia
            // 
            this.txtDataPericia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPericia.Location = new System.Drawing.Point(540, 244);
            this.txtDataPericia.Mask = "00/00/0000";
            this.txtDataPericia.Name = "txtDataPericia";
            this.txtDataPericia.Size = new System.Drawing.Size(10, 22);
            this.txtDataPericia.TabIndex = 34;
            this.txtDataPericia.ValidatingType = typeof(System.DateTime);
            this.txtDataPericia.Visible = false;
            // 
            // cboxStatusProcesso
            // 
            this.cboxStatusProcesso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxStatusProcesso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxStatusProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatusProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxStatusProcesso.FormattingEnabled = true;
            this.cboxStatusProcesso.Items.AddRange(new object[] {
            "1-EM ANDAMENTO",
            "2-ARQUIVADO",
            "3-SUSPENSO",
            "4-OUTROS"});
            this.cboxStatusProcesso.Location = new System.Drawing.Point(540, 217);
            this.cboxStatusProcesso.Name = "cboxStatusProcesso";
            this.cboxStatusProcesso.Size = new System.Drawing.Size(10, 24);
            this.cboxStatusProcesso.TabIndex = 23;
            this.cboxStatusProcesso.Visible = false;
            // 
            // cboxTipoProcesso
            // 
            this.cboxTipoProcesso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxTipoProcesso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTipoProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoProcesso.FormattingEnabled = true;
            this.cboxTipoProcesso.Items.AddRange(new object[] {
            "1-ADMINISTRATIVO",
            "2-JUDICIAL",
            "3-OUTROS"});
            this.cboxTipoProcesso.Location = new System.Drawing.Point(540, 185);
            this.cboxTipoProcesso.Name = "cboxTipoProcesso";
            this.cboxTipoProcesso.Size = new System.Drawing.Size(10, 24);
            this.cboxTipoProcesso.TabIndex = 18;
            this.cboxTipoProcesso.Visible = false;
            // 
            // txtTipoAudiencia
            // 
            this.txtTipoAudiencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoAudiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAudiencia.Location = new System.Drawing.Point(540, 196);
            this.txtTipoAudiencia.Name = "txtTipoAudiencia";
            this.txtTipoAudiencia.Size = new System.Drawing.Size(10, 22);
            this.txtTipoAudiencia.TabIndex = 40;
            this.txtTipoAudiencia.Visible = false;
            // 
            // txtAssunto1
            // 
            this.txtAssunto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAssunto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto1.Location = new System.Drawing.Point(522, 201);
            this.txtAssunto1.Name = "txtAssunto1";
            this.txtAssunto1.Size = new System.Drawing.Size(10, 22);
            this.txtAssunto1.TabIndex = 36;
            this.txtAssunto1.Visible = false;
            // 
            // txtAssunto3
            // 
            this.txtAssunto3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAssunto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto3.Location = new System.Drawing.Point(496, 228);
            this.txtAssunto3.Name = "txtAssunto3";
            this.txtAssunto3.Size = new System.Drawing.Size(10, 22);
            this.txtAssunto3.TabIndex = 48;
            this.txtAssunto3.Visible = false;
            // 
            // txtAssunto2
            // 
            this.txtAssunto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAssunto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto2.Location = new System.Drawing.Point(521, 236);
            this.txtAssunto2.Name = "txtAssunto2";
            this.txtAssunto2.Size = new System.Drawing.Size(10, 22);
            this.txtAssunto2.TabIndex = 45;
            this.txtAssunto2.Visible = false;
            // 
            // txtEstadoReu
            // 
            this.txtEstadoReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadoReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoReu.Location = new System.Drawing.Point(469, 195);
            this.txtEstadoReu.Name = "txtEstadoReu";
            this.txtEstadoReu.Size = new System.Drawing.Size(10, 22);
            this.txtEstadoReu.TabIndex = 44;
            this.txtEstadoReu.Visible = false;
            // 
            // txtBairroReu
            // 
            this.txtBairroReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroReu.Location = new System.Drawing.Point(556, 241);
            this.txtBairroReu.Name = "txtBairroReu";
            this.txtBairroReu.Size = new System.Drawing.Size(33, 22);
            this.txtBairroReu.TabIndex = 37;
            this.txtBairroReu.Visible = false;
            // 
            // txtProcesso
            // 
            this.txtProcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesso.Location = new System.Drawing.Point(522, 187);
            this.txtProcesso.Name = "txtProcesso";
            this.txtProcesso.Size = new System.Drawing.Size(10, 22);
            this.txtProcesso.TabIndex = 15;
            this.txtProcesso.Visible = false;
            // 
            // txtNumeroReu
            // 
            this.txtNumeroReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroReu.Location = new System.Drawing.Point(515, 198);
            this.txtNumeroReu.Name = "txtNumeroReu";
            this.txtNumeroReu.Size = new System.Drawing.Size(10, 22);
            this.txtNumeroReu.TabIndex = 29;
            this.txtNumeroReu.Visible = false;
            // 
            // txtNatProcesso
            // 
            this.txtNatProcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNatProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNatProcesso.Location = new System.Drawing.Point(521, 246);
            this.txtNatProcesso.Name = "txtNatProcesso";
            this.txtNatProcesso.Size = new System.Drawing.Size(10, 22);
            this.txtNatProcesso.TabIndex = 28;
            this.txtNatProcesso.Visible = false;
            // 
            // txtComplementoReu
            // 
            this.txtComplementoReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplementoReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoReu.Location = new System.Drawing.Point(469, 222);
            this.txtComplementoReu.Name = "txtComplementoReu";
            this.txtComplementoReu.Size = new System.Drawing.Size(10, 22);
            this.txtComplementoReu.TabIndex = 32;
            this.txtComplementoReu.Visible = false;
            // 
            // txtIdProcesso
            // 
            this.txtIdProcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProcesso.Location = new System.Drawing.Point(521, 222);
            this.txtIdProcesso.Name = "txtIdProcesso";
            this.txtIdProcesso.Size = new System.Drawing.Size(10, 22);
            this.txtIdProcesso.TabIndex = 22;
            this.txtIdProcesso.Visible = false;
            // 
            // txtCidadeReu
            // 
            this.txtCidadeReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeReu.Location = new System.Drawing.Point(490, 180);
            this.txtCidadeReu.Name = "txtCidadeReu";
            this.txtCidadeReu.Size = new System.Drawing.Size(49, 22);
            this.txtCidadeReu.TabIndex = 41;
            this.txtCidadeReu.Visible = false;
            // 
            // txtLogradouroReu
            // 
            this.txtLogradouroReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouroReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouroReu.Location = new System.Drawing.Point(556, 219);
            this.txtLogradouroReu.Name = "txtLogradouroReu";
            this.txtLogradouroReu.Size = new System.Drawing.Size(33, 22);
            this.txtLogradouroReu.TabIndex = 26;
            this.txtLogradouroReu.Visible = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(460, 180);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacao.Size = new System.Drawing.Size(129, 87);
            this.txtObservacao.TabIndex = 14;
            this.txtObservacao.Visible = false;
            // 
            // txtTelefoneReu
            // 
            this.txtTelefoneReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneReu.Location = new System.Drawing.Point(469, 194);
            this.txtTelefoneReu.Mask = "(99)00000-0000";
            this.txtTelefoneReu.Name = "txtTelefoneReu";
            this.txtTelefoneReu.Size = new System.Drawing.Size(10, 22);
            this.txtTelefoneReu.TabIndex = 19;
            this.txtTelefoneReu.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(469, 218);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(10, 22);
            this.txtCPF.TabIndex = 33;
            this.txtCPF.Visible = false;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(569, 199);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(10, 22);
            this.txtDataNascimento.TabIndex = 35;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtDataNascimento.Visible = false;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.Location = new System.Drawing.Point(470, 174);
            this.txtTelefone2.Mask = "(99)00000-0000";
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(10, 22);
            this.txtTelefone2.TabIndex = 43;
            this.txtTelefone2.Visible = false;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.Location = new System.Drawing.Point(571, 236);
            this.txtTelefone1.Mask = "(99)00000-0000";
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(10, 22);
            this.txtTelefone1.TabIndex = 39;
            this.txtTelefone1.Visible = false;
            // 
            // cboxEstadoCivil
            // 
            this.cboxEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstadoCivil.FormattingEnabled = true;
            this.cboxEstadoCivil.Items.AddRange(new object[] {
            "1-SOLTEIRO",
            "2-CASADO",
            "3-SEPARADO",
            "4-DIVORCIADO",
            "5-VIÚVO"});
            this.cboxEstadoCivil.Location = new System.Drawing.Point(470, 228);
            this.cboxEstadoCivil.Name = "cboxEstadoCivil";
            this.cboxEstadoCivil.Size = new System.Drawing.Size(10, 24);
            this.cboxEstadoCivil.TabIndex = 20;
            this.cboxEstadoCivil.Visible = false;
            // 
            // txtProfissao
            // 
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfissao.Location = new System.Drawing.Point(470, 211);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(122, 22);
            this.txtProfissao.TabIndex = 24;
            this.txtProfissao.Visible = false;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.Location = new System.Drawing.Point(498, 224);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(10, 22);
            this.txtNacionalidade.TabIndex = 16;
            this.txtNacionalidade.Text = "BRASILEIRO(A)";
            this.txtNacionalidade.Visible = false;
            // 
            // txtDataAudiencia
            // 
            this.txtDataAudiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAudiencia.Location = new System.Drawing.Point(540, 234);
            this.txtDataAudiencia.Mask = "00/00/0000";
            this.txtDataAudiencia.Name = "txtDataAudiencia";
            this.txtDataAudiencia.Size = new System.Drawing.Size(10, 22);
            this.txtDataAudiencia.TabIndex = 47;
            this.txtDataAudiencia.ValidatingType = typeof(System.DateTime);
            this.txtDataAudiencia.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(470, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(122, 22);
            this.txtEmail.TabIndex = 46;
            this.txtEmail.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(469, 195);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(10, 22);
            this.txtEstado.TabIndex = 42;
            this.txtEstado.Visible = false;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(490, 180);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(49, 22);
            this.txtCidade.TabIndex = 38;
            this.txtCidade.Visible = false;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(556, 241);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(33, 22);
            this.txtBairro.TabIndex = 31;
            this.txtBairro.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(515, 198);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(10, 22);
            this.txtNumero.TabIndex = 25;
            this.txtNumero.Visible = false;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(556, 219);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(33, 22);
            this.txtLogradouro.TabIndex = 21;
            this.txtLogradouro.Visible = false;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(496, 239);
            this.txtRG.Mask = "CC,CCC,CCC-C";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(10, 22);
            this.txtRG.TabIndex = 27;
            this.txtRG.Visible = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(469, 222);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(10, 22);
            this.txtComplemento.TabIndex = 30;
            this.txtComplemento.Visible = false;
            // 
            // txtReu
            // 
            this.txtReu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReu.Location = new System.Drawing.Point(469, 186);
            this.txtReu.Name = "txtReu";
            this.txtReu.Size = new System.Drawing.Size(122, 22);
            this.txtReu.TabIndex = 12;
            this.txtReu.Visible = false;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(470, 190);
            this.txtCEP.Mask = "00,000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(10, 22);
            this.txtCEP.TabIndex = 13;
            this.txtCEP.Visible = false;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(524, 218);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(10, 22);
            this.txtCNPJ.TabIndex = 17;
            this.txtCNPJ.Visible = false;
            // 
            // FormSelecionarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 292);
            this.Controls.Add(this.txtCEPReu);
            this.Controls.Add(this.txtDataPericia);
            this.Controls.Add(this.cboxStatusProcesso);
            this.Controls.Add(this.cboxTipoProcesso);
            this.Controls.Add(this.txtTipoAudiencia);
            this.Controls.Add(this.txtAssunto1);
            this.Controls.Add(this.txtAssunto3);
            this.Controls.Add(this.txtAssunto2);
            this.Controls.Add(this.txtEstadoReu);
            this.Controls.Add(this.txtBairroReu);
            this.Controls.Add(this.txtProcesso);
            this.Controls.Add(this.txtNumeroReu);
            this.Controls.Add(this.txtNatProcesso);
            this.Controls.Add(this.txtComplementoReu);
            this.Controls.Add(this.txtIdProcesso);
            this.Controls.Add(this.txtCidadeReu);
            this.Controls.Add(this.txtLogradouroReu);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtTelefoneReu);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.cboxEstadoCivil);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.txtDataAudiencia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtReu);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtIDAutor);
            this.Controls.Add(this.btnGerarDocumento);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelecionarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboxDocumento;
        public System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerarDocumento;
        public System.Windows.Forms.TextBox txtIDAutor;
        public System.Windows.Forms.MaskedTextBox txtCEPReu;
        public System.Windows.Forms.MaskedTextBox txtDataPericia;
        public System.Windows.Forms.ComboBox cboxStatusProcesso;
        public System.Windows.Forms.ComboBox cboxTipoProcesso;
        public System.Windows.Forms.TextBox txtTipoAudiencia;
        public System.Windows.Forms.TextBox txtAssunto1;
        public System.Windows.Forms.TextBox txtAssunto3;
        public System.Windows.Forms.TextBox txtAssunto2;
        public System.Windows.Forms.TextBox txtEstadoReu;
        public System.Windows.Forms.TextBox txtBairroReu;
        public System.Windows.Forms.TextBox txtProcesso;
        public System.Windows.Forms.TextBox txtNumeroReu;
        public System.Windows.Forms.TextBox txtNatProcesso;
        public System.Windows.Forms.TextBox txtComplementoReu;
        public System.Windows.Forms.TextBox txtIdProcesso;
        public System.Windows.Forms.TextBox txtCidadeReu;
        public System.Windows.Forms.TextBox txtLogradouroReu;
        public System.Windows.Forms.TextBox txtObservacao;
        public System.Windows.Forms.MaskedTextBox txtTelefoneReu;
        public System.Windows.Forms.MaskedTextBox txtCPF;
        public System.Windows.Forms.MaskedTextBox txtDataNascimento;
        public System.Windows.Forms.MaskedTextBox txtTelefone2;
        public System.Windows.Forms.MaskedTextBox txtTelefone1;
        public System.Windows.Forms.ComboBox cboxEstadoCivil;
        public System.Windows.Forms.TextBox txtProfissao;
        public System.Windows.Forms.TextBox txtNacionalidade;
        public System.Windows.Forms.MaskedTextBox txtDataAudiencia;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtLogradouro;
        public System.Windows.Forms.MaskedTextBox txtRG;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtReu;
        public System.Windows.Forms.MaskedTextBox txtCEP;
        public System.Windows.Forms.TextBox txtCNPJ;
    }
}