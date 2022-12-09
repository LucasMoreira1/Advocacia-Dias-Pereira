using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Advocacia_Dias_Pereira
{
    public partial class FormReuAdicional : Form
    {
        public FormReuAdicional()
        {
            InitializeComponent();
        }

        private void FormReuAdicional_Load(object sender, EventArgs e)
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

            //Outros
            CRUD.cmd.Parameters.AddWithValue("observacao", txtObservacao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("Data_Cadastro", txtDataCadastro.Text.Trim());
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReu.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO REU_ADICIONAL(Data_Cadastro, id_cadastro, reu, cnpjcpf, telefone_reu, cep_reu, logradouro_reu, numero_reu, complemento_reu," +
                "bairro_reu, cidade_reu, estado_reu, observacao_reu)" +
                "Values(@Data_Cadastro, @CadNumero, @Reu, @cnpj, @telefoneReu, @cepReu, @logradouroReu, @numeroReu, @complementoReu, @bairroReu," +
                "@cidadeReu, @estadoReu, @observacao);";


            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Réu Adicional registrado.", "Cadastro Réu Adicional",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PesquisarCNPJ(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaCNPJReu();
            }
        }
        public void pesquisaCNPJReu()
        {

            CRUD.sql = "SELECT * FROM CADASTRO WHERE CNPJCPF LIKE '" + txtCNPJ.Text.Trim() + "'";

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
                //txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                //txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                //cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                //txtProfissao.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                //txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                //txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                //txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                //txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                //txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                //txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                //txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                //txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                //txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                //txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                //txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                //txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                //txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);

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
                //txtCNPJAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[50].Value);



                dgv.Visible = false;
                //MessageBox.Show("Cliente localizado.");
            }


        }
    }
}
