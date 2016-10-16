using ModelFirstUplatnica.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFirstUplatnica
{
    public partial class IzmenaOtpremnice : Form
    {
        OtpremnicaClient service = new OtpremnicaClient();
        private UplatnicaWCFtoDb.Otpremnica otpremnicaIEdit;
        private Pocetna pp;

        public IzmenaOtpremnice(UplatnicaWCFtoDb.Otpremnica otpremniceListaBrisanjeIEdit, Pocetna p)
        {
            InitializeComponent();
            otpremnicaIEdit = otpremniceListaBrisanjeIEdit;
            pp = p;
            Initialize();
            dodavanjeRobe();
        }
        public void Initialize()
        {
            comboBox1.DataSource = service.SifarnikPartnerList();
            comboBox1.DisplayMember = "NazivPartnera";
            comboBox1.ValueMember = "Id";

            dateTimePicker1.Text = otpremnicaIEdit.Datum.ToShortDateString();
            textBox1.Text = otpremnicaIEdit.BrojOtpremnice;

            UplatnicaWCFtoDb.SifarnikPartner partner = service.SifarnikPartnerListById(otpremnicaIEdit.SifarnikPartnerId);
            comboBox1.Text = partner.NazivPartnera;
        }
        public void dodavanjeRobe()
        {
            dataGridEditovanje.ColumnCount = 4;
            dataGridEditovanje.Columns[0].Name = "Sifra Robe";
            dataGridEditovanje.Columns[1].Name = "Kolicina robe";
            dataGridEditovanje.Columns[2].Name = "Nova cena robe";
            dataGridEditovanje.Columns[3].Name = "Ukupna cena robe na Otpremnici";

            var listaRobeUProduktima = service.listaRobePordukata(otpremnicaIEdit.Id);
            var svaRoba = service.SifarnikRobeList();

            for (int i=0; i < listaRobeUProduktima.Count(); i++)
            {
                DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
                DataGridViewRow RowSample = new DataGridViewRow();

                CellSample.DataSource = svaRoba;
                CellSample.DisplayMember= "SifraRobe";
                CellSample.ValueMember = "Id";                
                CellSample.Value = listaRobeUProduktima[i].SifarnikRobeId;

                RowSample.Cells.Add(CellSample);

                dataGridEditovanje.Rows.Add(RowSample);
                dataGridEditovanje.Rows[i].Cells[1].Value = listaRobeUProduktima[i].KolicinaRobe;
                dataGridEditovanje.Rows[i].Cells[2].Value = listaRobeUProduktima[i].NovaCenaRobe;
                dataGridEditovanje.Rows[i].Cells[3].Value = listaRobeUProduktima[i].UkupnaCenaRobe;
                if (i == listaRobeUProduktima.Count() - 1)
                {                   
                    dataGridEditovanje.Rows.Add((DataGridViewRow)RowSample.Clone());
                }
            }
        }
        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Dispose();
            pp.BeginInitialization();
        }
        private void dataGridEditovanje_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridEditovanje.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridEditovanje.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridEditovanje_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridEditovanje.Rows[e.RowIndex].Cells[0];
            if (cb.Value != null && e.ColumnIndex == 0)
            {
                var roba = service.SifarnikRobeListById((int)dataGridEditovanje.CurrentRow.Cells[0].Value);
                bool exist = false;
                int brojKolona = dataGridEditovanje.Rows.Count - 1;
                for (int i = 0; i < brojKolona; i++)
                {
                    if (dataGridEditovanje.Rows[i].Cells[0].FormattedValue.ToString() != "")
                    {
                        if ((int)dataGridEditovanje.Rows[i].Cells[0].Value == roba.Id && i != dataGridEditovanje.CurrentRow.Index)
                        {
                            MessageBox.Show("Otpremnica vec sadrzi ovu robu! Nemogu biti 2 iste robe!");
                            cb.Value = null;

                            dataGridEditovanje.CurrentRow.Cells[2].Value = "";
                            dataGridEditovanje.CurrentRow.Cells[3].Value = "";
                            brojKolona--;
                            exist = true;
                        }
                    }
                }
                if (!exist)
                {
                    UplatnicaWCFtoDb.SifarnikRobe zaCenuRobe = service.SifarnikRobeListById(roba.Id);
                    dataGridEditovanje.CurrentRow.Cells[2].Value = zaCenuRobe.JedinicnaCena.ToString();
                    if (e.RowIndex == dataGridEditovanje.Rows.Count - 1)
                    {
                        DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
                        DataGridViewRow RowSample = new DataGridViewRow();
                        CellSample.DataSource = service.SifarnikRobeList(); 
                        CellSample.DisplayMember = "SifraRobe";
                        CellSample.ValueMember = "Id";
                        RowSample.Cells.Add(CellSample);

                        dataGridEditovanje.Rows.Add(RowSample);
                    }
                }
            }
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                double kolicina = 0;
                double.TryParse(dataGridEditovanje.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(), out kolicina);

                if (kolicina != 0)
                {
                    double novaCena = 0;
                    double.TryParse(dataGridEditovanje.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(), out novaCena);
                    if (novaCena > 0)
                    {
                        dataGridEditovanje.Rows[e.RowIndex].Cells[3].Value = kolicina * novaCena;
                    }
                    else
                    {
                        dataGridEditovanje.Rows[e.RowIndex].Cells[3].Value = "";
                    }
                }
                else
                {
                    dataGridEditovanje.Rows[e.RowIndex].Cells[3].Value = "";
                }
            }
        }
        private void dataGridEditovanje_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridEditovanje.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (dataGridEditovanje.CurrentCell.ColumnIndex == 2) //Desired Column
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
        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Broj Otpremnice je obavezan!");
            if (service.postojiNazivOtpremniceUBazi(textBox1.Text, otpremnicaIEdit.Id)) MessageBox.Show("Postoji Otpremnica sa ovim Brojem u bazi! Unesite drugi Broj Otpremnice");

            if (textBox1.Text != "" && !service.postojiNazivOtpremniceUBazi(textBox1.Text, otpremnicaIEdit.Id))
            {
                otpremnicaIEdit.BrojOtpremnice = textBox1.Text;
                otpremnicaIEdit.SifarnikPartnerId = (int)comboBox1.SelectedValue;
                otpremnicaIEdit.Datum = (DateTime)dateTimePicker1.Value;
                bool imaRobu = false;
                for (int i = 0; i < dataGridEditovanje.Rows.Count; i++)
                {
                    if (dataGridEditovanje.Rows[i].Cells[0].FormattedValue.ToString() != "" && dataGridEditovanje.Rows[i].Cells[1].FormattedValue.ToString() != "" && dataGridEditovanje.Rows[i].Cells[2].FormattedValue.ToString() != "" && dataGridEditovanje.Rows[i].Cells[3].FormattedValue.ToString() != "")
                    {
                        imaRobu = true;
                    }
                }
                if (imaRobu)
                {
                    if (service.updateOtpremnice(otpremnicaIEdit))
                    {
                        if (service.obrisiListuRobeNaOsnovuOtpremniceId(otpremnicaIEdit.Id))
                        {
                            for (int i = 0; i < dataGridEditovanje.Rows.Count; i++)
                            {
                                if (dataGridEditovanje.Rows[i].Cells[0].FormattedValue.ToString() != "")
                                {
                                    var roba = service.SifarnikRobeListById((int)dataGridEditovanje.Rows[i].Cells[0].Value);

                                    double kolicina;
                                    double.TryParse(dataGridEditovanje.Rows[i].Cells[1].FormattedValue.ToString(), out kolicina);
                                    double novaCena;
                                    double.TryParse(dataGridEditovanje.Rows[i].Cells[2].FormattedValue.ToString(), out novaCena);
                                    if (kolicina != 0 && dataGridEditovanje.Rows[i].Cells[3].FormattedValue.ToString() != "" && novaCena > 0)
                                    {
                                        UplatnicaWCFtoDb.ListaRobe lr = new UplatnicaWCFtoDb.ListaRobe();

                                        lr.OtpremnicaId = otpremnicaIEdit.Id;
                                        lr.SifarnikRobeId = roba.Id;
                                        lr.KolicinaRobe = kolicina;
                                        lr.NovaCenaRobe = novaCena;
                                        lr.UkupnaCenaRobe = kolicina * novaCena;

                                        service.insertListuRobe(lr);
                                    }
                                }
                            }
                            this.Dispose();
                            pp.Initialization();
                        }
                    }
                }
                else MessageBox.Show("Otpremnica mora imati robu");
            }
        }
        private void ObrisiRed_Click(object sender, EventArgs e)
        {
            if(dataGridEditovanje.Rows.Count > 1)
            {
                dataGridEditovanje.Rows.RemoveAt(dataGridEditovanje.CurrentCell.RowIndex);
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

            dataGridEditovanje.Rows.Add(RowSample);
        }
    }
}
