using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UplatnicaServis
{
    
    public class Uplatnica
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SifarnikPartnerId { get; set; }
        public int ListaRobeId { get; set; }

        //public virtual SifarnikPartner SifarnikPartner { get; set; }
        //public virtual ListaRobe ListaRobe { get; set; }
    }
}
