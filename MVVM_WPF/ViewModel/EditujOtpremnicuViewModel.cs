using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_WPF.ServiceReference1;
using System.Collections.ObjectModel;
using MVVM_WPF.Common;
using System.Windows.Input;
using System.Windows;

namespace MVVM_WPF.ViewModel
{
    public class EditujOtpremnicuViewModel : ViewModelBase
    {
        OtpremnicaClient service = new OtpremnicaClient();
        public PocetnaOtpremnicaViewModel GridSelectedItemThis;
        ObservableCollection<PocetnaOtpremnicaViewModel> allZaglavlja;
        ObservableCollection<double> getSumVerdnostiDokumenata;
        public Action CloseAction { get; set; } // SET uradjen u backend kodu.

        List<RobaProsireno> ListaRobaProsireno;// = new List<RobaProsireno>();
        public EditujOtpremnicuViewModel()
        { }

        public EditujOtpremnicuViewModel(PocetnaOtpremnicaViewModel o, ObservableCollection<PocetnaOtpremnicaViewModel> AllZaglavlja, ObservableCollection<double> GetSumVerdnostiDokumenata)
        {
            GridSelectedItemThis = o;
            allZaglavlja = AllZaglavlja;
            getSumVerdnostiDokumenata = GetSumVerdnostiDokumenata;
            _brojOtpremnice = GridSelectedItemThis.CurrentOtpremnicaZaglavlje.BrojOtpremnice;
            _partneri = new ObservableCollection<SifarnikPartner>(service.SifarnikPartnerList());
            PartnerSelectedValue = service.SifarnikPartnerListById(o.CurrentOtpremnicaZaglavlje.SifarnikPartnerId);

            _roba = new ObservableCollection<SifarnikRobe>(service.SifarnikRobeList());
            FilterDatum = DateTime.Parse(o.DatumOtpremnice);

            var listaRobe = service.listaRobePordukata(o.CurrentOtpremnicaZaglavlje.Id);
            ObservableCollection<RobaProsireno> tempListExpando = new ObservableCollection<RobaProsireno>();

            ListaRobaProsireno = new List<RobaProsireno>();
            foreach (var lista in listaRobe)
            {
                SifarnikRobe var = service.SifarnikRobeListById(lista.SifarnikRobeId);

                RobaProsireno rp = new RobaProsireno();
                rp.ListaRobe = lista;
                rp.NazivRobe = var.NazivRobe;
                rp.JedinicaMere = var.JedinicaMere;
                tempListExpando.Add(rp);

                ListaRobaProsireno.Add(rp);
            }

            GetKreiraneStavkeProsireno = new ObservableCollection<RobaProsireno>(tempListExpando);
            IzracunajUkupnuVrednostSvihStavki();
        }

        #region Fields

        private DateTime _filterDatum;
        public DateTime FilterDatum
        {
            get
            {
                return _filterDatum;
            }
            set
            {
                if (value != _filterDatum)
                {
                    _filterDatum = value;
                    OnPropertyChanged();
                }
            }
        }

        private SifarnikPartner _partnerSelectedValue;
        public SifarnikPartner PartnerSelectedValue
        {
            get { return _partnerSelectedValue; }
            set
            {
                if (_partnerSelectedValue != value)
                {
                    _partnerSelectedValue = value;
                    OnPropertyChanged();
                }

            }
        }

