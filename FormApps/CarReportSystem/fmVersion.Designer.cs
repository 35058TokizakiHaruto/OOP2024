namespace CarReportSystem {
    partial class fmVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btVersionOK = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btVersionOK
            // 
            btVersionOK.Location = new Point(362, 40);
            btVersionOK.Name = "btVersionOK";
            btVersionOK.Size = new Size(75, 23);
            btVersionOK.TabIndex = 0;
            btVersionOK.Text = "OK";
            btVersionOK.UseVisualStyleBackColor = true;
            btVersionOK.Click += btVersionOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ＭＳ Ｐゴシック", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 128);
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(227, 27);
            label1.TabIndex = 1;
            label1.Text = "CarReportSystem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(267, 36);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Ver.0.0.1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(156, 70);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 3;
            label3.Text = "32bit-edition";
            // 
            // fmVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 353);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btVersionOK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fmVersion";
            Text = "fmVersion";
            Load += fmVersion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button btVersionOK;
        private Label label3;
    }
}