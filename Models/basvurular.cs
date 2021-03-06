//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Basvuru_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class basvurular
    {
        public basvurular()
        {
            this.byabancidil = new HashSet<byabancidil>();
            this.deneyim = new HashSet<deneyim>();
            this.projeler = new HashSet<projeler>();
            this.referanslar = new HashSet<referanslar>();
            this.sem_kurs = new HashSet<sem_kurs>();
            this.sertifikalar = new HashSet<sertifikalar>();
        }
    
        public int BID { get; set; }
        public Nullable<int> KID { get; set; }
        public Nullable<int> Ucret_Beklenti { get; set; }
        public Nullable<int> TCalSure { get; set; }
        public Nullable<int> bolum_id { get; set; }
        public Nullable<int> BDurumID { get; set; }
        public string Hobiler { get; set; }
        public string BOnYazi { get; set; }
        public Nullable<int> AskerliID { get; set; }
        public Nullable<int> MeslekID { get; set; }
    
        public virtual askerlik askerlik { get; set; }
        public virtual basvuru_durumu basvuru_durumu { get; set; }
        public virtual bolumler bolumler { get; set; }
        public virtual meslekler meslekler { get; set; }
        public virtual kullanicilar kullanicilar { get; set; }
        public virtual ICollection<byabancidil> byabancidil { get; set; }
        public virtual ICollection<deneyim> deneyim { get; set; }
        public virtual ICollection<projeler> projeler { get; set; }
        public virtual ICollection<referanslar> referanslar { get; set; }
        public virtual ICollection<sem_kurs> sem_kurs { get; set; }
        public virtual ICollection<sertifikalar> sertifikalar { get; set; }
    }
}
