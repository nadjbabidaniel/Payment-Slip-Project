using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UplatnicaWCFtoDb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUplatnica" in both code and config file together.
    [ServiceContract]
    public interface IOtpremnica
    {
        [OperationContract]
        Otpremnica insertOtpremnicu(Otpremnica u);

        [OperationContract]
        Otpremnica getOtpremnicu(int Id);

        [OperationContract]
        bool obrisiOtpremnicu(int Id);

        [OperationContract]
        bool updateOtpremnice(Otpremnica o);

        [OperationContract]
        List<Otpremnica> OtpremnicaList();

        [OperationContract]
        bool otpremnicaImaRobu(Otpremnica o);

        [OperationContract]
        bool postojiNazivOtpremniceUBazi(string BrojOtpremnice, int Id);

        [OperationContract]
        List<SifarnikPartner> SifarnikPartnerList();

        [OperationContract]
        List<SifarnikRobe> SifarnikRobeList();

        [OperationContract]
        SifarnikRobe SifarnikRobeListById(int Id);

        [OperationContract]
        void insertListuRobe(ListaRobe lrobe);

        [OperationContract]
        SifarnikPartner SifarnikPartnerListById(int Id);

        [OperationContract]
        int brojRobeNaUplatnici(int Id);

        [OperationContract]
        double UkupnaCenaRobePoUplatnici(int Id);

        [OperationContract]
        bool obrisiListuRobeNaOsnovuOtpremniceId(int otpremnicaId);

        [OperationContract]
        List<ListaRobe> listaRobePordukata(int Id);

        [OperationContract]
        ListaRobe listaRobeById(int Id);

        [OperationContract]
        List<Otpremnica> OtpremnicaListBasedOnPartnersId(int partnerId);

        [OperationContract]
        List<Otpremnica> OtpremnicaListBasedOnDateTime(DateTime partnerObjDate);

        [OperationContract]
        List<Otpremnica> OtpremnicaListBasedOnPartnerIdAndDateTime(int? partnerId, DateTime? partnerObjDate);

    }
}
