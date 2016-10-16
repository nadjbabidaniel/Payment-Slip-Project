namespace ModelFirstUplatnica
{
    partial class Dodavanje_Otpremnice
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboListaPartnera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridDadavanjeRobeOtpremnice = new System.Windows.Forms.DataGridView();
            this.DodajOtpremnicuSaRobom = new System.Windows.Forms.Button();
            this.OdustaniOdOtpremnice = new System.Windows.Forms.Button();
            this.Filtiraj_Robu = new System.Windows.Forms.Button();
            this.DodajRed = new System.Windows.Forms.Button();
            this.ObrisiRed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDadavanjeRobeOtpremnice)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboListaPartnera
            // 
            this.comboListaPartnera.FormattingEnabled = true;
            this.comboListaPartnera.Location = new System.Drawing.Point(530, 77);
            this.comboListaPartnera.Name = "comboListaPartnera";
            this.comboListaPartnera.Size = new System.Drawing.Size(121, 21);
            this.comboListaPartnera.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum Otpremnice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj Otpremnice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Partner";
            // 
            // dataGridDadavanjeRobeOtpremnice
            // 
            this.dataGridDadavanjeRobeOtpremnice.AllowUserToAddRows = false;
            this.dataGridDadavanjeRobeOtpremnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDadavanjeRobeOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDadavanjeRobeOtpremnice.Location = new System.Drawing.Point(12, 297);
            this.dataGridDadavanjeRobeOtpremnice.Name = "dataGridDadavanjeRobeOtpremnice";
            this.dataGridDadavanjeRobeOtpremnice.Size = new System.Drawing.Size(717, 205);
            this.dataGridDadavanjeRobeOtpremnice.TabIndex = 6;
            this.dataGridDadavanjeRobeOtpremnice.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDadavanjeRobeOtpremnice_CellValueChanged);
            this.dataGridDadavanjeRobeOtpremnice.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridDadavanjeRobeOtpremnice_CurrentCellDirtyStateChanged);
            this.dataGridDadavanjeRobeOtpremnice.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridDadavanjeRobeOtpremnice_EditingControlShowing);
            // 
            // DodajOtpremnicuSaRobom
            // 
            this.DodajOtpremnicuSaRobom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DodajOtpremnicuSaRobom.Location = new System.Drawing.Point(737, 38);
            this.DodajOtpremnicuSaRobom.Name = "DodajOtpremnicuSaRobom";
            this.DodajOtpremnicuSaRobom.Size = new System.Drawing.Size(115, 118);
            this.DodajOtpremnicuSaRobom.TabIndex = 7;
            this.DodajOtpremnicuSaRobom.Text = "Dodaj Otpremnicu";
            this.DodajOtpremnicuSaRobom.UseVisualStyleBackColor = false;
            this.DodajOtpremnicuSaRobom.Click += new System.EventHandler(this.DodajOtpremnicuSaRobom_Click);
            // 
            // OdustaniOdOtpremnice
            // 
            this.OdustaniOdOtpremnice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OdustaniOdOtpremnice.Location = new System.Drawing.Point(737, 162);
            this.OdustaniOdOtpremnice.Name = "OdustaniOdOtpremnice";
            this.OdustaniOdOtpremnice.Size = new System.Drawing.Size(115, 69);
            this.OdustaniOdOtpremnice.TabIndex = 8;
            this.OdustaniOdOtpremnice.Text = "Odustani";
            this.OdustaniOdOtpremnice.UseVisualStyleBackColor = false;
            this.OdustaniOdOtpremnice.Click += new System.EventHandler(this.OdustaniOdOtpremnice_Click);
            // 
            // Filtiraj_Robu
            // 
            this.Filtiraj_Robu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Filtiraj_Robu.Location = new System.Drawing.Point(737, 317);
            this.Filtiraj_Robu.Name = "Filtiraj_Robu";
            this.Filtiraj_Robu.Size = new System.Drawing.Size(115, 119);
            this.Filtiraj_Robu.TabIndex = 9;
            this.Filtiraj_Robu.Text = "Filtiraj Robu";
            this.Filtiraj_Robu.UseVisualStyleBackColor = false;
            this.Filtiraj_Robu.Click += new System.EventHandler(this.FiltrirajRobu_Click);
            // 
            // DodajRed
            // 
            this.DodajRed.BackColor = System.Drawing.Color.Lime;
            this.DodajRed.Location = new System.Drawing.Point(737, 507);
            this.DodajRed.Name = "DodajRed";
            this.DodajRed.Size = new System.Drawing.Size(115, 23);
            this.DodajRed.TabIndex = 10;
            this.DodajRed.Text = "Dodaj Red";
            this.DodajRed.UseVisualStyleBackColor = false;
            this.DodajRed.Click += new System.EventHandler(this.DodajRed_Click);
            // 
            // ObrisiRed
            // 
            this.ObrisiRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ObrisiRed.Location = new System.Drawing.Point(737, 546);
            this.ObrisiRed.Name = "ObrisiRed";
            this.ObrisiRed.Size = new System.Drawing.Size(115, 23);
            this.ObrisiRed.TabIndex = 11;
            this.ObrisiRed.Text = "Obrisi Red";
            this.ObrisiRed.UseVisualStyleBackColor = false;
            this.ObrisiRed.Click += new System.EventHandler(this.ObrisiRed_Click);
            // 
            // Dodavanje_Otpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.ObrisiRed);
            this.Controls.Add(this.DodajRed);
            this.Controls.Add(this.Filtiraj_Robu);
            this.Controls.Add(this.OdustaniOdOtpremnice);
            this.Controls.Add(this.DodajOtpremnicuSaRobom);
            this.Controls.Add(this.dataGridDadavanjeRobeOtpremnice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboListaPartnera);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Dodavanje_Otpremnice";
            this.Text = "Dodavanje_Otpremnice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDadavanjeRobeOtpremnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboListaPartnera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridDadavanjeRobeOtpremnice;
        private System.Windows.Forms.Button DodajOtpremnicuSaRobom;
        private System.Windows.Forms.Button OdustaniOdOtpremnice;
        private System.Windows.Forms.Button Filtiraj_Robu;
        private System.Windows.Forms.Button DodajRed;
        private System.Windows.Forms.Button ObrisiRed;
    }
}