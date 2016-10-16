namespace ModelFirstUplatnica
{
    partial class Pocetna
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
            this.dataGridSveOtpremnice = new System.Windows.Forms.DataGridView();
            this.DodajOtpremnicu = new System.Windows.Forms.Button();
            this.IzmaniOtpremnicu = new System.Windows.Forms.Button();
            this.ObrisiOtpremnicu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filter = new System.Windows.Forms.Button();
            this.filterPartnerComboBox = new System.Windows.Forms.ComboBox();
            this.filterDatumComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSveOtpremnice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSveOtpremnice
            // 
            this.dataGridSveOtpremnice.AllowUserToAddRows = false;
            this.dataGridSveOtpremnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSveOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSveOtpremnice.Location = new System.Drawing.Point(12, 357);
            this.dataGridSveOtpremnice.Name = "dataGridSveOtpremnice";
            this.dataGridSveOtpremnice.Size = new System.Drawing.Size(788, 244);
            this.dataGridSveOtpremnice.TabIndex = 0;
            this.dataGridSveOtpremnice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSveOtpremnice_CellClick);
            // 
            // DodajOtpremnicu
            // 
            this.DodajOtpremnicu.BackColor = System.Drawing.Color.Lime;
            this.DodajOtpremnicu.Location = new System.Drawing.Point(829, 39);
            this.DodajOtpremnicu.Name = "DodajOtpremnicu";
            this.DodajOtpremnicu.Size = new System.Drawing.Size(90, 89);
            this.DodajOtpremnicu.TabIndex = 1;
            this.DodajOtpremnicu.Text = "Dodaj Otpremnicu";
            this.DodajOtpremnicu.UseVisualStyleBackColor = false;
            this.DodajOtpremnicu.Click += new System.EventHandler(this.DodajOtpremnicu_Click);
            // 
            // IzmaniOtpremnicu
            // 
            this.IzmaniOtpremnicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IzmaniOtpremnicu.Location = new System.Drawing.Point(829, 271);
            this.IzmaniOtpremnicu.Name = "IzmaniOtpremnicu";
            this.IzmaniOtpremnicu.Size = new System.Drawing.Size(90, 82);
            this.IzmaniOtpremnicu.TabIndex = 2;
            this.IzmaniOtpremnicu.Text = "Izmani Otpremnicu";
            this.IzmaniOtpremnicu.UseVisualStyleBackColor = false;
            this.IzmaniOtpremnicu.Click += new System.EventHandler(this.IzmaniOtpremnicu_Click);
            // 
            // ObrisiOtpremnicu
            // 
            this.ObrisiOtpremnicu.BackColor = System.Drawing.Color.Red;
            this.ObrisiOtpremnicu.Location = new System.Drawing.Point(829, 521);
            this.ObrisiOtpremnicu.Name = "ObrisiOtpremnicu";
            this.ObrisiOtpremnicu.Size = new System.Drawing.Size(90, 80);
            this.ObrisiOtpremnicu.TabIndex = 3;
            this.ObrisiOtpremnicu.Text = "Obrisi Otpremnicu";
            this.ObrisiOtpremnicu.UseVisualStyleBackColor = false;
            this.ObrisiOtpremnicu.Click += new System.EventHandler(this.ObrisiOtpremnicu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj dostupnih Otpremnica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum Otpremnice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj Otpremnice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Partner";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(533, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Filter);
            this.panel1.Controls.Add(this.filterPartnerComboBox);
            this.panel1.Controls.Add(this.filterDatumComboBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(392, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 149);
            this.panel1.TabIndex = 12;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(141, 120);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(75, 23);
            this.Filter.TabIndex = 4;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // filterPartnerComboBox
            // 
            this.filterPartnerComboBox.FormattingEnabled = true;
            this.filterPartnerComboBox.Location = new System.Drawing.Point(213, 82);
            this.filterPartnerComboBox.Name = "filterPartnerComboBox";
            this.filterPartnerComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterPartnerComboBox.TabIndex = 3;
            this.filterPartnerComboBox.SelectedIndexChanged += new System.EventHandler(this.filterPartnerComboBox_SelectedIndexChanged);
            // 
            // filterDatumComboBox
            // 
            this.filterDatumComboBox.FormattingEnabled = true;
            this.filterDatumComboBox.Location = new System.Drawing.Point(21, 82);
            this.filterDatumComboBox.Name = "filterDatumComboBox";
            this.filterDatumComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterDatumComboBox.TabIndex = 2;
            this.filterDatumComboBox.SelectedIndexChanged += new System.EventHandler(this.filterDatumComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Po Partneru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Po Datumu";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObrisiOtpremnicu);
            this.Controls.Add(this.IzmaniOtpremnicu);
            this.Controls.Add(this.DodajOtpremnicu);
            this.Controls.Add(this.dataGridSveOtpremnice);
            this.Name = "Pocetna";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSveOtpremnice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSveOtpremnice;
        private System.Windows.Forms.Button DodajOtpremnicu;
        private System.Windows.Forms.Button IzmaniOtpremnicu;
        private System.Windows.Forms.Button ObrisiOtpremnicu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.ComboBox filterPartnerComboBox;
        private System.Windows.Forms.ComboBox filterDatumComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}