namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            cbAuthor = new ComboBox();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            groupBox2 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            tbReport = new TextBox();
            label7 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            btReportSave = new Button();
            button8 = new Button();
            dgvCarReport = new DataGridView();
            btReportOpen = new Button();
            ofdPicFileOpen = new OpenFileDialog();
            ssMassageArea = new StatusStrip();
            tslbMassage = new ToolStripStatusLabel();
            tslbbMessage = new ToolStripStatusLabel();
            tslbMessage = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            ssMassageArea.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(101, 18);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(31, 154);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(44, 212);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(103, 204);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(280, 33);
            cbCarName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(25, 272);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 0;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(100, 88);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(283, 33);
            cbAuthor.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "トヨタ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(103, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 43);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(103, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "トヨタ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(47, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "トヨタ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(42, 390);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbOther);
            groupBox2.Controls.Add(rbImport);
            groupBox2.Controls.Add(rbSubaru);
            groupBox2.Controls.Add(rbHonda);
            groupBox2.Controls.Add(rbNissan);
            groupBox2.Controls.Add(rbToyota);
            groupBox2.Location = new Point(103, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 43);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(283, 15);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 3;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(220, 15);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 3;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(164, 15);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(109, 15);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 3;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(58, 15);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 3;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 15);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 3;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(104, 259);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(375, 115);
            tbReport.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(500, 52);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.Location = new Point(586, 56);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 6;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(695, 56);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 6;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.FromArgb(192, 255, 255);
            pbPicture.Location = new Point(519, 85);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(251, 212);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 7;
            pbPicture.TabStop = false;
            // 
            // btAddReport
            // 
            btAddReport.Location = new Point(500, 325);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(75, 23);
            btAddReport.TabIndex = 6;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.Location = new Point(597, 325);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(75, 23);
            btModifyReport.TabIndex = 6;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = true;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Location = new Point(694, 325);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(75, 23);
            btDeleteReport.TabIndex = 6;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            btDeleteReport.Click += btDeleteReport_Click;
            // 
            // btReportSave
            // 
            btReportSave.Location = new Point(25, 469);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(56, 23);
            btReportSave.TabIndex = 6;
            btReportSave.Text = "保存";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(695, 523);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 6;
            button8.Text = "終了";
            button8.UseVisualStyleBackColor = true;
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(104, 390);
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.Size = new Size(666, 132);
            dgvCarReport.TabIndex = 8;
            dgvCarReport.Click += dgvCarReport_Click;
            // 
            // btReportOpen
            // 
            btReportOpen.Location = new Point(25, 430);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(56, 23);
            btReportOpen.TabIndex = 6;
            btReportOpen.Text = "開く";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            ofdPicFileOpen.FileOk += btPicOpen_Click;
            // 
            // ssMassageArea
            // 
            ssMassageArea.Items.AddRange(new ToolStripItem[] { tslbMassage, tslbbMessage, tslbMessage });
            ssMassageArea.Location = new Point(0, 549);
            ssMassageArea.Name = "ssMassageArea";
            ssMassageArea.Size = new Size(803, 22);
            ssMassageArea.TabIndex = 9;
            ssMassageArea.Text = "statusStrip1";
            // 
            // tslbMassage
            // 
            tslbMassage.Name = "tslbMassage";
            tslbMassage.Size = new Size(0, 17);
            // 
            // tslbbMessage
            // 
            tslbbMessage.Name = "tslbbMessage";
            tslbbMessage.Size = new Size(0, 17);
            // 
            // tslbMessage
            // 
            tslbMessage.Name = "tslbMessage";
            tslbMessage.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 571);
            Controls.Add(ssMassageArea);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btReportOpen);
            Controls.Add(btReportSave);
            Controls.Add(button8);
            Controls.Add(btAddReport);
            Controls.Add(btPicOpen);
            Controls.Add(tbReport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cbAuthor);
            Controls.Add(cbCarName);
            Controls.Add(dtpDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "試乗レポート管理システム";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ssMassageArea.ResumeLayout(false);
            ssMassageArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private ComboBox cbAuthor;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label6;
        private GroupBox groupBox2;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private TextBox tbReport;
        private RadioButton rbOther;
        private Label label7;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Button btReportSave;
        private Button button8;
        private DataGridView dgvCarReport;
        private Button btReportOpen;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip ssMassageArea;
        private ToolStripStatusLabel tslbMassage;
        private ToolStripStatusLabel tslbbMessage;
        private ToolStripStatusLabel tslbMessage;
    }
}
