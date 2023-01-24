using static DovizKuruAPI.DovizModel;
using System.Net;
using Newtonsoft.Json;

namespace DovizKuruAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string url = "https://api.genelpara.com/embed/altin.json";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            string jsonverisi = "";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader r = new StreamReader(response.GetResponseStream());
                jsonverisi = r.ReadToEnd();
            }

            Doviz doviz = JsonConvert.DeserializeObject<Doviz>(jsonverisi);


            label9.Text = doviz.GA.alis;
            label10.Text = doviz.BTC.alis;
            label11.Text = doviz.USD.alis;
            label12.Text = doviz.EUR.alis;

            label13.Text = doviz.GA.satis;
            label14.Text = doviz.BTC.satis;
            label15.Text = doviz.USD.satis;
            label16.Text = doviz.EUR.satis;

            label17.Text = doviz.GA.degisim;
            label18.Text = doviz.BTC.degisim;
            label19.Text = doviz.USD.degisim;
            label20.Text = doviz.EUR.degisim;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}