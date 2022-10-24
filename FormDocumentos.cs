using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Advocacia_Dias_Pereira
{
    public partial class FormDocumentos : Form
    {
        string id = "";
        MySqlDataReader reader;
        public static MySqlCommand cmd = default(MySqlCommand);
        public string filename;
        public FormDocumentos()
        {
            InitializeComponent();
        }

        private void FormDocumentos_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            CRUD.sql = "SELECT * FROM DOCUMENTOS WHERE Cad_Cliente = " + txtCadCliente.Text + ";";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.DataSource = dt;
            //dgv.Columns["Documento"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM DOCUMENTOS WHERE Cad_Cliente = " + txtCadCliente.Text + ";";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;


            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.DataSource = dt;
            //dgv.Columns["Documento"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            CRUD.con.Close();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = dataGridView1.SelectedCells[3].Value.ToString();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
            }
            bool em = false;
           
            CRUD.sql = "SELECT DOCUMENTO FROM DOCUMENTOS WHERE DOC_ID = " + txtSelecionado.Text + ";";
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
                        MessageBox.Show("Download concluído.", "Download Documento",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            CRUD.con.Close();

        }

        private void btnExluir_Click(object sender, EventArgs e)
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
            
            if (MessageBox.Show("Tem certeza que deseja deletar o documento selecionados?", "Deletar Documento",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM DOCUMENTOS WHERE DOC_ID = " + txtSelecionado.Text + "";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Documento deletados com sucesso.", "Deletar Documento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarDados();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtSelecionado.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            CRUD.con.Close();
            SaveFileDialog sfd = new SaveFileDialog();
            string dir = Path.GetTempPath();

            sfd.FileName = dir + dataGridView1.SelectedCells[3].Value.ToString();

            
            filename = sfd.FileName;
            
            bool em = false;

            CRUD.sql = "SELECT DOCUMENTO FROM DOCUMENTOS WHERE DOC_ID = " + txtSelecionado.Text + ";";
            CRUD.con.Open();
            using (CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con))
            {
                using (reader = CRUD.cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        em = true;
                        byte[] fileData = (byte[])reader.GetValue(0);

                        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(fileData);
                                bw.Close();

                            }
                        }
                        System.Diagnostics.Process.Start(filename);

                        //MessageBox.Show("Download concluído.", "Download Documento",
                        //        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            CRUD.con.Close();
        }
    }
}
