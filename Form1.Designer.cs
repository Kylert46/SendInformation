namespace Gestione_ListBox
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkViaggi = new System.Windows.Forms.CheckBox();
            this.checkMusica = new System.Windows.Forms.CheckBox();
            this.checkInternet = new System.Windows.Forms.CheckBox();
            this.checkSport = new System.Windows.Forms.CheckBox();
            this.checkCinema = new System.Windows.Forms.CheckBox();
            this.checkLettura = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEta = new System.Windows.Forms.ComboBox();
            this.bEsci = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bInserisci = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lNumeroRighe = new System.Windows.Forms.Label();
            this.bSalva = new System.Windows.Forms.Button();
            this.bOrdina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome_Cognome";
            // 
            // tNome
            // 
            this.tNome.Cursor = System.Windows.Forms.Cursors.No;
            this.tNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNome.Location = new System.Drawing.Point(12, 53);
            this.tNome.MaxLength = 20;
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(268, 29);
            this.tNome.TabIndex = 1;
            this.tNome.TextChanged += new System.EventHandler(this.tNome_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sesso";
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Checked = true;
            this.radioF.Location = new System.Drawing.Point(92, 29);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(43, 29);
            this.radioF.TabIndex = 1;
            this.radioF.TabStop = true;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(17, 30);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(48, 29);
            this.radioM.TabIndex = 0;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.checkViaggi);
            this.groupBox2.Controls.Add(this.checkMusica);
            this.groupBox2.Controls.Add(this.checkInternet);
            this.groupBox2.Controls.Add(this.checkSport);
            this.groupBox2.Controls.Add(this.checkCinema);
            this.groupBox2.Controls.Add(this.checkLettura);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 251);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interessi";
            // 
            // checkViaggi
            // 
            this.checkViaggi.AutoSize = true;
            this.checkViaggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkViaggi.Location = new System.Drawing.Point(18, 206);
            this.checkViaggi.Name = "checkViaggi";
            this.checkViaggi.Size = new System.Drawing.Size(82, 28);
            this.checkViaggi.TabIndex = 3;
            this.checkViaggi.Text = "Viaggi";
            this.checkViaggi.UseVisualStyleBackColor = true;
            // 
            // checkMusica
            // 
            this.checkMusica.AutoSize = true;
            this.checkMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMusica.Location = new System.Drawing.Point(18, 172);
            this.checkMusica.Name = "checkMusica";
            this.checkMusica.Size = new System.Drawing.Size(89, 28);
            this.checkMusica.TabIndex = 3;
            this.checkMusica.Text = "Musica";
            this.checkMusica.UseVisualStyleBackColor = true;
            // 
            // checkInternet
            // 
            this.checkInternet.AutoSize = true;
            this.checkInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInternet.Location = new System.Drawing.Point(17, 137);
            this.checkInternet.Name = "checkInternet";
            this.checkInternet.Size = new System.Drawing.Size(186, 28);
            this.checkInternet.TabIndex = 3;
            this.checkInternet.Text = "Internet/Informatica";
            this.checkInternet.UseVisualStyleBackColor = true;
            // 
            // checkSport
            // 
            this.checkSport.AutoSize = true;
            this.checkSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSport.Location = new System.Drawing.Point(17, 103);
            this.checkSport.Name = "checkSport";
            this.checkSport.Size = new System.Drawing.Size(73, 28);
            this.checkSport.TabIndex = 2;
            this.checkSport.Text = "Sport";
            this.checkSport.UseVisualStyleBackColor = true;
            // 
            // checkCinema
            // 
            this.checkCinema.AutoSize = true;
            this.checkCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCinema.Location = new System.Drawing.Point(17, 69);
            this.checkCinema.Name = "checkCinema";
            this.checkCinema.Size = new System.Drawing.Size(153, 28);
            this.checkCinema.TabIndex = 1;
            this.checkCinema.Text = "Uomo di legge";
            this.checkCinema.UseVisualStyleBackColor = true;
            // 
            // checkLettura
            // 
            this.checkLettura.AutoSize = true;
            this.checkLettura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLettura.Location = new System.Drawing.Point(17, 35);
            this.checkLettura.Name = "checkLettura";
            this.checkLettura.Size = new System.Drawing.Size(128, 28);
            this.checkLettura.TabIndex = 0;
            this.checkLettura.Text = "Non-Legale";
            this.checkLettura.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Età";
            // 
            // comboEta
            // 
            this.comboEta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEta.FormattingEnabled = true;
            this.comboEta.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "30+"});
            this.comboEta.Location = new System.Drawing.Point(174, 123);
            this.comboEta.Name = "comboEta";
            this.comboEta.Size = new System.Drawing.Size(90, 28);
            this.comboEta.TabIndex = 5;
            this.comboEta.DropDown += new System.EventHandler(this.comboEta_DropDown);
            this.comboEta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEta_KeyPress);
            // 
            // bEsci
            // 
            this.bEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEsci.Location = new System.Drawing.Point(982, 447);
            this.bEsci.Name = "bEsci";
            this.bEsci.Size = new System.Drawing.Size(101, 36);
            this.bEsci.TabIndex = 6;
            this.bEsci.Text = "Esci";
            this.bEsci.UseVisualStyleBackColor = true;
            this.bEsci.Click += new System.EventHandler(this.bEsci_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Gold;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(286, 443);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(249, 40);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Cancella riga della ListBox";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bInserisci
            // 
            this.bInserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInserisci.Location = new System.Drawing.Point(125, 443);
            this.bInserisci.Name = "bInserisci";
            this.bInserisci.Size = new System.Drawing.Size(127, 40);
            this.bInserisci.TabIndex = 9;
            this.bInserisci.Text = "Inserisci ";
            this.bInserisci.UseVisualStyleBackColor = true;
            this.bInserisci.Click += new System.EventHandler(this.bInserisci_Click);
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(12, 441);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(107, 42);
            this.bReset.TabIndex = 8;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(286, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(797, 382);
            this.listBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personaggi";
            // 
            // lNumeroRighe
            // 
            this.lNumeroRighe.AutoSize = true;
            this.lNumeroRighe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumeroRighe.Location = new System.Drawing.Point(926, 32);
            this.lNumeroRighe.Name = "lNumeroRighe";
            this.lNumeroRighe.Size = new System.Drawing.Size(114, 18);
            this.lNumeroRighe.TabIndex = 0;
            this.lNumeroRighe.Text = "Numero righe: 0";
            // 
            // bSalva
            // 
            this.bSalva.BackColor = System.Drawing.Color.Gold;
            this.bSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalva.Location = new System.Drawing.Point(670, 445);
            this.bSalva.Name = "bSalva";
            this.bSalva.Size = new System.Drawing.Size(297, 40);
            this.bSalva.TabIndex = 7;
            this.bSalva.Text = "Salva Lista personaggi in un file txt";
            this.bSalva.UseVisualStyleBackColor = false;
            this.bSalva.Click += new System.EventHandler(this.bSalva_Click);
            // 
            // bOrdina
            // 
            this.bOrdina.BackColor = System.Drawing.Color.Gold;
            this.bOrdina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrdina.Location = new System.Drawing.Point(559, 445);
            this.bOrdina.Name = "bOrdina";
            this.bOrdina.Size = new System.Drawing.Size(88, 40);
            this.bOrdina.TabIndex = 7;
            this.bOrdina.Text = "Ordina";
            this.bOrdina.UseVisualStyleBackColor = false;
            this.bOrdina.Click += new System.EventHandler(this.bOrdina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1096, 497);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bInserisci);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSalva);
            this.Controls.Add(this.bOrdina);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEsci);
            this.Controls.Add(this.comboEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tNome);
            this.Controls.Add(this.lNumeroRighe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkInternet;
        private System.Windows.Forms.CheckBox checkSport;
        private System.Windows.Forms.CheckBox checkCinema;
        private System.Windows.Forms.CheckBox checkLettura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEta;
        private System.Windows.Forms.Button bEsci;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bInserisci;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkViaggi;
        private System.Windows.Forms.CheckBox checkMusica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNumeroRighe;
        private System.Windows.Forms.Button bSalva;
        private System.Windows.Forms.Button bOrdina;
    }
}

