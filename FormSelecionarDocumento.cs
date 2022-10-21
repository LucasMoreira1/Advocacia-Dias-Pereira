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
    public partial class FormSelecionarDocumento : Form
    {
        public FormSelecionarDocumento()
        {
            InitializeComponent();
        }

        private void btnGerarDocumento_Click(object sender, EventArgs e)
        {
            if (cboxDocumento.Text == "1 - CONTRATO DE HONORARIOS ADVOCATÍCIOS")
            {
                FormContratoHonorario formContratoHonorario = new FormContratoHonorario();
                formContratoHonorario.txtIDCliente.Text = txtIDAutor.Text;
                formContratoHonorario.Show();
            }
            else if (cboxDocumento.Text == "2 - DECLARAÇÃO DE HIPOSSUFICIÊNCIA")
            {
                FormDeclaracaoHipo formDeclaracaoHipo = new FormDeclaracaoHipo();
                formDeclaracaoHipo.txtIDCliente.Text = txtIDAutor.Text;
                formDeclaracaoHipo.Show();
            }
            else if (cboxDocumento.Text == "3 - MANIFESTAÇÃO")
            {
                FormManifestacao formManifestacao = new FormManifestacao();
                formManifestacao.txtIDCliente.Text = txtIDAutor.Text;
                formManifestacao.Show();
            }
            else if (cboxDocumento.Text == "4 - PROCURAÇÃO")
            {
                FormProcuracao formProcuracao = new FormProcuracao();
                formProcuracao.txtIDCliente.Text = txtIDAutor.Text;
                formProcuracao.Show();
            }
            
        }
    }
}
