//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirstUplatnica
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListaRobe
    {
        public int Id { get; set; }
        public double KolicinaRobe { get; set; }
        public double NovaCenaRobe { get; set; }
        public double UkupnaCenaRobe { get; set; }
        public int SifarnikRobeId { get; set; }
        public int OtpremnicaId { get; set; }
    
        public virtual SifarnikRobe SifarnikRobe { get; set; }
        public virtual Otpremnica Otpremnica { get; set; }
    }
}
