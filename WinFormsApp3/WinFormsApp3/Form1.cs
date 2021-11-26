using System.Xml;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));

                label1.Text = dolar.ToString();
                label2.Text = euro.ToString();
                label3.Text = sterlin.ToString();
            }
            catch (XmlException xml)
            {
               
                MessageBox.Show(xml.ToString());
            }



        }

        XmlTextReader rdr = new XmlTextReader(" http://www.tcmb.gov.tr/kurlar/today.xml");
        DataSet ds = new DataSet();
        ds.ReadXml(rdr);
 dgv.DataSource = ds.Tables["Currency"];

    }
}