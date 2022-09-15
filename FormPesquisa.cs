using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace Advocacia_Dias_Pereira
{
    public partial class FormPesquisa : Form
    {
        private int row = 0;
        private string id = "";
        public FormPesquisa()
        {
            InitializeComponent();

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            loadData("");
        }



        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            loadFiltro();
        }

        public void loadFiltro()
        {
            CRUD.sql = "SELECT * FROM CADASTRO WHERE " + cboxFiltro2.Text.Trim() + " LIKE '%" + txtFiltro2.Text.Trim() + "%' AND " +
              "" + cboxFiltro3.Text.Trim() + " LIKE '%" + txtFiltro3.Text.Trim() + "%' ORDER BY Id;";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgv.DataSource = dt;
            //dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        void dgv_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (e.RowIndex >= dt.Rows.Count)
                return;

            if (e.ColumnIndex >= dt.Columns.Count)
                return;

            e.Value = dt.Rows[e.RowIndex][e.ColumnIndex];
        }

        private void loadData(string keyword)
        {

            CRUD.sql = "SELECT * FROM CADASTRO ORDER BY Id;";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgv.DataSource = dt;
            //dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();


            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();

            formcadastro.txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            formcadastro.txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtProfissao.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formcadastro.txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formcadastro.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formcadastro.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formcadastro.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formcadastro.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            formcadastro.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            formcadastro.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formcadastro.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            formcadastro.txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
            formcadastro.txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
            formcadastro.txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
            formcadastro.txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
            formcadastro.txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
            formcadastro.txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
            formcadastro.txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
            formcadastro.txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[25].Value);
            formcadastro.txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
            formcadastro.txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[27].Value);
            formcadastro.txtProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[28].Value);
            formcadastro.cboxTipoProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[29].Value);
            formcadastro.txtIdProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[30].Value);
            formcadastro.cboxStatusProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[31].Value);
            formcadastro.txtNatProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[32].Value);
            formcadastro.txtAssunto1.Text = Convert.ToString(dgv.CurrentRow.Cells[33].Value);
            formcadastro.txtAssunto2.Text = Convert.ToString(dgv.CurrentRow.Cells[34].Value);
            formcadastro.txtAssunto3.Text = Convert.ToString(dgv.CurrentRow.Cells[35].Value);
            formcadastro.txtDataPericia.Text = Convert.ToString(dgv.CurrentRow.Cells[36].Value);
            formcadastro.txtTipoAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[37].Value);
            formcadastro.txtDataAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[38].Value);
            formcadastro.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[45].Value);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                this.id = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
                txtRegistroSelecionado.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
                btnAtualizar.Text = "Atualizar (" + this.id + ")";
                btnDeletar.Text = "Deletar (" + this.id + ")";

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();

            formcadastro.txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            formcadastro.txtAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtProfissao.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.txtTelefone1.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formcadastro.txtTelefone2.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formcadastro.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formcadastro.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formcadastro.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formcadastro.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            formcadastro.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            formcadastro.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formcadastro.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            formcadastro.txtReu.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
            formcadastro.txtCNPJ.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
            formcadastro.txtTelefoneReu.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
            formcadastro.txtCEPReu.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
            formcadastro.txtLogradouroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
            formcadastro.txtNumeroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
            formcadastro.txtComplementoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
            formcadastro.txtBairroReu.Text = Convert.ToString(dgv.CurrentRow.Cells[25].Value);
            formcadastro.txtCidadeReu.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
            formcadastro.txtEstadoReu.Text = Convert.ToString(dgv.CurrentRow.Cells[27].Value);
            formcadastro.txtProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[28].Value);
            formcadastro.cboxTipoProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[29].Value);
            formcadastro.txtIdProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[30].Value);
            formcadastro.cboxStatusProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[31].Value);
            formcadastro.txtNatProcesso.Text = Convert.ToString(dgv.CurrentRow.Cells[32].Value);
            formcadastro.txtAssunto1.Text = Convert.ToString(dgv.CurrentRow.Cells[33].Value);
            formcadastro.txtAssunto2.Text = Convert.ToString(dgv.CurrentRow.Cells[34].Value);
            formcadastro.txtAssunto3.Text = Convert.ToString(dgv.CurrentRow.Cells[35].Value);
            formcadastro.txtDataPericia.Text = Convert.ToString(dgv.CurrentRow.Cells[36].Value);
            formcadastro.txtTipoAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[37].Value);
            formcadastro.txtDataAudiencia.Text = Convert.ToString(dgv.CurrentRow.Cells[38].Value);
            formcadastro.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[45].Value);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            if (dgv.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Por favor, selecione um item da lista.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string registroSelecionado = txtRegistroSelecionado.Text.Trim();


            if (MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?", "Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM CADASTRO WHERE Id = " + registroSelecionado + "";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");
            }
        }
        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            //loadData("");
        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void txtFiltro1_KeyDown(object sender, KeyEventArgs e)
        {
            CRUD.sql = "SELECT * FROM CADASTRO WHERE Id = '" + txtFiltro1.Text.Trim() + "' ORDER BY Id;";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgv.DataSource = dt;
            //dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
