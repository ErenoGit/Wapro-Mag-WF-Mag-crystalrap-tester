namespace WaproCrystalrapTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generatePdfBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlServer = new System.Windows.Forms.TextBox();
            this.sqlDatabase = new System.Windows.Forms.TextBox();
            this.sqlUser = new System.Windows.Forms.TextBox();
            this.sqlPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sqlConnectBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.documentComboBox = new System.Windows.Forms.ComboBox();
            this.reportComboBox = new System.Windows.Forms.ComboBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.waproFolder = new System.Windows.Forms.TextBox();
            this.pdfFolder = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generateCommand = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generatePdfBtn
            // 
            this.generatePdfBtn.Enabled = false;
            this.generatePdfBtn.Location = new System.Drawing.Point(179, 364);
            this.generatePdfBtn.Name = "generatePdfBtn";
            this.generatePdfBtn.Size = new System.Drawing.Size(141, 23);
            this.generatePdfBtn.TabIndex = 0;
            this.generatePdfBtn.Text = "Generuj PDF";
            this.generatePdfBtn.UseVisualStyleBackColor = true;
            this.generatePdfBtn.Click += new System.EventHandler(this.generatePdfBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serwer SQL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Użytkownik SQL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasło SQL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nazwa bazy danych:";
            // 
            // sqlServer
            // 
            this.sqlServer.Location = new System.Drawing.Point(129, 20);
            this.sqlServer.Name = "sqlServer";
            this.sqlServer.Size = new System.Drawing.Size(234, 20);
            this.sqlServer.TabIndex = 5;
            // 
            // sqlDatabase
            // 
            this.sqlDatabase.Location = new System.Drawing.Point(129, 50);
            this.sqlDatabase.Name = "sqlDatabase";
            this.sqlDatabase.Size = new System.Drawing.Size(234, 20);
            this.sqlDatabase.TabIndex = 6;
            // 
            // sqlUser
            // 
            this.sqlUser.Location = new System.Drawing.Point(129, 78);
            this.sqlUser.Name = "sqlUser";
            this.sqlUser.Size = new System.Drawing.Size(234, 20);
            this.sqlUser.TabIndex = 7;
            // 
            // sqlPassword
            // 
            this.sqlPassword.Location = new System.Drawing.Point(129, 104);
            this.sqlPassword.Name = "sqlPassword";
            this.sqlPassword.Size = new System.Drawing.Size(234, 20);
            this.sqlPassword.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sqlConnectBtn);
            this.groupBox1.Controls.Add(this.sqlPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sqlUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sqlDatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sqlServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Połączenie z bazą SQL";
            // 
            // sqlConnectBtn
            // 
            this.sqlConnectBtn.Location = new System.Drawing.Point(382, 111);
            this.sqlConnectBtn.Name = "sqlConnectBtn";
            this.sqlConnectBtn.Size = new System.Drawing.Size(89, 23);
            this.sqlConnectBtn.TabIndex = 5;
            this.sqlConnectBtn.Text = "Połącz";
            this.sqlConnectBtn.UseVisualStyleBackColor = true;
            this.sqlConnectBtn.Click += new System.EventHandler(this.sqlConnectBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Raport:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.documentComboBox);
            this.groupBox2.Controls.Add(this.reportComboBox);
            this.groupBox2.Controls.Add(this.companyComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konfiguracja generowania";
            // 
            // documentComboBox
            // 
            this.documentComboBox.Enabled = false;
            this.documentComboBox.FormattingEnabled = true;
            this.documentComboBox.Location = new System.Drawing.Point(66, 74);
            this.documentComboBox.Name = "documentComboBox";
            this.documentComboBox.Size = new System.Drawing.Size(395, 21);
            this.documentComboBox.TabIndex = 17;
            this.documentComboBox.SelectedIndexChanged += new System.EventHandler(this.documentComboBox_SelectedIndexChanged);
            // 
            // reportComboBox
            // 
            this.reportComboBox.Enabled = false;
            this.reportComboBox.FormattingEnabled = true;
            this.reportComboBox.Location = new System.Drawing.Point(66, 45);
            this.reportComboBox.Name = "reportComboBox";
            this.reportComboBox.Size = new System.Drawing.Size(395, 21);
            this.reportComboBox.TabIndex = 16;
            this.reportComboBox.SelectedIndexChanged += new System.EventHandler(this.reportComboBox_SelectedIndexChanged);
            // 
            // companyComboBox
            // 
            this.companyComboBox.Enabled = false;
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(66, 18);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(395, 21);
            this.companyComboBox.TabIndex = 15;
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Firma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dokument:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ścieżka do katalogu Wapro (WAPRO MAG): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ścieżka do katalogu gdzie zapisywać PDF:";
            // 
            // waproFolder
            // 
            this.waproFolder.Location = new System.Drawing.Point(231, 295);
            this.waproFolder.Name = "waproFolder";
            this.waproFolder.Size = new System.Drawing.Size(208, 20);
            this.waproFolder.TabIndex = 14;
            // 
            // pdfFolder
            // 
            this.pdfFolder.Location = new System.Drawing.Point(231, 324);
            this.pdfFolder.Name = "pdfFolder";
            this.pdfFolder.Size = new System.Drawing.Size(208, 20);
            this.pdfFolder.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WaproCrystalrapTester.Properties.Resources.Folder;
            this.pictureBox2.Location = new System.Drawing.Point(447, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WaproCrystalrapTester.Properties.Resources.Folder;
            this.pictureBox1.Location = new System.Drawing.Point(447, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // generateCommand
            // 
            this.generateCommand.Location = new System.Drawing.Point(12, 403);
            this.generateCommand.Multiline = true;
            this.generateCommand.Name = "generateCommand";
            this.generateCommand.ReadOnly = true;
            this.generateCommand.Size = new System.Drawing.Size(477, 61);
            this.generateCommand.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 476);
            this.Controls.Add(this.generateCommand);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pdfFolder);
            this.Controls.Add(this.waproFolder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generatePdfBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Wapro Crystalrap Tester v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generatePdfBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sqlServer;
        private System.Windows.Forms.TextBox sqlDatabase;
        private System.Windows.Forms.TextBox sqlUser;
        private System.Windows.Forms.TextBox sqlPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sqlConnectBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox documentComboBox;
        private System.Windows.Forms.ComboBox reportComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox waproFolder;
        private System.Windows.Forms.TextBox pdfFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox generateCommand;
    }
}

