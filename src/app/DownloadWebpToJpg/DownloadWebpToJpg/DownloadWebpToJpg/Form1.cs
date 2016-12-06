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

            // Google+ webp url https://lh3.googleusercontent.com/-VWgf1rOPY2c/WEWCXWt2y3I/AAAAAAAANz8/niaCNgGnoIkKTPuaqQVtCbhWhFm7rMV7ACJoC/w716-h538-p-rw/70554a2c-8ac8-4609-b578-0cfb9ca29b27
            //
            //const string Pattern = @"";
            //var regex =
            //  new System.Text.RegularExpressions.Regex(Pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            //string trTxt = null;
            //var match = regex.Match(trTxt);

            string origurl = this.txtUrl.Text;
            var url = origurl;
            var filename = string.Format("{0}.{1}", DateTimeOffset.Now.ToString("yyyyMMddHHmmss"), "jpg");
            System.Net.WebClient WC = new System.Net.WebClient();
            System.IO.MemoryStream Ms = new System.IO.MemoryStream(WC.DownloadData(url));
            Image img = Image.FromStream(Ms);
            img.Save(PATH + "/" + filename);


            this.lblResults.Text = PATH;
            this._path = PATH;

        }

        private void lblResults_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this._path); //打開路徑
        }
    }
}
