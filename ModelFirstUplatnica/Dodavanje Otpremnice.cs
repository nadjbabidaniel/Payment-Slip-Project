using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelFirstUplatnica.ServiceReference1;

namespace ModelFirstUplatnica
{
    public partial class Dodavanje_Otpremnice : Form
    {
        OtpremnicaClient service = new OtpremnicaClient();
        UplatnicaWCFtoDb.Otpremnica o = new UplatnicaWCFtoDb.Otpremnica();
        private Pocetna f;
                
        public Dodavanje_Otpremnice(Pocetna f1)
        {
            InitializeComponent();
            Initialization();
            dodavanjeDataGridView();
            f = f1;
        }
        public void Initialization()
        {
            var sviPartneri = service.SifarnikPartnerList();
            comboListaPartnera.DataSource = sviPartneri;
            comboListaPartnera.DisplayMember = "NazivPartnera";
            comboListaPartnera.ValueMember = "Id";

            dataGridDadavanjeRobeOtpremnice.Rows.Clear();
            textBox1.Clear();
            dateTimePicker1.ResetText();

        }
        public void dodavanjeDataGridView()
        {
            var svaRoba = service.SifarnikRobeList();

            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.HeaderText = "Sifra robe";
            cb.DataSource = svaRoba;
            cb.DisplayMember = "SifraRobe";
            cb.ValueMember = "Id";
            dataGridDadavanjeRobeOtpremnice.Columns.Add(cb);

            dataGridDadavanjeRobeOtpremnice.ColumnCount = 4;
            dataGridDadavanjeRobeOtpremnice.Columns[1].Name = "Kolicina robe";
            dataGridDadavanjeRobeOtpremnice.Columns[2].Name = "Nova cena robe";
            dataGridDadavanjeRobeOtpremnice.Columns[3].Name = "Ukupna cena robe na Otpremnici";
            dataGridDadavanjeRobeOtpremnice.Columns[3].ReadOnly = true;
            dataGridDadavanjeRobeOtpremnice.Rows.Add();
        }
        private void OdustaniOdOtpremnice_Click(object sender, EventArgs e)
        {
            this.Dispose();
            f.Initialization();
        }
        private void FiltrirajRobu_Click(object sender, EventArgs e)
        {
            int n = dataGridDadavanjeRobeOtpremnice.Rows.Count;
            if (n > 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[0].FormattedValue.ToString() == "")
                    {
                        dataGridDadavanjeRobeOtpremnice.Rows.RemoveAt(i);
                        n--;
                    }
                }
            }
        }
        private void dataGridDadavanjeRobeOtpremnice_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridDadavanjeRobeOtpremnice.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridDadavanjeRobeOtpremnice.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridDadavanjeRobeOtpremnice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridDadavanjeRobeOtpremnice.Rows[e.RowIndex].Cells[0];
            if (cb.Value != null && e.ColumnIndex == 0 )
            {
                var roba = service.SifarnikRobeListById((int)dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[0].Value);
                bool exist = false;
                int brojKolona = dataGridDadavanjeRobeOtpremnice.Rows.Count-1;
                for (int i=0; i< brojKolona; i++)
                {
                    if (dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[0].FormattedValue.ToString() != "")
                    {
                        if ((int)dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[0].Value == roba.Id && i != dataGridDadavanjeRobeOtpremnice.CurrentRow.Index)
                        {
                            MessageBox.Show("Otpremnica vec sadrzi ovu robu! Nemogu biti 2 iste robe!");
                            cb.Value = null;
                            
                            dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[2].Value = "";
                            dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[3].Value = "";
                            brojKolona--;
                            exist = true;                            
                        }
                    }
                }
                if (!exist)
                {
                    UplatnicaWCFtoDb.SifarnikRobe zaCenuRobe = service.SifarnikRobeListById(roba.Id);
                    dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[2].Value = zaCenuRobe.JedinicnaCena.ToString();
                    if (e.RowIndex==dataGridDadavanjeRobeOtpremnice.Rows.Count-1)
                    {
                        dataGridDadavanjeRobeOtpremnice.Rows.Add();
                    }
                }
            }
            if (e.ColumnIndex == 1 || e.ColumnIndex==2)//&& dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[1].FormattedValue.ToString()!="")
            {   
                double kolicina=0;
                double.TryParse(dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[1].FormattedValue.ToString(), out kolicina);

                if (kolicina!=0)
                {
                    double novaCena = 0;
                    double.TryParse(dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[2].FormattedValue.ToString(), out novaCena);
                    if(novaCena > 0)
                    {
                        dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[3].Value = kolicina * novaCena;
                    }
                    else
                    {
                        dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[3].Value = "";
                    }
                }
                else
                {
                    dataGridDadavanjeRobeOtpremnice.CurrentRow.Cells[3].Value = "";
                }                                                     
            }
        }
        private void DodajOtpremnicuSaRobom_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Broj Otpremnice je obavezan!");
            if (service.postojiNazivOtpremniceUBazi(textBox1.Text, -1)) MessageBox.Show("Postoji Otpremnica sa ovim Brojem u bazi! Unesite drugi Broj Otpremnice");

            if (textBox1.Text != "" && !service.postojiNazivOtpremniceUBazi(textBox1.Text, -1))
            {
                UplatnicaWCFtoDb.Otpremnica o = new UplatnicaWCFtoDb.Otpremnica();
                o.BrojOtpremnice = textBox1.Text;
                o.SifarnikPartnerId = (int)comboListaPartnera.SelectedValue;
                o.Datum = (DateTime)dateTimePicker1.Value;

                o = service.insertOtpremnicu(o);

                for (int i=0; i< dataGridDadavanjeRobeOtpremnice.Rows.Count; i++)
                {
                    if (dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[0].FormattedValue.ToString() != "")
                    {
                        var roba = service.SifarnikRobeListById((int)dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[0].Value);

                        double kolicina;
                        double.TryParse(dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[1].FormattedValue.ToString(), out kolicina);
                        double novaCena;
                        double.TryParse(dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[2].FormattedValue.ToString(), out novaCena);
                        if (kolicina != 0 && dataGridDadavanjeRobeOtpremnice.Rows[i].Cells[3].FormattedValue.ToString() != "" && novaCena > 0)
                        {
                            UplatnicaWCFtoDb.ListaRobe lr = new UplatnicaWCFtoDb.ListaRobe();

                            lr.OtpremnicaId = o.Id;
                            lr.SifarnikRobeId = roba.Id;
                            lr.KolicinaRobe = kolicina;
                            lr.NovaCenaRobe = novaCena;
                            lr.UkupnaCenaRobe = kolicina * novaCena;

                            service.insertListuRobe(lr);
                        }                       
                    }
                }
                if (service.otpremnicaImaRobu(o))
                {
                    MessageBox.Show("Otpremnica sa brojem: " + o.BrojOtpremnice + " uspesno ubacena");
                    Initialization();
                    dodavanjeDataGridView();

                }
                else
                {
                    service.obrisiOtpremnicu(o.Id);
                    MessageBox.Show("Otpremnica mora imati robu, u suprotnom nece biti ubacena u bazu!!");
                }
            }
        }
        private void dataGridDadavanjeRobeOtpremnice_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridDadavanjeRobeOtpremnice.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (dataGridDadavanjeRobeOtpremnice.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }        
        }
        private void DodajRed_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
            DataGridViewRow RowSample = new DataGridViewRow();

            CellSample.DataSource = service.SifarnikRobeList();
            CellSample.DisplayMember = "SifraRobe";
            CellSample.ValueMember = "Id";
            RowSample.Cells.Add(CellSample);

            dataGridDadavanjeRobeOtpremnice.Rows.Add(RowSample);
        }
        private void ObrisiRed_Click(object sender, EventArgs e)
        {
            if (dataGridDadavanjeRobeOtpremnice.Rows.Count > 1)
            {
                dataGridDadavanjeRobeOtpremnice.Rows.RemoveAt(dataGridDadavanjeRobeOtpremnice.CurrentCell.RowIndex);
            }
        }
    }
}
