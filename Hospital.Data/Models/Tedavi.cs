//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tedavi
    {
        public Nullable<int> hastaID { get; set; }
        public Nullable<int> doktorID { get; set; }
        public string hastaSikayet { get; set; }
        public int tedaviID { get; set; }
    
        public virtual Doktor Doktor { get; set; }
        public virtual Hasta Hasta { get; set; }
    }
}