// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static SqlConnection comand;
Console.WriteLine("Getting Connection ...");
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
//"UPDATE DOVIZKURLARI SET DolarIsim='ABD DOLARI', DolarCurrencyName='US DOLLAR', DolarForexBuying='" + ("USD", ExchRateType.ForexBuying) + "',DolarForexSelling='" + ("USD", ExchRateType.ForexSelling) + "',EuroIsim='EURO',EuroCurrencyName='EURO',EuroForexBuying='" + ("EUR", ExchRateType.ForexBuying) + "',EuroForexSelling='" + ("EUR", ExchRateType.ForexSelling) + "', WHERE ogrno=" + no.ToString();

Console.WriteLine(DateTime.Now);

//Veri tabanı bağlantısı test komutları.
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
        

    