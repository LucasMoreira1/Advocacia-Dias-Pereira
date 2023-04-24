using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace Advocacia_Dias_Pereira
{
    public partial class FormPaginaInicial : Form
    {
        string filename = "";
        MySqlDataReader reader;
        public static MySqlCommand cmd = default(MySqlCommand);
        public FormPaginaInicial()
        {
            InitializeComponent();
            //CustomizeDesign();
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
            CRUD.cmd.Parameters.AddWithValue("ID_CADASTRO", "9999");
            CRUD.cmd.Parameters.AddWithValue("NOME_CADASTRO", "LOG_LOGIN");
            //Informações Gerais
            CRUD.cmd.Parameters.AddWithValue("DATA_ATUALIZACAO", Convert.ToDateTime(DateTime.Now));
        }
        //private void CustomizeDesign()
        //{
        //    panelCadastros.Visible = false;
        //    panelPesquisas.Visible = false;
        //    panelDocumentos.Visible = false;
        //    //...
        //}

        //private void EsconderSubmenu()
        //{
        //    if (panelCadastros.Visible == true)
        //        panelCadastros.Visible = false;
        //    if (panelPesquisas.Visible == true)
        //        panelPesquisas.Visible = false;
        //    if (panelDocumentos.Visible == true)
        //        panelDocumentos.Visible = false;
        //    //...
        //}
        //private void MostrarSubmenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        EsconderSubmenu();
        //        subMenu.Visible = true;
        //    }
        //    else
        //        subMenu.Visible = false;
        //}

        #region Cadastros
        //private void btnCadastros_Click(object sender, EventArgs e)
        //{
        //    MostrarSubmenu(panelCadastros);
        //}

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.txtNomeLogin.Text = txtNomeLogin.Text;
            formCadastro.txtPermissaoLogin.Text = txtPermissaoLogin.Text;
            formCadastro.Show();
            //OpenChildForm(new FormCadastro());
            //..
            //Codigos
            //..
            //EsconderSubmenu();
        }

        private void btnCriarPacotes_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormCriarPacote());
            //..
            //Codigos
            //..
            //EsconderSubmenu();
        }
        #endregion
        #region Pesquisar
        //private void btnPesquisar_Click(object sender, EventArgs e)
        //{
        //    MostrarSubmenu(panelPesquisas);
        //}

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa();
            formPesquisa.txtNomeLogin.Text = txtNomeLogin.Text;
            formPesquisa.Show();
            //OpenChildForm(new FormPesquisa());
            //..
            //Codigos
            //..
            //EsconderSubmenu();
        }

        //private void btnPesquisarEmpresa_Click(object sender, EventArgs e)
        //{
        //    //..
        //    //Codigos
        //    //..
        //    //EsconderSubmenu();
        //}
        #endregion
        #region Relatorios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            //EsconderSubmenu();
        }
        #endregion
        #region Documentos
        //private void btnDocumentos_Click(object sender, EventArgs e)
        //{
        //    MostrarSubmenu(panelDocumentos);
        //}

        //private void btnCarteirinha_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FormDocumentos());
        //    //..
        //    //Codigos
        //    //..
        //    EsconderSubmenu();
        //}

        private void btnCheques_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            //EsconderSubmenu();
        }
        #endregion
        #region Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            FormVisualizarLog formVisualizarLog = new FormVisualizarLog();
            formVisualizarLog.txtIDCadastro.Visible = false;
            formVisualizarLog.txtIDCadastro.Text = "9999";
            formVisualizarLog.txtNomeAutor.Visible = false;
            formVisualizarLog.txtNomeAutor.Text = "LOG_LOGIN";
            formVisualizarLog.Show();

        }
        #endregion

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormCentral.Controls.Add(childForm);
            panelFormCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void formPaginaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void btnDocumentos_Click(object sender, EventArgs e)
        {

        }

        private void FormPaginaInicial_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //CRIAÇÃO DE LOG
            //Converter para string a pasta %temp%
            string dir = Path.GetTempPath();
            filename = dir + "9999_LOG_LOGIN.txt";
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
                Logger.WriteLog(filename, "Saiu do sistema;", txtNomeLogin.Text);
                //Atualiza Log existente
                CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = @ID_CADASTRO";
                Executar(CRUD.sql, "Update");
            }
            else
            {
                //Escrever no Documento de LOG
                Logger.WriteLog(filename, "Saiu do sistema;", txtNomeLogin.Text);
                //Salvar Documento de LOG
                CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                            "Values(@ID_CADASTRO, @NOME_CADASTRO, @LOG_FILE, @DATA_ATUALIZACAO)";
                Executar(CRUD.sql, "Insert");
            }
            //Application.Exit();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChat());
        }
        public void Maximizar()
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Maximizar();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelFormTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            panelFormCentral.Controls.Clear();
        }
    }
}
