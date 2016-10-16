using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using MVVM_WPF.ServiceReference1;
using System.Windows;
using System.Dynamic;
using MVVM_WPF.Common;

namespace MVVM_WPF.ViewModel
{
    class DodavanjeOtpremniceViewModel : ViewModelBase
    {
        private ObservableCollection<SifarnikPartner> _partneri;
        private ObservableCollection<SifarnikRobe> _roba;

        ObservableCollection<PocetnaOtpremnicaViewModel> allZaglavlja;
        ObservableCollection<double> getSumVerdnostiDokumenata;


        OtpremnicaClient service = new OtpremnicaClient();
        public DodavanjeOtpremniceViewModel(ObservableCollection<PocetnaOtpremnicaViewModel> AllZaglavlja, ObservableCollection<double> GetSumVerdnostiDokumenata)
        {
            _partneri = new ObservableCollection<SifarnikPartner>(service.SifarnikPartnerList());
            _roba = new ObservableCollection<SifarnikRobe>(service.SifarnikRobeList());
            FilterDatum = DateTime.Now;
            allZaglavlja = AllZaglavlja;
            getSumVerdnostiDokumenata = GetSumVerdnostiDokumenata;
        }

        public ObservableCollection<SifarnikRobe> Roba
        {
            get
            {
                return _roba;
            }
        }

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

        public Action CloseAction { get; set; } // SET uradjen u backend kodu.
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

        private RelayCommand _saveOtpremnicaCommand;
        public ICommand SaveOtpremnicaCommand
        {
            get
            {
                if (_saveOtpremnicaCommand == null)
                {
                    _saveOtpremnicaCommand = new RelayCommand(
                        param => this.SaveOtpremnicaCommandExecute(),
                        param => this.SaveOtpremnicaCommandCanExecute);
                }
                return _saveOtpremnicaCommand;
            }
        }
        void SaveOtpremnicaCommandExecute()
        {
            Otpremnica o = new Otpremnica();
            o.SifarnikPartnerId = this.PartnerSelectedValue.Id;
            o.BrojOtpremnice = this.BrojOtpremnice;
            o.Datum = this.FilterDatum;

            o = service.insertOtpremnicu(o);

            foreach (var stavka in ListaRobaProsireno)
            {
                if (stavka.ListaRobe.UkupnaCenaRobe != 0)
                {
                    stavka.ListaRobe.OtpremnicaId = o.Id;
                    service.insertListuRobe(stavka.ListaRobe);
                }
            }

            if (o == null)
                MessageBox.Show("Zaglavlje otpremnice nije snimljeno. Greška: ");
            else
            {
                MessageBox.Show(String.Format("Otpremnica sa \n Brojem: {0} \n Partnerom: {1} \n Datumom: {2} \n je uspešno snimljena.", o.BrojOtpremnice, this.PartnerSelectedValue.NazivPartnera, o.Datum));
                CloseAction();
                PocetnaOtpremnicaViewModel prom = new PocetnaOtpremnicaViewModel();
                prom.BrojOtpremnice = this.BrojOtpremnice;
                prom.DatumOtpremnice = this.FilterDatum.ToString();
                prom.OtpremnicaZaglavljeId = o.Id;
                prom.CurrentOtpremnicaZaglavlje = o;

                allZaglavlja.Add(prom);
                if (getSumVerdnostiDokumenata != null)
                {
                    getSumVerdnostiDokumenata[0] += this.UkupnaVrednostSvihStavki;
                }

                //else {
                //    getSumVerdnostiDokumenata = new ObservableCollection<double>();
                //    getSumVerdnostiDokumenata.Add(this.UkupnaVrednostSvihStavki);
                //}
            }
        }

        bool SaveOtpremnicaCommandCanExecute
        {
            get
            {
                if (!(this.PartnerSelectedValue is SifarnikPartner))
                    return false;

                if (String.IsNullOrWhiteSpace(this.BrojOtpremnice))
                {
                    return false;
                }

                try
                {                  
                    if (GetKreiraneStavkeProsireno.Count() == 0)
                        return false;
                    if (UkupnaVrednostSvihStavki == 0)
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            }
        }


        #endregion

        #region Methods

        List<RobaProsireno> ListaRobaProsireno = new List<RobaProsireno>();
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

        #region Properties
        public ObservableCollection<SifarnikPartner> Partneri
        {
            get
            {
                return _partneri;
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

        #endregion       
    }
}
