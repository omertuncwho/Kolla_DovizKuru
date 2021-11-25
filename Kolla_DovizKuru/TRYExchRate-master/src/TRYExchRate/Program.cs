using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//SQl Bağlantısı
using System.Data;
using System.Data.SqlClient;
//XML  Bağlantısı
using System.Xml;
namespace TRYExchRate
{
    class Program
    {
        static SqlConnection comand;
        static void Main(string[] args)
        {

            TRYExchRate helper = new TRYExchRate(DateTime.Now.Date);
            helper.LoadExchRate();

            Console.Write("İstenilen kur tarihi: " + helper.CurrencyDate.Date);
            Console.WriteLine("");
            Console.Write("Alınan kur tarihi: " + helper.ActualCurrencyDate.Date);
            Console.WriteLine("");
            Console.WriteLine("Api linki: " + helper.ApiUrl);
            Console.WriteLine("");

            // USD Kurları Gösterilir
            Console.WriteLine("USD - DOLAR Alış: " + helper.GetExchRate("USD", ExchRateType.ForexBuying).ToString());
            Console.WriteLine("USD - DOLAR Satış: " + helper.GetExchRate("USD", ExchRateType.ForexSelling).ToString());
            Console.WriteLine("");

            //EURO Kurları Gösterilir
            Console.WriteLine("EUR - EURO Alış: " + helper.GetExchRate("EUR", ExchRateType.ForexBuying).ToString());
            Console.WriteLine("EUR - EURO Satış: " + helper.GetExchRate("EUR", ExchRateType.ForexSelling).ToString());
            Console.WriteLine("");

            //SQL START Connection

            Console.WriteLine("Getting Connection ...");

            var datasource = "vpn.koella.com.tr";//Server Adresimiz
            var database = "Cockpit"; //Veri Tabanı İsmimiz
            var username = "koella.cockpit"; //Kullanıcı Adımız
            var password = "kDj4FtPe"; //Parolamız

            //Bağlantı Kelimeleri 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="+ database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand komm = new SqlCommand();
            komm.Connection = conn;
            //komm.CommandText = "UPDATE DOVIZKURLARI SET  DolarIsim='ABD DOLARI', DolarCurrencyName='US DOLLAR', DolarForexBuying='" + ("USD", ExchRateType.ForexBuying) + "',DolarForexSelling='" + ("USD", ExchRateType.ForexSelling) + "',EuroIsim='EURO',EuroCurrencyName='EURO',EuroForexBuying='" + ("EUR", ExchRateType.ForexBuying) + "',EuroForexSelling='" + ("EUR", ExchRateType.ForexSelling) + "',  WHERE ogrno=" + no.ToString();
            DateTime localDate = DateTime.Now;
            
            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }

    }


}

 
    
