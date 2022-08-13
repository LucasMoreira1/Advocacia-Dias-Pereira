using System;
using System.Data;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;

namespace Advocacia_Dias_Pereira
{
    public partial class FormCadastro : Form
    {
        public Boolean CameraOn = false;
        public string localizacaoFoto;
        public FormCadastro()
        {
            InitializeComponent();
            ResetMe();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Bitmap bitmap;

        private void ResetMe()
        {
            //Zerar comboBox identificação cliente
            
            cboxEstadoCivil.SelectedIndex = -1;
            

            

            //Limpar campos identificação cliente
            txtNome.Text = "";
            txtRG.Text = "";
            
            txtDataNascimento.Text = "";
            txtTelefone.Text = "";
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


            //MemoryStream ms = new MemoryStream();
            //if (imgCamera.Image == null)
            //{
            //    imgCamera.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //}
            //else
            //{
            //    imgCamera.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //}


            //byte[] img = ms.GetBuffer();


            CRUD.cmd.Parameters.AddWithValue("Autor", txtNome.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("rg", txtRG.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("orgemissor", txtOrgEmissor.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("cpf", txtCPF.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("passaporte", txtPassaporte.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("estadocivil", cboxEstadoCivil.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("datanascimento", txtDataNascimento.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("telefone", txtTelefone.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("email", txtEmail.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("nacionalidade", txtNacionalidade.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("datacasamento", txtDataCasamento.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("pet", cboxPet.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("cep", txtCEP.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("numero", txtNumero.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("complemento", txtComplemento.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("bairro", txtBairro.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("cidade", txtCidade.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("estado", txtEstado.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("observacao", txtObservacao.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("foto", img);
            //CRUD.cmd.Parameters.AddWithValue("data_cadastro", txtDataCadastro.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("Cad_numero", txtCadNumero.Text.Trim());

            //CRUD.cmd.Parameters.AddWithValue("nomeDependente", txtNomeDependente.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("RGDependente", txtRGDependente.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("orgemissordependente", txtOrgEmissorDependente.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("CPFDependente", txtCPFDependente.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("PassaporteDependente", txtPassaporteDependente.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("certidaonascimento", txtCertidaoNascimentoDependente.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("GrauParentesco", cboxGrauParentesco.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("DataNascimentoDependente", txtDataNascimentoDependente.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("autorizacao", cboxAutorizacaoDependente.Text.Trim());


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO CADASTRO(autor)" +
                "Values(@autor);";


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


            //loadData("");
            //ResetMe();
            pesquisaCPF();
            //formPaginaInicial formPaginaInicial = new formPaginaInicial();
            //formPaginaInicial.btnPaginaInicial.PerformClick();
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


            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "UPDATE CADASTRO SET nome = @nome, rg = @rg, orgemissor = @orgemissor, cpf = @cpf, " +
                "passaporte = @passaporte, estadocivil = @estadocivil, datanascimento = @datanascimento," +
                "telefone = @telefone, email = @email,nacionalidade = @nacionalidade, datacasamento = @datacasamento," +
                "pet = @pet, cep = @cep, logradouro = @logradouro, numero = @numero, " +
                "complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado," +
                "observacao = @observacao, foto = @foto, datacadastro = @data_cadastro WHERE CadNumero = @Cad_numero";


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

            if (string.IsNullOrEmpty(txtNome.Text.Trim()) ||
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

            //FormDependentes formDependentes = new FormDependentes();
            //formDependentes.txtCadReferencia.Text = txtCadNumero.Text;
            //formDependentes.txtNomeReferencia.Text = txtNome.Text;
            //formDependentes.Show();

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
            
            txtTelefone.SelectionStart = 0;
            
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
                txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                //txtOrgEmissor.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                //txtPassaporte.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                //txtDataCasamento.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                //cboxPet.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
                txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
                txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                //MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[20].Value);
                //imgCamera.Image = Image.FromStream(ms);
                txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
                txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);

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

                txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                //txtOrgEmissor.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                //txtPassaporte.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                //txtDataCasamento.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                //cboxPet.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
                txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
                txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                //MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[20].Value);
                //imgCamera.Image = Image.FromStream(ms);
                txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
                txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);

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
    }
}
