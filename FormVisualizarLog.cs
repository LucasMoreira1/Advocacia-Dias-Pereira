using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Advocacia_Dias_Pereira
{
    public partial class FormVisualizarLog : Form
    {
        string filename = "";
        MySqlDataReader reader;
        public static MySqlCommand cmd = default(MySqlCommand);
        public FormVisualizarLog()
        {
            InitializeComponent();
        }

        private void FormVisualizarLog_Load(object sender, EventArgs e)
        {
            //Converter para string a pasta %temp%
            string dir = Path.GetTempPath();
            filename = dir + txtIDCadastro.Text + "_" + txtNomeAutor.Text + ".txt";
            //Validar se já existe aquivo LOG
            CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDCadastro.Text + ";";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                //Baixar Documento de LOG
                bool em = false;
                CRUD.sql = "SELECT LOG_FILE FROM LOGS WHERE ID_CADASTRO = " + txtIDCadastro.Text + ";";
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
                StreamReader stream = new StreamReader(filename);
                string filedata = stream.ReadToEnd();
                txtLog.Text = filedata.ToString();
                stream.Close();
            }
            else
            {
                MessageBox.Show("Não há arquivo de Log para esse Cadastro!", "LOG.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Converter para string a pasta %temp%
            string dir = Path.GetTempPath();
            filename = dir + txtIDCadastro.Text + "_" + txtNomeAutor.Text + ".txt";
            
            string pesquisa = txtPesquisar.Text;

            int counter = 0;
            string line;
            txtLog.Text = null;
            // Read the file and display it line by line.
            StreamReader file = new StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(pesquisa))
                {
                    //txtLog.Text = "";
                    txtLog.Text = txtLog.Text + line + '\r';
                }

                counter++;
            }
            

            file.Close();
        }
    }
}
