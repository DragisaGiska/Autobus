namespace rok_11_7_2014
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPozadina = new System.Windows.Forms.Panel();
            this.buttonRezervisi = new System.Windows.Forms.Button();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.comboBoxLinija = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSjediste = new System.Windows.Forms.Button();
            this.textBoxSjediste = new System.Windows.Forms.TextBox();
            this.textBoxputnik = new System.Windows.Forms.TextBox();
            this.labelKategorija = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelSjediste = new System.Windows.Forms.Label();
            this.labelLinija = new System.Windows.Forms.Label();
            this.labelPutnik = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPozadina.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPozadina
            // 
            this.panelPozadina.Controls.Add(this.buttonRezervisi);
            this.panelPozadina.Controls.Add(this.comboBoxKategorija);
            this.panelPozadina.Controls.Add(this.comboBoxLinija);
            this.panelPozadina.Controls.Add(this.dateTimePicker1);
            this.panelPozadina.Controls.Add(this.buttonSjediste);
            this.panelPozadina.Controls.Add(this.textBoxSjediste);
            this.panelPozadina.Controls.Add(this.textBoxputnik);
            this.panelPozadina.Controls.Add(this.labelKategorija);
            this.panelPozadina.Controls.Add(this.labelDatum);
            this.panelPozadina.Controls.Add(this.labelSjediste);
            this.panelPozadina.Controls.Add(this.labelLinija);
            this.panelPozadina.Controls.Add(this.labelPutnik);
            this.panelPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPozadina.Location = new System.Drawing.Point(0, 0);
            this.panelPozadina.Name = "panelPozadina";
            this.panelPozadina.Size = new System.Drawing.Size(436, 339);
            this.panelPozadina.TabIndex = 0;
            this.panelPozadina.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPozadina_Paint);
            // 
            // buttonRezervisi
            // 
            this.buttonRezervisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRezervisi.Location = new System.Drawing.Point(175, 265);
            this.buttonRezervisi.Name = "buttonRezervisi";
            this.buttonRezervisi.Size = new System.Drawing.Size(165, 41);
            this.buttonRezervisi.TabIndex = 11;
            this.buttonRezervisi.Text = "Rezerviši";
            this.buttonRezervisi.UseVisualStyleBackColor = true;
            this.buttonRezervisi.Click += new System.EventHandler(this.buttonRezervisi_Click);
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxKategorija.Location = new System.Drawing.Point(149, 212);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(248, 32);
            this.comboBoxKategorija.TabIndex = 10;
            // 
            // comboBoxLinija
            // 
            this.comboBoxLinija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLinija.BackColor = System.Drawing.Color.White;
            this.comboBoxLinija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLinija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLinija.FormattingEnabled = true;
            this.comboBoxLinija.Items.AddRange(new object[] {
            "Sarajevo - Banja Luka",
            "Sarajevo - Budimpesta",
            "Sarajevo - Tuzla",
            "Sarajevo - Sofija"});
            this.comboBoxLinija.Location = new System.Drawing.Point(149, 80);
            this.comboBoxLinija.Name = "comboBoxLinija";
            this.comboBoxLinija.Size = new System.Drawing.Size(248, 32);
            this.comboBoxLinija.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // buttonSjediste
            // 
            this.buttonSjediste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSjediste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSjediste.Location = new System.Drawing.Point(355, 126);
            this.buttonSjediste.Name = "buttonSjediste";
            this.buttonSjediste.Size = new System.Drawing.Size(41, 28);
            this.buttonSjediste.TabIndex = 7;
            this.buttonSjediste.Text = ". . . ";
            this.buttonSjediste.UseVisualStyleBackColor = true;
            this.buttonSjediste.Click += new System.EventHandler(this.buttonSjediste_Click);
            // 
            // textBoxSjediste
            // 
            this.textBoxSjediste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSjediste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSjediste.Location = new System.Drawing.Point(147, 125);
            this.textBoxSjediste.Name = "textBoxSjediste";
            this.textBoxSjediste.Size = new System.Drawing.Size(193, 29);
            this.textBoxSjediste.TabIndex = 6;
            this.textBoxSjediste.TextChanged += new System.EventHandler(this.textBoxSjediste_TextChanged);
            // 
            // textBoxputnik
            // 
            this.textBoxputnik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxputnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxputnik.Location = new System.Drawing.Point(147, 37);
            this.textBoxputnik.Name = "textBoxputnik";
            this.textBoxputnik.Size = new System.Drawing.Size(249, 29);
            this.textBoxputnik.TabIndex = 5;
            // 
            // labelKategorija
            // 
            this.labelKategorija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKategorija.AutoSize = true;
            this.labelKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategorija.Location = new System.Drawing.Point(41, 220);
            this.labelKategorija.Name = "labelKategorija";
            this.labelKategorija.Size = new System.Drawing.Size(98, 24);
            this.labelKategorija.TabIndex = 4;
            this.labelKategorija.Text = "Kategorija:";
            // 
            // labelDatum
            // 
            this.labelDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(72, 176);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(69, 24);
            this.labelDatum.TabIndex = 3;
            this.labelDatum.Text = "Datum:";
            // 
            // labelSjediste
            // 
            this.labelSjediste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSjediste.AutoSize = true;
            this.labelSjediste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSjediste.Location = new System.Drawing.Point(60, 132);
            this.labelSjediste.Name = "labelSjediste";
            this.labelSjediste.Size = new System.Drawing.Size(81, 24);
            this.labelSjediste.TabIndex = 2;
            this.labelSjediste.Text = "Sjedište:";
            // 
            // labelLinija
            // 
            this.labelLinija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLinija.AutoSize = true;
            this.labelLinija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinija.Location = new System.Drawing.Point(80, 88);
            this.labelLinija.Name = "labelLinija";
            this.labelLinija.Size = new System.Drawing.Size(58, 24);
            this.labelLinija.TabIndex = 1;
            this.labelLinija.Text = "Linija:";
            // 
            // labelPutnik
            // 
            this.labelPutnik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPutnik.AutoSize = true;
            this.labelPutnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPutnik.Location = new System.Drawing.Point(72, 44);
            this.labelPutnik.Name = "labelPutnik";
            this.labelPutnik.Size = new System.Drawing.Size(66, 24);
            this.labelPutnik.TabIndex = 0;
            this.labelPutnik.Text = "Putnik:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(436, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVrijeme
            // 
            this.toolStripStatusLabelVrijeme.Name = "toolStripStatusLabelVrijeme";
            this.toolStripStatusLabelVrijeme.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelVrijeme.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 339);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelPozadina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 799);
            this.MinimumSize = new System.Drawing.Size(452, 376);
            this.Name = "Form1";
            this.Text = "Bus++ -Dragisa Mitrovic";
            this.panelPozadina.ResumeLayout(false);
            this.panelPozadina.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPozadina;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSjediste;
        private System.Windows.Forms.TextBox textBoxSjediste;
        private System.Windows.Forms.TextBox textBoxputnik;
        private System.Windows.Forms.Label labelKategorija;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelSjediste;
        private System.Windows.Forms.Label labelLinija;
        private System.Windows.Forms.Label labelPutnik;
        private System.Windows.Forms.Button buttonRezervisi;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBoxLinija;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVrijeme;
        private System.Windows.Forms.Timer timer1;
    }
}

