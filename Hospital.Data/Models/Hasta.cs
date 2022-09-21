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
    
    public partial class Hasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hasta()
        {
            this.Tedavi = new HashSet<Tedavi>();
        }
    
        public int hastaID { get; set; }
        public string hastaAdi { get; set; }
        public string hastaSoyadi { get; set; }
        public string hastaTelefonNumara { get; set; }
        public string hastaTC { get; set; }
        public string hastaEmail { get; set; }
        public Nullable<System.DateTime> hastaDogumTarihi { get; set; }
        public Nullable<int> cinsiyetID { get; set; }
        public string HastaPassword { get; set; }
        public Nullable<int> RoleID { get; set; }
    
        public virtual Cinsiyet Cinsiyet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tedavi> Tedavi { get; set; }
        public virtual Role Role { get; set; }
    }
}