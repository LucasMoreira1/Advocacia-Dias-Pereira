using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Data;





namespace Advocacia_Dias_Pereira
{
    public partial class FormSelecionarDocumento : Form
    {
        string filename = "";
        MySqlDataReader reader;
        public static MySqlCommand cmd = default(MySqlCommand);
        public FormSelecionarDocumento()
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
            CRUD.cmd.Parameters.AddWithValue("ID_CADASTRO", txtIDAutor.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("NOME_CADASTRO", txtAutor.Text.Trim());
            //Informações Gerais
            CRUD.cmd.Parameters.AddWithValue("DATA_ATUALIZACAO", Convert.ToDateTime(DateTime.Now));
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
                object isVisible = true;
                wordApp.Visible = true;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

                myWordDoc.Activate();

                //this.FindAndReplace(wordApp, "[AUTOR]", txtAutor.Text);
                //this.FindAndReplace(wordApp, "[NOME]", txtAutor.Text);
                //this.FindAndReplace(wordApp, "[RG]", txtRG.Text);
                //this.FindAndReplace(wordApp, "[CPF]", txtCPF.Text);
                //this.FindAndReplace(wordApp, "[NUMERO]", txtNumero.Text);
                //this.FindAndReplace(wordApp, "[LOGRADOURO]", txtLogradouro.Text);
                //this.FindAndReplace(wordApp, "[BAIRRO]", txtBairro.Text);
                //this.FindAndReplace(wordApp, "[CIDADE]", txtCidade.Text);
                //this.FindAndReplace(wordApp, "[ESTADO]", txtEstado.Text);
                //this.FindAndReplace(wordApp, "[CEP]", txtCEP.Text);
                //this.FindAndReplace(wordApp, "[DATA]", DateTime.Now.ToShortDateString()) ;

                //this.FindAndReplace(wordApp, "[CAD_NUMERO]", txtCadNumero.Text;
                this.FindAndReplace(wordApp, "[AUTOR]", txtAutor.Text);
                this.FindAndReplace(wordApp, "[NACIONALIDADE]", txtNacionalidade.Text);
                this.FindAndReplace(wordApp, "[ESTADO_CIVIL]", cboxEstadoCivil.Text);
                this.FindAndReplace(wordApp, "[RG]", txtRG.Text);
                this.FindAndReplace(wordApp, "[CPF]", txtCPF.Text);
                this.FindAndReplace(wordApp, "[DATA_NASCIMENTO]", txtDataNascimento.Text);
                this.FindAndReplace(wordApp, "[EMAIL]", txtEmail.Text);
                this.FindAndReplace(wordApp, "[TELEFONE1]", txtTelefone1.Text);
                this.FindAndReplace(wordApp, "[TELEFONE2]", txtTelefone2.Text);
                this.FindAndReplace(wordApp, "[CEP]", txtCEP.Text);
                this.FindAndReplace(wordApp, "[LOGRADOURO]", txtLogradouro.Text);
                this.FindAndReplace(wordApp, "[NUMERO]", txtNumero.Text);
                this.FindAndReplace(wordApp, "[COMPLEMENTO]", txtComplemento.Text);
                this.FindAndReplace(wordApp, "[BAIRRO]", txtBairro.Text);
                this.FindAndReplace(wordApp, "[CIDADE]", txtCidade.Text);
                this.FindAndReplace(wordApp, "[ESTADO]", txtEstado.Text);
                this.FindAndReplace(wordApp, "[REU]", txtReu.Text);
                this.FindAndReplace(wordApp, "[CNPJ_REU]", txtCNPJ.Text);
                this.FindAndReplace(wordApp, "[TELEFONER_REU]", txtTelefoneReu.Text);
                this.FindAndReplace(wordApp, "[CEP_REU]", txtCEPReu.Text);
                this.FindAndReplace(wordApp, "[LAGRADOURO_REU]", txtLogradouroReu.Text);
                this.FindAndReplace(wordApp, "[NUMERO_REU]", txtNumeroReu.Text);
                this.FindAndReplace(wordApp, "[COMPLEMENTO_REU]", txtComplementoReu.Text);
                this.FindAndReplace(wordApp, "[BAIRRO_REU]", txtBairroReu.Text);
                this.FindAndReplace(wordApp, "[CIDADE_REU]", txtCidadeReu.Text);
                this.FindAndReplace(wordApp, "[ESTADO_REU]", txtEstadoReu.Text);
                this.FindAndReplace(wordApp, "[PROCESSO]", txtProcesso.Text);
                this.FindAndReplace(wordApp, "[TIPO_PROCESSO]", cboxTipoProcesso.Text);
                this.FindAndReplace(wordApp, "[ID_PROCESSO]", txtIdProcesso.Text);
                this.FindAndReplace(wordApp, "[STATUS_PROCESSO]", cboxStatusProcesso.Text);
                this.FindAndReplace(wordApp, "[NAT_PROCESSO]", txtNatProcesso.Text);
                this.FindAndReplace(wordApp, "[ASSUNTO1]", txtAssunto1.Text);
                this.FindAndReplace(wordApp, "[ASSUNTO2]", txtAssunto2.Text);
                this.FindAndReplace(wordApp, "[ASSUNTO3]", txtAssunto3.Text);
                this.FindAndReplace(wordApp, "[DATA_PERICIA]", txtDataPericia.Text);
                this.FindAndReplace(wordApp, "[TIPO_AUDIENCIA]", txtTipoAudiencia.Text);
                this.FindAndReplace(wordApp, "[DATA_AUDIENCIA]", txtDataAudiencia.Text);
                this.FindAndReplace(wordApp, "[OBSERVACAO]", txtObservacao.Text);
                this.FindAndReplace(wordApp, "[DATA]", DateTime.Now.ToShortDateString());
            }
            else
            {
                MessageBox.Show("Arquivo modelo não encontrado","Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            //myWordDoc.Close();
            //wordApp.Quit();
            
            MessageBox.Show("Documento criado!","Documento.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGerarDocumento_Click(object sender, EventArgs e)
        {
            
            if (cboxDocumento.Text == "1 - CONTRATO DE HONORARIOS ADVOCATÍCIOS")
            {
                //Baixar arquivo modelo da Web//
                //Converter para string a pasta %temp%
                string dir = Path.GetTempPath();
                
                //Fazer download do arquivo modelo
                System.Net.WebClient client = new System.Net.WebClient();
                //Diretorio Web onde está o documento
                string url = "https://sistema.solucoesagility.com.br/Modelo_Contrato_Hono.docx";
                //Salvar documento na pasta %temp%
                string localFileName = dir + "Modelo_Contrato_Hono.docx";
                client.DownloadFile(url, localFileName);

                //CRIAÇÃO DE LOG
                filename = dir + txtIDAutor.Text + "_" + txtAutor.Text + ".txt";
                //Validar se já existe aquivo LOG
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";

                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

                if (dt.Rows.Count > 0)
                {
                    //Baixar Documento de LOG
                        bool em = false;
                        CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";
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
                        Logger.WriteLog(filename, "Documento criado: Honorarios_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Atualiza Log existente
                        CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = @ID_CADASTRO";
                        Executar(CRUD.sql, "Update");
                }
                else
                {
                    //Escrever no Documento de LOG
                        Logger.WriteLog(filename, "Documento criado: Honorarios_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Salvar Documento de LOG
                        CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                                    "Values(@ID_CADASTRO, @NOME_CADASTRO, @LOG_FILE, @DATA_ATUALIZACAO)";
                        Executar(CRUD.sql, "Insert");
                }
                
                //Gerar Documento WORD
                    CreateWordDocument(localFileName,
                        "Honorarios_" + txtAutor.Text);
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
                //SaveFileDialog mySaveFileDialog = new SaveFileDialog();
                //mySaveFileDialog.FileName = "Declaracao_Hipossuficiencia_"+txtAutor.Text+".docx";
                //mySaveFileDialog.ShowDialog();

                //Executar comando para converter os dados do arquivo modelo e salvar no destino.
                //CreateWordDocument(localFileName,
                //    mySaveFileDialog.FileName.ToString());

                //CRIAÇÃO DE LOG
                filename = dir + txtIDAutor.Text + "_" + txtAutor.Text + ".txt";
                //Validar se já existe aquivo LOG
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";

                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

                if (dt.Rows.Count > 0)
                {
                    //Baixar Documento de LOG
                    bool em = false;
                    CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";
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
                    Logger.WriteLog(filename, "Documento criado: Hipossuficiencia_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = @ID_CADASTRO";
                    Executar(CRUD.sql, "Update");
                }
                else
                {
                    //Escrever no Documento de LOG
                    Logger.WriteLog(filename, "Documento criado: Hipossuficiencia_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Salvar Documento de LOG
                    CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                                "Values(@ID_CADASTRO, @NOME_CADASTRO, @LOG_FILE, @DATA_ATUALIZACAO)";
                    Executar(CRUD.sql, "Insert");
                }

                CreateWordDocument(localFileName,
                    "Hipossuficiencia_" + txtAutor.Text);


            }
            else if (cboxDocumento.Text == "3 - MANIFESTAÇÃO")
            {
                //Baixar arquivo modelo da Web//
                //Converter para string a pasta %temp%
                string dir = Path.GetTempPath();
                //Fazer download do arquivo modelo
                System.Net.WebClient client = new System.Net.WebClient();
                //Diretorio Web onde está o documento
                string url = "https://sistema.solucoesagility.com.br/Modelo_Manifesto.docx";
                //Salvar documento na pasta %temp%
                string localFileName = dir + "Modelo_Manifesto.docx";
                client.DownloadFile(url, localFileName);

                //Abir dialog para salvar o arquivo atualizado
                //SaveFileDialog mySaveFileDialog = new SaveFileDialog();
                //mySaveFileDialog.FileName = "Manifesto_" + txtAutor.Text + ".docx";
                //mySaveFileDialog.ShowDialog();

                //CreateWordDocument(localFileName,
                //    mySaveFileDialog.FileName.ToString());

                //CRIAÇÃO DE LOG
                filename = dir + txtIDAutor.Text + "_" + txtAutor.Text + ".txt";
                //Validar se já existe aquivo LOG
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";

                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

                if (dt.Rows.Count > 0)
                {
                    //Baixar Documento de LOG
                    bool em = false;
                    CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";
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
                    Logger.WriteLog(filename, "Documento criado: Manifesto_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = @ID_CADASTRO";
                    Executar(CRUD.sql, "Update");
                }
                else
                {
                    //Escrever no Documento de LOG
                    Logger.WriteLog(filename, "Documento criado: Manifesto_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Salvar Documento de LOG
                    CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                                "Values(@ID_CADASTRO, @NOME_CADASTRO, @LOG_FILE, @DATA_ATUALIZACAO)";
                    Executar(CRUD.sql, "Insert");
                }

                CreateWordDocument(localFileName,
                    "Manifesto_" + txtAutor.Text);
            }
            else if (cboxDocumento.Text == "4 - PROCURAÇÃO")
            {
                //Baixar arquivo modelo da Web//
                //Converter para string a pasta %temp%
                string dir = Path.GetTempPath();
                //Fazer download do arquivo modelo
                System.Net.WebClient client = new System.Net.WebClient();
                //Diretorio Web onde está o documento
                string url = "https://sistema.solucoesagility.com.br/Modelo_Procuracao.docx";
                //Salvar documento na pasta %temp%
                string localFileName = dir + "Modelo_Procuracao.docx";
                client.DownloadFile(url, localFileName);

                //Abir dialog para salvar o arquivo atualizado
                //SaveFileDialog mySaveFileDialog = new SaveFileDialog();
                //mySaveFileDialog.FileName = "Procuracao_" + txtAutor.Text + ".docx";
                //mySaveFileDialog.ShowDialog();

                //CreateWordDocument(localFileName,
                //    mySaveFileDialog.FileName.ToString());

                //CRIAÇÃO DE LOG
                filename = dir + txtIDAutor.Text + "_" + txtAutor.Text + ".txt";
                //Validar se já existe aquivo LOG
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";

                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

                if (dt.Rows.Count > 0)
                {
                    //Baixar Documento de LOG
                    bool em = false;
                    CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDAutor.Text + ";";
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
                    Logger.WriteLog(filename, "Documento criado: Procuracao_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Atualiza Log existente
                    CRUD.sql = "UPDATE LOGS SET LOG_FILE = @LOG_FILE, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CADASTRO = @ID_CADASTRO";
                    Executar(CRUD.sql, "Update");
                }
                else
                {
                    //Escrever no Documento de LOG
                    Logger.WriteLog(filename, "Documento criado: Procuracao_" + txtAutor.Text + ";", txtNomeLogin.Text);
                    //Salvar Documento de LOG
                    CRUD.sql = "INSERT INTO LOGS(ID_CADASTRO,NOME_CADASTRO,LOG_FILE,DATA_ATUALIZACAO)" +
                                "Values(@ID_CADASTRO, @NOME_CADASTRO, @LOG_FILE, @DATA_ATUALIZACAO)";
                    Executar(CRUD.sql, "Insert");
                }

                CreateWordDocument(localFileName,
                    "Procuracao_" + txtAutor.Text);
            }
            
        }
    }
}
