using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_WPF.ServiceReference1;
using System.Dynamic;
using MVVM_WPF.Common;
using System.Windows;

namespace MVVM_WPF.ViewModel
{
    public class PocetnaOtpremnicaViewModel : ViewModelBase
    {

        OtpremnicaClient service = new OtpremnicaClient();

        #region Fields
        private int _OtpremnicaZaglavljeId;
        private Otpremnica _currentOtpremnicaZaglavlje;
        private string _brojOtpremnice;
        private SifarnikPartner _partnerOtpremnice;
        private SifarnikRobe _sifarnikRobe;
        private string _datumOtpremnice;
        private ObservableCollection<SifarnikPartner> _partnerisearch;
        #endregion

        #region Properties

        public Otpremnica CurrentOtpremnicaZaglavlje
        {
            get { return _currentOtpremnicaZaglavlje; }
            set
            {
                if (!Equals(_currentOtpremnicaZaglavlje, value))
                {
                    _currentOtpremnicaZaglavlje = value;
                    _brojOtpremnice = _currentOtpremnicaZaglavlje.BrojOtpremnice;
                    SifarnikPartner prom = service.SifarnikPartnerListById(_currentOtpremnicaZaglavlje.SifarnikPartnerId);
                    _partnerOtpremnice = prom;//.NazivPartnera;
                    _datumOtpremnice = _currentOtpremnicaZaglavlje.Datum.ToString();
                    OnPropertyChanged();
                }
            }
        }
        public int OtpremnicaZaglavljeId
        {
            get { return _OtpremnicaZaglavljeId; }
            set
            {
                if (value != _OtpremnicaZaglavljeId)
                {
                    _OtpremnicaZaglavljeId = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BrojOtpremnice
        {
            get { return _brojOtpremnice; }
            set
            {
                if (value != _brojOtpremnice)
                {
                    _brojOtpremnice = value;
                    OnPropertyChanged();
                }
            }
        }
        public SifarnikPartner PartnerOtpremnice
        {
            get { return _partnerOtpremnice; }
            set
            {
                if (value != _partnerOtpremnice)
                {
                    _partnerOtpremnice = value;
                    OnPropertyChanged();
                }
            }
        }
        public SifarnikRobe SifarnikRobe
        {
            get { return _sifarnikRobe; }
            set
            {
                if (value != _sifarnikRobe)
                {
                    _sifarnikRobe = value;
                    OnPropertyChanged();
                }
            }
        }
        public string DatumOtpremnice
        {
            get { return _datumOtpremnice; }
            set
            {
                if (value != _datumOtpremnice)
                {
                    _datumOtpremnice = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _filterDatum;
        public string FilterDatum
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

        private double _getSumVerdnostiStavki;
        public double GetSumVerdnostiStavki
        {
            get
            {
                return _getSumVerdnostiStavki;
            }
            set
            {
                if (value != _getSumVerdnostiStavki)
                {
                    _getSumVerdnostiStavki = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _getSumVerdnostiDokumenata;
        public double GetSumVerdnostiDokumenata
        {
            get
            {
                return _getSumVerdnostiDokumenata;
            }
            set
            {
                //if (value != _getSumVerdnostiDokumenata)
                {
                    _getSumVerdnostiDokumenata = value;
                    ObservableCollection<double> var = new ObservableCollection<double>();
                    var.Add(_getSumVerdnostiDokumenata);
                    GetSumVerdnostiDokumenataObservable = var;
                     OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<double> _getSumVerdnostiDokumenataObservable;
        public ObservableCollection<double> GetSumVerdnostiDokumenataObservable
        {
            get
            {
                return _getSumVerdnostiDokumenataObservable;
            }
            set
            {
                //if (value != _getSumVerdnostiDokumenataObservable)
                {
                    _getSumVerdnostiDokumenataObservable = value;
                    
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<RobaProsireno> _getStavke_ByCurrentZaglavljeProsireno;
        public ObservableCollection<RobaProsireno> GetStavke_ByCurrentZaglavljeProsireno
        {
            get
            {
                return _getStavke_ByCurrentZaglavljeProsireno;
            }
            set
            {
                if (value != _getStavke_ByCurrentZaglavljeProsireno)
                {
                    _getStavke_ByCurrentZaglavljeProsireno = value;
                   this.GetSumVerdnostiStavki = _getStavke_ByCurrentZaglavljeProsireno.Sum(i => i.ListaRobe.UkupnaCenaRobe);
                    OnPropertyChanged();
                }
            } // ne zelimo da se SET-uje spolja jer je ovaj ViewModel izlozen UI-u
        }

        private ObservableCollection<PocetnaOtpremnicaViewModel> _allZaglavlja;
        public ObservableCollection<PocetnaOtpremnicaViewModel> AllZaglavlja
        {
            get
            {
                return _allZaglavlja;
            }
            set
            {
                if (value != _allZaglavlja)
                {
                    _allZaglavlja = value;
                    //if (_allZaglavlja != null)
                    //    GridSelectedItem = _allZaglavlja.FirstOrDefault();
                    OnPropertyChanged();
                }
            }
        }

        private PocetnaOtpremnicaViewModel _gridSelectedItem;
        public PocetnaOtpremnicaViewModel GridSelectedItem
        {
            get
            {
                return _gridSelectedItem;
            }
            set
            {
                if (_gridSelectedItem == value)
                {
                    return;
                }
                _gridSelectedItem = value;

                //_gridSelectedItem sada ima sadrzaj selektovanog reda iz DataGrid-a.
                try
                {
                    //using (var service = new OtpremnicaClient())
                    //{
                    //    var listaRobe2 = service.listaRobePordukata(_gridSelectedItem.CurrentOtpremnicaZaglavlje.Id);
                    //    ObservableCollection<RobaProsireno> tempListExpando2 = new ObservableCollection<RobaProsireno>();
                    //}

                        var listaRobe = service.listaRobePordukata(_gridSelectedItem.CurrentOtpremnicaZaglavlje.Id);
                    ObservableCollection<RobaProsireno> tempListExpando = new ObservableCollection<RobaProsireno>();

                    foreach (var lista in listaRobe)
                    {
                        SifarnikRobe var = service.SifarnikRobeListById(lista.SifarnikRobeId);                    

                        RobaProsireno rp = new RobaProsireno();
                        rp.ListaRobe = lista;
                        rp.NazivRobe = var.NazivRobe;
                        rp.JedinicaMere = var.JedinicaMere;
                        tempListExpando.Add(rp);
                    }

                    GetStavke_ByCurrentZaglavljeProsireno = new ObservableCollection<RobaProsireno>(tempListExpando); 
                    this.BrojOtpremnice = _gridSelectedItem.BrojOtpremnice;
                    this.DatumOtpremnice = _gridSelectedItem.DatumOtpremnice.ToString();
                    this.PartnerOtpremnice = _gridSelectedItem.PartnerOtpremnice;
                                        
                }
                catch (NullReferenceException)
                {
                    //this.GetStavke_ByCurrentZaglavlje.Clear();
                    //this.GetSumVerdnostiStavki = 0;
                }
                OnPropertyChanged();
            }
        }

        public ObservableCollection<SifarnikPartner> PartneriSearch
        {
            get
            {
                return _partnerisearch;
            }
        }
       
        private SifarnikPartner _partnerSearchSelectedValue;
        public SifarnikPartner PartnerSearchSelectedValue
        {
            get { return _partnerSearchSelectedValue; }
            set
            {
                if (_partnerSearchSelectedValue != value)
                {
                    _partnerSearchSelectedValue = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public PocetnaOtpremnicaViewModel()
        { }

        public PocetnaOtpremnicaViewModel(OtpremnicaClient service)
        {
            var zaglavlja = service.OtpremnicaList();
            _partnerisearch = new ObservableCollection<SifarnikPartner>(service.SifarnikPartnerList());
            FilterDatum = "";

            double vrednostSvihDokumenata = 0;
            ObservableCollection<PocetnaOtpremnicaViewModel> tempList = new ObservableCollection<PocetnaOtpremnicaViewModel>();
            foreach (Otpremnica oz in zaglavlja)
            {
                PocetnaOtpremnicaViewModel ozVM = new PocetnaOtpremnicaViewModel();
                ozVM.CurrentOtpremnicaZaglavlje = oz;
                ozVM.OtpremnicaZaglavljeId = oz.Id;
                var listaRobeTrenutneOtpremnice = service.listaRobePordukata(oz.Id);
                ozVM.GetSumVerdnostiDokumenata = listaRobeTrenutneOtpremnice.Sum(i=>i.UkupnaCenaRobe);
                vrednostSvihDokumenata += ozVM.GetSumVerdnostiDokumenata;

                tempList.Add(ozVM);
            }
            this.GetSumVerdnostiDokumenata = vrednostSvihDokumenata;
            this.AllZaglavlja = tempList;
        }

        #region Commands
        private RelayCommand _dodajOtpremnicuCommand;
        private RelayCommand _editujOtpremnicuCommand;
        private RelayCommand _obrisiOtpremnicuCommand;
        public ICommand DodajOtpremnicu
        {
            get
            {
                if (_dodajOtpremnicuCommand == null)
                {
                    _dodajOtpremnicuCommand = new RelayCommand(
                        param => this.KreirajOtpremnicuCommandExecute(),
                        param => true);// (umesto CanExecute)
                }
                return _dodajOtpremnicuCommand;
            }
        }

        void KreirajOtpremnicuCommandExecute()
        {
            DodavanjeUplatnice window = new DodavanjeUplatnice(AllZaglavlja, GetSumVerdnostiDokumenataObservable);
            window.Show();
        }

        public ICommand EditujOtpremnicu
        {
            get
            {
                if (_editujOtpremnicuCommand == null)
                {
                    _editujOtpremnicuCommand = new RelayCommand(
                        param => this.EditujOtpremnicuCommandExecute(),
                        param => EditCommandCanExecute);// (umesto CanExecute)
                }
                return _editujOtpremnicuCommand;
            }
        }
        bool EditCommandCanExecute
        {
            get
            {
                if (this.AllZaglavlja.Count == 0) { return false; }
                //if (this.AllZaglavlja.Count == 1)
                //{
                //    GridSelectedItem = AllZaglavlja.FirstOrDefault();
                //}

                return (GridSelectedItem != null) ? true : false;
                    //return true;
            }
        }

        void EditujOtpremnicuCommandExecute()
        {
            EditOtpremnice window = new EditOtpremnice(GridSelectedItem, AllZaglavlja, GetSumVerdnostiDokumenataObservable);
            window.Show();
        }

        private RelayCommand _searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if (_searchCommand == null)
                {
                    _searchCommand = new RelayCommand(
                        param => this.SearchCommandExecute(),
                        param => this.SearchCommandCanExecute);
                }
                return _searchCommand;
            }
        }

        void SearchCommandExecute()
        {
            int? PartnerId;

            try
            {
                PartnerId = (PartnerSearchSelectedValue.Id);
            }
            catch (Exception)
            {
                PartnerId = null;
            }

            DateTime? DatumUnosa;
            try
            {
                DatumUnosa = DateTime.Parse(FilterDatum);
            }
            catch (ArgumentNullException)
            {
                DatumUnosa = null;
            }
            catch (Exception)
            {
                DatumUnosa = null;
            }


            var zaglavlja = new ObservableCollection<Otpremnica>(service.OtpremnicaListBasedOnPartnerIdAndDateTime(PartnerId, DatumUnosa));

            ObservableCollection<PocetnaOtpremnicaViewModel> tempList = new ObservableCollection<PocetnaOtpremnicaViewModel>();
            double vrednostSvihDokumenata = 0;
            foreach (Otpremnica oz in zaglavlja)
            {
                PocetnaOtpremnicaViewModel ozVM = new PocetnaOtpremnicaViewModel();
                ozVM.CurrentOtpremnicaZaglavlje = oz;
                ozVM.OtpremnicaZaglavljeId = oz.Id;
                var listaRobeTrenutneOtpremnice = service.listaRobePordukata(oz.Id);
                ozVM.GetSumVerdnostiDokumenata = listaRobeTrenutneOtpremnice.Sum(i => i.UkupnaCenaRobe);
                vrednostSvihDokumenata += ozVM.GetSumVerdnostiDokumenata;

                tempList.Add(ozVM);
            }
            this.GetSumVerdnostiDokumenata = tempList.Sum(i => i.GetSumVerdnostiDokumenata); 
            this.AllZaglavlja = tempList;
            try
            {
                if (tempList.Count == 0)
                {
                    this._getStavke_ByCurrentZaglavljeProsireno.Clear();
                    this.GetSumVerdnostiStavki = 0;
                    this.DatumOtpremnice = "";
                    this.PartnerOtpremnice = null;
                    this.BrojOtpremnice = null;
                }
            }
            catch (Exception)
            {
            }
        }

        bool SearchCommandCanExecute
        {
            get
            {
                //if (this.AllZaglavlja.Count == 0)
                    //return false;
                              
                return true;
            }
        }


        private RelayCommand _inicijalizujCommand;
        public ICommand InicijalizujCommand
        {
            get
            {
                if (_inicijalizujCommand == null)
                {
                    _inicijalizujCommand = new RelayCommand(
                        param => this.InicijalizujCommandExecute(),
                        param => true);
                }
                return _inicijalizujCommand;
            }
        }

        void InicijalizujCommandExecute()
        {
            //kopirano iz AllZaglavlja
            var zaglavlja = service.OtpremnicaList();
            _partnerisearch = new ObservableCollection<SifarnikPartner>(service.SifarnikPartnerList());
            FilterDatum = "";
            PartnerSearchSelectedValue = null;

            ObservableCollection<PocetnaOtpremnicaViewModel> tempList = new ObservableCollection<PocetnaOtpremnicaViewModel>();
            double vrednostSvihDokumenata = 0;
            foreach (Otpremnica oz in zaglavlja)
            {
                PocetnaOtpremnicaViewModel ozVM = new PocetnaOtpremnicaViewModel();
                ozVM.CurrentOtpremnicaZaglavlje = oz;
                ozVM.OtpremnicaZaglavljeId = oz.Id;
                var listaRobeTrenutneOtpremnice = service.listaRobePordukata(oz.Id);
                ozVM.GetSumVerdnostiDokumenata = listaRobeTrenutneOtpremnice.Sum(i => i.UkupnaCenaRobe);
                vrednostSvihDokumenata += ozVM.GetSumVerdnostiDokumenata;

                tempList.Add(ozVM);
            }
            this.GetSumVerdnostiDokumenata = tempList.Sum(i => i.GetSumVerdnostiDokumenata);
            this.AllZaglavlja = tempList;
        }

        public ICommand ObrisiOtpremnicu
        {
            get
            {
                if (_obrisiOtpremnicuCommand == null)
                {
                    _obrisiOtpremnicuCommand = new RelayCommand(
                        param => this.ObrisiOtpremnicuCommandExecute(),
                        param => ObrisiCommandCanExecute);// (umesto CanExecute)
                }
                return _obrisiOtpremnicuCommand;
            }
        }

        bool ObrisiCommandCanExecute
        {
            get
            {
                if (this.AllZaglavlja.Count == 0) { return false; }

                return true;
            }
        }

        void ObrisiOtpremnicuCommandExecute()
        {
            if (AllZaglavlja.Count > 0 && GridSelectedItem != null) {

                //if (!service.obrisiOtpremnicu(GridSelectedItem.CurrentOtpremnicaZaglavlje.Id))
                //{

                //}

                AllZaglavlja.Remove(GridSelectedItem);
                MessageBox.Show(String.Format("Otpremnica sa \n Brojem: {0} \n Partnerom: {1} \n Datumom: {2} \n je uspešno obrisana.", this.BrojOtpremnice, this.PartnerOtpremnice.NazivPartnera, this.DatumOtpremnice));
                this.GetSumVerdnostiDokumenata = AllZaglavlja.Sum(i => i.GetSumVerdnostiDokumenata);
                InicijalizujCommandExecute();
            }
        }

        #endregion

    }
}
