using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Advocacia_Dias_Pereira
{
    public partial class FormContratoHonorario : Form
    {
        public FormContratoHonorario()
        {
            InitializeComponent();
        }

        private void FormGerarDocumentos_Load(object sender, EventArgs e)
        {
            Cadastro dsCadastro = GetCadastro();
            ReportDataSource datasource1 = new ReportDataSource("Cadastro", dsCadastro.Tables[1]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource1);
            this.reportViewer1.RefreshReport();
        }
        private static string getConnectionString()
        {
            string conString = "Server=108.167.132.199;Database=soluc963_ADV_DIASPEREIRA;Uid=soluc963_DIASPER;Pwd=fXsI2J01!-5-; ";
            return conString;
        }

        private Cadastro GetCadastro()
        {


            using (MySqlConnection con = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM CADASTRO WHERE ID LIKE '" + txtIDCliente.Text.Trim() + "'"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;

                        using (Cadastro dsCadastro = new Cadastro())
                        {
                            sda.Fill(dsCadastro);
                            return dsCadastro;
                        }

                    }
                }
            }
        }
        
    }
}
