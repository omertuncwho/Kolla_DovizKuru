
using System.IO;
using System.Xml;

namespace Kolla_DovizKuru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}