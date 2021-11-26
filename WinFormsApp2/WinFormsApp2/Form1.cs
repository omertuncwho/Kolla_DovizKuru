
using System.Xml;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument tcmbdoviz = XmlDocument.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument tcmbdoviz = XmlDocument.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            listBox1.Items.Clear();

            try
            {
                //Linq kullanarak verileri getir
                var kurbilgileri = from kurlar in tcmbdoviz.Descendants("Currency")
                                   select new
                                   {
                                       kuraditr = kurlar.Element("Isim").Value
                                   };
                //Listbox'a aktar
                foreach (var dovizler in kurbilgileri)
                {
                    listBox1.Items.Add(dovizler.kuraditr.ToString());
                }
            }
            catch (Exception hata)
            {
                label1.Text = "Veriler alınamadı. Hata :" + hata.Message;
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Elemanlar değiştiğinde https://www.bilisimogretmeni.com/
            var kurbilgileri = from kurlar in tcmbdoviz.Descendants("Currency")
                               where kurlar.Element("Isim").Value == listBox1.SelectedItem.ToString()
                               select new
                               {
                                   kuradiing = kurlar.Element("CurrencyName").Value,
                                   kuralis = kurlar.Element("ForexBuying").Value,
                                   kursatis = kurlar.Element("ForexSelling").Value
                               };
            foreach (var veriler in kurbilgileri)
            {
                label1.Text = string.Format("Adı : {0} Alış : {1:C} Satış : {2:C}",
                    veriler.kuradiing, veriler.kuralis, veriler.kursatis);
            }
        }
    }
}

