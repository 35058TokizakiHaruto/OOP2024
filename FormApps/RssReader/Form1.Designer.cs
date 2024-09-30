namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbRssUrl = new System.Windows.Forms.TextBox();
            this.cbGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.URL = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRssUrl
            // 
            this.tbRssUrl.Location = new System.Drawing.Point(196, 45);
            this.tbRssUrl.Name = "tbRssUrl";
            this.tbRssUrl.Size = new System.Drawing.Size(130, 19);
            this.tbRssUrl.TabIndex = 0;
            // 
            // cbGet
            // 
            this.cbGet.Location = new System.Drawing.Point(448, 12);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(75, 23);
            this.cbGet.TabIndex = 1;
            this.cbGet.Text = "取得";
            this.cbGet.UseVisualStyleBackColor = true;
            this.cbGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(50, 85);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(209, 316);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.LbRssTitle_SelectedIndexChanged);
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(196, 12);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(236, 20);
            this.cbRssUrl.TabIndex = 4;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Cursor = System.Windows.Forms.Cursors.Default;
            this.URL.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.URL.Location = new System.Drawing.Point(27, 17);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(163, 12);
            this.URL.TabIndex = 5;
            this.URL.Text = "このURL又はお気に入り名称：";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.Cursor = System.Windows.Forms.Cursors.Default;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(265, 85);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(748, 524);
            this.webView21.TabIndex = 6;
            this.webView21.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(89, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "お気に入り名称：";
            // 
            // tbGet
            // 
            this.tbGet.Location = new System.Drawing.Point(342, 43);
            this.tbGet.Name = "tbGet";
            this.tbGet.Size = new System.Drawing.Size(75, 23);
            this.tbGet.TabIndex = 8;
            this.tbGet.Text = "登録";
            this.tbGet.UseVisualStyleBackColor = true;
            this.tbGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1053, 745);
            this.Controls.Add(this.tbGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.cbGet);
            this.Controls.Add(this.tbRssUrl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRssUrl;
        private System.Windows.Forms.Button cbGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Label URL;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbGet;
    }
}

