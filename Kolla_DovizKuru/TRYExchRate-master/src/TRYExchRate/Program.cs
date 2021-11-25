using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


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

      




    }
    }
