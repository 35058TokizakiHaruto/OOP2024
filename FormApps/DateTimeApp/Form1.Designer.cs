namespace DateTimeApp {
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
            btDateCount = new Button();
            tbDisp = new Button();
            nud = new NumericUpDown();
            btDayBefore = new Button();
            btDayAfter = new Button();
            tbDayAge = new Button();
            ((System.ComponentModel.ISupportInitialize)nud).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(28, 59);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(149, 59);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(208, 39);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(231, 116);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(126, 56);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(28, 337);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(329, 47);
            tbDisp.TabIndex = 3;
            tbDisp.UseVisualStyleBackColor = true;
            // 
            // nud
            // 
            nud.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nud.Location = new Point(28, 197);
            nud.Name = "nud";
            nud.Size = new Size(120, 46);
            nud.TabIndex = 4;
            nud.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btDayBefore
            // 
            btDayBefore.Location = new Point(231, 197);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(126, 46);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Location = new Point(231, 269);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(126, 46);
            btDayAfter.TabIndex = 5;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += btDayAfter_Click;
            // 
            // tbDayAge
            // 
            tbDayAge.Location = new Point(413, 197);
            tbDayAge.Name = "tbDayAge";
            tbDayAge.Size = new Size(126, 46);
            tbDayAge.TabIndex = 5;
            tbDayAge.Text = "年齢";
            tbDayAge.UseVisualStyleBackColor = true;
            tbDayAge.Click += btDayAfter_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(715, 478);
            Controls.Add(tbDayAge);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefore);
            Controls.Add(nud);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button btDateCount;
        private Button tbDisp;
        private NumericUpDown nud;
        private Button btDayBefore;
        private Button btDayAfter;
        private Button tbDayAge;
    }
}
