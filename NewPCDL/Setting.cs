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
        private const string PCDL_APP_KEY = "12527264";

        public Setting()
        {
            InitializeComponent();
            Main.setit = SettingFileController.ReadSettingFile();
            tb_apiurl.Text = Main.setit.ApiUrl;
            tb_appkey.Text = Main.setit.AppKey;
            tb_secret.Text = Main.setit.Secret;
            tb_sessionkey.Text = Main.setit.SessionKey;
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
            Main.setit.ApiUrl = tb_apiurl.Text;
            Main.setit.AppKey = tb_appkey.Text;
            Main.setit.Secret = tb_secret.Text;
            Main.setit.SessionKey = tb_sessionkey.Text;
            File.WriteAllText(@"setting.json", JsonConvert.SerializeObject(Main.setit));
            this.Close();
        }

        private void btn_pcdl_key_Click(object sender, EventArgs e)
        {
            tb_appkey.Text = PCDL_APP_KEY;
        }
    }
}
