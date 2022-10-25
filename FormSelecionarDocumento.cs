using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;




namespace Advocacia_Dias_Pereira
{
    public partial class FormSelecionarDocumento : Form
    {
        public FormSelecionarDocumento()
        {
            InitializeComponent();
        }

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object matchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref matchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiacritics, ref matchAlefHamza,
                ref matchControl);
        }

        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

                myWordDoc.Activate();

                this.FindAndReplace(wordApp, "[NOME]", txtAutor.Text);
                this.FindAndReplace(wordApp, "[RG]", txtRG.Text);
                this.FindAndReplace(wordApp, "[CPF]", txtCPF.Text);
                this.FindAndReplace(wordApp, "[NUMERO]", txtNumero.Text);
                this.FindAndReplace(wordApp, "[LOGRADOURO]", txtLogradouro.Text);
                this.FindAndReplace(wordApp, "[BAIRRO]", txtBairro.Text);
                this.FindAndReplace(wordApp, "[CIDADE]", txtCidade.Text);
                this.FindAndReplace(wordApp, "[ESTADO]", txtEstado.Text);
                this.FindAndReplace(wordApp, "[CEP]", txtCEP.Text);
                this.FindAndReplace(wordApp, "[DATA]", DateTime.Now.ToShortDateString()) ;

            }
            else
            {
                MessageBox.Show("Arquivo modelo não encontrado");
            }

            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Arquivo criado!");

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
                //Baixar arquivo modelo da Web//
                //Converter para string a pasta %temp%
                string dir = Path.GetTempPath();
                //Fazer download do arquivo modelo
                System.Net.WebClient client = new System.Net.WebClient();
                //Diretorio Web onde está o documento
                string url = "https://sistema.solucoesagility.com.br/Modelo_Declaracao_Hipo.docx";
                //Salvar documento na pasta %temp%
                string localFileName = dir + "Modelo_Declaracao_Hipo.docx";
                client.DownloadFile(url, localFileName);

                //Abir dialog para salvar o arquivo atualizado
                SaveFileDialog mySaveFileDialog = new SaveFileDialog();
                mySaveFileDialog.FileName = "Declaracao_Hipo_"+txtAutor.Text+".docx";
                mySaveFileDialog.ShowDialog();

                //Executar comando para converter os dados do arquivo modelo e salvar no destino.
                CreateWordDocument(localFileName,
                    mySaveFileDialog.FileName.ToString());
                              

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
