using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace NewPCDL
{
    public partial class Setting : Form
    {
        private const string REAL_URL = "http://gw.api.taobao.com/router/rest";
        private const string SANDBOX_URL = "http://gw.api.tbsandbox.com/router/rest";

        public Setting()
        {
            InitializeComponent();
            // read file into a string and deserialize JSON to a type
            uppic_main.seta = JsonConvert.DeserializeObject<TaobaoApiSetting>(File.ReadAllText(@"setting.json"));

            this.tb_apiurl.Text = uppic_main.seta.ApiUrl;
            this.tb_appkey.Text = uppic_main.seta.AppKey;
            this.tb_secret.Text = uppic_main.seta.Secret;
            this.tb_sessionkey.Text = uppic_main.seta.SessionKey;

            // deserialize JSON directly from a file
            //using (StreamReader file = File.OpenText(@"setting.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    Setting movie2 = (Setting)serializer.Deserialize(file, typeof(Setting));
            //}
        }

        private void btn_real_url_Click(object sender, EventArgs e)
        {
            tb_apiurl.Text = REAL_URL;
        }

        private void btn_sandbox_url_Click(object sender, EventArgs e)
        {
            tb_apiurl.Text = SANDBOX_URL;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //TaobaoApiSetting set = new TaobaoApiSetting
            //{
            //    ApiUrl = tb_apiurl.Text,
            //    AppKey = tb_appkey.Text,
            //    Secret = tb_secret.Text,
            //    SessionKey = tb_sessionkey.Text
            //};
            //File.WriteAllText(@"setting.json", JsonConvert.SerializeObject(set));
            uppic_main.seta.ApiUrl = tb_apiurl.Text;
            uppic_main.seta.AppKey = tb_appkey.Text;
            uppic_main.seta.Secret = tb_secret.Text;
            uppic_main.seta.SessionKey = tb_sessionkey.Text;
            File.WriteAllText(@"setting.json", JsonConvert.SerializeObject(uppic_main.seta));
        }
    }
}
