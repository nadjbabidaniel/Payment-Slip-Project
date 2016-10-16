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
using System.Collections;

namespace ModelFirstUplatnica
{
    public partial class Pocetna : Form
    {
        OtpremnicaClient service = new OtpremnicaClient();
        List<UplatnicaWCFtoDb.Otpremnica> otpremniceListaBrisanjeIEdit = new List<UplatnicaWCFtoDb.Otpremnica>();
        List<UplatnicaWCFtoDb.SifarnikPartner> filterPartnerList = new List<UplatnicaWCFtoDb.SifarnikPartner>();
        List<DateTime> filterDatumList = new List<DateTime>();

        public Pocetna()
        {
            InitializeComponent();
            Initialization();
        }
        public void Initialization()
        {
            BeginInitialization();
            comboBox1.DataSource = service.SifarnikPartnerList();
            comboBox1.DisplayMember = "NazivPartnera";
            textBox1.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
        }
        public void BeginInitialization()
        {
            dataGridSveOtpremnice.ColumnCount = 5;
            dataGridSveOtpremnice.Columns[0].Name = "Datum Otpremnice";
            dataGridSveOtpremnice.Columns[1].Name = "Broj Otpremnice";
            dataGridSveOtpremnice.Columns[2].Name = "Ime Partnera Otpremnice";
            dataGridSveOtpremnice.Columns[3].Name = "Broj robe na Uplatnici";
            dataGridSveOtpremnice.Columns[4].Name = "Ukupna cena robe na Otpremnici";
            dataGridSveOtpremnice.AutoResizeColumns();

            var sveOtpremnice = service.OtpremnicaList();
            inicijalizacijaDataGridView(sveOtpremnice);
            BeginInitializationFilter();
        }
        public void inicijalizacijaDataGridView(UplatnicaWCFtoDb.Otpremnica[] lists)
        {
            dataGridSveOtpremnice.Rows.Clear();
            otpremniceListaBrisanjeIEdit.Clear();

            foreach (var list in lists)
            {
                var partner = service.SifarnikPartnerListById(list.SifarnikPartnerId);
               
                ArrayList row = new ArrayList();
                row.Add(list.Datum.ToShortDateString());
                row.Add(list.BrojOtpremnice);
                row.Add(partner.NazivPartnera);
                row.Add(service.brojRobeNaUplatnici(list.Id));
                row.Add(service.UkupnaCenaRobePoUplatnici(list.Id));
                dataGridSveOtpremnice.Rows.Add(row.ToArray());
                otpremniceListaBrisanjeIEdit.Add(list);
            }
            label2.Text = lists.Count().ToString();
        }
        private void DodajOtpremnicu_Click(object sender, EventArgs e)
        {
            Dodavanje_Otpremnice f = new Dodavanje_Otpremnice(this);
            f.ShowDialog();
        }
        private void ObrisiOtpremnicu_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowCollection = new List<DataGridViewRow>();

            foreach (DataGridViewCell cell in dataGridSveOtpremnice.SelectedCells)
            {
                rowCollection.Add(dataGridSveOtpremnice.Rows[cell.RowIndex]);           
            }

