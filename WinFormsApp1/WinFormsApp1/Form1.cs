using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var datasource = "vpn.koella.com.tr";//Server Adresimiz
            var database = "Cockpit"; //Veri Tabanı İsmimiz
            var username = "koella.cockpit"; //Kullanıcı Adımız
            var password = "kDj4FtPe"; //Parolamız
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            //Bağlantı Kelimeleri
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand komm = new SqlCommand();
            komm.Connection = conn;
            komm.CommandText = "INSERT INTO GuncelDoviz (Tarih,DolarIsim,DolarCurrencyName,DolarForexBuying,DolarForexSelling,EuroIsim,EuroCurrencyName,EuroForexBuying,EuroForexSelling) VALUES('" + DateTime.Now + "','" + DolarIsim + "','" + DolarCurrencyName + "','" + dolarAlis + "','" + dolarSatis + "','" + EuroIsim + "','" + EuroCurrencyName + "','" + euroAlis + "','" + euroSatis + "') ";

        }
    }
}