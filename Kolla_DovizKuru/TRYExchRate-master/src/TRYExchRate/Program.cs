using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//SQl Connection
using System.Data;
using System.Data.SqlClient;
//XML Connection
using System.Xml;
namespace TRYExchRate
{
    class Program
    {
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

            // USD
            Console.WriteLine("USD - DOLAR Alış: " + helper.GetExchRate("USD", ExchRateType.ForexBuying).ToString());
            Console.WriteLine("USD - DOLAR Satış: " + helper.GetExchRate("USD", ExchRateType.ForexSelling).ToString());
            Console.WriteLine("");

            //EUR
            Console.WriteLine("EUR - EURO Alış: " + helper.GetExchRate("EUR", ExchRateType.ForexBuying).ToString());
            Console.WriteLine("EUR - EURO Satış: " + helper.GetExchRate("EUR", ExchRateType.ForexSelling).ToString());
            Console.WriteLine("");

            Console.ReadLine();
        }

        //SQL CONNECTİON
        // SQL satırlarınu bu şekilde ekledim fakat , euro veya dolar değişkenlerinden gelen verileri ve tarihi veri tabanına ekleyemedim .. Aşağıdaki sadece bir örnek 
        baglanti = new SqlConnection();
        baglanti.ConnectionString = "Data Source=.;Initial Catalog=kutuphane;Integrated Security=SSPI";
            komut = new SqlCommand();
        komut.Connection = baglanti;
            komut.CommandText = "UPDATE ogrenci SET ograd='"+ad+"',ogrsoyad='"+soyad+"',sinif='"+sinif+"' WHERE ogrno="+no.ToString();
 
            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
        baglanti.Close();
            if (sonuc > 0)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
 
        }



    }
    }
