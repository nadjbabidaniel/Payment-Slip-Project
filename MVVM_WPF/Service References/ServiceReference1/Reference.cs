﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVM_WPF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Otpremnica", Namespace="http://schemas.datacontract.org/2004/07/UplatnicaWCFtoDb")]
    [System.SerializableAttribute()]
    public partial class Otpremnica : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrojOtpremniceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SifarnikPartnerIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BrojOtpremnice {
            get {
                return this.BrojOtpremniceField;
            }
            set {
                if ((object.ReferenceEquals(this.BrojOtpremniceField, value) != true)) {
                    this.BrojOtpremniceField = value;
                    this.RaisePropertyChanged("BrojOtpremnice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Datum {
            get {
                return this.DatumField;
            }
            set {
                if ((this.DatumField.Equals(value) != true)) {
                    this.DatumField = value;
                    this.RaisePropertyChanged("Datum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SifarnikPartnerId {
            get {
                return this.SifarnikPartnerIdField;
            }
            set {
                if ((this.SifarnikPartnerIdField.Equals(value) != true)) {
                    this.SifarnikPartnerIdField = value;
                    this.RaisePropertyChanged("SifarnikPartnerId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SifarnikPartner", Namespace="http://schemas.datacontract.org/2004/07/UplatnicaWCFtoDb")]
    [System.SerializableAttribute()]
    public partial class SifarnikPartner : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MestoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivPartneraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SifraPartneraField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mesto {
            get {
                return this.MestoField;
            }
            set {
                if ((object.ReferenceEquals(this.MestoField, value) != true)) {
                    this.MestoField = value;
                    this.RaisePropertyChanged("Mesto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NazivPartnera {
            get {
                return this.NazivPartneraField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivPartneraField, value) != true)) {
                    this.NazivPartneraField = value;
                    this.RaisePropertyChanged("NazivPartnera");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SifraPartnera {
            get {
                return this.SifraPartneraField;
            }
            set {
                if ((this.SifraPartneraField.Equals(value) != true)) {
                    this.SifraPartneraField = value;
                    this.RaisePropertyChanged("SifraPartnera");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SifarnikRobe", Namespace="http://schemas.datacontract.org/2004/07/UplatnicaWCFtoDb")]
    [System.SerializableAttribute()]
    public partial class SifarnikRobe : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JedinicaMereField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double JedinicnaCenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivRobeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SifraRobeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JedinicaMere {
            get {
                return this.JedinicaMereField;
            }
            set {
                if ((object.ReferenceEquals(this.JedinicaMereField, value) != true)) {
                    this.JedinicaMereField = value;
                    this.RaisePropertyChanged("JedinicaMere");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double JedinicnaCena {
            get {
                return this.JedinicnaCenaField;
            }
            set {
                if ((this.JedinicnaCenaField.Equals(value) != true)) {
                    this.JedinicnaCenaField = value;
                    this.RaisePropertyChanged("JedinicnaCena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NazivRobe {
            get {
                return this.NazivRobeField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivRobeField, value) != true)) {
                    this.NazivRobeField = value;
                    this.RaisePropertyChanged("NazivRobe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SifraRobe {
            get {
                return this.SifraRobeField;
            }
            set {
                if ((this.SifraRobeField.Equals(value) != true)) {
                    this.SifraRobeField = value;
                    this.RaisePropertyChanged("SifraRobe");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListaRobe", Namespace="http://schemas.datacontract.org/2004/07/UplatnicaWCFtoDb")]
    [System.SerializableAttribute()]
    public partial class ListaRobe : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double KolicinaRobeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double NovaCenaRobeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OtpremnicaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SifarnikRobeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double UkupnaCenaRobeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double KolicinaRobe {
            get {
                return this.KolicinaRobeField;
            }
            set {
                if ((this.KolicinaRobeField.Equals(value) != true)) {
                    this.KolicinaRobeField = value;
                    this.RaisePropertyChanged("KolicinaRobe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double NovaCenaRobe {
            get {
                return this.NovaCenaRobeField;
            }
            set {
                if ((this.NovaCenaRobeField.Equals(value) != true)) {
                    this.NovaCenaRobeField = value;
                    this.RaisePropertyChanged("NovaCenaRobe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OtpremnicaId {
            get {
                return this.OtpremnicaIdField;
            }
            set {
                if ((this.OtpremnicaIdField.Equals(value) != true)) {
                    this.OtpremnicaIdField = value;
                    this.RaisePropertyChanged("OtpremnicaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SifarnikRobeId {
            get {
                return this.SifarnikRobeIdField;
            }
            set {
                if ((this.SifarnikRobeIdField.Equals(value) != true)) {
                    this.SifarnikRobeIdField = value;
                    this.RaisePropertyChanged("SifarnikRobeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double UkupnaCenaRobe {
            get {
                return this.UkupnaCenaRobeField;
            }
            set {
                if ((this.UkupnaCenaRobeField.Equals(value) != true)) {
                    this.UkupnaCenaRobeField = value;
                    this.RaisePropertyChanged("UkupnaCenaRobe");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IOtpremnica")]
    public interface IOtpremnica {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/insertOtpremnicu", ReplyAction="http://tempuri.org/IOtpremnica/insertOtpremnicuResponse")]
        MVVM_WPF.ServiceReference1.Otpremnica insertOtpremnicu(MVVM_WPF.ServiceReference1.Otpremnica u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/insertOtpremnicu", ReplyAction="http://tempuri.org/IOtpremnica/insertOtpremnicuResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica> insertOtpremnicuAsync(MVVM_WPF.ServiceReference1.Otpremnica u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/getOtpremnicu", ReplyAction="http://tempuri.org/IOtpremnica/getOtpremnicuResponse")]
        MVVM_WPF.ServiceReference1.Otpremnica getOtpremnicu(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/getOtpremnicu", ReplyAction="http://tempuri.org/IOtpremnica/getOtpremnicuResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica> getOtpremnicuAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/obrisiOtpremnicu", ReplyAction="http://tempuri.org/IOtpremnica/obrisiOtpremnicuResponse")]
        bool obrisiOtpremnicu(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/obrisiOtpremnicu", ReplyAction="http://tempuri.org/IOtpremnica/obrisiOtpremnicuResponse")]
        System.Threading.Tasks.Task<bool> obrisiOtpremnicuAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/updateOtpremnice", ReplyAction="http://tempuri.org/IOtpremnica/updateOtpremniceResponse")]
        bool updateOtpremnice(MVVM_WPF.ServiceReference1.Otpremnica o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/updateOtpremnice", ReplyAction="http://tempuri.org/IOtpremnica/updateOtpremniceResponse")]
        System.Threading.Tasks.Task<bool> updateOtpremniceAsync(MVVM_WPF.ServiceReference1.Otpremnica o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaList", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListResponse")]
        MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaList", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/otpremnicaImaRobu", ReplyAction="http://tempuri.org/IOtpremnica/otpremnicaImaRobuResponse")]
        bool otpremnicaImaRobu(MVVM_WPF.ServiceReference1.Otpremnica o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/otpremnicaImaRobu", ReplyAction="http://tempuri.org/IOtpremnica/otpremnicaImaRobuResponse")]
        System.Threading.Tasks.Task<bool> otpremnicaImaRobuAsync(MVVM_WPF.ServiceReference1.Otpremnica o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/postojiNazivOtpremniceUBazi", ReplyAction="http://tempuri.org/IOtpremnica/postojiNazivOtpremniceUBaziResponse")]
        bool postojiNazivOtpremniceUBazi(string BrojOtpremnice, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/postojiNazivOtpremniceUBazi", ReplyAction="http://tempuri.org/IOtpremnica/postojiNazivOtpremniceUBaziResponse")]
        System.Threading.Tasks.Task<bool> postojiNazivOtpremniceUBaziAsync(string BrojOtpremnice, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikPartnerList", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikPartnerListResponse")]
        MVVM_WPF.ServiceReference1.SifarnikPartner[] SifarnikPartnerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikPartnerList", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikPartnerListResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikPartner[]> SifarnikPartnerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikRobeList", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikRobeListResponse")]
        MVVM_WPF.ServiceReference1.SifarnikRobe[] SifarnikRobeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikRobeList", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikRobeListResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikRobe[]> SifarnikRobeListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikRobeListById", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikRobeListByIdResponse")]
        MVVM_WPF.ServiceReference1.SifarnikRobe SifarnikRobeListById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikRobeListById", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikRobeListByIdResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikRobe> SifarnikRobeListByIdAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/insertListuRobe", ReplyAction="http://tempuri.org/IOtpremnica/insertListuRobeResponse")]
        void insertListuRobe(MVVM_WPF.ServiceReference1.ListaRobe lrobe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/insertListuRobe", ReplyAction="http://tempuri.org/IOtpremnica/insertListuRobeResponse")]
        System.Threading.Tasks.Task insertListuRobeAsync(MVVM_WPF.ServiceReference1.ListaRobe lrobe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikPartnerListById", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikPartnerListByIdResponse")]
        MVVM_WPF.ServiceReference1.SifarnikPartner SifarnikPartnerListById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/SifarnikPartnerListById", ReplyAction="http://tempuri.org/IOtpremnica/SifarnikPartnerListByIdResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikPartner> SifarnikPartnerListByIdAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/brojRobeNaUplatnici", ReplyAction="http://tempuri.org/IOtpremnica/brojRobeNaUplatniciResponse")]
        int brojRobeNaUplatnici(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/brojRobeNaUplatnici", ReplyAction="http://tempuri.org/IOtpremnica/brojRobeNaUplatniciResponse")]
        System.Threading.Tasks.Task<int> brojRobeNaUplatniciAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/UkupnaCenaRobePoUplatnici", ReplyAction="http://tempuri.org/IOtpremnica/UkupnaCenaRobePoUplatniciResponse")]
        double UkupnaCenaRobePoUplatnici(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/UkupnaCenaRobePoUplatnici", ReplyAction="http://tempuri.org/IOtpremnica/UkupnaCenaRobePoUplatniciResponse")]
        System.Threading.Tasks.Task<double> UkupnaCenaRobePoUplatniciAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/obrisiListuRobeNaOsnovuOtpremniceId", ReplyAction="http://tempuri.org/IOtpremnica/obrisiListuRobeNaOsnovuOtpremniceIdResponse")]
        bool obrisiListuRobeNaOsnovuOtpremniceId(int otpremnicaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/obrisiListuRobeNaOsnovuOtpremniceId", ReplyAction="http://tempuri.org/IOtpremnica/obrisiListuRobeNaOsnovuOtpremniceIdResponse")]
        System.Threading.Tasks.Task<bool> obrisiListuRobeNaOsnovuOtpremniceIdAsync(int otpremnicaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/listaRobePordukata", ReplyAction="http://tempuri.org/IOtpremnica/listaRobePordukataResponse")]
        MVVM_WPF.ServiceReference1.ListaRobe[] listaRobePordukata(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/listaRobePordukata", ReplyAction="http://tempuri.org/IOtpremnica/listaRobePordukataResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.ListaRobe[]> listaRobePordukataAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/listaRobeById", ReplyAction="http://tempuri.org/IOtpremnica/listaRobeByIdResponse")]
        MVVM_WPF.ServiceReference1.ListaRobe listaRobeById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/listaRobeById", ReplyAction="http://tempuri.org/IOtpremnica/listaRobeByIdResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.ListaRobe> listaRobeByIdAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnersId", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnersIdResponse")]
        MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaListBasedOnPartnersId(int partnerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnersId", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnersIdResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListBasedOnPartnersIdAsync(int partnerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnDateTime", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnDateTimeResponse")]
        MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaListBasedOnDateTime(System.DateTime partnerObjDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnDateTime", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnDateTimeResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListBasedOnDateTimeAsync(System.DateTime partnerObjDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnerIdAndDateTime", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnerIdAndDateTimeResponse")]
        MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaListBasedOnPartnerIdAndDateTime(System.Nullable<int> partnerId, System.Nullable<System.DateTime> partnerObjDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnerIdAndDateTime", ReplyAction="http://tempuri.org/IOtpremnica/OtpremnicaListBasedOnPartnerIdAndDateTimeResponse")]
        System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListBasedOnPartnerIdAndDateTimeAsync(System.Nullable<int> partnerId, System.Nullable<System.DateTime> partnerObjDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOtpremnicaChannel : MVVM_WPF.ServiceReference1.IOtpremnica, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OtpremnicaClient : System.ServiceModel.ClientBase<MVVM_WPF.ServiceReference1.IOtpremnica>, MVVM_WPF.ServiceReference1.IOtpremnica {
        
        public OtpremnicaClient() {
        }
        
        public OtpremnicaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OtpremnicaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OtpremnicaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OtpremnicaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVVM_WPF.ServiceReference1.Otpremnica insertOtpremnicu(MVVM_WPF.ServiceReference1.Otpremnica u) {
            return base.Channel.insertOtpremnicu(u);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica> insertOtpremnicuAsync(MVVM_WPF.ServiceReference1.Otpremnica u) {
            return base.Channel.insertOtpremnicuAsync(u);
        }
        
        public MVVM_WPF.ServiceReference1.Otpremnica getOtpremnicu(int Id) {
            return base.Channel.getOtpremnicu(Id);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica> getOtpremnicuAsync(int Id) {
            return base.Channel.getOtpremnicuAsync(Id);
        }
        
        public bool obrisiOtpremnicu(int Id) {
            return base.Channel.obrisiOtpremnicu(Id);
        }
        
        public System.Threading.Tasks.Task<bool> obrisiOtpremnicuAsync(int Id) {
            return base.Channel.obrisiOtpremnicuAsync(Id);
        }
        
        public bool updateOtpremnice(MVVM_WPF.ServiceReference1.Otpremnica o) {
            return base.Channel.updateOtpremnice(o);
        }
        
        public System.Threading.Tasks.Task<bool> updateOtpremniceAsync(MVVM_WPF.ServiceReference1.Otpremnica o) {
            return base.Channel.updateOtpremniceAsync(o);
        }
        
        public MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaList() {
            return base.Channel.OtpremnicaList();
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListAsync() {
            return base.Channel.OtpremnicaListAsync();
        }
        
        public bool otpremnicaImaRobu(MVVM_WPF.ServiceReference1.Otpremnica o) {
            return base.Channel.otpremnicaImaRobu(o);
        }
        
        public System.Threading.Tasks.Task<bool> otpremnicaImaRobuAsync(MVVM_WPF.ServiceReference1.Otpremnica o) {
            return base.Channel.otpremnicaImaRobuAsync(o);
        }
        
        public bool postojiNazivOtpremniceUBazi(string BrojOtpremnice, int Id) {
            return base.Channel.postojiNazivOtpremniceUBazi(BrojOtpremnice, Id);
        }
        
        public System.Threading.Tasks.Task<bool> postojiNazivOtpremniceUBaziAsync(string BrojOtpremnice, int Id) {
            return base.Channel.postojiNazivOtpremniceUBaziAsync(BrojOtpremnice, Id);
        }
        
        public MVVM_WPF.ServiceReference1.SifarnikPartner[] SifarnikPartnerList() {
            return base.Channel.SifarnikPartnerList();
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikPartner[]> SifarnikPartnerListAsync() {
            return base.Channel.SifarnikPartnerListAsync();
        }
        
        public MVVM_WPF.ServiceReference1.SifarnikRobe[] SifarnikRobeList() {
            return base.Channel.SifarnikRobeList();
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikRobe[]> SifarnikRobeListAsync() {
            return base.Channel.SifarnikRobeListAsync();
        }
        
        public MVVM_WPF.ServiceReference1.SifarnikRobe SifarnikRobeListById(int Id) {
            return base.Channel.SifarnikRobeListById(Id);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikRobe> SifarnikRobeListByIdAsync(int Id) {
            return base.Channel.SifarnikRobeListByIdAsync(Id);
        }
        
        public void insertListuRobe(MVVM_WPF.ServiceReference1.ListaRobe lrobe) {
            base.Channel.insertListuRobe(lrobe);
        }
        
        public System.Threading.Tasks.Task insertListuRobeAsync(MVVM_WPF.ServiceReference1.ListaRobe lrobe) {
            return base.Channel.insertListuRobeAsync(lrobe);
        }
        
        public MVVM_WPF.ServiceReference1.SifarnikPartner SifarnikPartnerListById(int Id) {
            return base.Channel.SifarnikPartnerListById(Id);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.SifarnikPartner> SifarnikPartnerListByIdAsync(int Id) {
            return base.Channel.SifarnikPartnerListByIdAsync(Id);
        }
        
        public int brojRobeNaUplatnici(int Id) {
            return base.Channel.brojRobeNaUplatnici(Id);
        }
        
        public System.Threading.Tasks.Task<int> brojRobeNaUplatniciAsync(int Id) {
            return base.Channel.brojRobeNaUplatniciAsync(Id);
        }
        
        public double UkupnaCenaRobePoUplatnici(int Id) {
            return base.Channel.UkupnaCenaRobePoUplatnici(Id);
        }
        
        public System.Threading.Tasks.Task<double> UkupnaCenaRobePoUplatniciAsync(int Id) {
            return base.Channel.UkupnaCenaRobePoUplatniciAsync(Id);
        }
        
        public bool obrisiListuRobeNaOsnovuOtpremniceId(int otpremnicaId) {
            return base.Channel.obrisiListuRobeNaOsnovuOtpremniceId(otpremnicaId);
        }
        
        public System.Threading.Tasks.Task<bool> obrisiListuRobeNaOsnovuOtpremniceIdAsync(int otpremnicaId) {
            return base.Channel.obrisiListuRobeNaOsnovuOtpremniceIdAsync(otpremnicaId);
        }
        
        public MVVM_WPF.ServiceReference1.ListaRobe[] listaRobePordukata(int Id) {
            return base.Channel.listaRobePordukata(Id);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.ListaRobe[]> listaRobePordukataAsync(int Id) {
            return base.Channel.listaRobePordukataAsync(Id);
        }
        
        public MVVM_WPF.ServiceReference1.ListaRobe listaRobeById(int Id) {
            return base.Channel.listaRobeById(Id);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.ListaRobe> listaRobeByIdAsync(int Id) {
            return base.Channel.listaRobeByIdAsync(Id);
        }
        
        public MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaListBasedOnPartnersId(int partnerId) {
            return base.Channel.OtpremnicaListBasedOnPartnersId(partnerId);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListBasedOnPartnersIdAsync(int partnerId) {
            return base.Channel.OtpremnicaListBasedOnPartnersIdAsync(partnerId);
        }
        
        public MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaListBasedOnDateTime(System.DateTime partnerObjDate) {
            return base.Channel.OtpremnicaListBasedOnDateTime(partnerObjDate);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListBasedOnDateTimeAsync(System.DateTime partnerObjDate) {
            return base.Channel.OtpremnicaListBasedOnDateTimeAsync(partnerObjDate);
        }
        
        public MVVM_WPF.ServiceReference1.Otpremnica[] OtpremnicaListBasedOnPartnerIdAndDateTime(System.Nullable<int> partnerId, System.Nullable<System.DateTime> partnerObjDate) {
            return base.Channel.OtpremnicaListBasedOnPartnerIdAndDateTime(partnerId, partnerObjDate);
        }
        
        public System.Threading.Tasks.Task<MVVM_WPF.ServiceReference1.Otpremnica[]> OtpremnicaListBasedOnPartnerIdAndDateTimeAsync(System.Nullable<int> partnerId, System.Nullable<System.DateTime> partnerObjDate) {
            return base.Channel.OtpremnicaListBasedOnPartnerIdAndDateTimeAsync(partnerId, partnerObjDate);
        }
    }
}