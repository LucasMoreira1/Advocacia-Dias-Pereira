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
    }
}
