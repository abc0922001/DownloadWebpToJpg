using MaterialSkin.Controls;

namespace DownloadWebpToJpg
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUrl = new MaterialSkin.Controls.MaterialLabel();
            this.txtUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblResultsPath = new System.Windows.Forms.LinkLabel();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSelectSavePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Depth = 0;
            this.lblUrl.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUrl.Location = new System.Drawing.Point(55, 121);
            this.lblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(41, 19);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "網址";
            // 
            // txtUrl
            // 
            this.txtUrl.Depth = 0;
            this.txtUrl.Hint = "";
            this.txtUrl.Location = new System.Drawing.Point(144, 118);
            this.txtUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.Size = new System.Drawing.Size(558, 23);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.UseSystemPasswordChar = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDownload.Location = new System.Drawing.Point(598, 164);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(104, 93);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "下載";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblResultsPath
            // 
            this.lblResultsPath.AutoSize = true;
            this.lblResultsPath.Location = new System.Drawing.Point(57, 164);
            this.lblResultsPath.Name = "lblResultsPath";
            this.lblResultsPath.Size = new System.Drawing.Size(25, 12);
            this.lblResultsPath.TabIndex = 7;
            this.lblResultsPath.TabStop = true;
            this.lblResultsPath.Text = "path";
            this.lblResultsPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblResults_LinkClicked);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(57, 196);
            this.lblResults.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(29, 12);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "結果";
            // 
            // btnSelectSavePath
            // 
            this.btnSelectSavePath.Location = new System.Drawing.Point(413, 164);
            this.btnSelectSavePath.Name = "btnSelectSavePath";
            this.btnSelectSavePath.Size = new System.Drawing.Size(92, 23);
            this.btnSelectSavePath.TabIndex = 9;
            this.btnSelectSavePath.Text = "選擇儲存位置";
            this.btnSelectSavePath.UseVisualStyleBackColor = true;
            this.btnSelectSavePath.Click += new System.EventHandler(this.btnSelectSavePath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 303);
            this.Controls.Add(this.btnSelectSavePath);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblResultsPath);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "Form1";
            this.Text = "Download Google+ Photo to jpg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialLabel lblUrl;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUrl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.LinkLabel lblResultsPath;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSelectSavePath;
    }
}

