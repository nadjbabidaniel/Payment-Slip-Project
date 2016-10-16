namespace ModelFirstUplatnica
{
    partial class IzmenaOtpremnice
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridEditovanje = new System.Windows.Forms.DataGridView();
            this.Sacuvaj = new System.Windows.Forms.Button();
            this.Odustani = new System.Windows.Forms.Button();
            this.ObrisiRed = new System.Windows.Forms.Button();
            this.DodajRed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditovanje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum Otpremnice";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj Otpremnice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Partner";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(577, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dataGridEditovanje
            // 
            this.dataGridEditovanje.AllowUserToAddRows = false;
            this.dataGridEditovanje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEditovanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEditovanje.Location = new System.Drawing.Point(33, 360);
            this.dataGridEditovanje.Name = "dataGridEditovanje";
            this.dataGridEditovanje.Size = new System.Drawing.Size(718, 213);
            this.dataGridEditovanje.TabIndex = 6;
            this.dataGridEditovanje.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEditovanje_CellValueChanged);
            this.dataGridEditovanje.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridEditovanje_CurrentCellDirtyStateChanged);
            this.dataGridEditovanje.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridEditovanje_EditingControlShowing);
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sacuvaj.Location = new System.Drawing.Point(788, 360);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(135, 88);
            this.Sacuvaj.TabIndex = 7;
            this.Sacuvaj.Text = "Sacuvaj";
            this.Sacuvaj.UseVisualStyleBackColor = false;
            this.Sacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // Odustani
            // 
            this.Odustani.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Odustani.Location = new System.Drawing.Point(788, 454);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(135, 38);
            this.Odustani.TabIndex = 8;
            this.Odustani.Text = "Odustani";
            this.Odustani.UseVisualStyleBackColor = false;
            this.Odustani.Click += new System.EventHandler(this.Odustani_Click);
            // 
            // ObrisiRed
            // 
            this.ObrisiRed.BackColor = System.Drawing.Color.Salmon;
            this.ObrisiRed.Location = new System.Drawing.Point(788, 581);
            this.ObrisiRed.Name = "ObrisiRed";
            this.ObrisiRed.Size = new System.Drawing.Size(135, 27);
            this.ObrisiRed.TabIndex = 9;
            this.ObrisiRed.Text = "Obrisi Red";
            this.ObrisiRed.UseVisualStyleBackColor = false;
            this.ObrisiRed.Click += new System.EventHandler(this.ObrisiRed_Click);
            // 
            // DodajRed
            // 
            this.DodajRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DodajRed.Location = new System.Drawing.Point(788, 546);
            this.DodajRed.Name = "DodajRed";
            this.DodajRed.Size = new System.Drawing.Size(135, 27);
            this.DodajRed.TabIndex = 10;
            this.DodajRed.Text = "Dodaj Red";
            this.DodajRed.UseVisualStyleBackColor = false;
            this.DodajRed.Click += new System.EventHandler(this.DodajRed_Click);
            // 
            // IzmenaOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.DodajRed);
            this.Controls.Add(this.ObrisiRed);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.Sacuvaj);
            this.Controls.Add(this.dataGridEditovanje);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "IzmenaOtpremnice";
            this.Text = "IzmenaOtpremnice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditovanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridEditovanje;
        private System.Windows.Forms.Button Sacuvaj;
        private System.Windows.Forms.Button Odustani;
        private System.Windows.Forms.Button ObrisiRed;
        private System.Windows.Forms.Button DodajRed;
    }
}