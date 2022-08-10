using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;

namespace Advocacia_Dias_Pereira
{
    public partial class FormPaginaInicial : Form
    {
        public FormPaginaInicial()
        {
            InitializeComponent();
            //CustomizeDesign();
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
            //..
            //Codigos
            //..
            //EsconderSubmenu();
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
            Application.Exit();
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            panelFormCentral.Controls.Clear();
            panelFormCentral.Controls.Add(txtConsultaCPF);
            txtConsultaCPF.Text = "";
            panelFormCentral.Controls.Add(btnPesquisarCPF);
            panelFormCentral.Controls.Add(label1);
            //panelFormCentral.Controls.Add(webView21);
            //EsconderSubmenu();
        }

        private void PesquisaCPF(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                pesquisaCPF();
            }

        }
        public void pesquisaCPF()
        {
            CRUD.sql = "SELECT * FROM CADASTRO WHERE CPF LIKE '" + txtConsultaCPF.Text.Trim() + "'";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;
            FormCadastro formCadastro = new FormCadastro();

            dgv.Visible = true;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            //dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            if (dgv.CurrentRow == null)
            {
                dgv.Visible = false;
                MessageBox.Show("Não há cliente registrado com esse CPF.");
                formCadastro.Show();
                formCadastro.btnSalvar.Visible = true;
                formCadastro.btnAtualizar.Visible = false;
                formCadastro.cboxDocumento.SelectedIndex = 0;
                formCadastro.txtCPF.Text = txtConsultaCPF.Text;
                txtConsultaCPF.Text = "";
            }
            else
            {
                formCadastro.Show();
                formCadastro.cboxDocumento.SelectedIndex = 0;
                formCadastro.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                formCadastro.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                formCadastro.txtOrgEmissor.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                formCadastro.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                formCadastro.txtPassaporte.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                formCadastro.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                formCadastro.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                formCadastro.txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                formCadastro.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
                formCadastro.txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                formCadastro.txtDataCasamento.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
                formCadastro.cboxPet.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
                formCadastro.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
                formCadastro.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
                formCadastro.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                formCadastro.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                formCadastro.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
                formCadastro.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
                formCadastro.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
                formCadastro.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
                MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[20].Value);
                formCadastro.imgCamera.Image = Image.FromStream(ms);
                formCadastro.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
                formCadastro.txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);

                formCadastro.btnSalvar.Visible = false;
                formCadastro.btnAtualizar.Visible = true;
                txtConsultaCPF.Text = "";
                dgv.Visible = false;
                //MessageBox.Show("Cliente localizado.");
            }
        }

        private void btnPesquisarCPF_Click(object sender, EventArgs e)
        {
            pesquisaCPF();
        }

        private void txtConsultaCPF_Click(object sender, EventArgs e)
        {
            txtConsultaCPF.SelectionStart = 0;
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {

        }

        //private void btnTelaVendas_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FormTelaVenda());
        //}
    }
}
