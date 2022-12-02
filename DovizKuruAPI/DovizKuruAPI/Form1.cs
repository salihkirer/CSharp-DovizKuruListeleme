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

            Altin altin = JsonConvert.DeserializeObject<Altin>(jsonverisi);


            label9.Text = altin.GA.alis;
            label10.Text = altin.BTC.alis;
            label11.Text = altin.USD.alis;
            label12.Text = altin.EUR.alis;

            label13.Text = altin.GA.satis;
            label14.Text = altin.BTC.satis;
            label15.Text = altin.USD.satis;
            label16.Text = altin.EUR.satis;

            label17.Text = altin.GA.degisim;
            label18.Text = altin.BTC.degisim;
            label19.Text = altin.USD.degisim;
            label20.Text = altin.EUR.degisim;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}