        private string _brojOtpremnice;
        public string BrojOtpremnice
        {
            get
            {
                return _brojOtpremnice;
            }
            set
            {
                if (value != _brojOtpremnice)
                {
                    _brojOtpremnice = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<SifarnikPartner> _partneri;
        public ObservableCollection<SifarnikPartner> Partneri
        {
            get
            {
                return _partneri;
            }
        }

        private ObservableCollection<RobaProsireno> _getKreiraneStavkeProsireno;
        public ObservableCollection<RobaProsireno> GetKreiraneStavkeProsireno
        {
            get { return _getKreiraneStavkeProsireno; }
            set
            {
                if (_getKreiraneStavkeProsireno != value)
                {
                    _getKreiraneStavkeProsireno = value;
                    OnPropertyChanged();
                }
            }

        }

        private ObservableCollection<SifarnikRobe> _roba;

        public ObservableCollection<SifarnikRobe> Roba
        {
            get
            {
                return _roba;
            }
        }

        private SifarnikRobe _robaSelectedValue;
        public SifarnikRobe RobaSelectedValue
        {
            get { return _robaSelectedValue; }
            set
            {
                if (_robaSelectedValue != value)
                {
                    _robaSelectedValue = value;
                    OnPropertyChanged();
                }
                JedinicaMere = _robaSelectedValue.JedinicaMere;
                IzracunataVrednostStavke = _kolicina * (decimal)RobaSelectedValue.JedinicnaCena;
            }
        }

        private string _jedinicaMere;
        public string JedinicaMere
        {
            get { return _jedinicaMere; }
            set
            {
                if (_jedinicaMere != value)
                {
                    _jedinicaMere = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _izracunataVrednostStavke;
        public decimal IzracunataVrednostStavke
        {
            get { return _izracunataVrednostStavke; }
            set
            {
                if (_izracunataVrednostStavke != value)
                {
                    _izracunataVrednostStavke = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _kolicina;
        public decimal Kolicina
        {
            get { return _kolicina; }
            set
            {
                if (_kolicina != value)
                {
                    _kolicina = value;
                    OnPropertyChanged();
                    // Trigger async validation check
                    //ValidateKolicina(_kolicina);
                }
                if (RobaSelectedValue != null)
                    IzracunataVrednostStavke = _kolicina * (decimal)RobaSelectedValue.JedinicnaCena;

            }
        }

        private double _ukupnaVrednostSvihStavki;
        public double UkupnaVrednostSvihStavki
        {
            get { return _ukupnaVrednostSvihStavki; }
            set
            {
                if (_ukupnaVrednostSvihStavki != value)
                {
                    _ukupnaVrednostSvihStavki = value;
                    OnPropertyChanged();
                }
            }
        }

        private RobaProsireno _editGridSelectedItem;
        public RobaProsireno EditGridSelectedItem
        {
            get
            {
                return _editGridSelectedItem;
            }
            set
            {
                if (_editGridSelectedItem == value)
                {
                    return;
                }
                _editGridSelectedItem = value;

                //_gridSelectedItem sada ima sadrzaj selektovanog reda iz DataGrid-a.               
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        // KOMANDA ZA DODAVANJE STAVKE
        private RelayCommand _dodajStavkuCommand;
        public ICommand DodajStavkuCommand
        {
            get
            {
                if (_dodajStavkuCommand == null)
                {
                    _dodajStavkuCommand = new RelayCommand(
                        param => this.DodajStavkuCommandExecute(),
                        param => this.DodajStavkuCommandCanExecute);
                }
                return _dodajStavkuCommand;

            }
        }

        void DodajStavkuCommandExecute()
        {
            DodajStavku();
        }

        bool DodajStavkuCommandCanExecute
        {
            get
            {

                //if (!(this.PartnerSelectedValue is SifarnikPartner))
                //    return false;

                if (!(this.RobaSelectedValue is SifarnikRobe))
                    return false;

                if (this.Kolicina == Decimal.Zero)
                    return false;

                return true;
            }
        }

        // KOMANDA ZA BRISANJE STAVKE
        private RelayCommand _izbaciStavkuCommand;
        public ICommand IzbaciStavkuCommand
        {
            get
            {
                if (_izbaciStavkuCommand == null)
                {
                    _izbaciStavkuCommand = new RelayCommand(
                        param => this.IzbaciStavkuCommandExecute(),
                        param => this.IzbaciStavkuCommandCanExecute);
                }
                return _izbaciStavkuCommand;

            }
        }

        void IzbaciStavkuCommandExecute()
        {
            GetKreiraneStavkeProsireno.Remove(EditGridSelectedItem);
            ListaRobaProsireno.RemoveRange(0, ListaRobaProsireno.Count);
            foreach (var list in GetKreiraneStavkeProsireno)
            {
                ListaRobaProsireno.Add(list);
            }

            IzracunajUkupnuVrednostSvihStavki();
        }

        bool IzbaciStavkuCommandCanExecute
        {
            get
            {
                //if (!(this.RobaSelectedValue is SifarnikRobe))
                //    return false;

                //if (this.Kolicina == Decimal.Zero)
                //    return false;
                return true;
            }
        }




        private RelayCommand _zatvoriProzorCommand;
        public ICommand ZatvoriProzorCommand
        {
            get
            {
                if (_zatvoriProzorCommand == null)
                {
                    _zatvoriProzorCommand = new RelayCommand(
                        param => this.ZatvoriProzorCommandExecute(),
                        param => true);
                }
                return _zatvoriProzorCommand;
            }
        }

        void ZatvoriProzorCommandExecute()
        {
            CloseAction();
        }


        // KOMANDA ZA SACUVAVANJE IZMENE OTPREMNICE
        private RelayCommand _sacuvajIzmeneOtpremnicaCommand;
        public ICommand SacuvajIzmeneOtpremnicaCommand
        {
            get
            {
                if (_sacuvajIzmeneOtpremnicaCommand == null)
                {
                    _sacuvajIzmeneOtpremnicaCommand = new RelayCommand(
                        param => this.SacuvajStavkuCommandExecute(),
                        param => this.SacuvajStavkuCommandCanExecute);
                }
                return _sacuvajIzmeneOtpremnicaCommand;
            }
        }

        void SacuvajStavkuCommandExecute()
        {

            GridSelectedItemThis.CurrentOtpremnicaZaglavlje.Datum = this.FilterDatum;
            GridSelectedItemThis.CurrentOtpremnicaZaglavlje.BrojOtpremnice = this.BrojOtpremnice;
            GridSelectedItemThis.CurrentOtpremnicaZaglavlje.SifarnikPartnerId = this.PartnerSelectedValue.Id;
            GridSelectedItemThis.PartnerOtpremnice = PartnerSelectedValue;
            GridSelectedItemThis.FilterDatum = FilterDatum.ToString();

            GridSelectedItemThis.GetStavke_ByCurrentZaglavljeProsireno = new ObservableCollection<RobaProsireno>(GetKreiraneStavkeProsireno);


            if (service.updateOtpremnice(GridSelectedItemThis.CurrentOtpremnicaZaglavlje))
            {

                if (service.obrisiListuRobeNaOsnovuOtpremniceId(GridSelectedItemThis.CurrentOtpremnicaZaglavlje.Id))
                {
                    foreach (var prom in GridSelectedItemThis.GetStavke_ByCurrentZaglavljeProsireno)
                    {
                        prom.ListaRobe.OtpremnicaId = GridSelectedItemThis.CurrentOtpremnicaZaglavlje.Id;
                        service.insertListuRobe(prom.ListaRobe);
                    }
                }
            }
           
            Otpremnica o = service.getOtpremnicu(GridSelectedItemThis.CurrentOtpremnicaZaglavlje.Id);
            GridSelectedItemThis.CurrentOtpremnicaZaglavlje = o;
           

            getSumVerdnostiDokumenata[0] = 0;

            for (int i=0; i < allZaglavlja.Count; i++)
            {
                if (allZaglavlja[i].OtpremnicaZaglavljeId == o.Id)
                {
                    allZaglavlja[i] = GridSelectedItemThis;
                    allZaglavlja[i].GridSelectedItem = GridSelectedItemThis;
                    allZaglavlja[i].CurrentOtpremnicaZaglavlje = o;          
                }

                var listaRobeTrenutneOtpremnice = service.listaRobePordukata(allZaglavlja[i].OtpremnicaZaglavljeId);
                var ukupnaVrednost = listaRobeTrenutneOtpremnice.Sum(k => k.UkupnaCenaRobe);
                getSumVerdnostiDokumenata[0] += ukupnaVrednost;
            }



            MessageBox.Show(String.Format("Otpremnica sa \n Brojem: {0} \n Partnerom: {1} \n Datumom: {2} \n je uspešno izmenjena.", GridSelectedItemThis.CurrentOtpremnicaZaglavlje.BrojOtpremnice, this.PartnerSelectedValue.NazivPartnera, GridSelectedItemThis.CurrentOtpremnicaZaglavlje.Datum));
            CloseAction();
        }

        bool SacuvajStavkuCommandCanExecute
        {
            get
            {
                if (GetKreiraneStavkeProsireno.Count() == 0)
                    return false;

                return true;
            }
        }

        #endregion


        #region Methods


        public void DodajStavku()
        {

            SifarnikRobe roba = service.SifarnikRobeListById(this.RobaSelectedValue.Id);

            ListaRobe lr = new ListaRobe();
            lr.SifarnikRobeId = this.RobaSelectedValue.Id;
            lr.KolicinaRobe = (double)this.Kolicina;
            lr.NovaCenaRobe = (double)this.RobaSelectedValue.JedinicnaCena;
            lr.UkupnaCenaRobe = (double)this.Kolicina * (double)this.RobaSelectedValue.JedinicnaCena;

            var os2 = new RobaProsireno();
            os2.ListaRobe = lr;
            os2.NazivRobe = roba.NazivRobe;
            os2.JedinicaMere = roba.JedinicaMere;



            //2. provera da li roba vec postoji medju unetim stavkama
            if (ListaRobaProsireno.Select(i => i.ListaRobe.SifarnikRobeId).Contains(lr.SifarnikRobeId))
            {
                //2.1. ako postoji izmeni vrednosti za: kolicinu i vrednost stavke
                MessageBox.Show("Odabrana roba već postoji u stavkama!");
                var obj = ListaRobaProsireno.FirstOrDefault(x => x.ListaRobe.SifarnikRobeId == lr.SifarnikRobeId);
                if (obj != null)
                {
                    obj.ListaRobe.KolicinaRobe += lr.KolicinaRobe;
                    obj.ListaRobe.UkupnaCenaRobe = obj.ListaRobe.KolicinaRobe * obj.ListaRobe.NovaCenaRobe;
                }
                else
                {
                    MessageBox.Show("Greska: Objekat nije nadjen");
                    return;
                }
            }
            else
            {
                //2.2. ako ne postoji, dodaj stavku u listu kreiranih stavke.              
                ListaRobaProsireno.Add(os2);
            }

            GetKreiraneStavkeProsireno = new ObservableCollection<RobaProsireno>(ListaRobaProsireno);
            IzracunajUkupnuVrednostSvihStavki();
        }

        public void IzracunajUkupnuVrednostSvihStavki()
        {
            this.UkupnaVrednostSvihStavki = ListaRobaProsireno.Sum(i => i.ListaRobe.UkupnaCenaRobe);
        }


        #endregion
    }
}
