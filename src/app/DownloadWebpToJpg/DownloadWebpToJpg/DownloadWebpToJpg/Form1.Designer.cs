using MaterialSkin;
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
            this.lblSavePath = new MaterialSkin.Controls.MaterialLabel();
            this.txtUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSavePath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSetSavePath = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Depth = 0;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUrl.Location = new System.Drawing.Point(55, 121);
            this.lblUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(41, 20);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "網址";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Depth = 0;
            this.lblSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSavePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSavePath.Location = new System.Drawing.Point(55, 181);
            this.lblSavePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(73, 20);
            this.lblSavePath.TabIndex = 1;
            this.lblSavePath.Text = "儲存位置";
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
            // txtSavePath
            // 
            this.txtSavePath.Depth = 0;
            this.txtSavePath.Hint = "";
            this.txtSavePath.Location = new System.Drawing.Point(144, 178);
            this.txtSavePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.PasswordChar = '\0';
            this.txtSavePath.SelectedText = "";
            this.txtSavePath.SelectionLength = 0;
            this.txtSavePath.SelectionStart = 0;
            this.txtSavePath.Size = new System.Drawing.Size(527, 23);
            this.txtSavePath.TabIndex = 3;
            this.txtSavePath.UseSystemPasswordChar = false;
            // 
            // btnSetSavePath
            // 
            this.btnSetSavePath.Location = new System.Drawing.Point(677, 177);
            this.btnSetSavePath.Name = "btnSetSavePath";
            this.btnSetSavePath.Size = new System.Drawing.Size(25, 23);
            this.btnSetSavePath.TabIndex = 4;
            this.btnSetSavePath.Text = "...";
            this.btnSetSavePath.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDownload.Location = new System.Drawing.Point(598, 234);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(104, 93);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "下載";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(63, 279);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 12);
            this.lblResults.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 465);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSetSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.lblUrl);
            this.Name = "Form1";
            this.Text = "Download Google+ Photo to jpg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblSavePath;
        private MaterialLabel lblUrl;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUrl;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSavePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSetSavePath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblResults;
    }
}

