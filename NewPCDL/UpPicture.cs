using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Util;
using System.IO;

using Newtonsoft.Json;

namespace NewPCDL
{
    public delegate void MessageEventHandler(string sParam);

    public partial class uppic_main : Form
    {
        internal static TaobaoApiSetting seta;

        public uppic_main()
        {
            InitializeComponent();
            this.Login += this.OnLogin;

            seta = JsonConvert.DeserializeObject<TaobaoApiSetting>(File.ReadAllText(@"setting.json"));
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (tb_filename.Text.Equals(string.Empty))
            {
                appendLine("文件名不能为空");
                return;
            }
            try
            {
                ITopClient client = new DefaultTopClient(seta.ApiUrl, seta.AppKey, seta.Secret);
                PictureUploadRequest req = new PictureUploadRequest();
                req.PictureCategoryId = 0L;
                req.Img = new FileItem(tb_filename.Text);
                req.ImageInputTitle = tb_up_filename.Text;
                req.Title = tb_up_title.Text;
                //req.PictureId = 10000L;
                req.ClientType = "client:computer";
                req.IsHttps = true;
                PictureUploadResponse rsp = client.Execute(req, seta.SessionKey);
                OnLoginEventHandler(rsp.Body);
                Console.WriteLine(rsp.Body);
            }
            catch (Exception ex)
            {
                appendLine(ex.ToString());
            }
            appendLine(seta.ApiUrl);
            appendLine(seta.AppKey);
            appendLine(seta.Secret);
            appendLine(seta.SessionKey);
        }

        private static MessageEventHandler OnLoginEventHandler;

        private string logMessage;

        internal event MessageEventHandler Login
        {
            add
            {
                OnLoginEventHandler += new MessageEventHandler(value);
            }
            remove
            {
                OnLoginEventHandler -= new MessageEventHandler(value);
            }
        }
        private void OnLogin(string s)
        {
            logMessage = s;
            Object[] list = { this, System.EventArgs.Empty };
            this.outputArea.BeginInvoke(new EventHandler(TextShow), list);
        }

        private void TextShow(object sender, EventArgs e)
        {
            appendLine(logMessage);
        }

        private void appendLine(string text)
        {
            this.outputArea.AppendText(text + "\n");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.outputArea.Clear();
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            openFileDialog_pic.InitialDirectory = @"C:\";
            openFileDialog_pic.RestoreDirectory = true;
            openFileDialog_pic.Filter = "所有文件 (*.*)|*.*|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.bmp)|*.bmp";
            if (openFileDialog_pic.ShowDialog() == DialogResult.OK)
            {
                //将选择的文件赋给文本框
                tb_filename.Text = openFileDialog_pic.FileName;
                pic_view.Image = new Bitmap(openFileDialog_pic.FileName);
            }
        }

        private void tb_filename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                show_pic();
                fileformat();
            }
        }

        private void tb_filename_Leave(object sender, EventArgs e)
        {
            show_pic();
            fileformat();
        }

        private void uppic_main_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            tb_filename.Text = s[0];
            show_pic();

            fileformat();
        }

        private void uppic_main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void show_pic()
        {
            try
            {
                pic_view.Image = new Bitmap(tb_filename.Text);
            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                //this.outputArea.AppendText(s);
            }
        }

        private void fileformat()
        {
            string s =  Path.GetFileName(tb_filename.Text);
            tb_up_filename.Text = s;
            tb_up_title.Text = s;
        }

        private Form setting;

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (setting == null || setting.IsDisposed)
            {
                setting = new Setting();
                setting.Show();
            }
            else
            {
                setting.Show();
                setting.Focus();
            }
        }
    }
}
