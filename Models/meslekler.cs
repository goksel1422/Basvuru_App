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
    
    public partial class meslekler
    {
        public meslekler()
        {
            this.deneyim = new HashSet<deneyim>();
            this.basvurular = new HashSet<basvurular>();
        }
    
        public int MeslekID { get; set; }
        public string kod { get; set; }
        public string isim { get; set; }
    
        public virtual ICollection<deneyim> deneyim { get; set; }
        public virtual ICollection<basvurular> basvurular { get; set; }
    }
}