            if (rowCollection.Count > 0 && rowCollection[0].Index < dataGridSveOtpremnice.RowCount)
            {
                for (int i = 0; i < rowCollection.Count; i++)
                {
                    if (rowCollection[i].Index < dataGridSveOtpremnice.RowCount)
                    {
                        var index = rowCollection[i].Index;
                        var otpremnica = otpremniceListaBrisanjeIEdit[index];

     //                   if (service.obrisiListuRobeNaOsnovuOtpremniceId(otpremnica.Id))
    //                    {
                            if (service.obrisiOtpremnicu(otpremnica.Id))
                            {
                                MessageBox.Show("Otpremnica sa brojem: " + otpremnica.BrojOtpremnice + " uspesno obrisana");
                            }
      //                  }
                        else
                        {
                            MessageBox.Show("GRESKA PRILIKOM BRISANJA UPLATNICE");
                        }
                    }
                }
                Initialization();
            }
            else MessageBox.Show("Obelezili ste redove u tabeli van opsega ili niste obelezili ni jednan red za brisanje!");
        }
        private void IzmaniOtpremnicu_Click(object sender, EventArgs e)
        {
            var cell = dataGridSveOtpremnice.SelectedCells[dataGridSveOtpremnice.SelectedCells.Count-1];
            if (cell.RowIndex < dataGridSveOtpremnice.Rows.Count)
            {
                IzmenaOtpremnice izmena = new IzmenaOtpremnice(otpremniceListaBrisanjeIEdit[cell.RowIndex], this);
                izmena.ShowDialog();
            }
            else
            {
                MessageBox.Show("Obelezte koju otpremnicu zelite da menjate - van opsega!");
            }
        }
        private void dataGridSveOtpremnice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridSveOtpremnice.Rows.Count)
            {
                DataGridViewRow row = this.dataGridSveOtpremnice.Rows[e.RowIndex];

                dateTimePicker1.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
            }
        }
        private void filterDatumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UplatnicaWCFtoDb.Otpremnica[] ListaOtpremnicaZaPartnere = new UplatnicaWCFtoDb.Otpremnica[dataGridSveOtpremnice.RowCount];
            UplatnicaWCFtoDb.Otpremnica[] ListaOtpremnicaZaDatume = new UplatnicaWCFtoDb.Otpremnica[dataGridSveOtpremnice.RowCount];
            List<UplatnicaWCFtoDb.Otpremnica> Otpremnice2 = new List<UplatnicaWCFtoDb.Otpremnica>();

            if (filterPartnerComboBox.SelectedIndex > 0)
            {
                var prom = filterPartnerComboBox.SelectedIndex;
                var partnerObj = filterPartnerList[prom];

                ListaOtpremnicaZaPartnere = service.OtpremnicaListBasedOnPartnersId(partnerObj.Id);
            }
            if (filterDatumComboBox.SelectedIndex > 0)
            {
                var promDate = filterDatumComboBox.SelectedIndex;
                var partnerObjDate = filterDatumList[promDate];

                ListaOtpremnicaZaDatume = service.OtpremnicaListBasedOnDateTime(partnerObjDate);
            }
            if ((filterPartnerComboBox.SelectedIndex > 0) && (filterDatumComboBox.SelectedIndex > 0))
            {
                foreach (var partner in ListaOtpremnicaZaPartnere)
                {
                    foreach (var datum in ListaOtpremnicaZaDatume)
                    {
                        if ((partner.Id) == (datum.Id))
                        {
                            Otpremnice2.Add(partner);
                        }
                    }
                }
                UplatnicaWCFtoDb.Otpremnica[] Otpremnice = new UplatnicaWCFtoDb.Otpremnica[Otpremnice2.Count];
                int i = 0;
                foreach (var otp in Otpremnice2)
                {
                    Otpremnice[i] = otp;
                    i++;
                }
                inicijalizacijaDataGridView(Otpremnice);
            }

            if ((filterPartnerComboBox.SelectedIndex > 0) && (filterDatumComboBox.SelectedIndex < 1))
            {
                inicijalizacijaDataGridView(ListaOtpremnicaZaPartnere);
            }

            if ((filterPartnerComboBox.SelectedIndex < 1) && (filterDatumComboBox.SelectedIndex > 0))
            {
                inicijalizacijaDataGridView(ListaOtpremnicaZaDatume);
            }

            if ((filterPartnerComboBox.SelectedIndex == 0) && (filterDatumComboBox.SelectedIndex == 0))
            {
                BeginInitialization();

            }
            if ((filterPartnerComboBox.SelectedIndex > 0) || (filterDatumComboBox.SelectedIndex > 0))
            {
                //PocetnoStanjeFiltera.Enabled = true;
            }
        }
        private void Filter_Click(object sender, EventArgs e)
        {
            Initialization();
        }
        public void BeginInitializationFilter()
        {
            var listaOtpremnica = service.OtpremnicaList();
            List<int> listaIdPartnera = new List<int>();

            filterDatumComboBox.Items.Clear();
            filterDatumList.Clear();
            filterDatumComboBox.Text = "";
            filterDatumComboBox.Items.Insert(0, "-");
            filterDatumList.Insert(0, new DateTime(2010,10,8));
                        
            foreach (var otpremnica in listaOtpremnica)
            {
                if (!(filterDatumList.Contains(otpremnica.Datum.Date)))
                {
                    filterDatumList.Add(otpremnica.Datum.Date);
                }
                if (!(listaIdPartnera.Contains(otpremnica.SifarnikPartnerId)))
                {
                    listaIdPartnera.Add(otpremnica.SifarnikPartnerId);
                }

            }
            DateTime t;
            for (int i = 1; i < filterDatumList.Count-1; i++)
            {
                for (int j = i + 1; j < filterDatumList.Count; j++)
                {
                    int result = DateTime.Compare(filterDatumList[i], filterDatumList[j]);
                    if (result > 0)
                    {
                        t = filterDatumList[i];
                        filterDatumList[i] = filterDatumList[j];
                        filterDatumList[j] = t;
                    }
                }                               
            }
            for (int i = 1; i < filterDatumList.Count; i++)
            {
                filterDatumComboBox.Items.Add(filterDatumList[i].Date); 
            }

            filterPartnerList.Clear();
            filterPartnerComboBox.Items.Clear();
            filterPartnerComboBox.Text = "";
            filterPartnerComboBox.Items.Insert(0, "-");
            filterPartnerList.Insert(0, new UplatnicaWCFtoDb.SifarnikPartner());

            foreach (var id in listaIdPartnera)
            {
                var partner = service.SifarnikPartnerListById(id);
                filterPartnerList.Add(partner);
                filterPartnerComboBox.Items.Add(partner);
            }
            filterPartnerComboBox.DisplayMember = "NazivPartnera";
            filterPartnerComboBox.ValueMember = "Id";
        }
        private void filterPartnerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDatumComboBox_SelectedIndexChanged(sender, e);
        }
    }
}
