using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UplatnicaWCFtoDb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Uplatnica" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Uplatnica.svc or Uplatnica.svc.cs at the Solution Explorer and start debugging.
    public class Uplatnica : IOtpremnica
    {
        UplatnicaLinqDbDataContext db = new UplatnicaLinqDbDataContext();
        ListaRobeLinqDbDataContext lr = new ListaRobeLinqDbDataContext();
        SifarnikPartnerDataContext sp = new SifarnikPartnerDataContext();
        SifarnikRobeDataContext sr = new SifarnikRobeDataContext();

        public Otpremnica insertOtpremnicu(Otpremnica o)
        {
            db.Otpremnicas.InsertOnSubmit(o);
            db.SubmitChanges();
            return o;
        }

        public Otpremnica getOtpremnicu(int Id)
        {
            var query = db.Otpremnicas.FirstOrDefault(x => x.Id == Id);
            return query;
        }

        public bool obrisiOtpremnicu(int Id)
        {
            var query = db.Otpremnicas.FirstOrDefault(x => x.Id == Id);
            if (query != null)
            {
                var query2 = (from r in lr.ListaRobes where r.OtpremnicaId==query.Id select r);
                foreach(var r in query2)
                {
                    lr.ListaRobes.DeleteOnSubmit(r);
                }
                lr.SubmitChanges();
                db.Otpremnicas.DeleteOnSubmit(query);
                db.SubmitChanges();
                return true;
            }
            else return false;
        }

        public bool updateOtpremnice(Otpremnica o)
        {
            //var query = db.Otpremnicas.FirstOrDefault(x => x.BrojOtpremnice == BrojOtpremnice);
            var query = (from r in db.Otpremnicas where r.Id == o.Id select r);
            foreach (var q in query)
            {
                q.Datum = o.Datum;
                q.BrojOtpremnice = o.BrojOtpremnice;
                q.SifarnikPartnerId = o.SifarnikPartnerId;
            }
            db.SubmitChanges();

            return true;
        }

        public List<Otpremnica> OtpremnicaList()
        {
            var query = (from r in db.Otpremnicas select r);
            return query.ToList();
        }

        public bool otpremnicaImaRobu(Otpremnica o)
        {
            var query = lr.ListaRobes.FirstOrDefault(x => x.OtpremnicaId == o.Id);
            if( query != null) return true;
            return false;
        }

        public bool postojiNazivOtpremniceUBazi(string BrojOtpremnice, int Id)
        {
            var query = (from r in db.Otpremnicas where r.BrojOtpremnice == BrojOtpremnice select r);
            foreach(var q in query)
            {
                if (q.Id != Id) return true;
            }
            return false;
        }

        public List<SifarnikPartner> SifarnikPartnerList()
        {
            var query = (from r in sp.SifarnikPartners select r);
            return query.ToList();
        }

        public List<SifarnikRobe> SifarnikRobeList()
        {
            var query = (from r in sr.SifarnikRobes select r);
            return query.ToList();
        }

        public SifarnikRobe SifarnikRobeListById(int Id)
        {
            var query = sr.SifarnikRobes.FirstOrDefault(x => x.Id == Id);
            return query;
        }

        public void insertListuRobe(ListaRobe lrobe)
        {
            lr.ListaRobes.InsertOnSubmit(lrobe);
            lr.SubmitChanges();
        }

        public SifarnikPartner SifarnikPartnerListById(int Id)
        {
            var query = sp.SifarnikPartners.FirstOrDefault(x => x.Id == Id);
            return query;
        }

        public int brojRobeNaUplatnici(int Id)
        {
            var query = (from r in lr.ListaRobes where r.OtpremnicaId == Id select r.SifarnikRobeId);
            return query.Count();
        }

        public double UkupnaCenaRobePoUplatnici(int Id)
        {
            var query = (from r in lr.ListaRobes where r.OtpremnicaId == Id select r.UkupnaCenaRobe);
            double ukupnaCena = 0;
            foreach (var ukupnaCenaRobe in query)
            {                
                ukupnaCena += ukupnaCenaRobe;
            }
            return ukupnaCena;
        }

        public bool obrisiListuRobeNaOsnovuOtpremniceId(int otpremnicaId)
        {
            var query = (from r in lr.ListaRobes where r.OtpremnicaId == otpremnicaId select r);
            foreach (var s in query)
            {
                lr.ListaRobes.DeleteOnSubmit(s);
                lr.SubmitChanges();
            }
            return true;
        }

        public List<ListaRobe> listaRobePordukata(int Id)
        {
            var query = (from r in lr.ListaRobes where r.OtpremnicaId == Id select r.Id);
            List<ListaRobe> listaRobe = new List<ListaRobe>();
            foreach (var listaRobeId in query)
            {
                listaRobe.Add(listaRobeById(listaRobeId));
            }
            return listaRobe.ToList();
        }

        public ListaRobe listaRobeById(int Id)
        {
            var query = lr.ListaRobes.FirstOrDefault(x => x.Id == Id);
            return query;
        }

        public List<Otpremnica> OtpremnicaListBasedOnPartnersId(int partnerId)
        {
            var query = (from r in db.Otpremnicas where r.SifarnikPartnerId == partnerId select r);
            return query.ToList();
        }
        public List<Otpremnica> OtpremnicaListBasedOnDateTime(DateTime partnerObjDate)
        {
            var query = (from r in db.Otpremnicas where r.Datum.Date.Equals(partnerObjDate.Date) select r);
            return query.ToList();
        }

        public List<Otpremnica> OtpremnicaListBasedOnPartnerIdAndDateTime(int? partnerId, DateTime? partnerObjDate)
        {
            if (partnerId != null && partnerObjDate == null)
            {
                var query = OtpremnicaListBasedOnPartnersId(partnerId.Value);
                return query.ToList();
            }

            if (partnerId == null && partnerObjDate != null)
            {
                var query = OtpremnicaListBasedOnDateTime(partnerObjDate.Value);
                return query.ToList();
            }

            if (partnerId != null && partnerObjDate != null)
            {
                var query = (from r in db.Otpremnicas where r.SifarnikPartnerId == partnerId && r.Datum.Date.Equals(partnerObjDate.Value) select r);
                return query.ToList();
            }
            else return new List<Otpremnica>();
        }

    }
}
