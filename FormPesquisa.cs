using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using Microsoft.SqlServer.Server;
using System.Globalization;

namespace Advocacia_Dias_Pereira
{
    public partial class FormPesquisa : Form
    {
        private int row = 0;
        private string id = "";
        string filename = "";
        MySqlDataReader reader;
        public static MySqlCommand cmd = default(MySqlCommand);
        public FormPesquisa()
        {
            InitializeComponent();

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

            FileStream fileStream = File.OpenRead(filename);
            byte[] contents = new byte[fileStream.Length];
            fileStream.Read(contents, 0, (int)contents.Length);
            fileStream.Close();

            CRUD.cmd.Parameters.AddWithValue("LOG_FILE", contents);

            //Identificação Autor
            //CRUD.cmd.Parameters.AddWithValue("ID_CADASTRO", txtIDAutor.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("NOME_CADASTRO", txtAutor.Text.Trim());
            //Informações Gerais
            CRUD.cmd.Parameters.AddWithValue("DATA_ATUALIZACAO", Convert.ToDateTime(DateTime.Now));
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
            //CRUD.sql = "SELECT * FROM CADASTRO WHERE " + cboxFiltro2.Text.Trim() + " LIKE '%" + txtFiltro2.Text.Trim() + "%' AND " +
            //  "" + cboxFiltro3.Text.Trim() + " LIKE '%" + txtFiltro3.Text.Trim() + "%' AND " + "" + cboxFiltro4.Text.Trim() + " LIKE '%" + txtFiltro4.Text.Trim() + "%'ORDER BY Id;";
            CRUD.sql = "SELECT * FROM CADASTRO WHERE " + cboxFiltro2.Text.Trim() + " LIKE '%" + txtFiltro2.Text.Trim() + "%' AND " +
              "" + cboxFiltro3.Text.Trim() + " LIKE '%" + txtFiltro3.Text.Trim() + "%' AND " + "" + cboxFiltro4.Text.Trim() + " LIKE '%" + txtFiltro4.Text.Trim() + "%' " +
              "AND " + cboxFiltro5.Text.Trim() + " LIKE '%" + txtFiltro5.Text.Trim() + "%'ORDER BY Id;";


            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();

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

            CRUD.sql = "SELECT ID, Autor FROM CADASTRO ORDER BY Id;";
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
            formcadastro.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[46].Value);
            formcadastro.cboxResultado.Text = Convert.ToString(dgv.CurrentRow.Cells[47].Value);
            formcadastro.cboxEscritorio.Text = Convert.ToString(dgv.CurrentRow.Cells[48].Value);
            formcadastro.txtDataEncerramento.Text = Convert.ToString(dgv.CurrentRow.Cells[49].Value);
            formcadastro.txtCNPJAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[50].Value);
            formcadastro.txtNomeLogin.Text = txtNomeLogin.Text;
            formcadastro.txtPermissaoLogin.Text = txtPermissaoLogin.Text;
            formcadastro.Show();
            //Logger.WriteLog("Visualizando o cadastro", txtNomeLogin.Text);
            //CRIAÇÃO DE LOG
            string dir = Path.GetTempPath();
            filename = dir + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "_" + Convert.ToString(dgv.CurrentRow.Cells[1].Value) + ".txt";
            //Validar se já existe aquivo LOG
            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                //Baixar Documento de LOG
                bool em = false;
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";";
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
                Logger.WriteLog(filename, "Visualizando o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "_" + Convert.ToString(dgv.CurrentRow.Cells[1].Value)+";", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '"+ Convert.ToString(dgv.CurrentRow.Cells[0].Value)+"'";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Visualizando o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "_" + Convert.ToString(dgv.CurrentRow.Cells[1].Value) + ";", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values('"+ Convert.ToString(dgv.CurrentRow.Cells[0].Value)+ "', '"+Convert.ToString(dgv.CurrentRow.Cells[1].Value)+"', @LOG_FILE, @DATA_ATUALIZACAO)";
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
                Logger.WriteLog(filename, "Visualizou o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Visualizou o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values('9999', @LOG_LOGIN, @LOG_FILE, @DATA_ATUALIZACAO)";
                Executar(CRUD.sql, "Insert");
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
            formcadastro.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[46].Value);
            formcadastro.cboxResultado.Text = Convert.ToString(dgv.CurrentRow.Cells[47].Value);
            formcadastro.cboxEscritorio.Text = Convert.ToString(dgv.CurrentRow.Cells[48].Value);
            formcadastro.txtDataEncerramento.Text = Convert.ToString(dgv.CurrentRow.Cells[49].Value);
            formcadastro.txtCNPJAutor.Text = Convert.ToString(dgv.CurrentRow.Cells[50].Value);
            formcadastro.txtNomeLogin.Text = txtNomeLogin.Text;
            formcadastro.txtPermissaoLogin.Text = txtPermissaoLogin.Text;
            //Logger.WriteLog("Visualizando o cadastro", txtNomeLogin.Text);
            
            //CRIAÇÃO DE LOG
            string dir = Path.GetTempPath();
            filename = dir + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "_" + Convert.ToString(dgv.CurrentRow.Cells[1].Value) + ".txt";
            //Validar se já existe aquivo LOG
            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                //Baixar Documento de LOG
                bool em = false;
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";";
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
                Logger.WriteLog(filename, "Visualizando o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "_" + Convert.ToString(dgv.CurrentRow.Cells[1].Value) + ";", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '" + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "'";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Visualizando o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "_" + Convert.ToString(dgv.CurrentRow.Cells[1].Value) + ";", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values('" + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + "', '" + Convert.ToString(dgv.CurrentRow.Cells[1].Value) + "', @LOG_FILE, @DATA_ATUALIZACAO)";
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
                Logger.WriteLog(filename, "Visualizou o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = '9999'";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Visualizou o cadastro: " + Convert.ToString(dgv.CurrentRow.Cells[0].Value) + ";", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values('9999', @LOG_LOGIN, @LOG_FILE, @DATA_ATUALIZACAO)";
                Executar(CRUD.sql, "Insert");
            }

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
                //Logger.WriteLog("Deletou o cadastro" + registroSelecionado, txtNomeLogin.Text);

                MessageBox.Show("Dados deletados com sucesso, favor atualize a pesquisa.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //loadData("");
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
            if (e.KeyCode == Keys.Enter)
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

        private void btnPesquisaID_Click(object sender, EventArgs e)
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

        private void btnPesquisaFiltro_Click(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, EventArgs e)
        {
            
        }


        private void btnPesquisaComData_Click(object sender, EventArgs e)
        {
            
            //DateTime filtrodata = DateTime.ParseExact(txtFiltro5.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //string str = filtrodata.ToString("yyyy-MM-dd");

            CRUD.sql = "SELECT * FROM CADASTRO WHERE " + cboxFiltro2.Text.Trim() + " LIKE '%" + txtFiltro2.Text.Trim() + "%' AND " +
              "" + cboxFiltro3.Text.Trim() + " LIKE '%" + txtFiltro3.Text.Trim() + "%' AND " + "" + cboxFiltro4.Text.Trim() + " LIKE '%" + txtFiltro4.Text.Trim() + "%' " +
              "AND " + cboxFiltro5.Text.Trim() + " LIKE '%" + txtFiltro5.Text.Trim() + "%'ORDER BY Id;";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizando exportação para o Excel, por favor aguarde.", "Exportação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Planilha1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exportado da tabela";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            MessageBox.Show("Exportação realizada.", "Exportação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();
        }
    }
}
