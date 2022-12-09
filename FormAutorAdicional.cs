using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace Advocacia_Dias_Pereira
{
    public partial class FormAutorAdicional : Form
    {
        public FormAutorAdicional()
        {
            InitializeComponent();
        }

        private void FormAutorAdicional_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = Convert.ToString(DateTime.Now);
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

            //Identificação Autor
            CRUD.cmd.Parameters.AddWithValue("CadNumero", txtCadNumero.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("autor", txtAutor.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nacionalidade", txtNacionalidade.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estadocivil", cboxEstadoCivil.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("profissao", txtProfissao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("rg", txtRG.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cpf", txtCPF.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cnpj", txtCNPJ.Text.Trim());
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

            //Outros
            CRUD.cmd.Parameters.AddWithValue("observacao", txtObservacao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Data_Cadastro", txtDataCadastro.Text.Trim());
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAutor.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO AUTOR_ADICIONAL(id_cadastro, autor, nacionalidade, estado_civil, profissao, rg, cpf, cnpj, data_nascimento, email, " +
                "telefone1, telefone2, cep, logradouro, numero, complemento, bairro, cidade, estado, observacao, Data_Cadastro)" +
                "Values(@CadNumero, @autor, @nacionalidade, @estadocivil, @profissao, @rg, @cpf, @cnpj, @datanascimento, @email, " +
                "@telefone1, @telefone2, @cepautor, @logradouroautor, @numeroautor, @complementoautor, @bairroautor, @cidadeautor, @estadoautor, @observacao, @Data_Cadastro);";


            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Autor Adicional registrado.", "Cadastro Autor Adicional",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PesquisarCPF(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaCPF();
            }
        }

        private void PesquisarCNPJ(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaCNPJ();
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

            //btnSalvar.Visible = false;
            //btnAtualizar.Visible = true;
            if (dgv.CurrentRow == null)
            {
                dgv.Visible = false;
                MessageBox.Show("Não há cliente registrado com esse CPF.");

            }
            else
            {

                //txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                txtProfissao.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                //txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);

                //txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
                //txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                //txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
                //txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
                //txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
                //txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
                //txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
                //txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[25].Value);
                //txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
                //txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[27].Value);
                //txtProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[28].Value);
                //cboxTipoProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[29].Value);
                //txtIdProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[30].Value);
                //cboxStatusProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[31].Value);
                //txtNatProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[32].Value);
                //txtAssunto1.Text = Convert.ToString(dgv.CurrentRow.Cells[33].Value);
                //txtAssunto2.Text = Convert.ToString(dgv.CurrentRow.Cells[34].Value);
                //txtAssunto3.Text = Convert.ToString(dgv.CurrentRow.Cells[35].Value);
                //txtDataPericia.Text = Convert.ToString(dgv.CurrentRow.Cells[36].Value);
                //txtTipoAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[37].Value);
                //txtDataAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[38].Value);
                //txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[45].Value);
                //txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[46].Value);
                //cboxResultado.Text = Convert.ToString(dgv.CurrentRow.Cells[47].Value);
                //cboxEscritorio.Text = Convert.ToString(dgv.CurrentRow.Cells[48].Value);
                //txtDataEncerramento.Text = Convert.ToString(dgv.CurrentRow.Cells[49].Value);
                txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[50].Value);



                dgv.Visible = false;
                //MessageBox.Show("Cliente localizado.");
            }


        }
        public void pesquisaCNPJ()
        {

            CRUD.sql = "SELECT * FROM CADASTRO WHERE CNPJAutor LIKE '" + txtCNPJ.Text.Trim() + "'";

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

            //btnSalvar.Visible = false;
            //btnAtualizar.Visible = true;
            if (dgv.CurrentRow == null)
            {
                dgv.Visible = false;
                MessageBox.Show("Não há cliente registrado com esse CNPJ.");

            }
            else
            {

                //txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                txtProfissao.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                //txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);

                //txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
                //txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                //txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
                //txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
                //txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
                //txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
                //txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
                //txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[25].Value);
                //txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
                //txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[27].Value);
                //txtProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[28].Value);
                //cboxTipoProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[29].Value);
                //txtIdProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[30].Value);
                //cboxStatusProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[31].Value);
                //txtNatProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[32].Value);
                //txtAssunto1.Text = Convert.ToString(dgv.CurrentRow.Cells[33].Value);
                //txtAssunto2.Text = Convert.ToString(dgv.CurrentRow.Cells[34].Value);
                //txtAssunto3.Text = Convert.ToString(dgv.CurrentRow.Cells[35].Value);
                //txtDataPericia.Text = Convert.ToString(dgv.CurrentRow.Cells[36].Value);
                //txtTipoAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[37].Value);
                //txtDataAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[38].Value);
                //txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[45].Value);
                //txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[46].Value);
                //cboxResultado.Text = Convert.ToString(dgv.CurrentRow.Cells[47].Value);
                //cboxEscritorio.Text = Convert.ToString(dgv.CurrentRow.Cells[48].Value);
                //txtDataEncerramento.Text = Convert.ToString(dgv.CurrentRow.Cells[49].Value);
                txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[50].Value);



                dgv.Visible = false;
                //MessageBox.Show("Cliente localizado.");
            }


        }
    }
}
