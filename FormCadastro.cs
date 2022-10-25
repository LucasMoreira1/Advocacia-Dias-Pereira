using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Microsoft.VisualBasic;

namespace Advocacia_Dias_Pereira
{
    public partial class FormCadastro : Form
    {
        public Boolean CameraOn = false;
        public string localizacaoFoto;
        public string filename = "";
        
        public FormCadastro()
        {
            InitializeComponent();
            ResetMe();
        }
        

        private void ResetMe()
        {
            //Zerar comboBox identificação cliente
            
            cboxEstadoCivil.SelectedIndex = -1;
            

            

            //Limpar campos identificação cliente
            txtAutor.Text = "";
            txtRG.Text = "";
            
            txtDataNascimento.Text = "";
            txtTelefone1.Text = "";
            txtEmail.Text = "";
            txtNacionalidade.Text = "";
            

            //Limpar campos identificação endereço
            txtCEP.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtObservacao.Text = "";

            //Limpar campos identificação dependente
            //txtNomeDependente.Text = "";
            //txtDataNascimentoDependente.Text = "";
            //txtRGDependente.Text = "";
            //txtCPFDependente.Text = "";
            //txtPassaporteDependente.Text = "";
            //txtCertidaoNascimentoDependente.Text = "";

        }

        private void Executar(string mySQL, string param)
        {
            CRUD.cmd = new MySqlCommand(mySQL, CRUD.con);
            AddParametros(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void AddParametros(string str)
        {
            CRUD.cmd.Parameters.Clear();

            if (filename == "")
            {
                goto SEMDOCUMENTO;
            }
            
            FileStream fileStream = File.OpenRead(filename);
            byte[] contents = new byte[fileStream.Length];
            fileStream.Read(contents, 0, (int)contents.Length);
            fileStream.Close();
            string nomedocumento = Path.GetFileName(filename);
            
            CRUD.cmd.Parameters.AddWithValue("Documento", contents);
            CRUD.cmd.Parameters.AddWithValue("Nome_Documento", nomedocumento.Trim());
            SEMDOCUMENTO:
            //Informações Gerais
            CRUD.cmd.Parameters.AddWithValue("DataCadastro", Convert.ToDateTime(DateTime.Now));

            //Identificação Autor
            CRUD.cmd.Parameters.AddWithValue("CadNumero", txtCadNumero.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("autor", txtAutor.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nacionalidade", txtNacionalidade.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estadocivil", cboxEstadoCivil.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("profissao", txtProfissao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("rg", txtRG.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cpf", txtCPF.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("datanascimento", txtDataNascimento.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("telefone1", txtTelefone1.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("telefone2", txtTelefone2.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("email", txtEmail.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cepAutor", txtCEP.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("logradouroAutor", txtLogradouro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("numeroAutor", txtNumero.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("complementoAutor", txtComplemento.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("bairroAutor", txtBairro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cidadeAutor", txtCidade.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estadoAutor", txtEstado.Text.Trim());

            //Identificação Réu
            CRUD.cmd.Parameters.AddWithValue("Reu", txtReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cnpj", txtCNPJ.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("telefoneReu", txtTelefoneReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cepReu", txtCEPReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("logradouroReu", txtLogradouroReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("numeroReu", txtNumeroReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("complementoReu", txtComplementoReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("bairroReu", txtBairroReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cidadeReu", txtCidadeReu.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estadoReu", txtEstadoReu.Text.Trim());

            //Dados Processo
            CRUD.cmd.Parameters.AddWithValue("processo", txtProcesso.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("tipoprocesso", cboxTipoProcesso.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("idprocesso", txtIdProcesso.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("statusprocesso", cboxStatusProcesso.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("natprocesso", txtNatProcesso.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("datapericia", txtDataPericia.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("assunto1", txtAssunto1.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("tipoaudiencia", txtTipoAudiencia.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("assunto2", txtAssunto2.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("dataaudiencia", txtDataAudiencia.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("assunto3", txtAssunto3.Text.Trim());
            
            //Outros
            CRUD.cmd.Parameters.AddWithValue("observacao", txtObservacao.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("Cad_numero", txtCadNumero.Text.Trim());


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAutor.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO CADASTRO(autor, nacionalidade, estadocivil, profissao, rg, cpf, datanascimento, email, " +
                "telefone1, telefone2, cep, logradouro, numero, complemento, bairro, cidade, estado, reu, cnpjcpf, " +
                "telefoneReu, cepReu, logradouroReu, numeroReu, complementoReu, bairroReu, cidadeReu, estadoReu, " +
                "processo, tipoprocesso, idprocesso, statusprocesso, natprocesso, assunto1, assunto2, assunto3, " +
                "datapericia, tipoaudiencia, dataaudiencia, observacao)" +
                "Values(@autor, @nacionalidade, @estadocivil, @profissao, @rg, @cpf, @datanascimento, @email, " +
                "@telefone1, @telefone2, @cepautor, @logradouroautor, @numeroautor, @complementoautor, @bairroautor, @cidadeautor, @estadoautor, @reu, @cnpj, " +
                "@telefoneReu, @cepReu, @logradouroReu, @numeroReu, @complementoReu, @bairroReu, @cidadeReu, @estadoReu, " +
                "@processo, @tipoprocesso, @idprocesso, @statusprocesso, @natprocesso, @assunto1, @assunto2, @assunto3, " +
                "@datapericia, @tipoaudiencia, @dataaudiencia, @observacao);";


            Executar(CRUD.sql, "Insert");

            CRUD.sql = "SELECT LAST_INSERT_ID()";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);


            DataGridView dgv = dataGridView1;
            dgv.Visible = true;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            // dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            string NumeroRegistro = dgv.CurrentCell.Value.ToString();
            // .CurrentRow.Cells[0].Value
            dgv.Visible = false;

            MessageBox.Show("Cliente registrado. ID número: " + NumeroRegistro + ".", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            pesquisaCPF();

            btnSalvar.Visible = true;
            btnAtualizar.Visible = false;
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text);

                ds.ReadXml(xml);

                txtLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao buscar CEP");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetMe();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtAutor.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //CRUD.sql = "UPDATE CADASTRO SET autor = @autor, nacionalidade = @nacionalidade, estadocivil = @estadocivil, " +
            //    "profissao = @profissao, rg = @rg, cpf = @cpf, datanascimento = @datanascimento, " +
            //    "email = @email, telefone1 = @telefone1, telefone2 = @telefone2, cep = @cepautor, " +
            //    "logradouro = @logradouroautor, numero = @numeroautor, complemento = @complementoautor, bairro = @bairroautor, " +
            //    "cidade = @cidadeautor, estado = @estadoautor, reu = @Reu, cnpjcpf = @cnpj WHERE ID = @CadNumero";

            CRUD.sql = "UPDATE CADASTRO SET autor = @autor, nacionalidade = @nacionalidade, estadocivil = @estadocivil, profissao = @profissao, " +
                "rg = @rg, cpf = @cpf, datanascimento = @datanascimento, " +
                "email = @email, telefone1 = @telefone1, telefone2 = @telefone2, cep = @cepautor, " +
                "logradouro = @logradouroautor, numero = @numeroautor, complemento = @complementoautor, bairro = @bairroautor, " +
                "cidade = @cidadeautor, estado = @estadoautor, reu = @Reu, cnpjcpf = @cnpj, " +
                "telefoneReu = @telefoneReu, cepReu = @cepReu, logradouroReu = @logradouroReu, " +
                "numeroReu = @numeroReu, complementoReu = @complementoReu, bairroReu = @bairroReu, cidadeReu = @cidadeReu, " +
                "estadoReu = @estadoReu, processo = @processo, tipoprocesso = @tipoprocesso, idprocesso = @idprocesso, " +
                "statusprocesso = @statusprocesso, natprocesso = @natprocesso, assunto1 = @assunto1, " +
                "assunto2 = @assunto2, assunto3 = @assunto3, datapericia = @datapericia, tipoaudiencia = @tipoaudiencia, " +
                "dataaudiencia = @dataaudiencia, observacao = @observacao WHERE ID = @CadNumero";

            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetMe();
            this.Close();

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //cboxDocumento.SelectedIndex = 0;

            //Camera
            
        }        

        private void btnImagemEmBranco_Click(object sender, EventArgs e)
        {


            CRUD.sql = "UPDATE CADASTRO SET foto = @foto";


            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormPesquisa formpesquisa = new FormPesquisa();
            formpesquisa.btnPesquisar_Click(sender, e);

            ResetMe();
            this.Close();
        }

        private void btnAdcDependente_Click(object sender, EventArgs e)
        {
            btnSalvar.PerformClick();

            if (string.IsNullOrEmpty(txtAutor.Text.Trim()) ||
                    (string.IsNullOrEmpty(txtCadNumero.Text.Trim())))
            {
                MessageBox.Show("Por favor finalize o cadastro do cliente e volte após para cadastrar os dependentes.", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "INSERT INTO DEPENDENTES(CadReferencia,Nome,RG,OrgEmissor,CPF,Passaporte,CertidaoNascimento,GrauParentesco,DataNascimento,Autorizacao)" +
                "Values(@Cad_numero, @nomeDependente, @RGDependente, @orgemissordependente, @CPFDependente, @PassaporteDependente, @certidaonascimento, " +
                "@GrauParentesco, @DataNascimentoDependente, @autorizacao);";


            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Dependente registrado.", "Cadastro Dependente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadData("");
            //ResetDependente();
        }

        

        private void btnListaDependente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadNumero.Text.Trim()))
            {
                MessageBox.Show("Por favor salve o cadastro", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        

        private void txtDataNascimento_Click(object sender, EventArgs e)
        {
            IniciarEsquerda();
        }

        private void IniciarEsquerda()
        {
            txtDataNascimento.SelectionStart = 0;
            txtRG.SelectionStart = 0;
            txtCPF.SelectionStart = 0;
            
            txtTelefone1.SelectionStart = 0;
            
            txtCEP.SelectionStart = 0;

            


        }


        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscarCEP_Click(sender, e);
        }

        
        private void btnAtualizarDependente_Click(object sender, EventArgs e)
        {
            CRUD.sql = "UPDATE DEPENDENTES SET Nome = @nomeDependente, RG = @RGDependente, OrgEmissor = @orgemissordependente,CPF = @CPFDependente," +
                "Passaporte = @PassaporteDependente, CertidaoNascimento = @certidaonascimento, GrauParentesco = @GrauParentesco,DataNascimento = @DataNascimentoDependente" +
                ",Autorizacao = @autorizacao WHERE CadReferencia = @cad_numero";


            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetMe();
            this.Close();
        }
        public void pesquisaRG()
        {

            CRUD.sql = "SELECT * FROM CADASTRO WHERE RG LIKE '" + txtRG.Text.Trim() + "'";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;

            dgv.Visible = true;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            //dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            btnSalvar.Visible = false;
            btnAtualizar.Visible = true;

            if (dgv.CurrentRow == null)
            {
                dgv.Visible = false;
                MessageBox.Show("Não há cliente registrado com esse RG.");
            }
            else
            {
                txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
                txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
                txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
                txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
                txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
                txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
                txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
                txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[25].Value);
                txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
                txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[27].Value);
                txtProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[28].Value);
                cboxTipoProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[29].Value);
                txtIdProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[30].Value);
                cboxStatusProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[31].Value);
                txtNatProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[32].Value);
                txtAssunto1.Text = Convert.ToString(dgv.CurrentRow.Cells[33].Value);
                txtAssunto2.Text = Convert.ToString(dgv.CurrentRow.Cells[34].Value);
                txtAssunto3.Text = Convert.ToString(dgv.CurrentRow.Cells[35].Value);
                txtDataPericia.Text = Convert.ToString(dgv.CurrentRow.Cells[36].Value);
                txtTipoAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[37].Value);
                txtDataAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[38].Value);
                txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[39].Value);

                dgv.Visible = false;
                MessageBox.Show("Cliente localizado.");
            }


        }

        private void PesquisarRG(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaRG();
            }
        }
        public void pesquisaCPF()
        {

            CRUD.sql = "SELECT * FROM CADASTRO WHERE CPF LIKE '" + txtCPF.Text.Trim() + "'";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;

            dgv.Visible = true;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            //dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            btnSalvar.Visible = false;
            btnAtualizar.Visible = true;
            if (dgv.CurrentRow == null)
            {
                dgv.Visible = false;
                MessageBox.Show("Não há cliente registrado com esse CPF.");

            }
            else
            {

                txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
                txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
                txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
                txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
                txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
                txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
                txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
                txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[25].Value);
                txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
                txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[27].Value);
                txtProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[28].Value);
                cboxTipoProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[29].Value);
                txtIdProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[30].Value);
                cboxStatusProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[31].Value);
                txtNatProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[32].Value);
                txtAssunto1.Text = Convert.ToString(dgv.CurrentRow.Cells[33].Value);
                txtAssunto2.Text = Convert.ToString(dgv.CurrentRow.Cells[34].Value);
                txtAssunto3.Text = Convert.ToString(dgv.CurrentRow.Cells[35].Value);
                txtDataPericia.Text = Convert.ToString(dgv.CurrentRow.Cells[36].Value);
                txtTipoAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[37].Value);
                txtDataAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[38].Value);
                txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[39].Value);

                dgv.Visible = false;
                //MessageBox.Show("Cliente localizado.");
            }


        }

        private void PesquisarCPF(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaCPF();
            }
        }

        private void btnBuscarCEPReu_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEPReu.Text);

                ds.ReadXml(xml);

                txtLogradouroReu.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairroReu.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidadeReu.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtEstadoReu.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao buscar CEP");
            }
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            txtCadNumero.Text = "";
            MessageBox.Show("Dados duplicados, favor finalizar o cadastro.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSalvar.Visible = true;
            btnAtualizar.Visible = false;
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            //btnSalvar.PerformClick();

            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "Todos arquivos (*) | *.*", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Tem certeza que deseja subir esse(s) documento(s)?", "Envio para núvem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        filename = dlg.FileName.ToString();

                        //nomedocumento = Interaction.InputBox("Qual o nome do documento?", "Nome documento");
                        //Interaction.MsgBox("Oi " + nomedocumento.ToString());
                        //FileStream fileStream = File.OpenRead(filename);
                        //byte[] contents = new byte[fileStream.Length];
                        //fileStream.Read(contents, 0, (int)contents.Length);
                        //fileStream.Close();

                        //CRUD.cmd.Parameters.AddWithValue("Documento", contents);

                        if (string.IsNullOrEmpty(txtAutor.Text.Trim()) ||
                            (string.IsNullOrEmpty(txtCadNumero.Text.Trim())))
                        {
                            MessageBox.Show("Por favor finalize o cadastro do cliente e volte após para enviar documentos.", "Dados Obrigatórios",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        CRUD.sql = "INSERT INTO DOCUMENTOS(Nome_Cliente,Cad_Cliente,Data_Documento,Documento,Nome_Documento)" +
                            "Values(@autor, @CadNumero, @DataCadastro, @Documento, @Nome_Documento);";


                        Executar(CRUD.sql, "Insert");

                        MessageBox.Show("Documento salvo.", "Envio Documento",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }

            
        }

        private void btnVisualizarDocumentos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadNumero.Text.Trim()))
            {
                MessageBox.Show("Por favor insira a Matrícula", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormDocumentos formDocumentos = new FormDocumentos();
            formDocumentos.txtCadCliente.Text = txtCadNumero.Text;
            formDocumentos.txtNomeCliente.Text = txtAutor.Text;
            formDocumentos.Show();
        }

        private void btnGerarDocumentos_Click(object sender, EventArgs e)
        {
            FormSelecionarDocumento formSelecionarDocumento = new FormSelecionarDocumento();
            formSelecionarDocumento.txtIDAutor.Text = txtCadNumero.Text;
            formSelecionarDocumento.txtAutor.Text = txtAutor.Text;
            formSelecionarDocumento.txtNacionalidade.Text = txtNacionalidade.Text;
            formSelecionarDocumento.cboxEstadoCivil.Text = cboxEstadoCivil.Text;
            formSelecionarDocumento.txtRG.Text = txtRG.Text;
            formSelecionarDocumento.txtCPF.Text = txtCPF.Text;
            formSelecionarDocumento.txtDataNascimento.Text = txtDataNascimento.Text;
            formSelecionarDocumento.txtEmail.Text = txtEmail.Text;
            formSelecionarDocumento.txtTelefone1.Text = txtTelefone1.Text;
            formSelecionarDocumento.txtTelefone2.Text = txtTelefone2.Text;
            formSelecionarDocumento.txtCEP.Text = txtCEP.Text;
            formSelecionarDocumento.txtLogradouro.Text = txtLogradouro.Text;
            formSelecionarDocumento.txtNumero.Text = txtNumero.Text;
            formSelecionarDocumento.txtComplemento.Text = txtComplemento.Text;
            formSelecionarDocumento.txtBairro.Text = txtBairro.Text;
            formSelecionarDocumento.txtCidade.Text = txtCidade.Text;
            formSelecionarDocumento.txtEstado.Text = txtEstado.Text;
            formSelecionarDocumento.txtReu.Text = txtReu.Text;
            formSelecionarDocumento.txtCNPJ.Text = txtCNPJ.Text;
            formSelecionarDocumento.txtTelefoneReu.Text = txtTelefoneReu.Text;
            formSelecionarDocumento.txtCEPReu.Text = txtCEPReu.Text;
            formSelecionarDocumento.txtLogradouroReu.Text = txtLogradouroReu.Text;
            formSelecionarDocumento.txtNumeroReu.Text = txtNumeroReu.Text;
            formSelecionarDocumento.txtComplementoReu.Text = txtComplementoReu.Text;
            formSelecionarDocumento.txtBairroReu.Text = txtBairroReu.Text;
            formSelecionarDocumento.txtCidadeReu.Text = txtCidadeReu.Text;
            formSelecionarDocumento.txtEstadoReu.Text = txtEstadoReu.Text;
            formSelecionarDocumento.txtProcesso.Text = txtProcesso.Text;
            formSelecionarDocumento.cboxTipoProcesso.Text = cboxTipoProcesso.Text;
            formSelecionarDocumento.txtIdProcesso.Text = txtIdProcesso.Text;
            formSelecionarDocumento.cboxStatusProcesso.Text = cboxStatusProcesso.Text;
            formSelecionarDocumento.txtNatProcesso.Text = txtNatProcesso.Text;
            formSelecionarDocumento.txtAssunto1.Text = txtAssunto1.Text;
            formSelecionarDocumento.txtAssunto2.Text = txtAssunto2.Text;
            formSelecionarDocumento.txtAssunto3.Text = txtAssunto3.Text;
            formSelecionarDocumento.txtDataPericia.Text = txtDataPericia.Text;
            formSelecionarDocumento.txtTipoAudiencia.Text = txtTipoAudiencia.Text;
            formSelecionarDocumento.txtDataAudiencia.Text = txtDataAudiencia.Text;
            formSelecionarDocumento.txtObservacao.Text = txtObservacao.Text;




            formSelecionarDocumento.Show();

            //FormGerarDocumentos formGerarDocumentos = new FormGerarDocumentos();
            //formGerarDocumentos.txtIDCliente.Text = txtCadNumero.Text;
            //formGerarDocumentos.Show();

        }
    }
}
