using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Drawing;

namespace DownloadWebpToJpg
{
    public partial class Form1 : MaterialForm
    {
        #region Member Fields
        string _path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Download");
        const string PHOTO_SIZE = "d";
        const string Pattern =
                @"^(?:([A-Za-z]+)\:\/\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+))(?:\/(.*))?$";
        #endregion
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDownload_Click(object sender, EventArgs e)
        {

            var regex =
              new System.Text.RegularExpressions.Regex(Pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            string origurl = this.txtUrl.Text;
            var match = regex.Match(origurl);
            var rr = new GetRegexResults();

            rr.scheme = match.Groups[1].Value;
            rr.host = match.Groups[2].Value;
            rr.unknow = string.Format("{0}/{1}/{2}/{3}",
            match.Groups[3].Value,
            match.Groups[4].Value,
            match.Groups[5].Value,
            match.Groups[6].Value
            );
            string filename = string.Format("{0}.{1}", DateTimeOffset.Now.ToString("yyyyMMddHHmmss"), "jpg");
            rr.photoSize = PHOTO_SIZE;
            rr.photoName = filename;

            var url =
                string.Format("{0}://{1}/{2}/{3}/{4}",
                rr.scheme,
                rr.host,
                rr.unknow,
                rr.photoSize,
                rr.photoName);

            System.Net.WebClient WC = new System.Net.WebClient();
            var sb = new System.Text.StringBuilder();
            try
            {
                System.IO.MemoryStream Ms = new System.IO.MemoryStream(WC.DownloadData(url));

                Image img = Image.FromStream(Ms);
                System.IO.Directory.CreateDirectory(_path);
                img.Save(this._path + "/" + filename);
                this.lblResults.Text = "已完成： " + rr.photoName;
                this.lblResultsPath.Text = this._path;
            }
            catch (Exception ex)
            {
                sb.AppendFormat("發生例外 : {0}", ex.ToString());
                this.lblResults.Text = sb.ToString();
            }
            finally
            {
                this.txtUrl.Clear();
                rr = null;
                sb.Clear();
            }

        }
        class GetRegexResults
        {
            public string scheme { get; set; }
            public string host { get; set; }
            public string unknow { get; set; }
            public string photoSize { get; set; }
            public string photoName { get; set; }
        }
        private void lblResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this._path); //打開路徑
        }

        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog(); //選擇目錄
            if (path.ShowDialog() == DialogResult.OK)
            {
                this._path = path.SelectedPath;
                this.lblResultsPath.Text = this._path;
            }
        }
    }
}
