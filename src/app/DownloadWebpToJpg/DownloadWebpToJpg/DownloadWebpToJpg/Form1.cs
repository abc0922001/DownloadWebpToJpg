using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net;
using System.IO;
using System.Drawing;

namespace DownloadWebpToJpg
{
    public partial class Form1 : MaterialForm
    {
        #region Member Fields
        string _path = "";
        const string PATH = "E:\\Kuaipan\\AKB\\Downlad";
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
            //FolderBrowserDialog path = new FolderBrowserDialog(); //選擇目錄
            //path.ShowDialog();

            const string Pattern = @"^(?:([A-Za-z]+):\/\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([\d\D\w\S]+)\/)(?:([0-9.\-A-Za-z]+))(?:\/(.*))?$";
            var regex =
              new System.Text.RegularExpressions.Regex(Pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            string origurl = this.txtUrl.Text;
            var match = regex.Match(origurl);
            var rr = new GetRegexResults();
            var filename = string.Format("{0}.{1}", DateTimeOffset.Now.ToString("yyyyMMddHHmmss"), "jpg");
            rr.scheme = match.Groups[1].Value;
            rr.host = match.Groups[2].Value;
            rr.unknow1 = match.Groups[3].Value;
            rr.unknow2 = match.Groups[4].Value;
            rr.unknow3 = match.Groups[5].Value;
            rr.unknow4 = match.Groups[6].Value;
            rr.photoSize = "d";
            rr.photoName = filename;
         
            var url =
                string.Format("{0}://{1}/{2}/{3}/{4}/{5}/{6}/{7}",
                rr.scheme,
                rr.host,
                rr.unknow1,
                rr.unknow2,
                rr.unknow3,
                rr.unknow4,
                rr.photoSize,
                rr.photoName);

            System.Net.WebClient WC = new System.Net.WebClient();
            System.IO.MemoryStream Ms = new System.IO.MemoryStream(WC.DownloadData(url));
            Image img = Image.FromStream(Ms);
            img.Save(PATH + "/" + filename);

            this.lblResults.Text = "已完成： " + rr.photoName;
            this.lblResultsPath.Text = PATH;
            this._path = PATH;
            this.txtUrl.Clear();
            rr = null;
        }
        class GetRegexResults
        {
            public string scheme { get; set; }
            public string host { get; set; }
            public string unknow1 { get; set; }
            public string unknow2 { get; set; }
            public string unknow3 { get; set; }
            public string unknow4 { get; set; }
            public string photoSize { get; set; }
            public string photoName { get; set; }
        }
        private void lblResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this._path); //打開路徑
        }
    }
}
