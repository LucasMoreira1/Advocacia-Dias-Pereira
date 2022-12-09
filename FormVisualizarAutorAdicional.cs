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
    public partial class FormVisualizarAutorAdicional : Form
    {
        public FormVisualizarAutorAdicional()
        {
            InitializeComponent();
        }

        private void FormVisualizarAutorAdicional_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void CarregarDados()
        {
            CRUD.sql = "SELECT * FROM AUTOR_ADICIONAL WHERE ID_CADASTRO = " + txtCadReferencia.Text + ";";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["ID_CADASTRO"].Visible = false;
            dgv.Columns["idAUTOR_ADICIONAL"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormAutorAdicional formAutorAdicional = new FormAutorAdicional();


            formAutorAdicional.btnSalvar.Visible = false;
            formAutorAdicional.btnAtualizar.Visible = true;
            formAutorAdicional.Show();

            formAutorAdicional.txtCadNumero.Text = txtCadReferencia.Text.Trim();

            formAutorAdicional.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formAutorAdicional.txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formAutorAdicional.txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formAutorAdicional.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formAutorAdicional.txtProfissao.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formAutorAdicional.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formAutorAdicional.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formAutorAdicional.txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formAutorAdicional.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formAutorAdicional.txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formAutorAdicional.txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formAutorAdicional.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formAutorAdicional.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            formAutorAdicional.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            formAutorAdicional.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formAutorAdicional.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            formAutorAdicional.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
            formAutorAdicional.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
            formAutorAdicional.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);

            //Outros
            formAutorAdicional.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
            

        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            string registroSelecionado = txtSelecionado.Text.Trim();

            if (MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?", "Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM AUTOR_ADICIONAL WHERE ID_CADASTRO = '" + txtCadReferencia.Text + "' AND AUTOR = '" + registroSelecionado + "'";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarDados();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                //this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtSelecionado.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormAutorAdicional formAutorAdicional = new FormAutorAdicional();


            formAutorAdicional.btnSalvar.Visible = false;
            formAutorAdicional.btnAtualizar.Visible = true;
            formAutorAdicional.Show();

            formAutorAdicional.txtCadNumero.Text = txtCadReferencia.Text.Trim();

            formAutorAdicional.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formAutorAdicional.txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formAutorAdicional.txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formAutorAdicional.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formAutorAdicional.txtProfissao.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formAutorAdicional.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formAutorAdicional.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formAutorAdicional.txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formAutorAdicional.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formAutorAdicional.txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formAutorAdicional.txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formAutorAdicional.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formAutorAdicional.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            formAutorAdicional.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            formAutorAdicional.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formAutorAdicional.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            formAutorAdicional.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
            formAutorAdicional.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
            formAutorAdicional.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);

            //Outros
            formAutorAdicional.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
        }
    }
}
