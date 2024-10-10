using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Advocacia_Dias_Pereira
{
    class CRUD
    {
        private static string getConnectionString()
        {
            //string conString = "Server=108.167.132.199;Database=soluc963_ADV_DIASPEREIRA;Uid=soluc963_DIASPER; Pwd=fXsI2J01!-5-;Convert Zero Datetime=True";
            //string conString = "Server=187.95.26.193;Port=3306;Database=soluc963_ADV_DIASPEREIRA;Uid=Agility;Pwd=!Parrudo292701;Convert Zero Datetime=True";
            //string conString = "Server=mysql-agility.advogadodigital.click;Port=3306;Database=soluc963_adv_diaspereira;Uid=Agility;Pwd=!Parrudo292701;";
            //string conString = "Server=192.168.1.75;Port=3306;Database=soluc963_adv_diaspereira;Uid=agility;Pwd=!Parrudo292701;Allow Zero Datetime=True;";
            string conString = "Server=localhost;Port=3306;Database=soluc963_adv_diaspereira;Uid=agility;Pwd=!Parrudo292701;Allow Zero Datetime=True;";
            return conString;
        }

        public static MySqlConnection con = new MySqlConnection(getConnectionString());
        public static MySqlCommand cmd = default (MySqlCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCRUD(MySqlCommand com)
        {
            MySqlDataAdapter da = default(MySqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new MySqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message,
                    "Operação CRUD Falhou : Contate o ADM",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                dt=null;
            }
            return dt;
        }
    }
}
