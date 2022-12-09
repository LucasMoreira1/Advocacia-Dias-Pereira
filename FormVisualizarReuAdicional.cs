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
    public partial class FormVisualizarReuAdicional : Form
    {
        public FormVisualizarReuAdicional()
        {
            InitializeComponent();
        }

        private void FormVisualizarReuAdicional_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void CarregarDados()
        {
            CRUD.sql = "SELECT * FROM REU_ADICIONAL WHERE ID_CADASTRO = " + txtCadReferencia.Text + ";";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["ID_CADASTRO"].Visible = false;
            dgv.Columns["idREU_ADICIONAL"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormReuAdicional formReuAdicional = new FormReuAdicional();


            formReuAdicional.btnSalvar.Visible = false;
            formReuAdicional.btnAtualizar.Visible = true;
            formReuAdicional.Show();

            formReuAdicional.txtCadNumero.Text = txtCadReferencia.Text.Trim();

            formReuAdicional.txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formReuAdicional.txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formReuAdicional.txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formReuAdicional.txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formReuAdicional.txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formReuAdicional.txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formReuAdicional.txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formReuAdicional.txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formReuAdicional.txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formReuAdicional.txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);

            //Outros
            formReuAdicional.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formReuAdicional.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            string registroSelecionado = txtSelecionado.Text.Trim();


            if (MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?", "Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM REU_ADICIONAL WHERE ID_CADASTRO = '" + txtCadReferencia.Text + "' AND REU = '" + registroSelecionado + "'";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarDados();
            }
        }
    }
}
