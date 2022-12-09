using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Advocacia_Dias_Pereira
{
    public partial class FormCadastro : Form
    {
        public Boolean CameraOn = false;
        public string localizacaoFoto;
        string filename = "";
        string filename2 = "";
        string NumeroRegistro = "";
        bool txtautor_changed = false;
        bool txtDataCadastro_changed = false;
        bool txtNacionalidade_changed = false;
        bool cboxEstadoCivil_changed = false;
        bool txtProfissao_changed = false;
        bool txtRG_changed = false;
        bool txtCPF_changed = false;
        bool txtDataNascimento_changed = false;
        bool txtTelefone1_changed = false;
        bool txtTelefone2_changed = false;
        bool txtEmail_changed = false;
        bool txtCEP_changed = false;
        bool txtLogradouro_changed = false;
        bool txtNumero_changed = false;
        bool txtComplemento_changed = false;
        bool txtBairro_changed = false;
        bool txtCidade_changed = false;
        bool txtEstado_changed = false;
        bool txtReu_changed = false;
        bool txtCNPJ_changed = false;
        bool txtTelefoneReu_changed = false;
        bool txtCEPReu_changed = false;
        bool txtLogradouroReu_changed = false;
        bool txtNumeroReu_changed = false;
        bool txtComplementoReu_changed = false;
        bool txtBairroReu_changed = false;
        bool txtCidadeReu_changed = false;
        bool txtEstadoReu_changed = false;
        bool txtProcesso_changed = false;
        bool txtIdProcesso_changed = false;
        bool txtNatProcesso_changed = false;
        bool txtAssunto1_changed = false;
        bool txtAssunto2_changed = false;
        bool txtAssunto3_changed = false;
        bool cboxTipoProcesso_changed = false;
        bool cboxStatusProcesso_changed = false;
        bool cboxResultado_changed = false;
        bool txtDataPericia_changed = false;
        bool txtTipoAudiencia_changed = false;
        bool txtDataAudiencia_changed = false;
        bool txtObservacao_changed = false;
        bool cboxEscritorio_changed = false;
        bool txtDataEncerramento_changed = false;

        MySqlDataReader reader;
        public static MySqlCommand cmd = default(MySqlCommand);

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
            txtNomeDocumento.Text = nomedocumento;
            
            CRUD.cmd.Parameters.AddWithValue("Documento", contents);

            CRUD.cmd.Parameters.AddWithValue("Nome_Documento", nomedocumento.Trim());
            SEMDOCUMENTO:

            //Identificação Autor
            //CRUD.cmd.Parameters.AddWithValue("ID_CADASTRO", txtCadNumero.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("NOME_CADASTRO", txtAutor.Text.Trim());
            //Informações Gerais
            CRUD.cmd.Parameters.AddWithValue("DATA_ATUALIZACAO", Convert.ToDateTime(DateTime.Now));
            //Informações Gerais
            if(txtDataCadastro.Text != "  /  /")
            {
                CRUD.cmd.Parameters.AddWithValue("DataCadastro", Convert.ToDateTime(txtDataCadastro.Text));
            }
            else
            { 
                CRUD.cmd.Parameters.AddWithValue("DataCadastro", txtDataCadastro.Text);
            }

            

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
            CRUD.cmd.Parameters.AddWithValue("Resultado", cboxResultado.Text.Trim());

            //Outros
            CRUD.cmd.Parameters.AddWithValue("observacao", txtObservacao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Escritorio", cboxEscritorio.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("DataEncerramento", txtDataEncerramento.Text.Trim());
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
                "datapericia, tipoaudiencia, dataaudiencia, observacao, DataCadastro, Resultado, Escritorio, DataEncerramento)" +
                "Values(@autor, @nacionalidade, @estadocivil, @profissao, @rg, @cpf, @datanascimento, @email, " +
                "@telefone1, @telefone2, @cepautor, @logradouroautor, @numeroautor, @complementoautor, @bairroautor, @cidadeautor, @estadoautor, @reu, @cnpj, " +
                "@telefoneReu, @cepReu, @logradouroReu, @numeroReu, @complementoReu, @bairroReu, @cidadeReu, @estadoReu, " +
                "@processo, @tipoprocesso, @idprocesso, @statusprocesso, @natprocesso, @assunto1, @assunto2, @assunto3, " +
                "@datapericia, @tipoaudiencia, @dataaudiencia, @observacao, @DataCadastro, @Resultado, @Escritorio, @DataEncerramento);";


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

            //Logger.WriteLog("Cliente registrado: " + NumeroRegistro, txtNomeLogin.Text);
            //CRIAÇÃO DE LOG

            string dir = Path.GetTempPath();
            filename = dir + NumeroRegistro + "_" + txtAutor.Text + ".txt";
            //Logger.WriteLog(filename, "Cadastro: " + NumeroRegistro + "_" + txtAutor.Text + " criado;", txtNomeLogin.Text);
            //FileStream fileStream2 = File.OpenRead(filename);
            //byte[] contents2 = new byte[fileStream2.Length];
            //fileStream2.Read(contents2, 0, (int)contents2.Length);
            //fileStream2.Close();

            //informações para o Log
            //CRUD.cmd.Parameters.AddWithValue("LOG_FILE", contents2);
            //CRUD.cmd.Parameters.AddWithValue("ID_CADASTRO", NumeroRegistro);

            //Validar se já existe aquivo LOG
            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + NumeroRegistro  + ";";
            
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                //Baixar Documento de LOG
                bool em = false;
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + NumeroRegistro+ ";";
                CRUD.con.Open();
                using (CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con))
                {
                    using (reader = CRUD.cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            em = true;
                            byte[] fileData = (byte[])reader.GetValue(0);
                            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
                            {
                                using (BinaryWriter bw = new BinaryWriter(fs))
                                {
                                    bw.Write(fileData);
                                    bw.Close();

                                }
                            }

                        }
                    }
                }
                CRUD.con.Close();
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Cadastro: " + NumeroRegistro + "_"+ txtAutor.Text + " criado;", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = "+NumeroRegistro+"";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Cadastro: " + NumeroRegistro  + "_" + txtAutor.Text + " criado;", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values("+NumeroRegistro+ ", @NOME_CADASTRO, @Documento, @DATA_ATUALIZACAO)";
                Executar(CRUD.sql, "Insert");
            }
            txtCadNumero.Text = NumeroRegistro;

            //Criação do LOG GERAL
            string dir2 = Path.GetTempPath();
            filename = dir2 + "9999_LOG_LOGIN.txt";
            //Validar se já existe aquivo LOG
            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = '9999';";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt2 = CRUD.PerformCRUD(CRUD.cmd);

            if (dt2.Rows.Count > 0)
            {
                //Baixar Documento de LOG
                bool em = false;
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = '9999';";
                CRUD.con.Open();
                using (CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con))
                {
                    using (reader = CRUD.cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            em = true;
                            byte[] fileData = (byte[])reader.GetValue(0);
                            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
                            {
                                using (BinaryWriter bw = new BinaryWriter(fs))
                                {
                                    bw.Write(fileData);
                                    bw.Close();

                                }
                            }

                        }
                    }
                }
                CRUD.con.Close();
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Criou o cadastro: " + txtCadNumero.Text + ";", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Criou o cadastro: " + txtCadNumero.Text + ";", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values('9999', @LOG_LOGIN, @Documento, @DATA_ATUALIZACAO)";
                Executar(CRUD.sql, "Insert");
            }

            MessageBox.Show("Cliente registrado. ID número: " + NumeroRegistro + ".", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            btnSalvar.Visible = false;
            btnAtualizar.Visible = true;
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
                "dataaudiencia = @dataaudiencia, observacao = @observacao, DataCadastro = @DataCadastro, Resultado = @Resultado, Escritorio = @Escritorio, DataEncerramento = @DataEncerramento WHERE ID = @CadNumero";

            Executar(CRUD.sql, "Update");

            //CRIAÇÃO DE LOG
            string dir = Path.GetTempPath();
            filename = dir + txtCadNumero.Text + "_" + txtAutor.Text + ".txt";
            //Validar se já existe aquivo LOG
            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtCadNumero.Text + ";";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                //Baixar Documento de LOG
                bool em = false;
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtCadNumero.Text + ";";
                CRUD.con.Open();
                using (CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con))
                {
                    using (reader = CRUD.cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            em = true;
                            byte[] fileData = (byte[])reader.GetValue(0);
                            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
                            {
                                using (BinaryWriter bw = new BinaryWriter(fs))
                                {
                                    bw.Write(fileData);
                                    bw.Close();

                                }
                            }

                        }
                    }
                }
                CRUD.con.Close();
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + "_" + txtAutor.Text + " atualizado;", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = "+txtCadNumero.Text+"";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text +"_"+ txtAutor.Text + " atualizado;", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values("+txtCadNumero.Text+", @NOME_CADASTRO, @Documento, @DATA_ATUALIZACAO)";
                Executar(CRUD.sql, "Insert");
            }

            //Criação do LOG GERAL
            string dir2 = Path.GetTempPath();
            filename = dir2 + "9999_LOG_LOGIN.txt";
            //Validar se já existe aquivo LOG
            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = '9999';";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt2 = CRUD.PerformCRUD(CRUD.cmd);

            if (dt2.Rows.Count > 0)
            {
                //Baixar Documento de LOG
                bool em = false;
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = '9999';";
                CRUD.con.Open();
                using (CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con))
                {
                    using (reader = CRUD.cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            em = true;
                            byte[] fileData = (byte[])reader.GetValue(0);
                            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
                            {
                                using (BinaryWriter bw = new BinaryWriter(fs))
                                {
                                    bw.Write(fileData);
                                    bw.Close();

                                }
                            }

                        }
                    }
                }
                CRUD.con.Close();
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Atualizou o Cadastro: " + txtCadNumero.Text + ";", txtNomeLogin.Text);

                if (txtautor_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Nome Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtDataCadastro_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Data Cadastro.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtNacionalidade_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Nacionalidade Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (cboxEstadoCivil_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Estado Civil Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtProfissao_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Profissão Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtRG_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: RG Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtCPF_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: CPF Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtDataNascimento_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Data Nascimento Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtTelefone1_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Telefone 1 Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtTelefone2_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Telefone 2 Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtEmail_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Email Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtCEP_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: CEP Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtLogradouro_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Logradouro Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtNumero_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Número Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtComplemento_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Complemento Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtBairro_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Bairro Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtCidade_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Cidade Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtEstado_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Estado Autor.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Nome Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtCNPJ_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: CPF/CNPJ Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtTelefoneReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Telefone Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtCEPReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: CEP Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtLogradouroReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Logradouro Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtNumeroReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Número Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtComplementoReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Complemento Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtBairroReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Bairro Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtCidadeReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Cidade Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtEstadoReu_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Estado Réu.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtProcesso_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Processo.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtIdProcesso_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: ID Processo.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtNatProcesso_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Natureza do Processo.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtAssunto1_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Assunto 1.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtAssunto2_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Assunto 2.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtAssunto3_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Assunto 3.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (cboxTipoProcesso_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Tipo Processo.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (cboxStatusProcesso_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Status Processo.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (cboxResultado_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Resultado Processo.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtDataPericia_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Data Perícia.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtTipoAudiencia_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Tipo Audiência.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtDataAudiencia_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Data Audiência.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtObservacao_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Observação.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (cboxEscritorio_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Escritório.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }
                if (txtDataEncerramento_changed == true)
                {
                    Logger.WriteLog(filename, "Cadastro: " + txtCadNumero.Text + ", Campo: Data Encerramento.", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                    Executar(CRUD.sql, "Update");
                }


            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Atualizou o Cadastro: " + txtCadNumero.Text + ";", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values('9999', @LOG_LOGIN, @Documento, @DATA_ATUALIZACAO)";
                Executar(CRUD.sql, "Insert");
            }

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
        //public void pesquisaRG()
        //{

        //    CRUD.sql = "SELECT * FROM CADASTRO WHERE RG LIKE '" + txtRG.Text.Trim() + "'";

        //    CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
        //    DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
        //    DataGridView dgv = dataGridView1;

        //    dgv.Visible = true;
        //    dgv.MultiSelect = false;
        //    dgv.AutoGenerateColumns = true;
        //    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgv.DataSource = dt;
        //    //dgv.Columns["Foto"].Visible = false;
        //    dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        //    btnSalvar.Visible = false;
        //    btnAtualizar.Visible = true;

        //    if (dgv.CurrentRow == null)
        //    {
        //        dgv.Visible = false;
        //        MessageBox.Show("Não há cliente registrado com esse RG.");
        //    }
        //    else
        //    {
        //        txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
        //        txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
        //        txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
        //        cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
        //        txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
        //        txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
        //        txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
        //        txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
        //        txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
        //        txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
        //        txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
        //        txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
        //        txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
        //        txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
        //        txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
        //        txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
        //        txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
        //        txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
        //        txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
        //        txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
        //        txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
        //        txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
        //        txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
        //        txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
        //        txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[25].Value);
        //        txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
        //        txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[27].Value);
        //        txtProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[28].Value);
        //        cboxTipoProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[29].Value);
        //        txtIdProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[30].Value);
        //        cboxStatusProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[31].Value);
        //        txtNatProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[32].Value);
        //        txtAssunto1.Text = Convert.ToString(dgv.CurrentRow.Cells[33].Value);
        //        txtAssunto2.Text = Convert.ToString(dgv.CurrentRow.Cells[34].Value);
        //        txtAssunto3.Text = Convert.ToString(dgv.CurrentRow.Cells[35].Value);
        //        txtDataPericia.Text = Convert.ToString(dgv.CurrentRow.Cells[36].Value);
        //        txtTipoAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[37].Value);
        //        txtDataAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[38].Value);
        //        txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[39].Value);

        //        dgv.Visible = false;
        //        MessageBox.Show("Cliente localizado.");
        //    }


        //}

        //private void PesquisarRG(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        pesquisaRG();
        //    }
        //}
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

            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "Todos arquivos (*) | *.*", ValidateNames = true, Multiselect=true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Tem certeza que deseja subir esse(s) documento(s)?", "Envio para núvem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        foreach (String file in dlg.FileNames)
                        {
                            filename = file.ToString();
                            filename2 = Path.GetFileName(filename);

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

                            //CRIAÇÃO DE LOG
                            string dir = Path.GetTempPath();
                            filename = dir + txtCadNumero.Text + "_" + txtAutor.Text + ".txt";
                            //Validar se já existe aquivo LOG
                            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtCadNumero.Text + ";";

                            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

                            if (dt.Rows.Count > 0)
                            {
                                //Baixar Documento de LOG
                                bool em = false;
                                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtCadNumero.Text + ";";
                                CRUD.con.Open();
                                using (CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con))
                                {
                                    using (reader = CRUD.cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            em = true;
                                            byte[] fileData = (byte[])reader.GetValue(0);
                                            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
                                            {
                                                using (BinaryWriter bw = new BinaryWriter(fs))
                                                {
                                                    bw.Write(fileData);
                                                    bw.Close();

                                                }
                                            }

                                        }
                                    }
                                }
                                CRUD.con.Close();
                                //Escrever no Documento de LOG
                                Logger.WriteLog(filename, "Anexou o documento: " + txtNomeDocumento.Text + ";", txtNomeLogin.Text);
                                //Atualiza Log existente
                                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = " + txtCadNumero.Text + "";
                                Executar(CRUD.sql, "Update");
                            }
                            else
                            {
                                //Escrever no Documento de LOG
                                Logger.WriteLog(filename, "Anexou o documento: " + txtNomeDocumento.Text + ";", txtNomeLogin.Text);
                                //Salvar Documento de LOG
                                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                                            "Values(" + txtCadNumero + ", @NOME_CADASTRO, @Documento, @DATA_ATUALIZACAO)";
                                Executar(CRUD.sql, "Insert");
                            }

                            //Criação do LOG GERAL
                            string dir2 = Path.GetTempPath();
                            filename = dir2 + "9999_LOG_LOGIN.txt";
                            //Validar se já existe aquivo LOG
                            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = '9999';";

                            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                            DataTable dt2 = CRUD.PerformCRUD(CRUD.cmd);

                            if (dt2.Rows.Count > 0)
                            {
                                //Baixar Documento de LOG
                                bool em = false;
                                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = '9999';";
                                CRUD.con.Open();
                                using (CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con))
                                {
                                    using (reader = CRUD.cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            em = true;
                                            byte[] fileData = (byte[])reader.GetValue(0);
                                            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
                                            {
                                                using (BinaryWriter bw = new BinaryWriter(fs))
                                                {
                                                    bw.Write(fileData);
                                                    bw.Close();

                                                }
                                            }

                                        }
                                    }
                                }
                                CRUD.con.Close();
                                //Escrever no Documento de LOG
                                Logger.WriteLog(filename, "Anexou um documento no cadastro: " + txtCadNumero.Text + ";", txtNomeLogin.Text);
                                //Atualiza Log existente
                                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @Documento, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                                Executar(CRUD.sql, "Update");
                            }
                            else
                            {
                                //Escrever no Documento de LOG
                                Logger.WriteLog(filename, "Anexou um documento no cadastro: " + txtCadNumero.Text + ";", txtNomeLogin.Text);
                                //Salvar Documento de LOG
                                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                                            "Values('9999', @LOG_LOGIN, @Documento, @DATA_ATUALIZACAO)";
                                Executar(CRUD.sql, "Insert");
                            }
                            //Logger.WriteLog("Anexou o documento: " + txtNomeDocumento.Text, txtNomeLogin.Text);
                            
                        }
                        MessageBox.Show("Documento(s) salvo(s).", "Envio Documento",
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
            formDocumentos.txtNomeLogin.Text = txtNomeLogin.Text;
            formDocumentos.txtCadCliente.Text = txtCadNumero.Text;
            formDocumentos.txtNomeCliente.Text = txtAutor.Text;
            formDocumentos.Show();
        }

        private void btnGerarDocumentos_Click(object sender, EventArgs e)
        {
            FormSelecionarDocumento formSelecionarDocumento = new FormSelecionarDocumento();
            formSelecionarDocumento.txtNomeLogin.Text = txtNomeLogin.Text;
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
            formSelecionarDocumento.cboxResultado.Text = cboxResultado.Text;



            formSelecionarDocumento.Show();

            //FormGerarDocumentos formGerarDocumentos = new FormGerarDocumentos();
            //formGerarDocumentos.txtIDCliente.Text = txtCadNumero.Text;
            //formGerarDocumentos.Show();

        }

        private void btnVisualizarLog_Click(object sender, EventArgs e)
        {
            FormVisualizarLog formVisualizarLog = new FormVisualizarLog();
            formVisualizarLog.txtIDCadastro.Text = txtCadNumero.Text;
            formVisualizarLog.txtNomeAutor.Text = txtAutor.Text;
            formVisualizarLog.Show();

        }
        #region Textbox Changed
        private void FormCadastro_Load_1(object sender, EventArgs e)
        {
            txtautor_changed = false;
            txtDataCadastro_changed = false;
            txtNacionalidade_changed = false;
            cboxEstadoCivil_changed = false;
            txtProfissao_changed = false;
            txtRG_changed = false;
            txtCPF_changed = false;
            txtDataNascimento_changed = false;
            txtTelefone1_changed = false;
            txtTelefone2_changed = false;
            txtEmail_changed = false;
            txtCEP_changed = false;
            txtLogradouro_changed = false;
            txtNumero_changed = false;
            txtComplemento_changed = false;
            txtBairro_changed = false;
            txtCidade_changed = false;
            txtEstado_changed = false;
            txtReu_changed = false;
            txtCNPJ_changed = false;
            txtTelefoneReu_changed = false;
            txtCEPReu_changed = false;
            txtLogradouroReu_changed = false;
            txtNumeroReu_changed = false;
            txtComplementoReu_changed = false;
            txtBairroReu_changed = false;
            txtCidadeReu_changed = false;
            txtEstadoReu_changed = false;
            txtProcesso_changed = false;
            txtIdProcesso_changed = false;
            txtNatProcesso_changed = false;
            txtAssunto1_changed = false;
            txtAssunto2_changed = false;
            txtAssunto3_changed = false;
            cboxTipoProcesso_changed = false;
            cboxStatusProcesso_changed = false;
            cboxResultado_changed = false;
            txtDataPericia_changed = false;
            txtTipoAudiencia_changed = false;
            txtDataAudiencia_changed = false;
            txtObservacao_changed = false;
            txtDataEncerramento_changed = false;

            if (txtPermissaoLogin.Text == "2")
            {
                btnVisualizarLog.Visible = false;
            }
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            txtautor_changed = true;
        }

        private void txtDataCadastro_TextChanged(object sender, EventArgs e)
        {
            txtDataCadastro_changed = true;
        }

        private void txtNacionalidade_TextChanged(object sender, EventArgs e)
        {
            txtNacionalidade_changed = true;
        }

        private void cboxEstadoCivil_TextChanged(object sender, EventArgs e)
        {
            cboxEstadoCivil_changed = true;
        }

        private void txtProfissao_TextChanged(object sender, EventArgs e)
        {
            txtProfissao_changed = true;
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            txtRG_changed = true;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtCPF_changed = true;
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            txtDataNascimento_changed = true;
        }

        private void txtTelefone1_TextChanged(object sender, EventArgs e)
        {
            txtTelefone1_changed = true;
        }

        private void txtTelefone2_TextChanged(object sender, EventArgs e)
        {
            txtTelefone2_changed = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail_changed = true;
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            txtCEP_changed = true;
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            txtLogradouro_changed = true;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero_changed = true;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            txtComplemento_changed = true;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro_changed = true;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade_changed = true;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            txtEstado_changed = true;
        }

        private void txtReu_TextChanged(object sender, EventArgs e)
        {
            txtReu_changed = true;
        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {
            txtCNPJ_changed = true;
        }

        private void txtTelefoneReu_TextChanged(object sender, EventArgs e)
        {
            txtTelefoneReu_changed = true;
        }

        private void txtCEPReu_TextChanged(object sender, EventArgs e)
        {
            txtCEPReu_changed = true;
        }

        private void txtLogradouroReu_TextChanged(object sender, EventArgs e)
        {
            txtLogradouroReu_changed = true;
        }

        private void txtNumeroReu_TextChanged(object sender, EventArgs e)
        {
            txtNumeroReu_changed = true;
        }

        private void txtComplementoReu_TextChanged(object sender, EventArgs e)
        {
            txtComplementoReu_changed = true;
        }

        private void txtBairroReu_TextChanged(object sender, EventArgs e)
        {
            txtBairroReu_changed = true;
        }

        private void txtCidadeReu_TextChanged(object sender, EventArgs e)
        {
            txtCidadeReu_changed = true;
        }

        private void txtEstadoReu_TextChanged(object sender, EventArgs e)
        {
            txtEstadoReu_changed = true;
        }

        private void txtProcesso_TextChanged(object sender, EventArgs e)
        {
            txtProcesso_changed = true;
        }

        private void txtIdProcesso_TextChanged(object sender, EventArgs e)
        {
            txtIdProcesso_changed = true;
        }

        private void txtNatProcesso_TextChanged(object sender, EventArgs e)
        {
            txtNatProcesso_changed = true;
        }

        private void txtAssunto1_TextChanged(object sender, EventArgs e)
        {
            txtAssunto1_changed = true;
        }

        private void txtAssunto2_TextChanged(object sender, EventArgs e)
        {
            txtAssunto2_changed = true;
        }

        private void txtAssunto3_TextChanged(object sender, EventArgs e)
        {
            txtAssunto3_changed = true;
        }

        private void cboxTipoProcesso_TextChanged(object sender, EventArgs e)
        {
            cboxTipoProcesso_changed = true;
        }

        private void cboxStatusProcesso_TextChanged(object sender, EventArgs e)
        {
            cboxStatusProcesso_changed = true;
        }

        private void cboxResultado_TextChanged(object sender, EventArgs e)
        {
            cboxResultado_changed = true;
        }

        private void txtDataPericia_TextChanged(object sender, EventArgs e)
        {
            txtDataPericia_changed = true;
        }

        private void txtTipoAudiencia_TextChanged(object sender, EventArgs e)
        {
            txtTipoAudiencia_changed = true;
        }

        private void txtDataAudiencia_TextChanged(object sender, EventArgs e)
        {
            txtDataAudiencia_changed = true;
        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {
            txtObservacao_changed = true;
        }
        #endregion

        private void cboxEscritorio_TextChanged(object sender, EventArgs e)
        {
            cboxEscritorio_changed = true;
        }

        private void txtDataEncerramento_TextChanged(object sender, EventArgs e)
        {
            txtDataEncerramento_changed = true;
        }

        private void btnAdicionarAutorAdicional_Click(object sender, EventArgs e)
        {
            FormAutorAdicional formAutorAdicional = new FormAutorAdicional();
            formAutorAdicional.txtCadNumero.Text = txtCadNumero.Text;
            formAutorAdicional.Show();
        }

        private void btnAdicionarReuAdicional_Click(object sender, EventArgs e)
        {
            FormReuAdicional formReuAdicional = new FormReuAdicional();
            formReuAdicional.txtCadNumero.Text = txtCadNumero.Text;
            formReuAdicional.Show();
        }

        private void btnVisualizarAutorAdicional_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadNumero.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Número de Cadastro", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormVisualizarAutorAdicional formVisualizarAutorAdicional = new FormVisualizarAutorAdicional();
            formVisualizarAutorAdicional.txtCadReferencia.Text = txtCadNumero.Text;
            formVisualizarAutorAdicional.txtAutor.Text = txtAutor.Text;
            formVisualizarAutorAdicional.Show();
        }

        private void btnVisualizarReuAdicional_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadNumero.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Número de Cadastro", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormVisualizarReuAdicional formVisualizarReuAdicional = new FormVisualizarReuAdicional();
            formVisualizarReuAdicional.txtCadReferencia.Text = txtCadNumero.Text;
            formVisualizarReuAdicional.txtReu.Text = txtAutor.Text;
            formVisualizarReuAdicional.Show();
        }
    }
}
