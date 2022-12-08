using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
